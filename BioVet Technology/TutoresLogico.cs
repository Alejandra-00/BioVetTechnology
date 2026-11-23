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
            return respuesta;
        }

    }
}
