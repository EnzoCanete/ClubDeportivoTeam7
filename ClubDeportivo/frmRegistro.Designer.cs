namespace ClubDeportivo
{
    partial class frmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSocio = new System.Windows.Forms.TabPage();
            this.socioTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.groupBoxMembresia = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPlanPago = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFechaInicio = new System.Windows.Forms.ComboBox();
            this.tabPageNoSocio = new System.Windows.Forms.TabPage();
            this.noSocioTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1_n = new System.Windows.Forms.GroupBox();
            this.label1_n = new System.Windows.Forms.Label();
            this.txtNombre_n = new System.Windows.Forms.TextBox();
            this.label2_n = new System.Windows.Forms.Label();
            this.txtApellido_n = new System.Windows.Forms.TextBox();
            this.label3_n = new System.Windows.Forms.Label();
            this.txtDNI_n = new System.Windows.Forms.TextBox();
            this.label5_n = new System.Windows.Forms.Label();
            this.txtTelefono_n = new System.Windows.Forms.TextBox();
            this.groupBoxMembresia_n = new System.Windows.Forms.GroupBox();
            this.labelCantidadDinero = new System.Windows.Forms.Label();
            this.labelActivityNoSocio = new System.Windows.Forms.Label();
            this.comboBoxActividadNoSocio = new System.Windows.Forms.ComboBox();
            this.labelHorarioNoSocio = new System.Windows.Forms.Label();
            this.comboBoxHorarioNoSocio = new System.Windows.Forms.ComboBox();
            this.labelFechaAsistencia = new System.Windows.Forms.Label();
            this.comboBoxFechaAsistencia = new System.Windows.Forms.ComboBox();
            this.labelImporte = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageSocio.SuspendLayout();
            this.socioTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMembresia.SuspendLayout();
            this.tabPageNoSocio.SuspendLayout();
            this.noSocioTable.SuspendLayout();
            this.groupBox1_n.SuspendLayout();
            this.groupBoxMembresia_n.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.3203F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.6797F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(619, 331);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // tabControl
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tabControl, 2);
            this.tabControl.Controls.Add(this.tabPageSocio);
            this.tabControl.Controls.Add(this.tabPageNoSocio);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 15);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(613, 266);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            // 
            // tabPageSocio
            // 
            this.tabPageSocio.Controls.Add(this.socioTable);
            this.tabPageSocio.Location = new System.Drawing.Point(4, 22);
            this.tabPageSocio.Name = "tabPageSocio";
            this.tabPageSocio.Size = new System.Drawing.Size(605, 240);
            this.tabPageSocio.TabIndex = 0;
            this.tabPageSocio.Text = "Socio";
            // 
            // socioTable
            // 
            this.socioTable.ColumnCount = 2;
            this.socioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.socioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.socioTable.Controls.Add(this.groupBox1, 0, 0);
            this.socioTable.Controls.Add(this.groupBoxMembresia, 1, 0);
            this.socioTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.socioTable.Location = new System.Drawing.Point(0, 0);
            this.socioTable.Margin = new System.Windows.Forms.Padding(0);
            this.socioTable.Name = "socioTable";
            this.socioTable.RowCount = 1;
            this.socioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.socioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.socioTable.Size = new System.Drawing.Size(605, 240);
            this.socioTable.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox1.Size = new System.Drawing.Size(302, 240);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Personales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(22, 93);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(261, 20);
            this.txtApellido.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(22, 143);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(261, 20);
            this.txtDNI.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Télefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(22, 195);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(261, 20);
            this.txtTelefono.TabIndex = 21;
            // 
            // groupBoxMembresia
            // 
            this.groupBoxMembresia.Controls.Add(this.label7);
            this.groupBoxMembresia.Controls.Add(this.cmbActividad);
            this.groupBoxMembresia.Controls.Add(this.label8);
            this.groupBoxMembresia.Controls.Add(this.cmbHorarios);
            this.groupBoxMembresia.Controls.Add(this.label9);
            this.groupBoxMembresia.Controls.Add(this.cmbPlanPago);
            this.groupBoxMembresia.Controls.Add(this.label10);
            this.groupBoxMembresia.Controls.Add(this.cmbFechaInicio);
            this.groupBoxMembresia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMembresia.Location = new System.Drawing.Point(302, 0);
            this.groupBoxMembresia.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxMembresia.Name = "groupBoxMembresia";
            this.groupBoxMembresia.Padding = new System.Windows.Forms.Padding(9);
            this.groupBoxMembresia.Size = new System.Drawing.Size(303, 240);
            this.groupBoxMembresia.TabIndex = 27;
            this.groupBoxMembresia.TabStop = false;
            this.groupBoxMembresia.Text = "Membresía";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Actividad:";
            // 
            // cmbActividad
            // 
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(21, 42);
            this.cmbActividad.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(261, 21);
            this.cmbActividad.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Horarios:";
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.FormattingEnabled = true;
            this.cmbHorarios.Location = new System.Drawing.Point(21, 91);
            this.cmbHorarios.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(261, 21);
            this.cmbHorarios.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Plan de pago:";
            // 
            // cmbPlanPago
            // 
            this.cmbPlanPago.FormattingEnabled = true;
            this.cmbPlanPago.Location = new System.Drawing.Point(21, 141);
            this.cmbPlanPago.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cmbPlanPago.Name = "cmbPlanPago";
            this.cmbPlanPago.Size = new System.Drawing.Size(261, 21);
            this.cmbPlanPago.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fecha inicio:";
            // 
            // cmbFechaInicio
            // 
            this.cmbFechaInicio.FormattingEnabled = true;
            this.cmbFechaInicio.Location = new System.Drawing.Point(21, 194);
            this.cmbFechaInicio.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cmbFechaInicio.Name = "cmbFechaInicio";
            this.cmbFechaInicio.Size = new System.Drawing.Size(261, 21);
            this.cmbFechaInicio.TabIndex = 21;
            // 
            // tabPageNoSocio
            // 
            this.tabPageNoSocio.Controls.Add(this.noSocioTable);
            this.tabPageNoSocio.Location = new System.Drawing.Point(4, 22);
            this.tabPageNoSocio.Name = "tabPageNoSocio";
            this.tabPageNoSocio.Size = new System.Drawing.Size(605, 240);
            this.tabPageNoSocio.TabIndex = 1;
            this.tabPageNoSocio.Text = "No Socio";
            // 
            // noSocioTable
            // 
            this.noSocioTable.ColumnCount = 2;
            this.noSocioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.noSocioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.noSocioTable.Controls.Add(this.groupBox1_n, 0, 0);
            this.noSocioTable.Controls.Add(this.groupBoxMembresia_n, 1, 0);
            this.noSocioTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noSocioTable.Location = new System.Drawing.Point(0, 0);
            this.noSocioTable.Name = "noSocioTable";
            this.noSocioTable.RowCount = 1;
            this.noSocioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.noSocioTable.Size = new System.Drawing.Size(605, 240);
            this.noSocioTable.TabIndex = 0;
            // 
            // groupBox1_n
            // 
            this.groupBox1_n.Controls.Add(this.label1_n);
            this.groupBox1_n.Controls.Add(this.txtNombre_n);
            this.groupBox1_n.Controls.Add(this.label2_n);
            this.groupBox1_n.Controls.Add(this.txtApellido_n);
            this.groupBox1_n.Controls.Add(this.label3_n);
            this.groupBox1_n.Controls.Add(this.txtDNI_n);
            this.groupBox1_n.Controls.Add(this.label5_n);
            this.groupBox1_n.Controls.Add(this.txtTelefono_n);
            this.groupBox1_n.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1_n.Location = new System.Drawing.Point(0, 0);
            this.groupBox1_n.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1_n.Name = "groupBox1_n";
            this.groupBox1_n.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox1_n.Size = new System.Drawing.Size(302, 240);
            this.groupBox1_n.TabIndex = 0;
            this.groupBox1_n.TabStop = false;
            this.groupBox1_n.Text = "Detalles Personales (No Socio)";
            // 
            // label1_n
            // 
            this.label1_n.AutoSize = true;
            this.label1_n.Location = new System.Drawing.Point(19, 25);
            this.label1_n.Name = "label1_n";
            this.label1_n.Size = new System.Drawing.Size(47, 13);
            this.label1_n.TabIndex = 0;
            this.label1_n.Text = "Nombre:";
            // 
            // txtNombre_n
            // 
            this.txtNombre_n.Location = new System.Drawing.Point(22, 44);
            this.txtNombre_n.Name = "txtNombre_n";
            this.txtNombre_n.Size = new System.Drawing.Size(261, 20);
            this.txtNombre_n.TabIndex = 1;
            // 
            // label2_n
            // 
            this.label2_n.AutoSize = true;
            this.label2_n.Location = new System.Drawing.Point(19, 74);
            this.label2_n.Name = "label2_n";
            this.label2_n.Size = new System.Drawing.Size(47, 13);
            this.label2_n.TabIndex = 2;
            this.label2_n.Text = "Apellido:";
            // 
            // txtApellido_n
            // 
            this.txtApellido_n.Location = new System.Drawing.Point(22, 93);
            this.txtApellido_n.Name = "txtApellido_n";
            this.txtApellido_n.Size = new System.Drawing.Size(261, 20);
            this.txtApellido_n.TabIndex = 3;
            // 
            // label3_n
            // 
            this.label3_n.AutoSize = true;
            this.label3_n.Location = new System.Drawing.Point(19, 124);
            this.label3_n.Name = "label3_n";
            this.label3_n.Size = new System.Drawing.Size(29, 13);
            this.label3_n.TabIndex = 4;
            this.label3_n.Text = "DNI:";
            // 
            // txtDNI_n
            // 
            this.txtDNI_n.Location = new System.Drawing.Point(22, 143);
            this.txtDNI_n.Name = "txtDNI_n";
            this.txtDNI_n.Size = new System.Drawing.Size(261, 20);
            this.txtDNI_n.TabIndex = 5;
            // 
            // label5_n
            // 
            this.label5_n.AutoSize = true;
            this.label5_n.Location = new System.Drawing.Point(19, 177);
            this.label5_n.Name = "label5_n";
            this.label5_n.Size = new System.Drawing.Size(52, 13);
            this.label5_n.TabIndex = 6;
            this.label5_n.Text = "Télefono:";
            // 
            // txtTelefono_n
            // 
            this.txtTelefono_n.Location = new System.Drawing.Point(22, 195);
            this.txtTelefono_n.Name = "txtTelefono_n";
            this.txtTelefono_n.Size = new System.Drawing.Size(261, 20);
            this.txtTelefono_n.TabIndex = 7;
            // 
            // groupBoxMembresia_n
            // 
            this.groupBoxMembresia_n.Controls.Add(this.labelCantidadDinero);
            this.groupBoxMembresia_n.Controls.Add(this.labelActivityNoSocio);
            this.groupBoxMembresia_n.Controls.Add(this.comboBoxActividadNoSocio);
            this.groupBoxMembresia_n.Controls.Add(this.labelHorarioNoSocio);
            this.groupBoxMembresia_n.Controls.Add(this.comboBoxHorarioNoSocio);
            this.groupBoxMembresia_n.Controls.Add(this.labelFechaAsistencia);
            this.groupBoxMembresia_n.Controls.Add(this.comboBoxFechaAsistencia);
            this.groupBoxMembresia_n.Controls.Add(this.labelImporte);
            this.groupBoxMembresia_n.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMembresia_n.Location = new System.Drawing.Point(302, 0);
            this.groupBoxMembresia_n.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxMembresia_n.Name = "groupBoxMembresia_n";
            this.groupBoxMembresia_n.Padding = new System.Windows.Forms.Padding(9);
            this.groupBoxMembresia_n.Size = new System.Drawing.Size(303, 240);
            this.groupBoxMembresia_n.TabIndex = 1;
            this.groupBoxMembresia_n.TabStop = false;
            this.groupBoxMembresia_n.Text = "Visita";
            // 
            // labelCantidadDinero
            // 
            this.labelCantidadDinero.AutoSize = true;
            this.labelCantidadDinero.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelCantidadDinero.Location = new System.Drawing.Point(23, 202);
            this.labelCantidadDinero.Name = "labelCantidadDinero";
            this.labelCantidadDinero.Size = new System.Drawing.Size(49, 13);
            this.labelCantidadDinero.TabIndex = 29;
            this.labelCantidadDinero.Text = "Cantidad";
            // 
            // labelActivityNoSocio
            // 
            this.labelActivityNoSocio.AutoSize = true;
            this.labelActivityNoSocio.Location = new System.Drawing.Point(18, 25);
            this.labelActivityNoSocio.Name = "labelActivityNoSocio";
            this.labelActivityNoSocio.Size = new System.Drawing.Size(54, 13);
            this.labelActivityNoSocio.TabIndex = 22;
            this.labelActivityNoSocio.Text = "Actividad:";
            // 
            // comboBoxActividadNoSocio
            // 
            this.comboBoxActividadNoSocio.FormattingEnabled = true;
            this.comboBoxActividadNoSocio.Location = new System.Drawing.Point(21, 42);
            this.comboBoxActividadNoSocio.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.comboBoxActividadNoSocio.Name = "comboBoxActividadNoSocio";
            this.comboBoxActividadNoSocio.Size = new System.Drawing.Size(261, 21);
            this.comboBoxActividadNoSocio.TabIndex = 26;
            // 
            // labelHorarioNoSocio
            // 
            this.labelHorarioNoSocio.AutoSize = true;
            this.labelHorarioNoSocio.Location = new System.Drawing.Point(18, 74);
            this.labelHorarioNoSocio.Name = "labelHorarioNoSocio";
            this.labelHorarioNoSocio.Size = new System.Drawing.Size(49, 13);
            this.labelHorarioNoSocio.TabIndex = 23;
            this.labelHorarioNoSocio.Text = "Horarios:";
            // 
            // comboBoxHorarioNoSocio
            // 
            this.comboBoxHorarioNoSocio.FormattingEnabled = true;
            this.comboBoxHorarioNoSocio.Location = new System.Drawing.Point(21, 91);
            this.comboBoxHorarioNoSocio.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.comboBoxHorarioNoSocio.Name = "comboBoxHorarioNoSocio";
            this.comboBoxHorarioNoSocio.Size = new System.Drawing.Size(261, 21);
            this.comboBoxHorarioNoSocio.TabIndex = 27;
            // 
            // labelFechaAsistencia
            // 
            this.labelFechaAsistencia.AutoSize = true;
            this.labelFechaAsistencia.Location = new System.Drawing.Point(18, 124);
            this.labelFechaAsistencia.Name = "labelFechaAsistencia";
            this.labelFechaAsistencia.Size = new System.Drawing.Size(105, 13);
            this.labelFechaAsistencia.TabIndex = 24;
            this.labelFechaAsistencia.Text = "Fecha de asistencia:";
            // 
            // comboBoxFechaAsistencia
            // 
            this.comboBoxFechaAsistencia.FormattingEnabled = true;
            this.comboBoxFechaAsistencia.Location = new System.Drawing.Point(21, 141);
            this.comboBoxFechaAsistencia.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.comboBoxFechaAsistencia.Name = "comboBoxFechaAsistencia";
            this.comboBoxFechaAsistencia.Size = new System.Drawing.Size(261, 21);
            this.comboBoxFechaAsistencia.TabIndex = 28;
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Location = new System.Drawing.Point(18, 177);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(45, 13);
            this.labelImporte.TabIndex = 25;
            this.labelImporte.Text = "Importe:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(312, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 41);
            this.panel1.TabIndex = 28;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(87, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(198, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Añadir Socio";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // frmRegistro
            // 
            this.ClientSize = new System.Drawing.Size(619, 331);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmRegistro";
            this.Text = "Registro - Club de barrio";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageSocio.ResumeLayout(false);
            this.socioTable.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMembresia.ResumeLayout(false);
            this.groupBoxMembresia.PerformLayout();
            this.tabPageNoSocio.ResumeLayout(false);
            this.noSocioTable.ResumeLayout(false);
            this.groupBox1_n.ResumeLayout(false);
            this.groupBox1_n.PerformLayout();
            this.groupBoxMembresia_n.ResumeLayout(false);
            this.groupBoxMembresia_n.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxMembresia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSocio;
        private System.Windows.Forms.TabPage tabPageNoSocio;
        private System.Windows.Forms.TableLayoutPanel socioTable;
        private System.Windows.Forms.TableLayoutPanel noSocioTable;

        // NoSocio placeholder controls (suffixed with _n)
        private System.Windows.Forms.GroupBox groupBox1_n;
        private System.Windows.Forms.Label label1_n;
        private System.Windows.Forms.TextBox txtNombre_n;
        private System.Windows.Forms.Label label2_n;
        private System.Windows.Forms.TextBox txtApellido_n;
        private System.Windows.Forms.Label label3_n;
        private System.Windows.Forms.TextBox txtDNI_n;
        private System.Windows.Forms.Label label5_n;
        private System.Windows.Forms.TextBox txtTelefono_n;
        private System.Windows.Forms.GroupBox groupBoxMembresia_n;
        private System.Windows.Forms.Label labelActivityNoSocio;
        private System.Windows.Forms.ComboBox comboBoxActividadNoSocio;
        private System.Windows.Forms.Label labelHorarioNoSocio;
        private System.Windows.Forms.ComboBox comboBoxHorarioNoSocio;
        private System.Windows.Forms.Label labelFechaAsistencia;
        private System.Windows.Forms.ComboBox comboBoxFechaAsistencia;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPlanPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFechaInicio;
        private System.Windows.Forms.Label labelCantidadDinero;
    }
}