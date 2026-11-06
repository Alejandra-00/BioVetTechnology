using System.Windows.Forms;

namespace BioVet_Technology
{
    public static class Navegacion
    {
        public static void Abrir(Form nuevoFormulario, Form padre)
        {
            if (padre != null)
            {
                // Al pasar 'padre', CenterParent ubica el formulario centrado sobre él
                nuevoFormulario.ShowDialog(padre);
            }
            else
            {
                nuevoFormulario.ShowDialog();
            }
        }
    }
}