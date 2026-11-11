namespace BioVet_Technology
{
    partial class FormEstudio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudio));
            buttonAgregar = new Button();
            this.buttonCerrarEstudios = new Button();
            panelDeco = new Panel();
            panelBuscar = new Panel();
            this.comboBoxSelectEstudio = new ComboBox();
            buttonModificar = new Button();
            groupBox = new GroupBox();
            textBox_IdEstudio = new TextBox();
            label_IdEstudio = new Label();
            label_NombreEstudio = new Label();
            checkBox_EstudioActivo = new CheckBox();
            tabPageModificar = new TabPage();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox7 = new TextBox();
            checkBox_ModificarAnalito = new CheckBox();
            label7 = new Label();
            tabPage_AgregarAnalitos = new TabPage();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            checkBox_AgregarAnalito = new CheckBox();
            tabPage_Analitos = new TabPage();
            textBox_NombreAnalito = new TextBox();
            textBox_IdAnalito = new TextBox();
            label_IdAnalito = new Label();
            label_NombreAnalito = new Label();
            textBox_Referencias = new TextBox();
            label_Referencias = new Label();
            textBox_Medidas = new TextBox();
            label_Medidas = new Label();
            button_ModificarAnalito = new Button();
            checkBox_VerAnalitos = new CheckBox();
            dataGridView_VerAnalitos = new DataGridView();
            tabControlEstudio = new TabControl();
            textBox_NombreEstudio = new TextBox();
            panelDeco.SuspendLayout();
            panelBuscar.SuspendLayout();
            groupBox.SuspendLayout();
            tabPageModificar.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage_AgregarAnalitos.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage_Analitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_VerAnalitos).BeginInit();
            tabControlEstudio.SuspendLayout();
            SuspendLayout();
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
            // buttonCerrarEstudios
            // 
            this.buttonCerrarEstudios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.buttonCerrarEstudios.AutoSize = true;
            this.buttonCerrarEstudios.BackColor = Color.Transparent;
            this.buttonCerrarEstudios.FlatStyle = FlatStyle.Flat;
            this.buttonCerrarEstudios.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            this.buttonCerrarEstudios.ForeColor = Color.White;
            this.buttonCerrarEstudios.Location = new Point(1749, 11);
            this.buttonCerrarEstudios.Name = "buttonCerrarEstudios";
            this.buttonCerrarEstudios.Size = new Size(57, 58);
            this.buttonCerrarEstudios.TabIndex = 11;
            this.buttonCerrarEstudios.Text = "X";
            this.buttonCerrarEstudios.UseVisualStyleBackColor = false;
            this.buttonCerrarEstudios.Click += this.buttonCerrarEstudios_Click;
            // 
            // panelDeco
            // 
            panelDeco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDeco.BackColor = Color.MidnightBlue;
            panelDeco.Controls.Add(this.buttonCerrarEstudios);
            panelDeco.Location = new Point(1, 1);
            panelDeco.Name = "panelDeco";
            panelDeco.Size = new Size(1817, 78);
            panelDeco.TabIndex = 12;
            // 
            // panelBuscar
            // 
            panelBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBuscar.Controls.Add(this.comboBoxSelectEstudio);
            panelBuscar.Location = new Point(1, 130);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1817, 95);
            panelBuscar.TabIndex = 14;
            // 
            // comboBoxSelectEstudio
            // 
            this.comboBoxSelectEstudio.FormattingEnabled = true;
            this.comboBoxSelectEstudio.Location = new Point(274, 28);
            this.comboBoxSelectEstudio.Name = "comboBoxSelectEstudio";
            this.comboBoxSelectEstudio.Size = new Size(1292, 40);
            this.comboBoxSelectEstudio.TabIndex = 22;
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
            // groupBox
            // 
            groupBox.AutoSize = true;
            groupBox.Controls.Add(buttonAgregar);
            groupBox.Controls.Add(buttonModificar);
            groupBox.Enabled = false;
            groupBox.Location = new Point(12, 231);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(250, 199);
            groupBox.TabIndex = 24;
            groupBox.TabStop = false;
            // 
            // textBox_IdEstudio
            // 
            textBox_IdEstudio.Enabled = false;
            textBox_IdEstudio.Location = new Point(340, 289);
            textBox_IdEstudio.Multiline = true;
            textBox_IdEstudio.Name = "textBox_IdEstudio";
            textBox_IdEstudio.Size = new Size(1227, 58);
            textBox_IdEstudio.TabIndex = 17;
            // 
            // label_IdEstudio
            // 
            label_IdEstudio.AutoSize = true;
            label_IdEstudio.Enabled = false;
            label_IdEstudio.Font = new Font("Arial", 9F);
            label_IdEstudio.Location = new Point(340, 254);
            label_IdEstudio.Name = "label_IdEstudio";
            label_IdEstudio.Size = new Size(35, 27);
            label_IdEstudio.TabIndex = 19;
            label_IdEstudio.Text = "ID";
            // 
            // label_NombreEstudio
            // 
            label_NombreEstudio.AutoSize = true;
            label_NombreEstudio.Enabled = false;
            label_NombreEstudio.Font = new Font("Arial", 9F);
            label_NombreEstudio.Location = new Point(340, 360);
            label_NombreEstudio.Name = "label_NombreEstudio";
            label_NombreEstudio.Size = new Size(97, 27);
            label_NombreEstudio.TabIndex = 20;
            label_NombreEstudio.Text = "Nombre";
            // 
            // checkBox_EstudioActivo
            // 
            checkBox_EstudioActivo.AutoSize = true;
            checkBox_EstudioActivo.Enabled = false;
            checkBox_EstudioActivo.Font = new Font("Arial", 9F);
            checkBox_EstudioActivo.Location = new Point(340, 472);
            checkBox_EstudioActivo.Name = "checkBox_EstudioActivo";
            checkBox_EstudioActivo.Size = new Size(107, 31);
            checkBox_EstudioActivo.TabIndex = 26;
            checkBox_EstudioActivo.Text = "Activo";
            checkBox_EstudioActivo.UseVisualStyleBackColor = true;
            // 
            // tabPageModificar
            // 
            tabPageModificar.BackColor = Color.MidnightBlue;
            tabPageModificar.Controls.Add(label7);
            tabPageModificar.Controls.Add(checkBox_ModificarAnalito);
            tabPageModificar.Controls.Add(textBox7);
            tabPageModificar.Controls.Add(textBox3);
            tabPageModificar.Controls.Add(textBox6);
            tabPageModificar.Controls.Add(textBox5);
            tabPageModificar.Controls.Add(label4);
            tabPageModificar.Controls.Add(groupBox2);
            tabPageModificar.Controls.Add(label6);
            tabPageModificar.Controls.Add(label5);
            tabPageModificar.Location = new Point(8, 41);
            tabPageModificar.Name = "tabPageModificar";
            tabPageModificar.Size = new Size(1219, 635);
            tabPageModificar.TabIndex = 2;
            tabPageModificar.Text = "Modificar Analito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 232);
            label5.Name = "label5";
            label5.Size = new Size(139, 27);
            label5.TabIndex = 48;
            label5.Text = "Referencias";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 127);
            label6.Name = "label6";
            label6.Size = new Size(97, 27);
            label6.TabIndex = 46;
            label6.Text = "Nombre";
            label6.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(45, 375);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(1119, 57);
            textBox5.TabIndex = 49;
            textBox5.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(45, 267);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(1119, 57);
            textBox6.TabIndex = 47;
            textBox6.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(45, 486);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 130);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(254, 34);
            button2.Name = "button2";
            button2.Size = new Size(236, 58);
            button2.TabIndex = 17;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 34);
            button1.Name = "button1";
            button1.Size = new Size(242, 58);
            button1.TabIndex = 17;
            button1.Text = "ACEPTAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 340);
            label4.Name = "label4";
            label4.Size = new Size(102, 27);
            label4.TabIndex = 50;
            label4.Text = "Medidas";
            label4.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(45, 162);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1119, 57);
            textBox3.TabIndex = 45;
            textBox3.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(45, 58);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(1119, 58);
            textBox7.TabIndex = 29;
            // 
            // checkBox_ModificarAnalito
            // 
            checkBox_ModificarAnalito.AutoSize = true;
            checkBox_ModificarAnalito.ForeColor = Color.White;
            checkBox_ModificarAnalito.Location = new Point(45, 449);
            checkBox_ModificarAnalito.Name = "checkBox_ModificarAnalito";
            checkBox_ModificarAnalito.Size = new Size(107, 31);
            checkBox_ModificarAnalito.TabIndex = 44;
            checkBox_ModificarAnalito.Text = "Activo";
            checkBox_ModificarAnalito.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Enabled = false;
            label7.Font = new Font("Arial", 9F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(45, 23);
            label7.Name = "label7";
            label7.Size = new Size(35, 27);
            label7.TabIndex = 30;
            label7.Text = "ID";
            // 
            // tabPage_AgregarAnalitos
            // 
            tabPage_AgregarAnalitos.BackColor = Color.MidnightBlue;
            tabPage_AgregarAnalitos.Controls.Add(checkBox_AgregarAnalito);
            tabPage_AgregarAnalitos.Controls.Add(groupBox1);
            tabPage_AgregarAnalitos.Controls.Add(label1);
            tabPage_AgregarAnalitos.Controls.Add(textBox4);
            tabPage_AgregarAnalitos.Controls.Add(textBox1);
            tabPage_AgregarAnalitos.Controls.Add(textBox2);
            tabPage_AgregarAnalitos.Controls.Add(label2);
            tabPage_AgregarAnalitos.Controls.Add(label3);
            tabPage_AgregarAnalitos.Location = new Point(8, 41);
            tabPage_AgregarAnalitos.Name = "tabPage_AgregarAnalitos";
            tabPage_AgregarAnalitos.Padding = new Padding(3);
            tabPage_AgregarAnalitos.Size = new Size(1219, 635);
            tabPage_AgregarAnalitos.TabIndex = 1;
            tabPage_AgregarAnalitos.Text = "Agregar Analitos";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(49, 189);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1119, 57);
            textBox2.TabIndex = 39;
            textBox2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 49);
            label3.Name = "label3";
            label3.Size = new Size(97, 27);
            label3.TabIndex = 38;
            label3.Text = "Nombre";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 154);
            label2.Name = "label2";
            label2.Size = new Size(139, 27);
            label2.TabIndex = 40;
            label2.Text = "Referencias";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(49, 297);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1119, 57);
            textBox1.TabIndex = 41;
            textBox1.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(49, 84);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1119, 57);
            textBox4.TabIndex = 36;
            textBox4.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 262);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 42;
            label1.Text = "Medidas";
            label1.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(buttonAceptar);
            groupBox1.Controls.Add(buttonCancelar);
            groupBox1.Location = new Point(49, 408);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 130);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
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
            // checkBox_AgregarAnalito
            // 
            checkBox_AgregarAnalito.AutoSize = true;
            checkBox_AgregarAnalito.Checked = true;
            checkBox_AgregarAnalito.CheckState = CheckState.Checked;
            checkBox_AgregarAnalito.ForeColor = Color.White;
            checkBox_AgregarAnalito.Location = new Point(49, 371);
            checkBox_AgregarAnalito.Name = "checkBox_AgregarAnalito";
            checkBox_AgregarAnalito.Size = new Size(107, 31);
            checkBox_AgregarAnalito.TabIndex = 35;
            checkBox_AgregarAnalito.Text = "Activo";
            checkBox_AgregarAnalito.UseVisualStyleBackColor = true;
            // 
            // tabPage_Analitos
            // 
            tabPage_Analitos.BackColor = Color.MidnightBlue;
            tabPage_Analitos.Controls.Add(dataGridView_VerAnalitos);
            tabPage_Analitos.Controls.Add(checkBox_VerAnalitos);
            tabPage_Analitos.Controls.Add(button_ModificarAnalito);
            tabPage_Analitos.Controls.Add(label_Medidas);
            tabPage_Analitos.Controls.Add(textBox_Medidas);
            tabPage_Analitos.Controls.Add(textBox_Referencias);
            tabPage_Analitos.Controls.Add(textBox_IdAnalito);
            tabPage_Analitos.Controls.Add(textBox_NombreAnalito);
            tabPage_Analitos.Controls.Add(label_Referencias);
            tabPage_Analitos.Controls.Add(label_NombreAnalito);
            tabPage_Analitos.Controls.Add(label_IdAnalito);
            tabPage_Analitos.Location = new Point(8, 41);
            tabPage_Analitos.Name = "tabPage_Analitos";
            tabPage_Analitos.Padding = new Padding(3);
            tabPage_Analitos.Size = new Size(1219, 635);
            tabPage_Analitos.TabIndex = 0;
            tabPage_Analitos.Text = "Analitos";
            // 
            // textBox_NombreAnalito
            // 
            textBox_NombreAnalito.Enabled = false;
            textBox_NombreAnalito.Location = new Point(30, 438);
            textBox_NombreAnalito.Multiline = true;
            textBox_NombreAnalito.Name = "textBox_NombreAnalito";
            textBox_NombreAnalito.Size = new Size(538, 57);
            textBox_NombreAnalito.TabIndex = 27;
            textBox_NombreAnalito.Visible = false;
            // 
            // textBox_IdAnalito
            // 
            textBox_IdAnalito.Enabled = false;
            textBox_IdAnalito.Location = new Point(30, 332);
            textBox_IdAnalito.Multiline = true;
            textBox_IdAnalito.Name = "textBox_IdAnalito";
            textBox_IdAnalito.Size = new Size(538, 58);
            textBox_IdAnalito.TabIndex = 26;
            textBox_IdAnalito.Visible = false;
            // 
            // label_IdAnalito
            // 
            label_IdAnalito.AutoSize = true;
            label_IdAnalito.BackColor = Color.Transparent;
            label_IdAnalito.Enabled = false;
            label_IdAnalito.Font = new Font("Arial", 9F);
            label_IdAnalito.ForeColor = Color.White;
            label_IdAnalito.Location = new Point(30, 297);
            label_IdAnalito.Name = "label_IdAnalito";
            label_IdAnalito.Size = new Size(35, 27);
            label_IdAnalito.TabIndex = 28;
            label_IdAnalito.Text = "ID";
            label_IdAnalito.Visible = false;
            // 
            // label_NombreAnalito
            // 
            label_NombreAnalito.AutoSize = true;
            label_NombreAnalito.BackColor = Color.Transparent;
            label_NombreAnalito.Enabled = false;
            label_NombreAnalito.Font = new Font("Arial", 9F);
            label_NombreAnalito.ForeColor = Color.White;
            label_NombreAnalito.Location = new Point(30, 403);
            label_NombreAnalito.Name = "label_NombreAnalito";
            label_NombreAnalito.Size = new Size(97, 27);
            label_NombreAnalito.TabIndex = 29;
            label_NombreAnalito.Text = "Nombre";
            label_NombreAnalito.Visible = false;
            // 
            // textBox_Referencias
            // 
            textBox_Referencias.Enabled = false;
            textBox_Referencias.Location = new Point(648, 333);
            textBox_Referencias.Multiline = true;
            textBox_Referencias.Name = "textBox_Referencias";
            textBox_Referencias.Size = new Size(538, 57);
            textBox_Referencias.TabIndex = 30;
            textBox_Referencias.Visible = false;
            // 
            // label_Referencias
            // 
            label_Referencias.AutoSize = true;
            label_Referencias.BackColor = Color.Transparent;
            label_Referencias.Enabled = false;
            label_Referencias.Font = new Font("Arial", 9F);
            label_Referencias.ForeColor = Color.White;
            label_Referencias.Location = new Point(648, 298);
            label_Referencias.Name = "label_Referencias";
            label_Referencias.Size = new Size(139, 27);
            label_Referencias.TabIndex = 31;
            label_Referencias.Text = "Referencias";
            label_Referencias.Visible = false;
            // 
            // textBox_Medidas
            // 
            textBox_Medidas.Enabled = false;
            textBox_Medidas.Location = new Point(648, 438);
            textBox_Medidas.Multiline = true;
            textBox_Medidas.Name = "textBox_Medidas";
            textBox_Medidas.Size = new Size(538, 57);
            textBox_Medidas.TabIndex = 32;
            textBox_Medidas.Visible = false;
            // 
            // label_Medidas
            // 
            label_Medidas.AutoSize = true;
            label_Medidas.BackColor = Color.Transparent;
            label_Medidas.Enabled = false;
            label_Medidas.Font = new Font("Arial", 9F);
            label_Medidas.ForeColor = Color.White;
            label_Medidas.Location = new Point(648, 403);
            label_Medidas.Name = "label_Medidas";
            label_Medidas.Size = new Size(102, 27);
            label_Medidas.TabIndex = 33;
            label_Medidas.Text = "Medidas";
            label_Medidas.Visible = false;
            // 
            // button_ModificarAnalito
            // 
            button_ModificarAnalito.BackColor = Color.MidnightBlue;
            button_ModificarAnalito.Enabled = false;
            button_ModificarAnalito.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            button_ModificarAnalito.ForeColor = Color.White;
            button_ModificarAnalito.Location = new Point(30, 543);
            button_ModificarAnalito.Name = "button_ModificarAnalito";
            button_ModificarAnalito.Size = new Size(401, 63);
            button_ModificarAnalito.TabIndex = 24;
            button_ModificarAnalito.Text = "MODIFICAR ANALITO";
            button_ModificarAnalito.UseVisualStyleBackColor = false;
            // 
            // checkBox_VerAnalitos
            // 
            checkBox_VerAnalitos.AutoSize = true;
            checkBox_VerAnalitos.BackColor = Color.Transparent;
            checkBox_VerAnalitos.Font = new Font("Arial", 9F);
            checkBox_VerAnalitos.ForeColor = Color.White;
            checkBox_VerAnalitos.Location = new Point(30, 501);
            checkBox_VerAnalitos.Name = "checkBox_VerAnalitos";
            checkBox_VerAnalitos.Size = new Size(107, 31);
            checkBox_VerAnalitos.TabIndex = 27;
            checkBox_VerAnalitos.Text = "Activo";
            checkBox_VerAnalitos.UseVisualStyleBackColor = false;
            // 
            // dataGridView_VerAnalitos
            // 
            dataGridView_VerAnalitos.AllowUserToAddRows = false;
            dataGridView_VerAnalitos.AllowUserToDeleteRows = false;
            dataGridView_VerAnalitos.BackgroundColor = Color.White;
            dataGridView_VerAnalitos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_VerAnalitos.Location = new Point(30, 34);
            dataGridView_VerAnalitos.Name = "dataGridView_VerAnalitos";
            dataGridView_VerAnalitos.ReadOnly = true;
            dataGridView_VerAnalitos.RowHeadersWidth = 82;
            dataGridView_VerAnalitos.Size = new Size(1156, 572);
            dataGridView_VerAnalitos.TabIndex = 0;
            // 
            // tabControlEstudio
            // 
            tabControlEstudio.Controls.Add(tabPage_Analitos);
            tabControlEstudio.Controls.Add(tabPage_AgregarAnalitos);
            tabControlEstudio.Controls.Add(tabPageModificar);
            tabControlEstudio.Enabled = false;
            tabControlEstudio.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlEstudio.Location = new Point(340, 527);
            tabControlEstudio.Name = "tabControlEstudio";
            tabControlEstudio.SelectedIndex = 0;
            tabControlEstudio.Size = new Size(1235, 684);
            tabControlEstudio.TabIndex = 22;
            // 
            // textBox_NombreEstudio
            // 
            textBox_NombreEstudio.Enabled = false;
            textBox_NombreEstudio.Location = new Point(340, 395);
            textBox_NombreEstudio.Multiline = true;
            textBox_NombreEstudio.Name = "textBox_NombreEstudio";
            textBox_NombreEstudio.Size = new Size(1227, 57);
            textBox_NombreEstudio.TabIndex = 18;
            // 
            // FormEstudio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1819, 1292);
            Controls.Add(checkBox_EstudioActivo);
            Controls.Add(groupBox);
            Controls.Add(tabControlEstudio);
            Controls.Add(label_NombreEstudio);
            Controls.Add(label_IdEstudio);
            Controls.Add(textBox_NombreEstudio);
            Controls.Add(textBox_IdEstudio);
            Controls.Add(panelBuscar);
            Controls.Add(panelDeco);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEstudio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar estudio";
            FormClosing += FormEstudio_FormClosing;
            panelDeco.ResumeLayout(false);
            panelDeco.PerformLayout();
            panelBuscar.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            tabPageModificar.ResumeLayout(false);
            tabPageModificar.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabPage_AgregarAnalitos.ResumeLayout(false);
            tabPage_AgregarAnalitos.PerformLayout();
            groupBox1.ResumeLayout(false);
            tabPage_Analitos.ResumeLayout(false);
            tabPage_Analitos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_VerAnalitos).EndInit();
            tabControlEstudio.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAgregar;
        private Button buttonCerrarInformes;
        private Panel panelDeco;
        private Panel panelBuscar;
        private ComboBox comboBoxSelectInformes;
        private Button buttonModificar;
        private GroupBox groupBox;
        private TextBox textBox_IdEstudio;
        private Label label_IdEstudio;
        private Label label_NombreEstudio;
        private CheckBox checkBox_EstudioActivo;
        private TabPage tabPageModificar;
        private Label label7;
        private CheckBox checkBox_ModificarAnalito;
        private TextBox textBox7;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label4;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label5;
        private TabPage tabPage_AgregarAnalitos;
        private CheckBox checkBox_AgregarAnalito;
        private GroupBox groupBox1;
        private Button buttonAceptar;
        private Button buttonCancelar;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TabPage tabPage_Analitos;
        private DataGridView dataGridView_VerAnalitos;
        private CheckBox checkBox_VerAnalitos;
        private Button button_ModificarAnalito;
        private Label label_Medidas;
        private TextBox textBox_Medidas;
        private TextBox textBox_Referencias;
        private TextBox textBox_IdAnalito;
        private TextBox textBox_NombreAnalito;
        private Label label_Referencias;
        private Label label_NombreAnalito;
        private Label label_IdAnalito;
        private TabControl tabControlEstudio;
        private TextBox textBox_NombreEstudio;
        private CheckBox checkBox_InformeActivo;
    }
}