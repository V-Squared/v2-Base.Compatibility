using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Web.Script.Serialization;
namespace V_Base.Compatibility.Core
{ //http://www.microsoft.com/en-us/download/details.aspx?id=8572
    public class wmiHelper
    {
        //SELECT * FROM Win32_LogicalDisk
        public static string searchWMI(string WMIQuery)
        {
            WqlObjectQuery wqlQuery =
               new WqlObjectQuery(WMIQuery);
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(wqlQuery);
            List<string> result = new List<string>();
            foreach (ManagementObject disk in searcher.Get())
            {
                result.Add(disk.ToString());
            }
            JavaScriptSerializer JSONBuild = new JavaScriptSerializer();
            return JSONBuild.Serialize(result);
        }
         
    }
}
 


 