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
            flowLayoutPanelAcciones = new FlowLayoutPanel();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonBuscar = new Button();
            buttonCerrar = new Button();
            panelDeco = new Panel();
            dataGridViewEstudio = new DataGridView();
            textBoxBuscar = new TextBox();
            panelBuscar = new Panel();
            panelViewEstudio = new Panel();
            flowLayoutPanelAcepCan = new FlowLayoutPanel();
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            flowLayoutPanelAcciones.SuspendLayout();
            panelDeco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstudio).BeginInit();
            panelBuscar.SuspendLayout();
            panelViewEstudio.SuspendLayout();
            flowLayoutPanelAcepCan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelAcciones
            // 
            flowLayoutPanelAcciones.Controls.Add(buttonAgregar);
            flowLayoutPanelAcciones.Controls.Add(buttonModificar);
            flowLayoutPanelAcciones.Location = new Point(216, 941);
            flowLayoutPanelAcciones.Name = "flowLayoutPanelAcciones";
            flowLayoutPanelAcciones.Size = new Size(470, 66);
            flowLayoutPanelAcciones.TabIndex = 8;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Anchor = AnchorStyles.Top;
            buttonAgregar.BackColor = Color.MidnightBlue;
            buttonAgregar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(3, 3);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(218, 58);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "AGREGAR";
            buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.MidnightBlue;
            buttonModificar.Dock = DockStyle.Right;
            buttonModificar.Enabled = false;
            buttonModificar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonModificar.ForeColor = Color.White;
            buttonModificar.Location = new Point(227, 3);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(238, 58);
            buttonModificar.TabIndex = 1;
            buttonModificar.Text = "MODIFICAR";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Visible = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top;
            buttonBuscar.BackColor = Color.MidnightBlue;
            buttonBuscar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(1484, 13);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(242, 69);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "BUSCAR";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrar.AutoSize = true;
            buttonCerrar.BackColor = Color.Transparent;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCerrar.ForeColor = Color.White;
            buttonCerrar.Location = new Point(1749, 11);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(57, 58);
            buttonCerrar.TabIndex = 11;
            buttonCerrar.Text = "X";
            buttonCerrar.UseVisualStyleBackColor = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // panelDeco
            // 
            panelDeco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDeco.BackColor = Color.MidnightBlue;
            panelDeco.Controls.Add(buttonCerrar);
            panelDeco.Location = new Point(1, 1);
            panelDeco.Name = "panelDeco";
            panelDeco.Size = new Size(1817, 78);
            panelDeco.TabIndex = 12;
            // 
            // dataGridViewEstudio
            // 
            dataGridViewEstudio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEstudio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstudio.Location = new Point(17, 21);
            dataGridViewEstudio.Name = "dataGridViewEstudio";
            dataGridViewEstudio.RowHeadersWidth = 82;
            dataGridViewEstudio.Size = new Size(860, 604);
            dataGridViewEstudio.TabIndex = 13;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscar.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBuscar.Location = new Point(89, 13);
            textBoxBuscar.Multiline = true;
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Buscar por nombre";
            textBoxBuscar.RightToLeft = RightToLeft.No;
            textBoxBuscar.Size = new Size(1389, 69);
            textBoxBuscar.TabIndex = 9;
            // 
            // panelBuscar
            // 
            panelBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBuscar.Controls.Add(buttonBuscar);
            panelBuscar.Controls.Add(textBoxBuscar);
            panelBuscar.Location = new Point(1, 130);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1817, 95);
            panelBuscar.TabIndex = 14;
            // 
            // panelViewEstudio
            // 
            panelViewEstudio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelViewEstudio.Controls.Add(dataGridViewEstudio);
            panelViewEstudio.Location = new Point(12, 295);
            panelViewEstudio.Name = "panelViewEstudio";
            panelViewEstudio.Size = new Size(896, 640);
            panelViewEstudio.TabIndex = 15;
            // 
            // flowLayoutPanelAcepCan
            // 
            flowLayoutPanelAcepCan.Controls.Add(buttonAceptar);
            flowLayoutPanelAcepCan.Controls.Add(buttonCancelar);
            flowLayoutPanelAcepCan.Enabled = false;
            flowLayoutPanelAcepCan.Location = new Point(1150, 941);
            flowLayoutPanelAcepCan.Name = "flowLayoutPanelAcepCan";
            flowLayoutPanelAcepCan.Size = new Size(490, 67);
            flowLayoutPanelAcepCan.TabIndex = 16;
            flowLayoutPanelAcepCan.Visible = false;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.Top;
            buttonAceptar.BackColor = Color.MidnightBlue;
            buttonAceptar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonAceptar.ForeColor = Color.White;
            buttonAceptar.Location = new Point(3, 3);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(242, 58);
            buttonAceptar.TabIndex = 17;
            buttonAceptar.Text = "ACEPTAR";
            buttonAceptar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top;
            buttonCancelar.BackColor = Color.MidnightBlue;
            buttonCancelar.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(251, 3);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(236, 58);
            buttonCancelar.TabIndex = 17;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(1040, 354);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(551, 58);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1040, 460);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(551, 57);
            textBox2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(1043, 319);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 19;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1043, 425);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(959, 620);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(798, 300);
            dataGridView1.TabIndex = 21;
            // 
            // FormEstudio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1819, 1292);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(flowLayoutPanelAcepCan);
            Controls.Add(panelViewEstudio);
            Controls.Add(panelBuscar);
            Controls.Add(panelDeco);
            Controls.Add(flowLayoutPanelAcciones);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEstudio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar estudio";
            FormClosing += FormEstudio_FormClosing;
            flowLayoutPanelAcciones.ResumeLayout(false);
            panelDeco.ResumeLayout(false);
            panelDeco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstudio).EndInit();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            panelViewEstudio.ResumeLayout(false);
            flowLayoutPanelAcepCan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelAcciones;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonBuscar;
        private Button buttonCerrar;
        private Panel panelDeco;
        private DataGridView dataGridViewEstudio;
        private TextBox textBoxBuscar;
        private Panel panelBuscar;
        private Panel panelViewEstudio;
        private FlowLayoutPanel flowLayoutPanelAcepCan;
        private Button buttonAceptar;
        private Button buttonCancelar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}