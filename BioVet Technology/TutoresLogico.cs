using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;

namespace BioVet_Technology
{
    public partial class Tutores
    {
        private static void LlenarDiccionario()
        {
            if (diccionario == null)
                diccionario = new Dictionary<int, Tutores>();

            diccionario.Clear();

            DataTable res = TraerTodos();

            foreach(DataRow fila in res.Rows)
            {
                Tutores helper = new Tutores();
                helper.id = Convert.ToInt32(fila["id_tutor"].ToString());
                helper.Nombre = Convert.ToString(fila["nombre"]);
                helper.Telefono = Convert.ToString(fila["telefono"]);
                helper.Mail = Convert.ToString(fila["mail"]);
                helper.Activo = Convert.ToString(fila["activo"]);

                diccionario.Add(helper.id, helper);
            }
        }

        private static DataTable TraerTodos()
        {
            // Trae todos los registros de la base de datos y los ordena alfabeticamente
            string consulta = "SELECT * FROM Tutor ORDER BY mail ASC";

            return GestorConexion.ConsultarBD(consulta, null);
        }
    }
}