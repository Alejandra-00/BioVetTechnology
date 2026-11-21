using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace BioVet_Technology
{
    public static class GestorConexion
    {
        // Método para ejecutar consultas de lectura (SELECT) y devolver los resultados en forma de tabla
        public static DataTable ConsultarBD(string consulta, List<SqliteParameter> parametros)
        {
            SqliteConnection conexion = new SqliteConnection("Data source = BioVet.db"); // Crea el objeto de conexión apuntando al archivo de base de datos local "BioVet.db"

            DataTable tabla = null; // Declara la tabla que guardará los datos; inicia en null por si ocurre un error antes de llenarla

            try // Intenta ejecutar el código que puede fallar (ej. archivo bloqueado o SQL mal escrito)
            {
                conexion.Open();
                
                SqliteCommand comando = new SqliteCommand(consulta, conexion); // Prepara la instrucción SQL vinculándola con la conexión que acabamos de abrir

                if (parametros != null) // Verifica si se envió una lista de parámetros (para evitar inyección SQL)
                {
                    // Recorre cada parámetro de la lista y lo agrega al comando SQL
                    foreach (SqliteParameter param in parametros)
                        comando.Parameters.Add(param);
                }

                SqliteDataReader lector = comando.ExecuteReader(); // Ejecuta la consulta SELECT y obtiene un lector que recorre los resultados fila por fila

                tabla = new DataTable(); // Inicializa el objeto DataTable en memoria ahora que la consulta tuvo éxito

                tabla.Load(lector); // Vuelca todos los datos leídos por el SqliteDataReader dentro de la estructura de la tabla
            }
            catch (Exception ex) // Captura cualquier excepción (error) ocurrida dentro del bloque try
            {
                MessageBox.Show("Error.");
            }
            finally // Se ejecuta SIEMPRE al terminar (haya habido error o no)
            {
                conexion.Close(); // Cierra la conexión para liberar el archivo de base de datos y evitar bloqueos
            }

            return tabla; // Devuelve la tabla con los registros encontrados (o null si hubo un error)
        }

        // Método para ejecutar comandos que modifican datos (INSERT, UPDATE, DELETE) sin devolver filas
        public static void AlterarBD(string consulta, List<SqliteParameter> parametros)
        {  
            SqliteConnection conexion = new SqliteConnection("Data source = BioVet.db");

            try
            {
                conexion.Open();

                SqliteCommand comando = new SqliteCommand(consulta, conexion); // Prepara el comando SQL (INSERT, UPDATE o DELETE) sobre esa conexión
            
                if (parametros != null) // Si se pasaron parámetros, los carga en el comando uno por uno
                {
                    foreach (SqliteParameter param in parametros)
                        comando.Parameters.Add(param);
                }

                comando.ExecuteNonQuery(); // Ejecuta la instrucción en la base de datos sin esperar resultados de vuelta (solo afecta filas)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error."); // Muestra un aviso si falla la inserción, actualización o borrado
            }
            finally
            {
                conexion.Close(); // Asegura que la conexión se cierre pase lo que pase
            }
        }
    }
}