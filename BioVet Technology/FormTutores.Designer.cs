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
            panelDeco = new Panel();
            buttonCerrarTutores = new Button();
            groupBoxAcepCan = new GroupBox();
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
            groupBoxAcciones = new GroupBox();
            buttonImprimir = new Button();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            panelBuscar.SuspendLayout();
            panelDeco.SuspendLayout();
            groupBoxAcepCan.SuspendLayout();
            groupBoxAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // listBox_SelectTutores
            // 
            listBox_SelectTutores.FormattingEnabled = true;
            listBox_SelectTutores.Location = new Point(278, 129);
            listBox_SelectTutores.Margin = new Padding(2);
            listBox_SelectTutores.Name = "listBox_SelectTutores";
            listBox_SelectTutores.Size = new Size(586, 104);
            listBox_SelectTutores.TabIndex = 31;
            // 
            // textBox_BuscarTutor
            // 
            textBox_BuscarTutor.Location = new Point(278, 93);
            textBox_BuscarTutor.Margin = new Padding(2);
            textBox_BuscarTutor.Multiline = true;
            textBox_BuscarTutor.Name = "textBox_BuscarTutor";
            textBox_BuscarTutor.Size = new Size(586, 38);
            textBox_BuscarTutor.TabIndex = 30;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top;
            buttonBuscar.BackColor = Color.MidnightBlue;
            buttonBuscar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(1372, 12);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(149, 36);
            buttonBuscar.TabIndex = 28;
            buttonBuscar.Text = "BUSCAR";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // panelBuscar
            // 
            panelBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBuscar.Controls.Add(buttonBuscar);
            panelBuscar.Location = new Point(1, 81);
            panelBuscar.Margin = new Padding(2);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1118, 162);
            panelBuscar.TabIndex = 29;
            // 
            // panelDeco
            // 
            panelDeco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDeco.BackColor = Color.MidnightBlue;
            panelDeco.Controls.Add(buttonCerrarTutores);
            panelDeco.Location = new Point(1, 1);
            panelDeco.Margin = new Padding(2);
            panelDeco.Name = "panelDeco";
            panelDeco.Size = new Size(1118, 49);
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
            buttonCerrarTutores.Location = new Point(1071, 7);
            buttonCerrarTutores.Margin = new Padding(2);
            buttonCerrarTutores.Name = "buttonCerrarTutores";
            buttonCerrarTutores.Size = new Size(40, 40);
            buttonCerrarTutores.TabIndex = 32;
            buttonCerrarTutores.Text = "X";
            buttonCerrarTutores.UseVisualStyleBackColor = false;
            buttonCerrarTutores.Click += buttonCerrarTutores_Click;
            // 
            // groupBoxAcepCan
            // 
            groupBoxAcepCan.AutoSize = true;
            groupBoxAcepCan.Controls.Add(buttonAceptar);
            groupBoxAcepCan.Controls.Add(buttonCancelar);
            groupBoxAcepCan.Enabled = false;
            groupBoxAcepCan.Location = new Point(425, 528);
            groupBoxAcepCan.Margin = new Padding(2);
            groupBoxAcepCan.Name = "groupBoxAcepCan";
            groupBoxAcepCan.Padding = new Padding(2);
            groupBoxAcepCan.Size = new Size(305, 81);
            groupBoxAcepCan.TabIndex = 71;
            groupBoxAcepCan.TabStop = false;
            groupBoxAcepCan.Visible = false;
            // 
            // buttonAceptar
            // 
            buttonAceptar.BackColor = Color.MidnightBlue;
            buttonAceptar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonAceptar.ForeColor = Color.White;
            buttonAceptar.Location = new Point(0, 21);
            buttonAceptar.Margin = new Padding(2);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(149, 36);
            buttonAceptar.TabIndex = 17;
            buttonAceptar.Text = "ACEPTAR";
            buttonAceptar.UseVisualStyleBackColor = false;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.MidnightBlue;
            buttonCancelar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(156, 21);
            buttonCancelar.Margin = new Padding(2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(145, 36);
            buttonCancelar.TabIndex = 17;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label_Mail
            // 
            label_Mail.AutoSize = true;
            label_Mail.Enabled = false;
            label_Mail.Font = new Font("Arial", 9F);
            label_Mail.Location = new Point(231, 466);
            label_Mail.Margin = new Padding(2, 0, 2, 0);
            label_Mail.Name = "label_Mail";
            label_Mail.Size = new Size(33, 17);
            label_Mail.TabIndex = 70;
            label_Mail.Text = "Mail";
            label_Mail.Visible = false;
            // 
            // textBox_Mail
            // 
            textBox_Mail.Enabled = false;
            textBox_Mail.Location = new Point(231, 484);
            textBox_Mail.Margin = new Padding(2);
            textBox_Mail.Multiline = true;
            textBox_Mail.Name = "textBox_Mail";
            textBox_Mail.Size = new Size(757, 37);
            textBox_Mail.TabIndex = 69;
            textBox_Mail.Visible = false;
            // 
            // label_Telefono
            // 
            label_Telefono.AutoSize = true;
            label_Telefono.Enabled = false;
            label_Telefono.Font = new Font("Arial", 9F);
            label_Telefono.Location = new Point(231, 404);
            label_Telefono.Margin = new Padding(2, 0, 2, 0);
            label_Telefono.Name = "label_Telefono";
            label_Telefono.Size = new Size(62, 17);
            label_Telefono.TabIndex = 68;
            label_Telefono.Text = "Teléfono";
            label_Telefono.Visible = false;
            // 
            // textBox_Telefono
            // 
            textBox_Telefono.Enabled = false;
            textBox_Telefono.Location = new Point(231, 422);
            textBox_Telefono.Margin = new Padding(2);
            textBox_Telefono.Multiline = true;
            textBox_Telefono.Name = "textBox_Telefono";
            textBox_Telefono.Size = new Size(757, 37);
            textBox_Telefono.TabIndex = 67;
            textBox_Telefono.Visible = false;
            textBox_Telefono.KeyPress += textBox_Telefono_KeyPress;
            // 
            // checkBox_TutorActivo
            // 
            checkBox_TutorActivo.AutoSize = true;
            checkBox_TutorActivo.Enabled = false;
            checkBox_TutorActivo.Font = new Font("Arial", 9F);
            checkBox_TutorActivo.Location = new Point(231, 528);
            checkBox_TutorActivo.Margin = new Padding(2);
            checkBox_TutorActivo.Name = "checkBox_TutorActivo";
            checkBox_TutorActivo.Size = new Size(69, 21);
            checkBox_TutorActivo.TabIndex = 66;
            checkBox_TutorActivo.Text = "Activo";
            checkBox_TutorActivo.UseVisualStyleBackColor = true;
            checkBox_TutorActivo.Visible = false;
            // 
            // label_NombreTutor
            // 
            label_NombreTutor.AutoSize = true;
            label_NombreTutor.Enabled = false;
            label_NombreTutor.Font = new Font("Arial", 9F);
            label_NombreTutor.Location = new Point(231, 338);
            label_NombreTutor.Margin = new Padding(2, 0, 2, 0);
            label_NombreTutor.Name = "label_NombreTutor";
            label_NombreTutor.Size = new Size(60, 17);
            label_NombreTutor.TabIndex = 65;
            label_NombreTutor.Text = "Nombre";
            label_NombreTutor.Visible = false;
            // 
            // label_IdTutor
            // 
            label_IdTutor.AutoSize = true;
            label_IdTutor.Enabled = false;
            label_IdTutor.Font = new Font("Arial", 9F);
            label_IdTutor.Location = new Point(231, 272);
            label_IdTutor.Margin = new Padding(2, 0, 2, 0);
            label_IdTutor.Name = "label_IdTutor";
            label_IdTutor.Size = new Size(22, 17);
            label_IdTutor.TabIndex = 64;
            label_IdTutor.Text = "ID";
            label_IdTutor.Visible = false;
            // 
            // textBox_NombreTutor
            // 
            textBox_NombreTutor.Enabled = false;
            textBox_NombreTutor.Location = new Point(231, 360);
            textBox_NombreTutor.Margin = new Padding(2);
            textBox_NombreTutor.Multiline = true;
            textBox_NombreTutor.Name = "textBox_NombreTutor";
            textBox_NombreTutor.Size = new Size(757, 37);
            textBox_NombreTutor.TabIndex = 63;
            textBox_NombreTutor.Visible = false;
            // 
            // textBox_IdTutor
            // 
            textBox_IdTutor.Enabled = false;
            textBox_IdTutor.Location = new Point(231, 294);
            textBox_IdTutor.Margin = new Padding(2);
            textBox_IdTutor.Multiline = true;
            textBox_IdTutor.Name = "textBox_IdTutor";
            textBox_IdTutor.Size = new Size(757, 38);
            textBox_IdTutor.TabIndex = 62;
            textBox_IdTutor.Visible = false;
            // 
            // groupBoxAcciones
            // 
            groupBoxAcciones.AutoSize = true;
            groupBoxAcciones.Controls.Add(buttonImprimir);
            groupBoxAcciones.Controls.Add(buttonAgregar);
            groupBoxAcciones.Controls.Add(buttonModificar);
            groupBoxAcciones.Enabled = false;
            groupBoxAcciones.Location = new Point(1, 248);
            groupBoxAcciones.Margin = new Padding(2);
            groupBoxAcciones.Name = "groupBoxAcciones";
            groupBoxAcciones.Padding = new Padding(2);
            groupBoxAcciones.Size = new Size(154, 157);
            groupBoxAcciones.TabIndex = 26;
            groupBoxAcciones.TabStop = false;
            // 
            // buttonImprimir
            // 
            buttonImprimir.BackColor = Color.MidnightBlue;
            buttonImprimir.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonImprimir.ForeColor = Color.White;
            buttonImprimir.Location = new Point(4, 17);
            buttonImprimir.Margin = new Padding(2);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(143, 36);
            buttonImprimir.TabIndex = 24;
            buttonImprimir.Text = "IMPRIMIR";
            buttonImprimir.UseVisualStyleBackColor = false;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.MidnightBlue;
            buttonAgregar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(4, 57);
            buttonAgregar.Margin = new Padding(2);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(143, 36);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "AGREGAR";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.MidnightBlue;
            buttonModificar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonModificar.ForeColor = Color.White;
            buttonModificar.Location = new Point(4, 97);
            buttonModificar.Margin = new Padding(2);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(143, 36);
            buttonModificar.TabIndex = 23;
            buttonModificar.Text = "MODIFICAR";
            buttonModificar.UseVisualStyleBackColor = false;
            // 
            // FormTutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 764);
            Controls.Add(label_Mail);
            Controls.Add(textBox_Mail);
            Controls.Add(label_Telefono);
            Controls.Add(textBox_Telefono);
            Controls.Add(checkBox_TutorActivo);
            Controls.Add(label_NombreTutor);
            Controls.Add(label_IdTutor);
            Controls.Add(textBox_NombreTutor);
            Controls.Add(textBox_IdTutor);
            Controls.Add(listBox_SelectTutores);
            Controls.Add(textBox_BuscarTutor);
            Controls.Add(panelBuscar);
            Controls.Add(panelDeco);
            Controls.Add(groupBoxAcepCan);
            Controls.Add(groupBoxAcciones);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormTutores";
            Text = "FormTutores";
            FormClosing += FormTutores_FormClosing;
            Load += FormTutores_Load;
            panelBuscar.ResumeLayout(false);
            panelDeco.ResumeLayout(false);
            panelDeco.PerformLayout();
            groupBoxAcepCan.ResumeLayout(false);
            groupBoxAcciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_SelectTutores;
        private TextBox textBox_BuscarTutor;
        private Button buttonBuscar;
        private Panel panelBuscar;
        private Panel panelDeco;
        private Button buttonCerrarTutores;
        private GroupBox groupBoxAcepCan;
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
        private GroupBox groupBoxAcciones;
        private Button buttonImprimir;
        private Button buttonAgregar;
        private Button buttonModificar;
    }
}