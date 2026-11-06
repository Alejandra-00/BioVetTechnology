using System;
using System.Drawing;
using System;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BioVet_Technology
{
    public partial class FormEstudio : Form
    {
        public FormEstudio()
        {
            InitializeComponent();
            // Centra esta ventana tomando como referencia el formulario que la invocó
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEstudio_FormClosing(object sender, FormClosingEventArgs e)
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}