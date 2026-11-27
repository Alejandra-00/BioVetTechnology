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

        public static bool Guardar(Tutores obj)
        {
            string consulta = "INSERT INTO Tutor (nombre, telefono, mail, activo) VALUES (@nombre, @telefono, @mail, @activo)";

            List<SqliteParameter> parametros = new List<SqliteParameter>
            {
                new SqliteParameter("@nombre", obj.Nombre.ToUpper()),
                new SqliteParameter("@telefono", obj.Telefono),
                new SqliteParameter("@mail", obj.Mail),
                new SqliteParameter("@activo", obj.Activo)
            };

            GestorConexion.AlterarBD(consulta, parametros);
            

            return true;
        }
    }
}
