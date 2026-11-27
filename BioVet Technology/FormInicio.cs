using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BioVet_Technology
{
    public partial class FormInicio : System.Windows.Forms.Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            CentrarYSepararItemsMenu();

            //Recorre todos los controles hijos del formulario, inclusive el MdiClient.
            foreach (Control ctrl in this.Controls)
            {
                //Pregunta si alguno de los controles es el MdiClient e instancia un objeto de ese tipo
                if (ctrl is MdiClient clienteMdi)
                {
                    // Copia el color de fondo del FormInicio
                    clienteMdi.BackColor = this.BackColor;
                }
            }
        }

        private void FormInicio_Resize(object sender, EventArgs e)
        {
            // Recalcular posiciones cada vez que cambie el tamaño de la ventana
            CentrarYSepararItemsMenu();
        }

        private void CentrarYSepararItemsMenu()
        {
            // Sincronizar la altura del control con el área cliente del formulario
            menuInicio.Height = this.ClientSize.Height;

            int cantidadItems = menuInicio.Items.Count;
            if (cantidadItems == 0) return;

            // Calcular la altura pura de todos los elementos sin contar márgenes
            int altoPuroItems = 0;
            foreach (ToolStripItem item in menuInicio.Items)
            {
                altoPuroItems += item.Height;
            }

            // Obtener el espacio vertical que nos sobra en la pantalla
            int espacioLibre = menuInicio.Height - altoPuroItems;

            if (espacioLibre > 0)
            {
                // Dividimos el espacio libre para crear separaciones equitativas.
                // Usamos (cantidadItems + 1) para que quede espacio libre arriba, 
                // abajo y entremedio de cada botón como si fuera un layout flotante.
                int separacionEstiloGrip = espacioLibre / (cantidadItems + 1);

                // Aplicar la separación a cada ítem individualmente
                for (int i = 0; i < cantidadItems; i++)
                {
                    ToolStripItem item = menuInicio.Items[i];

                    // Forzar a que el texto se alinee al centro de su propio botón
                    item.TextAlign = ContentAlignment.MiddleCenter;

                    // Asignamos el espacio calculado como margen superior
                    item.Margin = new Padding(item.Margin.Left, separacionEstiloGrip, item.Margin.Right, 0);
                }
            }
        }

        private void administrarEstudiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstudio estudio = new FormEstudio();

            estudio.ShowDialog(this);
        }

        private void administrarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPacientes paciente = new FormPacientes();

            paciente.ShowDialog(this);
        }

        private void administrarTutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreApartado = ((ToolStripMenuItem)sender).Text;
            FormTutores tutor = new FormTutores(nombreApartado);

            tutor.ShowDialog(this);
        }

        private void administrarVeterinariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVeterinarios veterinario = new FormVeterinarios();

            veterinario.ShowDialog(this);
        }

        private void administrarInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformes informe = new FormInformes();

            informe.ShowDialog(this);
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIngresar_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evalúa si el intento de cierre fue iniciado directamente por el usuario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Despliega una ventana emergente de confirmación con botones 'Sí' y 'No' e icono de pregunta.
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea salir?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario selecciona "No", cancela el evento de cierre dejando el formulario abierto.
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true; // Cancela el cierre si elige "No"
                }
            }

        }
    }
}
