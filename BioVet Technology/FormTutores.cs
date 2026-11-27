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

        private void EstadoInicial()
        {
            textBox_IdTutor.Clear();
            textBox_NombreTutor.Clear();
            textBox_Telefono.Clear();
            textBox_Mail.Clear();
            checkBox_TutorActivo.Checked = true;

            activar(textBox_IdTutor, false);
            activar(textBox_NombreTutor, false);
            activar(textBox_Telefono, false);
            activar(textBox_Mail, false);
            activar(checkBox_TutorActivo, false);

            // Oculta el panel completo de detalles y los botones de Aceptar/Cancelar
            mostrar(panelDetallesTutor, false);
            mostrar(groupBoxAcepCan, false);

            // Muestra las acciones principales y desactiva Modificar
            activar(groupBoxAcciones, true);
            mostrar(groupBoxAcciones, true);
            activar(buttonModificar, false);

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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            groupBoxAcepCan.Text = "AGREGAR";
            activar(textBox_IdTutor, false);
            mostrar(panelDetallesTutor, true);
            activar(panelDetallesTutor, true);
            mostrar(groupBoxAcciones, false);
            mostrar(panelBuscar, false);
            mostrar(textBox_BuscarTutor, false);
            textBox_BuscarTutor.Clear();
            listBox_SelectTutores.Visible = false;
            listBox_SelectTutores.Items.Clear();

            // Muestra aceptar/cancelar
            mostrar(groupBoxAcepCan, true);
            activar(groupBoxAcepCan, true);

            // Limpia campos
            textBox_IdTutor.Clear();
            textBox_NombreTutor.Clear();
            textBox_Telefono.Clear();
            textBox_Mail.Clear();
            checkBox_TutorActivo.Checked = true;
            textBox_NombreTutor.Focus();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_IdTutor.Text))
                return;

            groupBoxAcepCan.Text = "MODIFICAR";
            groupBoxAcciones.Visible = false;
            textBox_BuscarTutor.Visible = false;
            listBox_SelectTutores.Visible = false;

            panelDetallesTutor.Visible = true;
            panelDetallesTutor.Enabled = true;

            textBox_IdTutor.Enabled = false;
            textBox_NombreTutor.Enabled = true;
            textBox_Telefono.Enabled = true;
            textBox_Mail.Enabled = true;
            checkBox_TutorActivo.Enabled = true;

            groupBoxAcepCan.Visible = true;
            groupBoxAcepCan.Enabled = true;

            textBox_NombreTutor.Focus();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (groupBoxAcepCan.Text == "AGREGAR")
            {
                if (!camposVacios()) return; // Si hay campos vacíos, se detiene la ejecución del método y no se guarda el registro

                Tutores objeto = new Tutores(); // Crea una nueva instancia de la clase Tutores para almacenar los datos ingresados por el usuario
                objeto.Nombre = textBox_NombreTutor.Text;  // Asigna el valor del campo de texto al objeto
                objeto.Telefono = textBox_Telefono.Text;
                objeto.Mail = textBox_Mail.Text;
                objeto.Activo = checkBox_TutorActivo.Checked ? "1" : "0"; // Adaptado al formato "1" / "0"

                if (Tutores.Guardar(objeto)) // Llama al método Guardar de la clase Tutores para intentar guardar el objeto
                {
                    EstadoInicial();
                }
            }

            else if (groupBoxAcepCan.Text == "MODIFICAR")
            {
                if (!camposVacios()) return;

                int idTutor = int.Parse(textBox_IdTutor.Text);
                string nombre = textBox_NombreTutor.Text;
                string telefono = textBox_Telefono.Text;
                string mail = textBox_Mail.Text;
                string activo = checkBox_TutorActivo.Checked ? "1" : "0";

                if (Tutores.Modificar(idTutor, nombre, telefono, mail, activo))
                {
                    EstadoInicial();
                }
            }
        }

        private bool camposVacios()
        {
            if (string.IsNullOrWhiteSpace(textBox_NombreTutor.Text) ||  // Verifica si los campos de texto están vacíos o contienen solo espacios en blanco
               string.IsNullOrWhiteSpace(textBox_Telefono.Text) ||
               string.IsNullOrWhiteSpace(textBox_Mail.Text))
            {
                MessageBox.Show("Rellená todos los campos, son obligatorios.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_NombreTutor.Focus();
                return false;
            }

            if (textBox_Telefono.Text.Length < 11) // Verifica que el teléfono tenga los 10 dígitos más el espacio (ej: 2262 667587)
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos (ej: 2262 667587).",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Telefono.Focus();
                return false;
            }

            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }
    }
}
