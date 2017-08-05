using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SistemaParqueoAdministracion
{
    class SN
    {
        public string serial()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";

            foreach (ManagementObject strt in mcol)
            {
                if (Convert.ToString(strt["MediaType"]).ToUpper().Contains("FIXED"))
                {
                    result += Convert.ToString(strt["SerialNumber"]);
                }
            }
            string time = DateTime.Now.ToString("yyyyMM");
            
            return time.Trim() + result.Trim();
        }
    }
}
