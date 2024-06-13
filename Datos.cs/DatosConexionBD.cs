using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data.OleDb;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Contexts;

namespace Datos.cs
{
    public class DatosConexionBD
    {
        public SqlConnection conexion;
        public string cadenaConexion = @"Data Source = DESKTOP - LF6ERKD\SQLEXPRESS;Initial Catalog = Programacion2; Integrated Security = True; Connect Timeout = 30; Encrypt=True";

        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexion", e);
            }
        }

        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexion", e);
            }
        }

    
    }
        
}

