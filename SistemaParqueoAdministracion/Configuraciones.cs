using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaParqueoAdministracion
{
    public class Configuraciones
    {
        private Conexion C = new Conexion();
        int Mid;
        int Mposicion;
        int Mtiempo;
        double Mprecio;
        string Mempresa;
        bool Mestado;
        int Midvalidacion;
        double Mmonto;

        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Posicion
        {
            get { return Mposicion; }
            set { Mposicion = value; }
        }

        public int Tiempo
        {
            get { return Mtiempo; }
            set { Mtiempo = value; }
        }

        public double Precio {get { return Mprecio; } set { Mprecio = value; }}
        public string Empresa {get { return Mempresa; } set { Mempresa = value; }}
        public bool Estado {get { return Mestado; } set { Mestado = value; }}
        public double Monto {get { return Mmonto; } set { Mmonto = value; } }

        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@posicion", Mposicion));
            lst.Add(new clsParametros("@tiempo", Mtiempo));
            lst.Add(new clsParametros("@precio", Mprecio));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("REG_TIME_PRICE", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }
        public string RegistrarValidaciones()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            mensaje = lst[0].Valor.ToString();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@nombre", Mempresa));
            lst.Add(new clsParametros("@monto", Mmonto));
            lst.Add(new clsParametros("@estado", Mestado));
            C.EjecutarSP("INS_VALIDACIONES", ref lst);
            return mensaje;
        }
        public string Actualizar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@posicion", Mposicion));
            lst.Add(new clsParametros("@tiempo", Mtiempo));
            lst.Add(new clsParametros("@precio", Mprecio));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("UPD_TIME_PRICE", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public DataTable GetTimePriceSettings()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("GET_TIME_PRICE", lst);
        }
    }
}
