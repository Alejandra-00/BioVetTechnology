using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BioVet_Technology
{
    public partial class Tutores
    {
        private int id;
        public int Id { get{ return id; } } //Impedimos que cambien el valor del id desde afuera, solo leemos el valor de la base de datos
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Activo { get; set; }

        public override string ToString()
        {
            return $"{Mail}"; // Formato que se muestra en el ListBox
        }

        private static Dictionary<int, Tutores> diccionario;
        public static Dictionary<int, Tutores> Diccionario
        {
            get
            {
                if (diccionario == null)
                {
                    LlenarDiccionario();
                }
                return diccionario;
            }
        }

        public static List<Tutores> Buscar(string texto)
        {
            List<Tutores> coincide = new List<Tutores>();
            List<Tutores> NoCoincide = new List<Tutores>();

            string filtrar = texto;

            foreach (Tutores tutor in Diccionario.Values)
            {
                if (string.IsNullOrEmpty(filtrar))
                {
                    coincide.Add(tutor);
                }
                else
                {
                    string mail = tutor.Mail.ToString();

                    if (mail.StartsWith(filtrar))
                    {
                        coincide.Add(tutor);
                    }
                    else if (mail.Contains(filtrar))
                    {
                        NoCoincide.Add(tutor);
                    }
                }
            }

            coincide.AddRange(NoCoincide);
            return coincide;
        }
    }
}