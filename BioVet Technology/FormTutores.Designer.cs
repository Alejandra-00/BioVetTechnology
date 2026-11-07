namespace BioVet_Technology
{
    partial class FormTutores
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
            listBox_SelectTutores = new ListBox();
            textBox_BuscarTutor = new TextBox();
            buttonBuscar = new Button();
            panelBuscar = new Panel();
            buttonBuscarTutores = new Button();
            panelDeco = new Panel();
            buttonCerrarTutores = new Button();
            buttonCerrarPacientes = new Button();
            buttonCerrar = new Button();
            groupBox1 = new GroupBox();
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            label_Mail = new Label();
            textBox_Mail = new TextBox();
            label_Telefono = new Label();
            textBox_Telefono = new TextBox();
            checkBox_TutorActivo = new CheckBox();
            label_NombreTutor = new Label();
            label_IdTutor = new Label();
            textBox_NombreTutor = new TextBox();
            textBox_IdTutor = new TextBox();
            groupBox = new GroupBox();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            panelBuscar.SuspendLayout();
            panelDeco.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // listBox_SelectTutores
            // 
            listBox_SelectTutores.FormattingEnabled = true;
            listBox_SelectTutores.Location = new Point(452, 207);
            listBox_SelectTutores.Name = "listBox_SelectTutores";
            listBox_SelectTutores.Size = new Size(949, 164);
            listBox_SelectTutores.TabIndex = 31;
            // 
            // textBox_BuscarTutor
            // 
            textBox_BuscarTutor.Location = new Point(452, 149);
            textBox_BuscarTutor.Multiline = true;
            textBox_BuscarTutor.Name = "textBox_BuscarTutor";
            textBox_BuscarTutor.Size = new Size(949, 58);
            textBox_BuscarTutor.TabIndex = 30;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top;
            buttonBuscar.BackColor = Color.MidnightBlue;
            buttonBuscar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(2229, 19);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(242, 58);
            buttonBuscar.TabIndex = 28;
            buttonBuscar.Text = "BUSCAR";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // panelBuscar
            // 
            panelBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBuscar.Controls.Add(buttonBuscarTutores);
            panelBuscar.Controls.Add(buttonBuscar);
            panelBuscar.Location = new Point(1, 130);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1817, 260);
            panelBuscar.TabIndex = 29;
            // 
            // buttonBuscarTutores
            // 
            buttonBuscarTutores.Anchor = AnchorStyles.Top;
            buttonBuscarTutores.BackColor = Color.MidnightBlue;
            buttonBuscarTutores.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonBuscarTutores.ForeColor = Color.White;
            buttonBuscarTutores.Location = new Point(1423, 19);
            buttonBuscarTutores.Name = "buttonBuscarTutores";
            buttonBuscarTutores.Size = new Size(242, 58);
            buttonBuscarTutores.TabIndex = 33;
            buttonBuscarTutores.Text = "BUSCAR";
            buttonBuscarTutores.UseVisualStyleBackColor = false;
            // 
            // panelDeco
            // 
            panelDeco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDeco.BackColor = Color.MidnightBlue;
            panelDeco.Controls.Add(buttonCerrarTutores);
            panelDeco.Controls.Add(buttonCerrarPacientes);
            panelDeco.Controls.Add(buttonCerrar);
            panelDeco.Location = new Point(1, 1);
            panelDeco.Name = "panelDeco";
            panelDeco.Size = new Size(1817, 78);
            panelDeco.TabIndex = 28;
            // 
            // buttonCerrarTutores
            // 
            buttonCerrarTutores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrarTutores.AutoSize = true;
            buttonCerrarTutores.BackColor = Color.Transparent;
            buttonCerrarTutores.FlatStyle = FlatStyle.Flat;
            buttonCerrarTutores.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCerrarTutores.ForeColor = Color.White;
            buttonCerrarTutores.Location = new Point(1749, 11);
            buttonCerrarTutores.Name = "buttonCerrarTutores";
            buttonCerrarTutores.Size = new Size(57, 58);
            buttonCerrarTutores.TabIndex = 32;
            buttonCerrarTutores.Text = "X";
            buttonCerrarTutores.UseVisualStyleBackColor = false;
            buttonCerrarTutores.Click += buttonCerrarTutores_Click;
            // 
            // buttonCerrarPacientes
            // 
            buttonCerrarPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrarPacientes.AutoSize = true;
            buttonCerrarPacientes.BackColor = Color.Transparent;
            buttonCerrarPacientes.FlatStyle = FlatStyle.Flat;
            buttonCerrarPacientes.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCerrarPacientes.ForeColor = Color.White;
            buttonCerrarPacientes.Location = new Point(3367, 11);
            buttonCerrarPacientes.Name = "buttonCerrarPacientes";
            buttonCerrarPacientes.Size = new Size(57, 58);
            buttonCerrarPacientes.TabIndex = 25;
            buttonCerrarPacientes.Text = "X";
            buttonCerrarPacientes.UseVisualStyleBackColor = false;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrar.AutoSize = true;
            buttonCerrar.BackColor = Color.Transparent;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCerrar.ForeColor = Color.White;
            buttonCerrar.Location = new Point(4983, 11);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(57, 58);
            buttonCerrar.TabIndex = 11;
            buttonCerrar.Text = "X";
            buttonCerrar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(buttonAceptar);
            groupBox1.Controls.Add(buttonCancelar);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(690, 844);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 130);
            groupBox1.TabIndex = 71;
            groupBox1.TabStop = false;
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
            // label_Mail
            // 
            label_Mail.AutoSize = true;
            label_Mail.Enabled = false;
            label_Mail.Font = new Font("Arial", 9F);
            label_Mail.Location = new Point(375, 745);
            label_Mail.Name = "label_Mail";
            label_Mail.Size = new Size(55, 27);
            label_Mail.TabIndex = 70;
            label_Mail.Text = "Mail";
            // 
            // textBox_Mail
            // 
            textBox_Mail.Enabled = false;
            textBox_Mail.Location = new Point(375, 775);
            textBox_Mail.Multiline = true;
            textBox_Mail.Name = "textBox_Mail";
            textBox_Mail.Size = new Size(1227, 57);
            textBox_Mail.TabIndex = 69;
            // 
            // label_Telefono
            // 
            label_Telefono.AutoSize = true;
            label_Telefono.Enabled = false;
            label_Telefono.Font = new Font("Arial", 9F);
            label_Telefono.Location = new Point(375, 646);
            label_Telefono.Name = "label_Telefono";
            label_Telefono.Size = new Size(102, 27);
            label_Telefono.TabIndex = 68;
            label_Telefono.Text = "Teléfono";
            // 
            // textBox_Telefono
            // 
            textBox_Telefono.Enabled = false;
            textBox_Telefono.Location = new Point(375, 675);
            textBox_Telefono.Multiline = true;
            textBox_Telefono.Name = "textBox_Telefono";
            textBox_Telefono.Size = new Size(1227, 57);
            textBox_Telefono.TabIndex = 67;
            // 
            // checkBox_TutorActivo
            // 
            checkBox_TutorActivo.AutoSize = true;
            checkBox_TutorActivo.Enabled = false;
            checkBox_TutorActivo.Font = new Font("Arial", 9F);
            checkBox_TutorActivo.Location = new Point(375, 844);
            checkBox_TutorActivo.Name = "checkBox_TutorActivo";
            checkBox_TutorActivo.Size = new Size(107, 31);
            checkBox_TutorActivo.TabIndex = 66;
            checkBox_TutorActivo.Text = "Activo";
            checkBox_TutorActivo.UseVisualStyleBackColor = true;
            // 
            // label_NombreTutor
            // 
            label_NombreTutor.AutoSize = true;
            label_NombreTutor.Enabled = false;
            label_NombreTutor.Font = new Font("Arial", 9F);
            label_NombreTutor.Location = new Point(375, 541);
            label_NombreTutor.Name = "label_NombreTutor";
            label_NombreTutor.Size = new Size(97, 27);
            label_NombreTutor.TabIndex = 65;
            label_NombreTutor.Text = "Nombre";
            // 
            // label_IdTutor
            // 
            label_IdTutor.AutoSize = true;
            label_IdTutor.Enabled = false;
            label_IdTutor.Font = new Font("Arial", 9F);
            label_IdTutor.Location = new Point(375, 435);
            label_IdTutor.Name = "label_IdTutor";
            label_IdTutor.Size = new Size(35, 27);
            label_IdTutor.TabIndex = 64;
            label_IdTutor.Text = "ID";
            // 
            // textBox_NombreTutor
            // 
            textBox_NombreTutor.Enabled = false;
            textBox_NombreTutor.Location = new Point(375, 576);
            textBox_NombreTutor.Multiline = true;
            textBox_NombreTutor.Name = "textBox_NombreTutor";
            textBox_NombreTutor.Size = new Size(1227, 57);
            textBox_NombreTutor.TabIndex = 63;
            // 
            // textBox_IdTutor
            // 
            textBox_IdTutor.Enabled = false;
            textBox_IdTutor.Location = new Point(375, 470);
            textBox_IdTutor.Multiline = true;
            textBox_IdTutor.Name = "textBox_IdTutor";
            textBox_IdTutor.Size = new Size(1227, 58);
            textBox_IdTutor.TabIndex = 62;
            // 
            // groupBox
            // 
            groupBox.AutoSize = true;
            groupBox.Controls.Add(buttonAgregar);
            groupBox.Controls.Add(buttonModificar);
            groupBox.Enabled = false;
            groupBox.Location = new Point(12, 396);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(250, 199);
            groupBox.TabIndex = 61;
            groupBox.TabStop = false;
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
            // FormTutores
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1819, 1292);
            Controls.Add(groupBox1);
            Controls.Add(label_Mail);
            Controls.Add(textBox_Mail);
            Controls.Add(label_Telefono);
            Controls.Add(textBox_Telefono);
            Controls.Add(checkBox_TutorActivo);
            Controls.Add(label_NombreTutor);
            Controls.Add(label_IdTutor);
            Controls.Add(textBox_NombreTutor);
            Controls.Add(textBox_IdTutor);
            Controls.Add(groupBox);
            Controls.Add(listBox_SelectTutores);
            Controls.Add(textBox_BuscarTutor);
            Controls.Add(panelBuscar);
            Controls.Add(panelDeco);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTutores";
            Text = "FormTutores";
            FormClosing += FormTutores_FormClosing;
            panelBuscar.ResumeLayout(false);
            panelDeco.ResumeLayout(false);
            panelDeco.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_SelectTutores;
        private TextBox textBox_BuscarTutor;
        private Button buttonBuscar;
        private Panel panelBuscar;
        private Panel panelDeco;
        private Button buttonCerrarPacientes;
        private Button buttonCerrar;
        private Button buttonCerrarTutores;
        private Button buttonBuscarTutores;
        private GroupBox groupBox1;
        private Button buttonAceptar;
        private Button buttonCancelar;
        private Label label_Mail;
        private TextBox textBox_Mail;
        private Label label_Telefono;
        private TextBox textBox_Telefono;
        private CheckBox checkBox_TutorActivo;
        private Label label_NombreTutor;
        private Label label_IdTutor;
        private TextBox textBox_NombreTutor;
        private TextBox textBox_IdTutor;
        private GroupBox groupBox;
        private Button buttonAgregar;
        private Button buttonModificar;
    }
}