using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace BioVet_Technology
{
    internal class GestorConexion
    {
       private string stringConexion = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
    }
}
