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
            textBox_IdTutor.Clear();
            textBox_NombreTutor.Clear();
            textBox_Telefono.Clear();
            textBox_Mail.Clear();
            checkBox_TutorActivo.Checked = true;

            textBox_IdTutor.Enabled = false;
            textBox_NombreTutor.Enabled = false;
            textBox_Telefono.Enabled = false;
            textBox_Mail.Enabled = false;
            checkBox_TutorActivo.Enabled = false;

            groupBoxAcepCan.Visible = false;

            groupBoxAcciones.Enabled = true;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            textBox_IdTutor.Enabled = false;
            textBox_NombreTutor.Enabled = true;
            textBox_Telefono.Enabled = true;
            textBox_Mail.Enabled = true;
            checkBox_TutorActivo.Enabled = true;

            // mostrar campos
            label_IdTutor.Visible = true;
            textBox_IdTutor.Visible = true;
            label_NombreTutor.Visible = true;
            textBox_NombreTutor.Visible = true;
            label_Telefono.Visible = true;
            textBox_Telefono.Visible = true;
            label_Mail.Visible = true;
            textBox_Mail.Visible = true;
            checkBox_TutorActivo.Visible = true;

            // mostrar aceptar/cancelar
            groupBoxAcepCan.Visible = true;
            groupBoxAcepCan.Enabled = true;

            // limpiar y enfocar
            textBox_IdTutor.Clear();
            textBox_NombreTutor.Clear();
            textBox_Telefono.Clear();
            textBox_Mail.Clear();
            checkBox_TutorActivo.Checked = true;
            textBox_NombreTutor.Focus();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (groupBoxAcciones.Text == "AGREGAR")
            {
                if (!camposVacios()) return;

                Tutores objeto = new Tutores();
                objeto.Nombre = textBox_NombreTutor.Text;
                objeto.Telefono = textBox_Telefono.Text;
                objeto.Mail = textBox_Mail.Text;
                objeto.Activo = checkBox_TutorActivo.Checked;

                if (TutoresLogico.Instancia.Guardar(objeto))
                {
                    groupBoxAcepCan.Visible = false;
                    groupBoxAcepCan.Enabled = false;
                    groupBoxAcciones.Visible = true;
                    groupBoxAcciones.Enabled = true;
                }
            }

        }

        private bool camposVacios()
        {
            if (textBox_NombreTutor.Text == "" ||
                textBox_Telefono.Text == "" ||
                textBox_Mail.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
    }
}
