namespace MuseoDSI.Formularios
{
    partial class Frm_RegistrarVisita
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
            this.cmb_Sede = new System.Windows.Forms.ComboBox();
            this.cmb_TipoVisita = new System.Windows.Forms.ComboBox();
            this.txt_visitantes = new System.Windows.Forms.TextBox();
            this.cmb_Escuela = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_Exposiciones = new System.Windows.Forms.ListView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dgv_Exposiciones = new System.Windows.Forms.DataGridView();
            this.nombreExposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_guiasNecesarios = new System.Windows.Forms.TextBox();
            this.dtpReserva = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lv_Guias = new System.Windows.Forms.ListView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_QuitarGuia = new MuseoDSI.Formularios.BotonRedondeado();
            this.btn_agregarGuia = new MuseoDSI.Formularios.BotonRedondeado();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_Guias = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nombreGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCerrar = new MuseoDSI.Formularios.BotonRedondeado();
            this.cmb_Guias = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelExposiciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_quitar = new MuseoDSI.Formularios.BotonRedondeado();
            this.btn_agregar = new MuseoDSI.Formularios.BotonRedondeado();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new MuseoDSI.Formularios.BotonRedondeado();
            this.btn_Registrar = new MuseoDSI.Formularios.BotonRedondeado();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exposiciones)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Guias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelExposiciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Sede
            // 
            this.cmb_Sede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Sede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sede.FormattingEnabled = true;
            this.cmb_Sede.Location = new System.Drawing.Point(496, 22);
            this.cmb_Sede.Name = "cmb_Sede";
            this.cmb_Sede.Size = new System.Drawing.Size(167, 28);
            this.cmb_Sede.TabIndex = 19;
            this.cmb_Sede.SelectedIndexChanged += new System.EventHandler(this.cmb_Sede_SelectedIndexChanged);
            this.cmb_Sede.SelectedValueChanged += new System.EventHandler(this.cmb_Sede_SelectedValueChanged);
            // 
            // cmb_TipoVisita
            // 
            this.cmb_TipoVisita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_TipoVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TipoVisita.FormattingEnabled = true;
            this.cmb_TipoVisita.Location = new System.Drawing.Point(810, 22);
            this.cmb_TipoVisita.Name = "cmb_TipoVisita";
            this.cmb_TipoVisita.Size = new System.Drawing.Size(167, 28);
            this.cmb_TipoVisita.TabIndex = 18;
            this.cmb_TipoVisita.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoVisita_SelectedIndexChanged);
            // 
            // txt_visitantes
            // 
            this.txt_visitantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_visitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_visitantes.Location = new System.Drawing.Point(363, 22);
            this.txt_visitantes.Name = "txt_visitantes";
            this.txt_visitantes.Size = new System.Drawing.Size(56, 26);
            this.txt_visitantes.TabIndex = 14;
            // 
            // cmb_Escuela
            // 
            this.cmb_Escuela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Escuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Escuela.FormattingEnabled = true;
            this.cmb_Escuela.Location = new System.Drawing.Point(85, 22);
            this.cmb_Escuela.Name = "cmb_Escuela";
            this.cmb_Escuela.Size = new System.Drawing.Size(167, 28);
            this.cmb_Escuela.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lv_Exposiciones);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(820, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(500, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 276);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exposiciones Seleccionadas";
            // 
            // lv_Exposiciones
            // 
            this.lv_Exposiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Exposiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lv_Exposiciones.HideSelection = false;
            this.lv_Exposiciones.Location = new System.Drawing.Point(3, 22);
            this.lv_Exposiciones.Name = "lv_Exposiciones";
            this.lv_Exposiciones.Size = new System.Drawing.Size(664, 251);
            this.lv_Exposiciones.TabIndex = 0;
            this.lv_Exposiciones.UseCompatibleStateImageBehavior = false;
            this.lv_Exposiciones.View = System.Windows.Forms.View.List;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(915, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 26);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dgv_Exposiciones
            // 
            this.dgv_Exposiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Exposiciones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Exposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exposiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreExposicion,
            this.publicoDestino,
            this.horaApertura,
            this.horaCierre});
            this.dgv_Exposiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Exposiciones.Location = new System.Drawing.Point(3, 22);
            this.dgv_Exposiciones.Name = "dgv_Exposiciones";
            this.dgv_Exposiciones.RowHeadersWidth = 51;
            this.dgv_Exposiciones.Size = new System.Drawing.Size(664, 251);
            this.dgv_Exposiciones.TabIndex = 12;
            this.dgv_Exposiciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreExposicion
            // 
            this.nombreExposicion.HeaderText = "Exposicion";
            this.nombreExposicion.MinimumWidth = 6;
            this.nombreExposicion.Name = "nombreExposicion";
            // 
            // publicoDestino
            // 
            this.publicoDestino.HeaderText = "Público";
            this.publicoDestino.MinimumWidth = 6;
            this.publicoDestino.Name = "publicoDestino";
            // 
            // horaApertura
            // 
            this.horaApertura.HeaderText = "Hora Apertura";
            this.horaApertura.MinimumWidth = 6;
            this.horaApertura.Name = "horaApertura";
            // 
            // horaCierre
            // 
            this.horaCierre.HeaderText = "Hora de Cierre";
            this.horaCierre.MinimumWidth = 6;
            this.horaCierre.Name = "horaCierre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_guiasNecesarios);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.dtpReserva);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(60, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 88);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(763, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Duracion estimada:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(579, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Guias necesarios:";
            // 
            // txt_guiasNecesarios
            // 
            this.txt_guiasNecesarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_guiasNecesarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guiasNecesarios.Location = new System.Drawing.Point(724, 55);
            this.txt_guiasNecesarios.Name = "txt_guiasNecesarios";
            this.txt_guiasNecesarios.ReadOnly = true;
            this.txt_guiasNecesarios.Size = new System.Drawing.Size(54, 26);
            this.txt_guiasNecesarios.TabIndex = 21;
            // 
            // dtpReserva
            // 
            this.dtpReserva.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReserva.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dtpReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReserva.Location = new System.Drawing.Point(515, 17);
            this.dtpReserva.Name = "dtpReserva";
            this.dtpReserva.ShowCheckBox = true;
            this.dtpReserva.Size = new System.Drawing.Size(200, 26);
            this.dtpReserva.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Fecha y hora de la reserva:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(671, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button5.Location = new System.Drawing.Point(816, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 20;
            this.button5.Text = "Verificar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(60, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 336);
            this.panel3.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lv_Guias);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(820, 0);
            this.groupBox5.MinimumSize = new System.Drawing.Size(500, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(670, 336);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Guías seleccionados";
            // 
            // lv_Guias
            // 
            this.lv_Guias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Guias.HideSelection = false;
            this.lv_Guias.Location = new System.Drawing.Point(3, 22);
            this.lv_Guias.Name = "lv_Guias";
            this.lv_Guias.Size = new System.Drawing.Size(664, 311);
            this.lv_Guias.TabIndex = 38;
            this.lv_Guias.UseCompatibleStateImageBehavior = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_QuitarGuia);
            this.panel9.Controls.Add(this.btn_agregarGuia);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(670, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(150, 336);
            this.panel9.TabIndex = 42;
            // 
            // btn_QuitarGuia
            // 
            this.btn_QuitarGuia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_QuitarGuia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_QuitarGuia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_QuitarGuia.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QuitarGuia.BorderRadius = 18;
            this.btn_QuitarGuia.BorderSize = 0;
            this.btn_QuitarGuia.FlatAppearance.BorderSize = 0;
            this.btn_QuitarGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuitarGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuitarGuia.ForeColor = System.Drawing.Color.White;
            this.btn_QuitarGuia.Location = new System.Drawing.Point(14, 202);
            this.btn_QuitarGuia.Name = "btn_QuitarGuia";
            this.btn_QuitarGuia.Size = new System.Drawing.Size(113, 36);
            this.btn_QuitarGuia.TabIndex = 41;
            this.btn_QuitarGuia.Text = "← Quitar";
            this.btn_QuitarGuia.TextColor = System.Drawing.Color.White;
            this.btn_QuitarGuia.UseVisualStyleBackColor = false;
            // 
            // btn_agregarGuia
            // 
            this.btn_agregarGuia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_agregarGuia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_agregarGuia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_agregarGuia.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_agregarGuia.BorderRadius = 18;
            this.btn_agregarGuia.BorderSize = 0;
            this.btn_agregarGuia.FlatAppearance.BorderSize = 0;
            this.btn_agregarGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarGuia.ForeColor = System.Drawing.Color.White;
            this.btn_agregarGuia.Location = new System.Drawing.Point(14, 136);
            this.btn_agregarGuia.Name = "btn_agregarGuia";
            this.btn_agregarGuia.Size = new System.Drawing.Size(113, 36);
            this.btn_agregarGuia.TabIndex = 40;
            this.btn_agregarGuia.Text = "Agregar →";
            this.btn_agregarGuia.TextColor = System.Drawing.Color.White;
            this.btn_agregarGuia.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_Guias);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.MinimumSize = new System.Drawing.Size(500, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(670, 336);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Guías disponibles";
            // 
            // dgv_Guias
            // 
            this.dgv_Guias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Guias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Guias.Location = new System.Drawing.Point(3, 22);
            this.dgv_Guias.Name = "dgv_Guias";
            this.dgv_Guias.Size = new System.Drawing.Size(664, 311);
            this.dgv_Guias.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreGuia});
            this.dataGridView2.Location = new System.Drawing.Point(710, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(200, 21);
            this.dataGridView2.TabIndex = 25;
            // 
            // nombreGuia
            // 
            this.nombreGuia.HeaderText = "Guias Seleccionado";
            this.nombreGuia.MinimumWidth = 6;
            this.nombreGuia.Name = "nombreGuia";
            this.nombreGuia.Width = 150;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnConfirmar.Location = new System.Drawing.Point(825, 18);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 30);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1120, 61);
            this.panel4.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar nueva reserva";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCerrar);
            this.panel5.Controls.Add(this.cmb_Guias);
            this.panel5.Controls.Add(this.btnConfirmar);
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 914);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1120, 60);
            this.panel5.TabIndex = 29;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btnCerrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btnCerrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrar.BorderRadius = 20;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(916, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmb_Guias
            // 
            this.cmb_Guias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmb_Guias.FormattingEnabled = true;
            this.cmb_Guias.Location = new System.Drawing.Point(737, 13);
            this.cmb_Guias.Name = "cmb_Guias";
            this.cmb_Guias.Size = new System.Drawing.Size(163, 26);
            this.cmb_Guias.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1060, 61);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 853);
            this.panel6.TabIndex = 30;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(60, 853);
            this.panel7.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Escuela:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Visitantes:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(699, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo de visita:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sede:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmb_TipoVisita);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb_Sede);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmb_Escuela);
            this.groupBox2.Controls.Add(this.txt_visitantes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(60, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 72);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visita";
            // 
            // panelExposiciones
            // 
            this.panelExposiciones.Controls.Add(this.groupBox1);
            this.panelExposiciones.Controls.Add(this.panel1);
            this.panelExposiciones.Controls.Add(this.groupBox3);
            this.panelExposiciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExposiciones.Location = new System.Drawing.Point(60, 133);
            this.panelExposiciones.Name = "panelExposiciones";
            this.panelExposiciones.Size = new System.Drawing.Size(1000, 276);
            this.panelExposiciones.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_quitar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(670, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 276);
            this.panel1.TabIndex = 13;
            // 
            // btn_quitar
            // 
            this.btn_quitar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_quitar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_quitar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_quitar.BorderRadius = 18;
            this.btn_quitar.BorderSize = 0;
            this.btn_quitar.FlatAppearance.BorderSize = 0;
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.ForeColor = System.Drawing.Color.White;
            this.btn_quitar.Location = new System.Drawing.Point(21, 135);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(113, 36);
            this.btn_quitar.TabIndex = 35;
            this.btn_quitar.Text = "← Quitar";
            this.btn_quitar.TextColor = System.Drawing.Color.White;
            this.btn_quitar.UseVisualStyleBackColor = false;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_agregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_agregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_agregar.BorderRadius = 18;
            this.btn_agregar.BorderSize = 0;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(21, 67);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(113, 36);
            this.btn_agregar.TabIndex = 34;
            this.btn_agregar.Text = "Agregar →";
            this.btn_agregar.TextColor = System.Drawing.Color.White;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_Exposiciones);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.MinimumSize = new System.Drawing.Size(500, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 276);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exposiciones disponibles";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_Cancelar);
            this.panel8.Controls.Add(this.btn_Registrar);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(60, 839);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1000, 75);
            this.panel8.TabIndex = 34;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_Cancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_Cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Cancelar.BorderRadius = 20;
            this.btn_Cancelar.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(560, 29);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(150, 40);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextColor = System.Drawing.Color.White;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_Registrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(116)))));
            this.btn_Registrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Registrar.BorderRadius = 20;
            this.btn_Registrar.BorderSize = 0;
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.ForeColor = System.Drawing.Color.White;
            this.btn_Registrar.Location = new System.Drawing.Point(269, 29);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(150, 40);
            this.btn_Registrar.TabIndex = 1;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.TextColor = System.Drawing.Color.White;
            this.btn_Registrar.UseVisualStyleBackColor = false;
            // 
            // Frm_RegistrarVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1120, 974);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelExposiciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "Frm_RegistrarVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Visita";
            this.Load += new System.EventHandler(this.Frm_RegistrarVisita_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exposiciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Guias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelExposiciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_Sede;
        private System.Windows.Forms.ComboBox cmb_TipoVisita;
        private System.Windows.Forms.TextBox txt_visitantes;
        private System.Windows.Forms.ComboBox cmb_Escuela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_Exposiciones;
        private System.Windows.Forms.DataGridView dgv_Exposiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreExposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCierre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_guiasNecesarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGuia;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private BotonRedondeado btnCerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelExposiciones;
        private System.Windows.Forms.Panel panel1;
        private BotonRedondeado btn_agregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private BotonRedondeado btn_quitar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpReserva;
        private BotonRedondeado btn_QuitarGuia;
        private BotonRedondeado btn_agregarGuia;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lv_Guias;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_Guias;
        private System.Windows.Forms.ComboBox cmb_Guias;
        private System.Windows.Forms.Panel panel8;
        private BotonRedondeado btn_Cancelar;
        private BotonRedondeado btn_Registrar;
        private System.Windows.Forms.Panel panel9;
    }
}