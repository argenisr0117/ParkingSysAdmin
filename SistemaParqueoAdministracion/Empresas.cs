using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaParqueoAdministracion
{
    class Empresas
    {
        private Conexion C = new Conexion();

        int Midempresa;
        string Mnombre;
        string Mdireccion;
        string Mtelefono;
        string Mcorreo;


        public int Idempresa
        {
            get { return Midempresa; }
            set { Midempresa = value; }
        }

        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }
        public string Direccion
        {
            get { return Mdireccion; }
            set { Mdireccion = value; }
        }

        public string Telefono
        {
            get { return Mtelefono; }
            set { Mtelefono = value; }
        }

        public string Correo
        {
            get { return Mcorreo; }
            set { Mcorreo = value; }
        }       

        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", Midempresa));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@direccion", Mdireccion));
            lst.Add(new clsParametros("@telefono", Mtelefono));
            lst.Add(new clsParametros("@correo", Mcorreo));
            C.EjecutarSP("REG_EMPRESA", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        //public string Actualizar()
        //{
        //    string mensaje = "";
        //    List<clsParametros> lst = new List<clsParametros>();
        //    lst.Add(new clsParametros("@id", MidTipo));
        //    lst.Add(new clsParametros("@description", Mdescripcion));
        //    lst.Add(new clsParametros("@men_ent_status", MentradaStatus));
        //    lst.Add(new clsParametros("@men_ent_salir", McerrarEntrada));
        //    lst.Add(new clsParametros("@men_tiempo_precio", MtiempoPrecio));
        //    lst.Add(new clsParametros("@men_sal_salir", MsalirSalida));
        //    lst.Add(new clsParametros("@ticket_perdido", MticketPerdido));
        //    lst.Add(new clsParametros("@ticket_manual", MticketManual));
        //    lst.Add(new clsParametros("@reportes", MgenerarReportes));
        //    lst.Add(new clsParametros("@agregar_usuario", MagregarUsuario));
        //    lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
        //    C.EjecutarSP("UPD_TIPO_USUARIO", ref lst);
        //    mensaje = lst[10].Valor.ToString();
        //    return mensaje;
        //}
        public DataTable GetEmpresa()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("GET_EMPRESA", lst);
        }
    }
}
