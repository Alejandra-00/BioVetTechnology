namespace BioVet_Technology
{
    partial class FormPacientes
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
            buttonCerrar = new Button();
            panelDeco = new Panel();
            buttonCerrarPacientes = new Button();
            panelBuscar = new Panel();
            buttonBuscarPaciente = new Button();
            textBox_BuscarPacientes = new TextBox();
            listBox_SelectPacientes = new ListBox();
            groupBox = new GroupBox();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            checkBox_PacienteActivo = new CheckBox();
            label_NombrePaciente = new Label();
            label_IdPaciente = new Label();
            textBox_NombrePaciente = new TextBox();
            textBox_IdPaciente = new TextBox();
            label_Especie = new Label();
            textBox_Especie = new TextBox();
            label_Raza = new Label();
            textBox_Raza = new TextBox();
            label_Sexo = new Label();
            textBox_Sexo = new TextBox();
            label_Nacimiento = new Label();
            textBox_Nacimiento = new TextBox();
            groupBox1 = new GroupBox();
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            panelDeco.SuspendLayout();
            panelBuscar.SuspendLayout();
            groupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCerrar
            // 
            buttonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrar.AutoSize = true;
            buttonCerrar.BackColor = Color.Transparent;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCerrar.ForeColor = Color.White;
            buttonCerrar.Location = new Point(3366, 11);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(57, 58);
            buttonCerrar.TabIndex = 11;
            buttonCerrar.Text = "X";
            buttonCerrar.UseVisualStyleBackColor = false;
            // 
            // panelDeco
            // 
            panelDeco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDeco.BackColor = Color.MidnightBlue;
            panelDeco.Controls.Add(buttonCerrarPacientes);
            panelDeco.Controls.Add(buttonCerrar);
            panelDeco.Location = new Point(1, 1);
            panelDeco.Name = "panelDeco";
            panelDeco.Size = new Size(1817, 78);
            panelDeco.TabIndex = 24;
            // 
            // buttonCerrarPacientes
            // 
            buttonCerrarPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrarPacientes.AutoSize = true;
            buttonCerrarPacientes.BackColor = Color.Transparent;
            buttonCerrarPacientes.FlatStyle = FlatStyle.Flat;
            buttonCerrarPacientes.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCerrarPacientes.ForeColor = Color.White;
            buttonCerrarPacientes.Location = new Point(1750, 11);
            buttonCerrarPacientes.Name = "buttonCerrarPacientes";
            buttonCerrarPacientes.Size = new Size(57, 58);
            buttonCerrarPacientes.TabIndex = 25;
            buttonCerrarPacientes.Text = "X";
            buttonCerrarPacientes.UseVisualStyleBackColor = false;
            buttonCerrarPacientes.Click += buttonCerrarPacientes_Click;
            // 
            // panelBuscar
            // 
            panelBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBuscar.Controls.Add(buttonBuscarPaciente);
            panelBuscar.Location = new Point(1, 130);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1817, 260);
            panelBuscar.TabIndex = 25;
            // 
            // buttonBuscarPaciente
            // 
            buttonBuscarPaciente.Anchor = AnchorStyles.Top;
            buttonBuscarPaciente.BackColor = Color.MidnightBlue;
            buttonBuscarPaciente.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonBuscarPaciente.ForeColor = Color.White;
            buttonBuscarPaciente.Location = new Point(1421, 19);
            buttonBuscarPaciente.Name = "buttonBuscarPaciente";
            buttonBuscarPaciente.Size = new Size(242, 58);
            buttonBuscarPaciente.TabIndex = 28;
            buttonBuscarPaciente.Text = "BUSCAR";
            buttonBuscarPaciente.UseVisualStyleBackColor = false;
            // 
            // textBox_BuscarPacientes
            // 
            textBox_BuscarPacientes.Location = new Point(452, 149);
            textBox_BuscarPacientes.Multiline = true;
            textBox_BuscarPacientes.Name = "textBox_BuscarPacientes";
            textBox_BuscarPacientes.Size = new Size(949, 58);
            textBox_BuscarPacientes.TabIndex = 26;
            // 
            // listBox_SelectPacientes
            // 
            listBox_SelectPacientes.FormattingEnabled = true;
            listBox_SelectPacientes.Location = new Point(452, 207);
            listBox_SelectPacientes.Name = "listBox_SelectPacientes";
            listBox_SelectPacientes.Size = new Size(949, 164);
            listBox_SelectPacientes.TabIndex = 27;
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
            groupBox.TabIndex = 28;
            groupBox.TabStop = false;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.MidnightBlue;
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
            // checkBox_PacienteActivo
            // 
            checkBox_PacienteActivo.AutoSize = true;
            checkBox_PacienteActivo.Enabled = false;
            checkBox_PacienteActivo.Font = new Font("Arial", 9F);
            checkBox_PacienteActivo.Location = new Point(375, 1042);
            checkBox_PacienteActivo.Name = "checkBox_PacienteActivo";
            checkBox_PacienteActivo.Size = new Size(107, 31);
            checkBox_PacienteActivo.TabIndex = 33;
            checkBox_PacienteActivo.Text = "Activo";
            checkBox_PacienteActivo.UseVisualStyleBackColor = true;
            // 
            // label_NombrePaciente
            // 
            label_NombrePaciente.AutoSize = true;
            label_NombrePaciente.Enabled = false;
            label_NombrePaciente.Font = new Font("Arial", 9F);
            label_NombrePaciente.Location = new Point(375, 541);
            label_NombrePaciente.Name = "label_NombrePaciente";
            label_NombrePaciente.Size = new Size(97, 27);
            label_NombrePaciente.TabIndex = 32;
            label_NombrePaciente.Text = "Nombre";
            // 
            // label_IdPaciente
            // 
            label_IdPaciente.AutoSize = true;
            label_IdPaciente.Enabled = false;
            label_IdPaciente.Font = new Font("Arial", 9F);
            label_IdPaciente.Location = new Point(375, 435);
            label_IdPaciente.Name = "label_IdPaciente";
            label_IdPaciente.Size = new Size(35, 27);
            label_IdPaciente.TabIndex = 31;
            label_IdPaciente.Text = "ID";
            // 
            // textBox_NombrePaciente
            // 
            textBox_NombrePaciente.Enabled = false;
            textBox_NombrePaciente.Location = new Point(375, 576);
            textBox_NombrePaciente.Multiline = true;
            textBox_NombrePaciente.Name = "textBox_NombrePaciente";
            textBox_NombrePaciente.Size = new Size(1227, 57);
            textBox_NombrePaciente.TabIndex = 30;
            // 
            // textBox_IdPaciente
            // 
            textBox_IdPaciente.Enabled = false;
            textBox_IdPaciente.Location = new Point(375, 470);
            textBox_IdPaciente.Multiline = true;
            textBox_IdPaciente.Name = "textBox_IdPaciente";
            textBox_IdPaciente.Size = new Size(1227, 58);
            textBox_IdPaciente.TabIndex = 29;
            // 
            // label_Especie
            // 
            label_Especie.AutoSize = true;
            label_Especie.Enabled = false;
            label_Especie.Font = new Font("Arial", 9F);
            label_Especie.Location = new Point(375, 646);
            label_Especie.Name = "label_Especie";
            label_Especie.Size = new Size(97, 27);
            label_Especie.TabIndex = 35;
            label_Especie.Text = "Especie";
            // 
            // textBox_Especie
            // 
            textBox_Especie.Enabled = false;
            textBox_Especie.Location = new Point(375, 675);
            textBox_Especie.Multiline = true;
            textBox_Especie.Name = "textBox_Especie";
            textBox_Especie.Size = new Size(1227, 57);
            textBox_Especie.TabIndex = 34;
            // 
            // label_Raza
            // 
            label_Raza.AutoSize = true;
            label_Raza.Enabled = false;
            label_Raza.Font = new Font("Arial", 9F);
            label_Raza.Location = new Point(375, 745);
            label_Raza.Name = "label_Raza";
            label_Raza.Size = new Size(67, 27);
            label_Raza.TabIndex = 37;
            label_Raza.Text = "Raza";
            // 
            // textBox_Raza
            // 
            textBox_Raza.Enabled = false;
            textBox_Raza.Location = new Point(375, 775);
            textBox_Raza.Multiline = true;
            textBox_Raza.Name = "textBox_Raza";
            textBox_Raza.Size = new Size(1227, 57);
            textBox_Raza.TabIndex = 36;
            // 
            // label_Sexo
            // 
            label_Sexo.AutoSize = true;
            label_Sexo.Enabled = false;
            label_Sexo.Font = new Font("Arial", 9F);
            label_Sexo.Location = new Point(375, 844);
            label_Sexo.Name = "label_Sexo";
            label_Sexo.Size = new Size(65, 27);
            label_Sexo.TabIndex = 39;
            label_Sexo.Text = "Sexo";
            // 
            // textBox_Sexo
            // 
            textBox_Sexo.Enabled = false;
            textBox_Sexo.Location = new Point(375, 874);
            textBox_Sexo.Multiline = true;
            textBox_Sexo.Name = "textBox_Sexo";
            textBox_Sexo.Size = new Size(1227, 57);
            textBox_Sexo.TabIndex = 38;
            // 
            // label_Nacimiento
            // 
            label_Nacimiento.AutoSize = true;
            label_Nacimiento.Enabled = false;
            label_Nacimiento.Font = new Font("Arial", 9F);
            label_Nacimiento.Location = new Point(375, 943);
            label_Nacimiento.Name = "label_Nacimiento";
            label_Nacimiento.Size = new Size(236, 27);
            label_Nacimiento.TabIndex = 41;
            label_Nacimiento.Text = "Fecha de nacimiento";
            // 
            // textBox_Nacimiento
            // 
            textBox_Nacimiento.Enabled = false;
            textBox_Nacimiento.Location = new Point(375, 972);
            textBox_Nacimiento.Multiline = true;
            textBox_Nacimiento.Name = "textBox_Nacimiento";
            textBox_Nacimiento.Size = new Size(1227, 57);
            textBox_Nacimiento.TabIndex = 40;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(buttonAceptar);
            groupBox1.Controls.Add(buttonCancelar);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(699, 1042);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 130);
            groupBox1.TabIndex = 42;
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
            // FormPacientes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1819, 1292);
            Controls.Add(groupBox1);
            Controls.Add(label_Nacimiento);
            Controls.Add(textBox_Nacimiento);
            Controls.Add(label_Sexo);
            Controls.Add(textBox_Sexo);
            Controls.Add(label_Raza);
            Controls.Add(textBox_Raza);
            Controls.Add(label_Especie);
            Controls.Add(textBox_Especie);
            Controls.Add(checkBox_PacienteActivo);
            Controls.Add(label_NombrePaciente);
            Controls.Add(label_IdPaciente);
            Controls.Add(textBox_NombrePaciente);
            Controls.Add(textBox_IdPaciente);
            Controls.Add(groupBox);
            Controls.Add(listBox_SelectPacientes);
            Controls.Add(textBox_BuscarPacientes);
            Controls.Add(panelBuscar);
            Controls.Add(panelDeco);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += FormPacientes_FormClosing;
            panelDeco.ResumeLayout(false);
            panelDeco.PerformLayout();
            panelBuscar.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCerrar;
        private Panel panelDeco;
        private Button buttonCerrarPacientes;
        private Panel panelBuscar;
        private TextBox textBox_BuscarPacientes;
        private ListBox listBox_SelectPacientes;
        private Button buttonBuscarPaciente;
        private GroupBox groupBox;
        private Button buttonAgregar;
        private Button buttonModificar;
        private CheckBox checkBox_PacienteActivo;
        private Label label_NombrePaciente;
        private Label label_IdPaciente;
        private TextBox textBox_NombrePaciente;
        private TextBox textBox_IdPaciente;
        private Label label_Especie;
        private TextBox textBox_Especie;
        private Label label_Raza;
        private TextBox textBox_Raza;
        private Label label_Sexo;
        private TextBox textBox_Sexo;
        private Label label_Nacimiento;
        private TextBox textBox_Nacimiento;
        private GroupBox groupBox1;
        private Button buttonAceptar;
        private Button buttonCancelar;
    }
}