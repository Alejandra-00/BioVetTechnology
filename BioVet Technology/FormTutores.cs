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

        public FormTutores(string apartado)
        {
            InitializeComponent();
            labelApartado.Text = apartado; // o label_Titulo.Text = titulo;
        }

        private void cargarDatosTutor(Tutores tutor)
        {
            textBox_IdTutor.Text = tutor.Id.ToString();
            textBox_NombreTutor.Text = tutor.Nombre;
            textBox_Telefono.Text = tutor.Telefono;
            textBox_Mail.Text = tutor.Mail;
            checkBox_TutorActivo.Checked = tutor.Activo == "1";
        }

        private void mostrar(Control control, bool mostrar)
        {
            control.Visible = mostrar;
        }

        private void activar(Control control, bool activar)
        {
            control.Enabled = activar;
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

        private void FormTutores_Activated(object sender, EventArgs e)
        {
            listBox_SelectTutores.Items.Clear();

            List<Tutores> resultados = Tutores.Buscar(textBox_BuscarTutor.Text);

            foreach (Tutores tutor in resultados)
            {
                listBox_SelectTutores.Items.Add(tutor);
            }

            // Si hay texto escrito y encontró coincidencias, marca automáticamente el primero (el más cercano)
            if (!string.IsNullOrWhiteSpace(textBox_BuscarTutor.Text) && listBox_SelectTutores.Items.Count > 0)
            {
                listBox_SelectTutores.SelectedIndex = 0;
            }

            textBox_BuscarTutor.Focus();
        }

        private void textBox_BuscarTutor_TextChanged(object sender, EventArgs e)
        {
            listBox_SelectTutores.Items.Clear();

            // Si el TextBox está vacío, ocultamos la lista y salimos.
            if (string.IsNullOrWhiteSpace(textBox_BuscarTutor.Text))
            {
                mostrar(listBox_SelectTutores, false);
            }

            List<Tutores> resultados = Tutores.Buscar(textBox_BuscarTutor.Text);

            // Si hay coincidencias, llenamos el listbox, y se marca el primero, o sea, el que mejor coincide.
            if (resultados.Count > 0)
            {
                listBox_SelectTutores.Items.AddRange(resultados.ToArray());
                mostrar(listBox_SelectTutores, true);
                
                listBox_SelectTutores.BringToFront();
                listBox_SelectTutores.SelectedIndex = 0;
            }
            else
            {
                mostrar(listBox_SelectTutores, false); // Si no escribió nada o borró, se oculta.
            }
        }

        private void textBox_BuscarTutor_KeyDown(object sender, KeyEventArgs e)
        {
            //Si la tecla presionada es Enter y el elemento seleccionado es un Tutor se crea la variable.
            if (e.KeyCode == Keys.Enter && listBox_SelectTutores.SelectedItem is Tutores tutorSeleccionado)
            {
                e.SuppressKeyPress = true;
                if (textBox_BuscarTutor.Text.Trim() == tutorSeleccionado.Mail)
                {
                    mostrar(listBox_SelectTutores, false);
                    mostrar(panelDetallesTutor, true);
                    
                    cargarDatosTutor(tutorSeleccionado);
                    mostrar(buttonModificar, true);
                    activar(buttonModificar, true);
                }
                else
                {
                    textBox_BuscarTutor.Text = tutorSeleccionado.Mail; //En el textbox se guarda el correo del tutor seleccionado.
                    textBox_BuscarTutor.Select(textBox_BuscarTutor.Text.Length, 0); //El cursor se posiciona al final de la cadena.
                }
            }
            //Pregunta si la tecla fue una de las flechas para subir o bajar y si hay items en el listbox.
            else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.Up) && listBox_SelectTutores.Items.Count > 0)
            {
                e.SuppressKeyPress = true;

                //Calcula el indice, si sube, resta 1, si baja, suma 1.
                int nuevoIndice = listBox_SelectTutores.SelectedIndex + (e.KeyCode == Keys.Down ? 1 : -1);

                //Pregunta si el nuevo indice es mayor o igual a 0 y si es menor a la cantidad de items.
                if (nuevoIndice >= 0 && nuevoIndice < listBox_SelectTutores.Items.Count)
                    listBox_SelectTutores.SelectedIndex = nuevoIndice;
            }
        }
    }
}
