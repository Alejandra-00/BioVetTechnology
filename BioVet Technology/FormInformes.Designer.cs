namespace BioVet_Technology
{
    partial class FormInformes
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
            panelBuscar = new Panel();
            comboBoxSelectInforme = new ComboBox();
            panelDeco = new Panel();
            buttonCerrarInformes = new Button();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            groupBoxAcciones = new GroupBox();
            label_FechaHora = new Label();
            dateTimePickerFechaHora = new DateTimePicker();
            comboBoxEstudio = new ComboBox();
            label_SelectEstudio = new Label();
            comboBoxTutor = new ComboBox();
            label_SelectTutor = new Label();
            comboBoxVeterinario = new ComboBox();
            label_SelectVeterinario = new Label();
            comboBoxPaciente = new ComboBox();
            checkBox_InformeActivo = new CheckBox();
            label_SelectPaciente = new Label();
            label_IdInforme = new Label();
            textBox_IdEstudio = new TextBox();
            groupBoxAcepCan = new GroupBox();
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            panelBuscar.SuspendLayout();
            panelDeco.SuspendLayout();
            groupBoxAcciones.SuspendLayout();
            groupBoxAcepCan.SuspendLayout();
            SuspendLayout();
            // 
            // panelBuscar
            // 
            panelBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBuscar.Controls.Add(comboBoxSelectInforme);
            panelBuscar.Location = new Point(0, 165);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1821, 95);
            panelBuscar.TabIndex = 16;
            // 
            // comboBoxSelectInforme
            // 
            comboBoxSelectInforme.FormattingEnabled = true;
            comboBoxSelectInforme.Location = new Point(274, 28);
            comboBoxSelectInforme.Name = "comboBoxSelectInforme";
            comboBoxSelectInforme.Size = new Size(1292, 40);
            comboBoxSelectInforme.TabIndex = 22;
            // 
            // panelDeco
            // 
            panelDeco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDeco.BackColor = Color.MidnightBlue;
            panelDeco.Controls.Add(buttonCerrarInformes);
            panelDeco.Location = new Point(0, 0);
            panelDeco.Name = "panelDeco";
            panelDeco.Size = new Size(1821, 78);
            panelDeco.TabIndex = 15;
            // 
            // buttonCerrarInformes
            // 
            buttonCerrarInformes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrarInformes.AutoSize = true;
            buttonCerrarInformes.BackColor = Color.Transparent;
            buttonCerrarInformes.FlatStyle = FlatStyle.Flat;
            buttonCerrarInformes.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCerrarInformes.ForeColor = Color.White;
            buttonCerrarInformes.Location = new Point(1750, 12);
            buttonCerrarInformes.Name = "buttonCerrarInformes";
            buttonCerrarInformes.Size = new Size(57, 58);
            buttonCerrarInformes.TabIndex = 17;
            buttonCerrarInformes.Text = "X";
            buttonCerrarInformes.UseVisualStyleBackColor = false;
            buttonCerrarInformes.Click += buttonCerrarInformes_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.MidnightBlue;
            buttonAgregar.Enabled = false;
            buttonAgregar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(6, 39);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(232, 58);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "AGREGAR";
            buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.MidnightBlue;
            buttonModificar.Enabled = false;
            buttonModificar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonModificar.ForeColor = Color.White;
            buttonModificar.Location = new Point(6, 103);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(232, 58);
            buttonModificar.TabIndex = 23;
            buttonModificar.Text = "MODIFICAR";
            buttonModificar.UseVisualStyleBackColor = false;
            // 
            // groupBoxAcciones
            // 
            groupBoxAcciones.AutoSize = true;
            groupBoxAcciones.Controls.Add(buttonAgregar);
            groupBoxAcciones.Controls.Add(buttonModificar);
            groupBoxAcciones.Enabled = false;
            groupBoxAcciones.Location = new Point(12, 266);
            groupBoxAcciones.Name = "groupBoxAcciones";
            groupBoxAcciones.Size = new Size(250, 199);
            groupBoxAcciones.TabIndex = 25;
            groupBoxAcciones.TabStop = false;
            // 
            // label_FechaHora
            // 
            label_FechaHora.AutoSize = true;
            label_FechaHora.Enabled = false;
            label_FechaHora.Font = new Font("Arial", 9F);
            label_FechaHora.Location = new Point(344, 765);
            label_FechaHora.Name = "label_FechaHora";
            label_FechaHora.Size = new Size(79, 27);
            label_FechaHora.TabIndex = 49;
            label_FechaHora.Text = "Fecha";
            // 
            // dateTimePickerFechaHora
            // 
            dateTimePickerFechaHora.Location = new Point(344, 795);
            dateTimePickerFechaHora.Name = "dateTimePickerFechaHora";
            dateTimePickerFechaHora.Size = new Size(1227, 39);
            dateTimePickerFechaHora.TabIndex = 48;
            // 
            // comboBoxEstudio
            // 
            comboBoxEstudio.FormattingEnabled = true;
            comboBoxEstudio.Location = new Point(344, 706);
            comboBoxEstudio.Name = "comboBoxEstudio";
            comboBoxEstudio.Size = new Size(1227, 40);
            comboBoxEstudio.TabIndex = 47;
            // 
            // label_SelectEstudio
            // 
            label_SelectEstudio.AutoSize = true;
            label_SelectEstudio.Enabled = false;
            label_SelectEstudio.Font = new Font("Arial", 9F);
            label_SelectEstudio.Location = new Point(344, 676);
            label_SelectEstudio.Name = "label_SelectEstudio";
            label_SelectEstudio.Size = new Size(93, 27);
            label_SelectEstudio.TabIndex = 46;
            label_SelectEstudio.Text = "Estudio";
            // 
            // comboBoxTutor
            // 
            comboBoxTutor.FormattingEnabled = true;
            comboBoxTutor.Location = new Point(344, 623);
            comboBoxTutor.Name = "comboBoxTutor";
            comboBoxTutor.Size = new Size(1227, 40);
            comboBoxTutor.TabIndex = 45;
            // 
            // label_SelectTutor
            // 
            label_SelectTutor.AutoSize = true;
            label_SelectTutor.Enabled = false;
            label_SelectTutor.Font = new Font("Arial", 9F);
            label_SelectTutor.Location = new Point(344, 593);
            label_SelectTutor.Name = "label_SelectTutor";
            label_SelectTutor.Size = new Size(67, 27);
            label_SelectTutor.TabIndex = 44;
            label_SelectTutor.Text = "Tutor";
            // 
            // comboBoxVeterinario
            // 
            comboBoxVeterinario.FormattingEnabled = true;
            comboBoxVeterinario.Location = new Point(344, 537);
            comboBoxVeterinario.Name = "comboBoxVeterinario";
            comboBoxVeterinario.Size = new Size(1227, 40);
            comboBoxVeterinario.TabIndex = 43;
            // 
            // label_SelectVeterinario
            // 
            label_SelectVeterinario.AutoSize = true;
            label_SelectVeterinario.Enabled = false;
            label_SelectVeterinario.Font = new Font("Arial", 9F);
            label_SelectVeterinario.Location = new Point(344, 502);
            label_SelectVeterinario.Name = "label_SelectVeterinario";
            label_SelectVeterinario.Size = new Size(125, 27);
            label_SelectVeterinario.TabIndex = 42;
            label_SelectVeterinario.Text = "Veterinario";
            // 
            // comboBoxPaciente
            // 
            comboBoxPaciente.FormattingEnabled = true;
            comboBoxPaciente.Location = new Point(344, 446);
            comboBoxPaciente.Name = "comboBoxPaciente";
            comboBoxPaciente.Size = new Size(1227, 40);
            comboBoxPaciente.TabIndex = 41;
            // 
            // checkBox_InformeActivo
            // 
            checkBox_InformeActivo.AutoSize = true;
            checkBox_InformeActivo.Enabled = false;
            checkBox_InformeActivo.Font = new Font("Arial", 9F);
            checkBox_InformeActivo.Location = new Point(344, 852);
            checkBox_InformeActivo.Name = "checkBox_InformeActivo";
            checkBox_InformeActivo.Size = new Size(107, 31);
            checkBox_InformeActivo.TabIndex = 40;
            checkBox_InformeActivo.Text = "Activo";
            checkBox_InformeActivo.UseVisualStyleBackColor = true;
            // 
            // label_SelectPaciente
            // 
            label_SelectPaciente.AutoSize = true;
            label_SelectPaciente.Enabled = false;
            label_SelectPaciente.Font = new Font("Arial", 9F);
            label_SelectPaciente.Location = new Point(344, 411);
            label_SelectPaciente.Name = "label_SelectPaciente";
            label_SelectPaciente.Size = new Size(105, 27);
            label_SelectPaciente.TabIndex = 39;
            label_SelectPaciente.Text = "Paciente";
            // 
            // label_IdInforme
            // 
            label_IdInforme.AutoSize = true;
            label_IdInforme.Enabled = false;
            label_IdInforme.Font = new Font("Arial", 9F);
            label_IdInforme.Location = new Point(344, 305);
            label_IdInforme.Name = "label_IdInforme";
            label_IdInforme.Size = new Size(35, 27);
            label_IdInforme.TabIndex = 38;
            label_IdInforme.Text = "ID";
            // 
            // textBox_IdEstudio
            // 
            textBox_IdEstudio.Enabled = false;
            textBox_IdEstudio.Location = new Point(344, 340);
            textBox_IdEstudio.Multiline = true;
            textBox_IdEstudio.Name = "textBox_IdEstudio";
            textBox_IdEstudio.Size = new Size(1227, 58);
            textBox_IdEstudio.TabIndex = 37;
            // 
            // groupBoxAcepCan
            // 
            groupBoxAcepCan.AutoSize = true;
            groupBoxAcepCan.Controls.Add(buttonAceptar);
            groupBoxAcepCan.Controls.Add(buttonCancelar);
            groupBoxAcepCan.Location = new Point(691, 873);
            groupBoxAcepCan.Name = "groupBoxAcepCan";
            groupBoxAcepCan.Size = new Size(496, 130);
            groupBoxAcepCan.TabIndex = 26;
            groupBoxAcepCan.TabStop = false;
            groupBoxAcepCan.Visible = false;
            // 
            // buttonAceptar
            // 
            buttonAceptar.BackColor = Color.MidnightBlue;
            buttonAceptar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonAceptar.ForeColor = Color.White;
            buttonAceptar.Location = new Point(0, 34);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(242, 58);
            buttonAceptar.TabIndex = 17;
            buttonAceptar.Text = "ACEPTAR";
            buttonAceptar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.MidnightBlue;
            buttonCancelar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(254, 34);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(236, 58);
            buttonCancelar.TabIndex = 17;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1819, 1292);
            Controls.Add(groupBoxAcepCan);
            Controls.Add(label_FechaHora);
            Controls.Add(dateTimePickerFechaHora);
            Controls.Add(comboBoxEstudio);
            Controls.Add(label_SelectEstudio);
            Controls.Add(comboBoxTutor);
            Controls.Add(label_SelectTutor);
            Controls.Add(comboBoxVeterinario);
            Controls.Add(label_SelectVeterinario);
            Controls.Add(comboBoxPaciente);
            Controls.Add(checkBox_InformeActivo);
            Controls.Add(label_SelectPaciente);
            Controls.Add(label_IdInforme);
            Controls.Add(textBox_IdEstudio);
            Controls.Add(groupBoxAcciones);
            Controls.Add(panelBuscar);
            Controls.Add(panelDeco);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInformes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInformes";
            FormClosing += FormInformes_FormClosing;
            panelBuscar.ResumeLayout(false);
            panelDeco.ResumeLayout(false);
            panelDeco.PerformLayout();
            groupBoxAcciones.ResumeLayout(false);
            groupBoxAcepCan.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBuscar;
        private ComboBox comboBoxSelectInforme;
        private Panel panelDeco;
        private Button buttonCerrarInformes;
        private Button buttonAgregar;
        private Button buttonModificar;
        private GroupBox groupBoxAcciones;
        private Label label_FechaHora;
        private DateTimePicker dateTimePickerFechaHora;
        private ComboBox comboBoxEstudio;
        private Label label_SelectEstudio;
        private ComboBox comboBoxTutor;
        private Label label_SelectTutor;
        private ComboBox comboBoxVeterinario;
        private Label label_SelectVeterinario;
        private ComboBox comboBoxPaciente;
        private CheckBox checkBox_InformeActivo;
        private Label label_SelectPaciente;
        private Label label_IdInforme;
        private TextBox textBox_IdEstudio;
        private GroupBox groupBoxAcepCan;
        private Button buttonAceptar;
        private Button buttonCancelar;
    }
}