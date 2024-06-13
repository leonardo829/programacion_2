using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;
using Datos.cs;
using Entidades.cs;

namespace Negocios.cs
{
    public class NegProfesionales
    {

        DatosProfesionales objDatosProfes = new DatosProfesionales();
        public int abmProfesionales(string accion, Profesional objProfesional)
        {
            return objDatosProfes.abmProfesionales(accion, objProfesional);
        }

        public DataSet listadoProfesionales(string cual)
        {
            return objDatosProfes.listadoProfesionales(cual);
        }

    }
}
