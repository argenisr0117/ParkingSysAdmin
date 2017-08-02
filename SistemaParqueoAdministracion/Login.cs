using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaParqueoAdministracion
{
    class Login
    {
        private Conexion C = new Conexion();

        string Mnombre;
        string Musuario;
        string Mclave;



        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }

        public string Usuario
        {
            get { return Musuario; }
            set { Musuario = value; }
        }

        public string Clave
        {
            get { return Mclave; }
            set { Mclave = value; }
        }



        public string TipoLogin()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            C.EjecutarSP("FIRST_LOGIN", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string[] PrimerLogin()
        {
            string[] mensaje = new string[2];
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idUser", "", SqlDbType.Int, ParameterDirection.Output, 50));
            C.EjecutarSP("REG_FIRST_USER", ref lst);
            mensaje[0] = lst[3].Valor.ToString();
            mensaje[1] = lst[4].Valor.ToString();
            return mensaje;
        }

        public string[] UserLogin()
        {
            string[] mensaje = new string[2];
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idUser", "", SqlDbType.Int, ParameterDirection.Output, 50));
            C.EjecutarSP("USER_LOGIN", ref lst);
            mensaje[0] = lst[2].Valor.ToString();
            mensaje[1]= lst[3].Valor.ToString();
            return mensaje;

        }
    }
}
