using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace BioVet_Technology
{
    public class TutoresLogico
    {
        private string Cadena => ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static TutoresLogico _instancia = null;

        public static TutoresLogico Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new TutoresLogico();
                }
                return _instancia;
            }
        }
        public bool Guardar(Tutores obj)
        {
            bool respuesta = true;

            using (SqliteConnection conexion = new SqliteConnection(Cadena)) // creo un objeto de conexion para la base de datos , usando la cadena de conexion que esta en el archivo App.config
            {
                conexion.Open();
                string query = "INSERT INTO Tutor (nombre, telefono, mail, activo) VALUES (@nombre, @telefono, @mail, @activo)";
                SqliteCommand cmd = new SqliteCommand(query, conexion);
                cmd.Parameters.Add(new SqliteParameter("@nombre", obj.Nombre.ToUpper())); // toUpper convierte el texto a mayúsculas para mantener consistencia en la base de datos
                cmd.Parameters.Add(new SqliteParameter("@telefono", obj.Telefono));
                cmd.Parameters.Add(new SqliteParameter("@mail", obj.Mail));
                cmd.Parameters.Add(new SqliteParameter("@activo", obj.Activo));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

    }
}
