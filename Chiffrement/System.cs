using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chiffrement
{
    class System
    { 
        private static string strProcessorId = string.Empty;
        private static string strSystemName = string.Empty;

        public static string GetSysInfo()
        {
            SelectQuery query = new SelectQuery("Win32_processor");
            ManagementObjectSearcher search = new ManagementObjectSearcher(query);

            foreach (ManagementObject info in search.Get())
            {
                strProcessorId = info["ProcessorID"].ToString();
                strSystemName = info["SystemName"].ToString();
            }
            return(strProcessorId + "-"+strSystemName);
             
        }

        

    }
}
