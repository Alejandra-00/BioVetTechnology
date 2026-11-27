using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BioVet_Technology
{
    public partial class FormTutores : Form
    {
        public FormTutores()
        {
            InitializeComponent();
            // Centra esta ventana tomando como referencia el formulario que la invocó
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCerrarTutores_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTutores_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormTutores_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void EstadoInicial()
        {
            textBox_IdTutor.Clear(); // Limpia el contenido de los campos de texto y restablece el estado inicial del formulario
            textBox_NombreTutor.Clear();
            textBox_Telefono.Clear();
            textBox_Mail.Clear();
            checkBox_TutorActivo.Checked = true; // Marca el checkbox como activo por defecto


            textBox_IdTutor.Enabled = false;
            textBox_NombreTutor.Enabled = false;
            textBox_Telefono.Enabled = false;
            textBox_Mail.Enabled = false;
            checkBox_TutorActivo.Enabled = false;

            label_IdTutor.Visible = false;
            textBox_IdTutor.Visible = false;
            label_NombreTutor.Visible = false;
            textBox_NombreTutor.Visible = false;
            label_Telefono.Visible = false;
            textBox_Telefono.Visible = false;
            label_Mail.Visible = false;
            textBox_Mail.Visible = false;
            checkBox_TutorActivo.Visible = false;

            groupBoxAcepCan.Visible = false;
            groupBoxAcciones.Enabled = true;
            groupBoxAcciones.Visible = true;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            textBox_IdTutor.Enabled = false;
            groupBoxAcepCan.Text = "AGREGAR";
            textBox_NombreTutor.Enabled = true;
            textBox_Telefono.Enabled = true;
            textBox_Mail.Enabled = true;
            checkBox_TutorActivo.Enabled = true;

            //campos visibles
            groupBoxAcciones.Visible = false;
            label_IdTutor.Visible = true;
            textBox_IdTutor.Visible = true;
            label_NombreTutor.Visible = true;
            textBox_NombreTutor.Visible = true;
            label_Telefono.Visible = true;
            textBox_Telefono.Visible = true;
            label_Mail.Visible = true;
            textBox_Mail.Visible = true;
            checkBox_TutorActivo.Visible = false;

            // mostrar aceptar/cancelar
            groupBoxAcepCan.Visible = true;
            groupBoxAcepCan.Enabled = true;

            // limpiar campos si es que se vuelve a agregar un nuevo registro
            textBox_IdTutor.Clear();
            textBox_NombreTutor.Clear();
            textBox_Telefono.Clear();
            textBox_Mail.Clear();
            checkBox_TutorActivo.Checked = true;
            textBox_NombreTutor.Focus();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (groupBoxAcepCan.Text == "AGREGAR")
            {
                if (!camposVacios()) return; // Si hay campos vacíos, se detiene la ejecución del método y no se guarda el registro

                Tutores objeto = new Tutores();
                objeto.Nombre = textBox_NombreTutor.Text;
                objeto.Telefono = textBox_Telefono.Text;
                objeto.Mail = textBox_Mail.Text;
                objeto.Activo = checkBox_TutorActivo.Checked;

                if (TutoresLogico.Instancia.Guardar(objeto))
                {
                    EstadoInicial();
                }
            }

        }

        private bool camposVacios()
        {
            if (string.IsNullOrWhiteSpace(textBox_NombreTutor.Text) ||
               string.IsNullOrWhiteSpace(textBox_Telefono.Text) ||
               string.IsNullOrWhiteSpace(textBox_Mail.Text))
            {
                MessageBox.Show("Rellená todos los campos, son obligatorios.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_NombreTutor.Focus();
                return false;
            }
            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar)) // Permitir solo dígitos, teclas de control y espacios
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
