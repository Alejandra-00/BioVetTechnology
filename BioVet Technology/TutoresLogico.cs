using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace BioVet_Technology
{
    public partial class Tutores
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString; 
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

        public static bool Guardar(Tutores obj)
        {
            bool respuesta = true;

            using (SqliteConnection conexion = new SqliteConnection(Cadena)) 
            {
                conexion.Open();
                string query = "INSERT INTO Tutor (nombre, telefono, mail, activo) VALUES (@nombre, @telefono, @mail, @activo)";
                SqliteCommand cmd = new SqliteCommand(query, conexion);
                cmd.Parameters.Add(new SqliteParameter("@nombre", obj.Nombre.ToUpper()));
                cmd.Parameters.Add(new SqliteParameter("@telefono", obj.Telefono));
                cmd.Parameters.Add(new SqliteParameter("@mail", obj.Mail));
                cmd.Parameters.Add(new SqliteParameter("@activo", obj.Activo));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            if (respuesta) // Si se guardó correctamente, actualiza el diccionario
            {
                LlenarDiccionario();  // Actualiza el diccionario después de guardar un nuevo registro
            }

            return respuesta;
        }
    }
}