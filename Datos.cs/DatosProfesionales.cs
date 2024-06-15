using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Entidades.cs;

namespace Datos.cs
{
    public class DatosProfesionales : DatosConexionBD
    {

        public int abmProfesionales(string accion, Profesional objProfesional)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Grabar")
                orden = "insert into Profesionales values (" + objProfesional.CodProf +
                ",'" + objProfesional.Nombre + "');";
            if (accion == "Modificar")
                orden = "update Profesionales set Nombre='" + objProfesional.Nombre + "' where CodProf = "+ objProfesional.CodProf + "; ";
            // falta la orden de borrar
             SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de Profesionales",e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


        public DataSet listadoProfesionales(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Profesionales where CodProf = " + int.Parse(cual) + ";";
            else
                orden = "select * from Profesionales;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar profesionales", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

    }
}
