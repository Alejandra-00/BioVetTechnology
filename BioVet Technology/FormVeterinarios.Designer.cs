namespace BioVet_Technology
{
    partial class FormVeterinarios
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
            panelDeco = new Panel();
            buttonCerrarVeterinarios = new Button();
            groupBox1 = new GroupBox();
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            textBox_Mail = new TextBox();
            textBox_Telefono = new TextBox();
            label_NombreEstudio = new Label();
            label_IdEstudio = new Label();
            textBox_NombreVeterinario = new TextBox();
            textBox_IdVeterinario = new TextBox();
            groupBox = new GroupBox();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            listBox_SelectVeterinarios = new ListBox();
            textBox_BuscarVeterinarios = new TextBox();
            panelBuscar = new Panel();
            buttonBuscarVeterinario = new Button();
            buttonBuscar = new Button();
            label_Telefono = new Label();
            label_Mail = new Label();
            checkBox_VeterinarioActivo = new CheckBox();
            panelDeco.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox.SuspendLayout();
            panelBuscar.SuspendLayout();
            SuspendLayout();
            // 
            // panelDeco
            // 
            panelDeco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDeco.BackColor = Color.MidnightBlue;
            panelDeco.Controls.Add(buttonCerrarVeterinarios);
            panelDeco.Location = new Point(0, 1);
            panelDeco.Name = "panelDeco";
            panelDeco.Size = new Size(1817, 78);
            panelDeco.TabIndex = 13;
            // 
            // buttonCerrarVeterinarios
            // 
            buttonCerrarVeterinarios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrarVeterinarios.AutoSize = true;
            buttonCerrarVeterinarios.BackColor = Color.Transparent;
            buttonCerrarVeterinarios.FlatStyle = FlatStyle.Flat;
            buttonCerrarVeterinarios.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCerrarVeterinarios.ForeColor = Color.White;
            buttonCerrarVeterinarios.Location = new Point(1750, 11);
            buttonCerrarVeterinarios.Name = "buttonCerrarVeterinarios";
            buttonCerrarVeterinarios.Size = new Size(57, 58);
            buttonCerrarVeterinarios.TabIndex = 14;
            buttonCerrarVeterinarios.Text = "X";
            buttonCerrarVeterinarios.UseVisualStyleBackColor = false;
            buttonCerrarVeterinarios.Click += buttonCerrarVeterinarios_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(buttonAceptar);
            groupBox1.Controls.Add(buttonCancelar);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(689, 845);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 130);
            groupBox1.TabIndex = 60;
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
            // textBox_Mail
            // 
            textBox_Mail.Enabled = false;
            textBox_Mail.Location = new Point(374, 776);
            textBox_Mail.Multiline = true;
            textBox_Mail.Name = "textBox_Mail";
            textBox_Mail.Size = new Size(1227, 57);
            textBox_Mail.TabIndex = 54;
            // 
            // textBox_Telefono
            // 
            textBox_Telefono.Enabled = false;
            textBox_Telefono.Location = new Point(374, 676);
            textBox_Telefono.Multiline = true;
            textBox_Telefono.Name = "textBox_Telefono";
            textBox_Telefono.Size = new Size(1227, 57);
            textBox_Telefono.TabIndex = 52;
            // 
            // label_NombreEstudio
            // 
            label_NombreEstudio.AutoSize = true;
            label_NombreEstudio.Enabled = false;
            label_NombreEstudio.Font = new Font("Arial", 9F);
            label_NombreEstudio.Location = new Point(374, 542);
            label_NombreEstudio.Name = "label_NombreEstudio";
            label_NombreEstudio.Size = new Size(97, 27);
            label_NombreEstudio.TabIndex = 50;
            label_NombreEstudio.Text = "Nombre";
            // 
            // label_IdEstudio
            // 
            label_IdEstudio.AutoSize = true;
            label_IdEstudio.Enabled = false;
            label_IdEstudio.Font = new Font("Arial", 9F);
            label_IdEstudio.Location = new Point(374, 436);
            label_IdEstudio.Name = "label_IdEstudio";
            label_IdEstudio.Size = new Size(35, 27);
            label_IdEstudio.TabIndex = 49;
            label_IdEstudio.Text = "ID";
            // 
            // textBox_NombreVeterinario
            // 
            textBox_NombreVeterinario.Enabled = false;
            textBox_NombreVeterinario.Location = new Point(374, 577);
            textBox_NombreVeterinario.Multiline = true;
            textBox_NombreVeterinario.Name = "textBox_NombreVeterinario";
            textBox_NombreVeterinario.Size = new Size(1227, 57);
            textBox_NombreVeterinario.TabIndex = 48;
            // 
            // textBox_IdVeterinario
            // 
            textBox_IdVeterinario.Enabled = false;
            textBox_IdVeterinario.Location = new Point(374, 471);
            textBox_IdVeterinario.Multiline = true;
            textBox_IdVeterinario.Name = "textBox_IdVeterinario";
            textBox_IdVeterinario.Size = new Size(1227, 58);
            textBox_IdVeterinario.TabIndex = 47;
            // 
            // groupBox
            // 
            groupBox.AutoSize = true;
            groupBox.Controls.Add(buttonAgregar);
            groupBox.Controls.Add(buttonModificar);
            groupBox.Enabled = false;
            groupBox.Location = new Point(11, 397);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(250, 199);
            groupBox.TabIndex = 46;
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
            // listBox_SelectVeterinarios
            // 
            listBox_SelectVeterinarios.FormattingEnabled = true;
            listBox_SelectVeterinarios.Location = new Point(451, 208);
            listBox_SelectVeterinarios.Name = "listBox_SelectVeterinarios";
            listBox_SelectVeterinarios.Size = new Size(949, 164);
            listBox_SelectVeterinarios.TabIndex = 45;
            // 
            // textBox_BuscarVeterinarios
            // 
            textBox_BuscarVeterinarios.Location = new Point(451, 150);
            textBox_BuscarVeterinarios.Multiline = true;
            textBox_BuscarVeterinarios.Name = "textBox_BuscarVeterinarios";
            textBox_BuscarVeterinarios.Size = new Size(949, 58);
            textBox_BuscarVeterinarios.TabIndex = 44;
            // 
            // panelBuscar
            // 
            panelBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBuscar.Controls.Add(buttonBuscarVeterinario);
            panelBuscar.Controls.Add(buttonBuscar);
            panelBuscar.Location = new Point(0, 131);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1817, 260);
            panelBuscar.TabIndex = 43;
            // 
            // buttonBuscarVeterinario
            // 
            buttonBuscarVeterinario.Anchor = AnchorStyles.Top;
            buttonBuscarVeterinario.BackColor = Color.MidnightBlue;
            buttonBuscarVeterinario.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonBuscarVeterinario.ForeColor = Color.White;
            buttonBuscarVeterinario.Location = new Point(1420, 19);
            buttonBuscarVeterinario.Name = "buttonBuscarVeterinario";
            buttonBuscarVeterinario.Size = new Size(242, 58);
            buttonBuscarVeterinario.TabIndex = 64;
            buttonBuscarVeterinario.Text = "BUSCAR";
            buttonBuscarVeterinario.UseVisualStyleBackColor = false;
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
            // label_Telefono
            // 
            label_Telefono.AutoSize = true;
            label_Telefono.Enabled = false;
            label_Telefono.Font = new Font("Arial", 9F);
            label_Telefono.Location = new Point(374, 646);
            label_Telefono.Name = "label_Telefono";
            label_Telefono.Size = new Size(102, 27);
            label_Telefono.TabIndex = 61;
            label_Telefono.Text = "Teléfono";
            // 
            // label_Mail
            // 
            label_Mail.AutoSize = true;
            label_Mail.Enabled = false;
            label_Mail.Font = new Font("Arial", 9F);
            label_Mail.Location = new Point(374, 746);
            label_Mail.Name = "label_Mail";
            label_Mail.Size = new Size(55, 27);
            label_Mail.TabIndex = 62;
            label_Mail.Text = "Mail";
            // 
            // checkBox_VeterinarioActivo
            // 
            checkBox_VeterinarioActivo.AutoSize = true;
            checkBox_VeterinarioActivo.Enabled = false;
            checkBox_VeterinarioActivo.Location = new Point(374, 845);
            checkBox_VeterinarioActivo.Name = "checkBox_VeterinarioActivo";
            checkBox_VeterinarioActivo.Size = new Size(112, 36);
            checkBox_VeterinarioActivo.TabIndex = 63;
            checkBox_VeterinarioActivo.Text = "Activo";
            checkBox_VeterinarioActivo.UseVisualStyleBackColor = true;
            // 
            // FormVeterinarios
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1819, 1292);
            Controls.Add(checkBox_VeterinarioActivo);
            Controls.Add(label_Mail);
            Controls.Add(label_Telefono);
            Controls.Add(groupBox1);
            Controls.Add(textBox_Mail);
            Controls.Add(textBox_Telefono);
            Controls.Add(label_NombreEstudio);
            Controls.Add(label_IdEstudio);
            Controls.Add(textBox_NombreVeterinario);
            Controls.Add(textBox_IdVeterinario);
            Controls.Add(groupBox);
            Controls.Add(listBox_SelectVeterinarios);
            Controls.Add(textBox_BuscarVeterinarios);
            Controls.Add(panelBuscar);
            Controls.Add(panelDeco);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVeterinarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVeterinarios";
            FormClosing += FormVeterinarios_FormClosing;
            panelDeco.ResumeLayout(false);
            panelDeco.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            panelBuscar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDeco;
        private Button buttonCerrarVeterinarios;
        private GroupBox groupBox1;
        private Button buttonAceptar;
        private Button buttonCancelar;
        private Label label_Nacimiento;
        private TextBox textBox5;
        private Label label_Sexo;
        private TextBox textBox4;
        private Label label_Raza;
        private TextBox textBox_Mail;
        private Label label_Especie;
        private TextBox textBox_Telefono;
        private CheckBox checkBox_EstudioActivo;
        private Label label_NombreEstudio;
        private Label label_IdEstudio;
        private TextBox textBox_NombreVeterinario;
        private TextBox textBox_IdVeterinario;
        private GroupBox groupBox;
        private Button buttonAgregar;
        private Button buttonModificar;
        private ListBox listBox_SelectVeterinarios;
        private TextBox textBox_BuscarVeterinarios;
        private Panel panelBuscar;
        private Button buttonBuscar;
        private Label label_Telefono;
        private Label label_Mail;
        private CheckBox checkBox_VeterinarioActivo;
        private Button buttonBuscarVeterinario;
    }
}