namespace BioVet_Technology
{
    partial class FormIngresar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresar));
            menuInicio = new MenuStrip();
            cargarEstudioToolStripMenuItem = new ToolStripMenuItem();
            administrarEstudiosToolStripMenuItem = new ToolStripMenuItem();
            cargarPacienteToolStripMenuItem = new ToolStripMenuItem();
            administrarPacientesToolStripMenuItem = new ToolStripMenuItem();
            cargarTutorToolStripMenuItem = new ToolStripMenuItem();
            administrarTutoresToolStripMenuItem = new ToolStripMenuItem();
            cargarToolStripMenuItem = new ToolStripMenuItem();
            administrarVeterinariosToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            administrarInformesToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            pictureLaboratorio = new PictureBox();
            menuInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLaboratorio).BeginInit();
            SuspendLayout();
            // 
            // menuInicio
            // 
            menuInicio.AutoSize = false;
            menuInicio.BackColor = Color.MidnightBlue;
            menuInicio.Dock = DockStyle.Left;
            menuInicio.ImageScalingSize = new Size(32, 32);
            menuInicio.Items.AddRange(new ToolStripItem[] { cargarEstudioToolStripMenuItem, cargarPacienteToolStripMenuItem, cargarTutorToolStripMenuItem, cargarToolStripMenuItem, informesToolStripMenuItem, cerrarToolStripMenuItem });
            menuInicio.Location = new Point(0, 0);
            menuInicio.Name = "menuInicio";
            menuInicio.RenderMode = ToolStripRenderMode.System;
            menuInicio.Size = new Size(301, 1093);
            menuInicio.Stretch = false;
            menuInicio.TabIndex = 3;
            menuInicio.Text = "menuStrip1";
            menuInicio.UseWaitCursor = true;
            // 
            // cargarEstudioToolStripMenuItem
            // 
            cargarEstudioToolStripMenuItem.BackColor = Color.Transparent;
            cargarEstudioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarEstudiosToolStripMenuItem });
            cargarEstudioToolStripMenuItem.Font = new Font("Verdana", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cargarEstudioToolStripMenuItem.ForeColor = Color.White;
            cargarEstudioToolStripMenuItem.Name = "cargarEstudioToolStripMenuItem";
            cargarEstudioToolStripMenuItem.RightToLeft = RightToLeft.No;
            cargarEstudioToolStripMenuItem.Size = new Size(294, 49);
            cargarEstudioToolStripMenuItem.Text = "Estudios";
            cargarEstudioToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // administrarEstudiosToolStripMenuItem
            // 
            administrarEstudiosToolStripMenuItem.Name = "administrarEstudiosToolStripMenuItem";
            administrarEstudiosToolStripMenuItem.Size = new Size(572, 54);
            administrarEstudiosToolStripMenuItem.Text = "Administrar estudio";
            administrarEstudiosToolStripMenuItem.Click += administrarEstudiosToolStripMenuItem_Click;
            // 
            // cargarPacienteToolStripMenuItem
            // 
            cargarPacienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarPacientesToolStripMenuItem });
            cargarPacienteToolStripMenuItem.Font = new Font("Verdana", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cargarPacienteToolStripMenuItem.ForeColor = Color.White;
            cargarPacienteToolStripMenuItem.Margin = new Padding(0, 80, 0, 0);
            cargarPacienteToolStripMenuItem.Name = "cargarPacienteToolStripMenuItem";
            cargarPacienteToolStripMenuItem.RightToLeft = RightToLeft.No;
            cargarPacienteToolStripMenuItem.Size = new Size(294, 49);
            cargarPacienteToolStripMenuItem.Text = "Pacientes";
            cargarPacienteToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // administrarPacientesToolStripMenuItem
            // 
            administrarPacientesToolStripMenuItem.Name = "administrarPacientesToolStripMenuItem";
            administrarPacientesToolStripMenuItem.Size = new Size(619, 54);
            administrarPacientesToolStripMenuItem.Text = "Administrar pacientes";
            administrarPacientesToolStripMenuItem.Click += administrarPacientesToolStripMenuItem_Click;
            // 
            // cargarTutorToolStripMenuItem
            // 
            cargarTutorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarTutoresToolStripMenuItem });
            cargarTutorToolStripMenuItem.Font = new Font("Verdana", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cargarTutorToolStripMenuItem.ForeColor = Color.White;
            cargarTutorToolStripMenuItem.Margin = new Padding(0, 80, 0, 0);
            cargarTutorToolStripMenuItem.Name = "cargarTutorToolStripMenuItem";
            cargarTutorToolStripMenuItem.RightToLeft = RightToLeft.No;
            cargarTutorToolStripMenuItem.Size = new Size(294, 49);
            cargarTutorToolStripMenuItem.Text = "Tutores";
            cargarTutorToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // administrarTutoresToolStripMenuItem
            // 
            administrarTutoresToolStripMenuItem.Name = "administrarTutoresToolStripMenuItem";
            administrarTutoresToolStripMenuItem.Size = new Size(568, 54);
            administrarTutoresToolStripMenuItem.Text = "Administrar tutores";
            administrarTutoresToolStripMenuItem.Click += administrarTutoresToolStripMenuItem_Click;
            // 
            // cargarToolStripMenuItem
            // 
            cargarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarVeterinariosToolStripMenuItem });
            cargarToolStripMenuItem.Font = new Font("Verdana", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cargarToolStripMenuItem.ForeColor = Color.White;
            cargarToolStripMenuItem.Margin = new Padding(0, 80, 0, 0);
            cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            cargarToolStripMenuItem.RightToLeft = RightToLeft.No;
            cargarToolStripMenuItem.Size = new Size(294, 49);
            cargarToolStripMenuItem.Text = "Veterinarios";
            cargarToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // administrarVeterinariosToolStripMenuItem
            // 
            administrarVeterinariosToolStripMenuItem.Name = "administrarVeterinariosToolStripMenuItem";
            administrarVeterinariosToolStripMenuItem.Size = new Size(669, 54);
            administrarVeterinariosToolStripMenuItem.Text = "Administrar veterinarios";
            administrarVeterinariosToolStripMenuItem.Click += administrarVeterinariosToolStripMenuItem_Click;
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarInformesToolStripMenuItem });
            informesToolStripMenuItem.Font = new Font("Verdana", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            informesToolStripMenuItem.ForeColor = Color.White;
            informesToolStripMenuItem.Margin = new Padding(0, 80, 0, 0);
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.RightToLeft = RightToLeft.No;
            informesToolStripMenuItem.Size = new Size(294, 49);
            informesToolStripMenuItem.Text = "Informes";
            informesToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // administrarInformesToolStripMenuItem
            // 
            administrarInformesToolStripMenuItem.Name = "administrarInformesToolStripMenuItem";
            administrarInformesToolStripMenuItem.Size = new Size(602, 54);
            administrarInformesToolStripMenuItem.Text = "Administrar informes";
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Font = new Font("Verdana", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cerrarToolStripMenuItem.ForeColor = Color.White;
            cerrarToolStripMenuItem.Margin = new Padding(0, 80, 0, 0);
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.RightToLeft = RightToLeft.No;
            cerrarToolStripMenuItem.Size = new Size(294, 49);
            cerrarToolStripMenuItem.Text = "Cerrar";
            cerrarToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            cerrarToolStripMenuItem.Click += cerrarToolStripMenuItem_Click;
            // 
            // pictureLaboratorio
            // 
            pictureLaboratorio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureLaboratorio.Image = (Image)resources.GetObject("pictureLaboratorio.Image");
            pictureLaboratorio.Location = new Point(1168, 823);
            pictureLaboratorio.Name = "pictureLaboratorio";
            pictureLaboratorio.Size = new Size(277, 258);
            pictureLaboratorio.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLaboratorio.TabIndex = 2;
            pictureLaboratorio.TabStop = false;
            // 
            // FormIngresar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1457, 1093);
            Controls.Add(pictureLaboratorio);
            Controls.Add(menuInicio);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuInicio;
            MinimizeBox = false;
            Name = "FormIngresar";
            Text = "Ingresar";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormIngresar_FormClosing;
            Load += FormIngresar_Load;
            Resize += FormIngresar_Resize;
            menuInicio.ResumeLayout(false);
            menuInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLaboratorio).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuInicio;
        private ToolStripMenuItem cargarEstudioToolStripMenuItem;
        private ToolStripMenuItem cargarPacienteToolStripMenuItem;
        private ToolStripMenuItem cargarTutorToolStripMenuItem;
        private ToolStripMenuItem administrarEstudiosToolStripMenuItem;
        private ToolStripMenuItem cargarToolStripMenuItem;
        private ToolStripMenuItem administrarPacientesToolStripMenuItem;
        private ToolStripMenuItem administrarTutoresToolStripMenuItem;
        private ToolStripMenuItem administrarVeterinariosToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem administrarInformesToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private PictureBox pictureLaboratorio;
    }
}