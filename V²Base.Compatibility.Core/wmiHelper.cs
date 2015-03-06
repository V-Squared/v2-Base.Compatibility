using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
namespace V_Base.Compatibility.Core
{ //http://www.microsoft.com/en-us/download/details.aspx?id=8572
    class wmiHelper
    {
        public string searchWMI(string WMIQuery)
        {
             
        }
        public static int Main(string[] args)
        {
            WqlObjectQuery wqlQuery =
                new WqlObjectQuery("SELECT * FROM Win32_LogicalDisk");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(wqlQuery);

            foreach (ManagementObject disk in searcher.Get())
            {
                Console.WriteLine(disk.ToString());
            }

            Console.ReadLine();
            return 0;
        }
    }
}
 


 