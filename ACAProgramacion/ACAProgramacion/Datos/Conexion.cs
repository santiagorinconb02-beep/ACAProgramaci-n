using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ACAProgramacion.Datos
{

    public class Conexion
    {


        private string cadenaConexion = "Server=SANTIAGOSRB;Database=ACAProgramacion;Integrated Security=true;TrustServerCertificate=true;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

    }

}
