using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaParqueoAdministracion
{
    class SETTINGS
    {
        private Conexion C = new Conexion();

        float MprecioTicketPerdido;
        string MmensajePromo;
        


        public float PrecioTicketPerdido
        {
            get { return MprecioTicketPerdido; }
            set { MprecioTicketPerdido = value; }
        }

        public string MensajePromo
        {
            get { return MmensajePromo; }
            set { MmensajePromo = value; }
        }
       
        public bool CheckIfSoftwareActivated()
        {
            bool mensaje;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Bit, ParameterDirection.Output, 50));
            C.EjecutarSP("GET_IF_SOFTWARE_ACTIVATED", ref lst);
            mensaje = Convert.ToBoolean(lst[0].Valor);
            return mensaje;
        }
        
        public bool ActivarSoftware()
        {
            bool mensaje;
            List<clsParametros> lst = new List<clsParametros>();
            
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Bit, ParameterDirection.Output, 50));
            C.EjecutarSP("ACTIVATE_SOFTWARE", ref lst);
            mensaje = Convert.ToBoolean( lst[0].Valor);
            return mensaje;
        }
        public DataTable GetSettings()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("GET_SETTINGS_ADM", lst);
        }
        public DataTable GetTotalesDiarios()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@estado", Mestado));
            return dt = C.Listado("GET_TOTALES_DIARIOS", lst);
        }
        public bool updateSettigs()
        {
            bool mensaje;
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Bit, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@precioTicket", MprecioTicketPerdido));
            lst.Add(new clsParametros("@promocion", MmensajePromo));
            C.EjecutarSP("UPD_SETTINGS_ADM", ref lst);
            mensaje = Convert.ToBoolean(lst[0].Valor);
            return mensaje;

        }
    }
}
