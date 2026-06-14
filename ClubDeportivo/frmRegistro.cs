using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ClubDeportivo
{
    public partial class frmRegistro : Form
    {
        // cache of horarios to avoid extra DB calls
        private DataTable _horariosCache;
        // random generator for importe amounts
        private static readonly Random _rand = new Random();

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void CmbHorarios_SelectedValueChanged(object sender, EventArgs e)
        {
            PopulateFechaFromHorario(cmbHorarios, cmbFechaInicio);
        }

        /// <summary>
        /// Devuelve las próximas 'count' fechas que caen en el día de la semana indicado.
        /// diaNumero: 1=Monday .. 7=Sunday
        /// </summary>
        private List<DateTime> GetNextOccurrences(int diaNumero, int count)
        {
            var result = new List<DateTime>();
            // Map 1=Monday..7=Sunday to DayOfWeek
            DayOfWeek target = DayOfWeek.Monday;
            switch (diaNumero)
            {
                case 1: target = DayOfWeek.Monday; break;
                case 2: target = DayOfWeek.Tuesday; break;
                case 3: target = DayOfWeek.Wednesday; break;
                case 4: target = DayOfWeek.Thursday; break;
                case 5: target = DayOfWeek.Friday; break;
                case 6: target = DayOfWeek.Saturday; break;
                case 7: target = DayOfWeek.Sunday; break;
            }

            DateTime current = DateTime.Today;

            // Find the next date (including today if it matches)
            int daysToAdd = ((int)target - (int)current.DayOfWeek + 7) % 7;
            if (daysToAdd == 0)
            {
                // If today is the target, start from next week to match requirement of 'next three'
                daysToAdd = 7;
            }

            DateTime next = current.AddDays(daysToAdd);
            for (int i = 0; i < count; i++)
            {
                result.Add(next.AddDays(7 * i));
            }

            return result;
        }

        private string MapDiaSemana(object diaValue)
        {
            if (diaValue == null) return string.Empty;

            int dia;
            if (!int.TryParse(diaValue.ToString(), out dia)) return diaValue.ToString();

            switch (dia)
            {
                case 1: return "Lunes";
                case 2: return "Martes";
                case 3: return "Miércoles";
                case 4: return "Jueves";
                case 5: return "Viernes";
                case 6: return "Sábado";
                case 7: return "Domingo";
                default: return diaValue.ToString();
            }
        }

        private string FormatHora(object horaValue)
        {
            if (horaValue == null) return string.Empty;

            // Try parse as TimeSpan or DateTime, otherwise fallback to string and trim seconds
            TimeSpan ts;
            DateTime dt;
            var s = horaValue.ToString();
            if (TimeSpan.TryParse(s, out ts))
            {
                return ts.ToString(@"hh\:mm");
            }
            if (DateTime.TryParse(s, out dt))
            {
                return dt.ToString("HH:mm");
            }

            // Fallback: try to remove seconds if present like HH:mm:ss
            var parts = s.Split(':');
            if (parts.Length >= 2) return parts[0].PadLeft(2, '0') + ":" + parts[1].PadLeft(2, '0');
            return s;
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            // Show the main form instead of exiting the application
            var main = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();
            if (main != null)
            {
                main.Show();
            }
            else
            {
                var principal = new frmPrincipal();
                principal.Show();
            }
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Decide which tab is active: Socio or NoSocio
            if (tabControl.SelectedTab == tabPageNoSocio)
            {
                // NoSocio flow
                if (txtDNI_n.Text == "" || txtNombre_n.Text == "" || txtApellido_n.Text == "")
                {
                    MessageBox.Show("Debe completar todos los campos requeridos para No Socio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBoxHorarioNoSocio.SelectedValue == null || comboBoxFechaAsistencia.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar actividad, horario y fecha de asistencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idHorarioNo;
                DateTime fechaAsistencia;
                if (!int.TryParse(comboBoxHorarioNoSocio.SelectedValue.ToString(), out idHorarioNo))
                {
                    MessageBox.Show("Id de horario inválido (No Socio).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    fechaAsistencia = (DateTime)comboBoxFechaAsistencia.SelectedValue;
                }
                catch
                {
                    MessageBox.Show("Fecha de asistencia inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Try to parse importe from labelCantidadDinero (fallback to 0)
                decimal importe = 0m;
                var txt = labelCantidadDinero.Text ?? string.Empty;
                if (!decimal.TryParse(txt, NumberStyles.Any, CultureInfo.CurrentCulture, out importe))
                {
                    // attempt invariant culture
                    decimal.TryParse(txt, NumberStyles.Any, CultureInfo.InvariantCulture, out importe);
                }

                var repoNo = new Datos.NoSocioRepositorio();
                string resp = repoNo.NuevoNoSocioVisita(txtDNI_n.Text, txtNombre_n.Text, txtApellido_n.Text, txtTelefono_n.Text, idHorarioNo, fechaAsistencia, importe);

                if (resp.StartsWith("-1"))
                {
                    MessageBox.Show("Error registrando no socio/visita: " + resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No socio y visita registrados exitosamente. Número de visita: " + resp, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // clear fields
                    txtDNI_n.Text = "";
                    txtNombre_n.Text = "";
                    txtApellido_n.Text = "";
                    txtTelefono_n.Text = "";
                    comboBoxActividadNoSocio.SelectedIndex = -1;
                    comboBoxHorarioNoSocio.DataSource = null;
                    comboBoxFechaAsistencia.DataSource = null;
                    labelCantidadDinero.Text = "Cantidad";
                }
            }
            else
            {
                // Socio flow (existing)
                if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Debe completar todos los campos requeridos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Corta la ejecución si faltan datos
                }

                // 2. Instanciamos un objeto de la clase Socio y le pasamos los datos de las cajas de texto
                Entidades.Socio nuevoSocio = new Entidades.Socio();
                nuevoSocio.DNI = txtDNI.Text;
                nuevoSocio.Nombre = txtNombre.Text;
                nuevoSocio.Apellido = txtApellido.Text;
                nuevoSocio.Telefono = txtTelefono.Text;

                // 3. Validar que se haya seleccionado horario, plan y fecha inicio
                if (cmbHorarios.SelectedValue == null || cmbPlanPago.SelectedValue == null || cmbFechaInicio.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar actividad, horario, plan y fecha de inicio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idHorario;
                int idPlan;
                DateTime fechaInicio;

                if (!int.TryParse(cmbHorarios.SelectedValue.ToString(), out idHorario))
                {
                    MessageBox.Show("Id de horario inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cmbPlanPago.SelectedValue.ToString(), out idPlan))
                {
                    MessageBox.Show("Id de plan inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    fechaInicio = (DateTime)cmbFechaInicio.SelectedValue;
                }
                catch
                {
                    MessageBox.Show("Fecha de inicio inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Instanciamos la clase Socios de la capa Datos y llamamos al método que crea socio + inscripcion
                Datos.Socios dato = new Datos.Socios();
                string respuesta = dato.NuevoSocioConInscripcion(nuevoSocio, idHorario, idPlan, fechaInicio);

                // 5. Analizamos la respuesta de la base de datos
                if (respuesta == "1")
                {
                    MessageBox.Show("El DNI ingresado ya se encuentra registrado en el sistema.", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (respuesta.StartsWith("-1"))
                {
                    MessageBox.Show("Error registrando socio/inscripción: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // fechaEntregaCarnet is 7 days from today
                    DateTime fechaEntregaCarnet = DateTime.Today.AddDays(7);
                    MessageBox.Show($"Socio registrado correctamente.\n\n" +
                                    $"Estado: Activo\n" +
                                    $"Fecha estimada de entrega del carnet: {fechaEntregaCarnet:dd/MM/yyyy}",
                                    "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiamos los campos para una nueva carga
                    txtDNI.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtTelefono.Text = "";
                    cmbActividad.SelectedIndex = -1;
                    cmbHorarios.DataSource = null;
                    cmbPlanPago.SelectedIndex = -1;
                    cmbFechaInicio.DataSource = null;
                }
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            try
            {
                var repo = new Datos.ActividadRepositorio();
                var tabla = repo.ObtenerActividades();

                cmbActividad.DisplayMember = "Nombre";
                cmbActividad.ValueMember = "IdActividad";
                cmbActividad.DataSource = tabla;

                // Populate non-socio activity combobox as well
                comboBoxActividadNoSocio.DisplayMember = "Nombre";
                comboBoxActividadNoSocio.ValueMember = "IdActividad";
                comboBoxActividadNoSocio.DataSource = tabla;

                // Preload horarios cache
                var repoHor = new Datos.HorarioRepositorio();
                _horariosCache = repoHor.ObtenerHorarios();

                // Attach handler for activity changes
                cmbActividad.SelectedValueChanged += CmbActividad_SelectedValueChanged;
                // Trigger initial population
                CmbActividad_SelectedValueChanged(cmbActividad, EventArgs.Empty);

                // Attach handlers and trigger for non-socio controls
                comboBoxActividadNoSocio.SelectedValueChanged += ComboBoxActividadNoSocio_SelectedValueChanged;
                comboBoxHorarioNoSocio.SelectedValueChanged += ComboBoxHorarioNoSocio_SelectedValueChanged;
                ComboBoxActividadNoSocio_SelectedValueChanged(comboBoxActividadNoSocio, EventArgs.Empty);

                // Attach handler to populate fecha inicio when horario selected
                cmbHorarios.SelectedValueChanged += CmbHorarios_SelectedValueChanged;

                // Preload plans for cmbPlanPago
                var repoPlan = new Datos.PlanPagoRepositorio();
                var tablaPlanes = repoPlan.ObtenerPlanes();
                // Add a display column combining descripcion and importe
                if (!tablaPlanes.Columns.Contains("Display")) tablaPlanes.Columns.Add("Display", typeof(string));
                foreach (DataRow r in tablaPlanes.Rows)
                {
                    r["Display"] = string.Format("{0} - {1}", r["descripcion"], r["importe"]);
                }
                cmbPlanPago.DisplayMember = "Display";
                cmbPlanPago.ValueMember = "idPlan";
                cmbPlanPago.DataSource = tablaPlanes;

                // Ensure the first input has focus (Nombre)
                this.ActiveControl = txtNombre;
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbActividad_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbHorarios.DataSource = null;

                if (cmbActividad.SelectedValue == null) return;

                int idActividad;
                if (!int.TryParse(cmbActividad.SelectedValue.ToString(), out idActividad)) return;

                // Filter cached horarios for the selected activity
                var view = new DataView(_horariosCache);
                view.RowFilter = "idActividad = " + idActividad;

                var tablaFiltrada = view.ToTable();

                // Create a display column for user-friendly text (e.g., Lunes 18:00-19:00)
                if (!tablaFiltrada.Columns.Contains("Display"))
                    tablaFiltrada.Columns.Add("Display", typeof(string));

                foreach (DataRow row in tablaFiltrada.Rows)
                {
                    var diaNombre = MapDiaSemana(row["diaSemana"]);
                    var horaInicio = FormatHora(row["horaInicio"]);
                    var horaFin = FormatHora(row["horaFin"]);
                    row["Display"] = string.Format("{0} {1}-{2}", diaNombre, horaInicio, horaFin);
                }

                cmbHorarios.DisplayMember = "Display";
                cmbHorarios.ValueMember = "idHorario";
                cmbHorarios.DataSource = tablaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando horarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Populate horarios for non-socio when activity changes
        private void ComboBoxActividadNoSocio_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxHorarioNoSocio.DataSource = null;

                if (comboBoxActividadNoSocio.SelectedValue == null) return;

                int idActividad;
                if (!int.TryParse(comboBoxActividadNoSocio.SelectedValue.ToString(), out idActividad)) return;

                var view = new DataView(_horariosCache);
                view.RowFilter = "idActividad = " + idActividad;

                var tablaFiltrada = view.ToTable();

                if (!tablaFiltrada.Columns.Contains("Display"))
                    tablaFiltrada.Columns.Add("Display", typeof(string));

                foreach (DataRow row in tablaFiltrada.Rows)
                {
                    var diaNombre = MapDiaSemana(row["diaSemana"]);
                    var horaInicio = FormatHora(row["horaInicio"]);
                    var horaFin = FormatHora(row["horaFin"]);
                    row["Display"] = string.Format("{0} {1}-{2}", diaNombre, horaInicio, horaFin);
                }

                comboBoxHorarioNoSocio.DisplayMember = "Display";
                comboBoxHorarioNoSocio.ValueMember = "idHorario";
                comboBoxHorarioNoSocio.DataSource = tablaFiltrada;

                // Generate a random importe between 2.500 and 15000 and display it
                try
                {
                    double r = _rand.NextDouble();
                    decimal importe = Math.Round((decimal)(2500.0 + r * (15000.0 - 2500.0)), 2);
                    labelCantidadDinero.Text = importe.ToString("N2", CultureInfo.CurrentCulture);
                }
                catch
                {
                    labelCantidadDinero.Text = "Cantidad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando horarios (NoSocio): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Populate fecha asistencia for non-socio when horario selected
        private void ComboBoxHorarioNoSocio_SelectedValueChanged(object sender, EventArgs e)
        {
            PopulateFechaFromHorario(comboBoxHorarioNoSocio, comboBoxFechaAsistencia);
        }

        // Helper to populate a fecha ComboBox from a horario ComboBox (shared behavior)
        private void PopulateFechaFromHorario(ComboBox horarioCombo, ComboBox fechaCombo)
        {
            try
            {
                fechaCombo.DataSource = null;

                if (horarioCombo.SelectedValue == null) return;

                var drv = horarioCombo.SelectedItem as DataRowView;
                if (drv == null) return;

                int diaNumero;
                if (!int.TryParse(drv["diaSemana"].ToString(), out diaNumero)) return;

                var fechas = GetNextOccurrences(diaNumero, 3);

                var tabla = new DataTable();
                tabla.Columns.Add("Fecha", typeof(DateTime));
                tabla.Columns.Add("Display", typeof(string));

                foreach (var d in fechas)
                {
                    var r = tabla.NewRow();
                    r["Fecha"] = d;
                    r["Display"] = d.ToString("dd/MM/yyyy");
                    tabla.Rows.Add(r);
                }

                fechaCombo.DisplayMember = "Display";
                fechaCombo.ValueMember = "Fecha";
                fechaCombo.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculando fechas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
