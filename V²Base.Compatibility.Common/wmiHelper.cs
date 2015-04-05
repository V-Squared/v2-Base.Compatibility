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
        public static List<KeyValuePair<string, string>> searchWMI(string WMIQuery, int lim)
        {
            var data = new List<KeyValuePair<string, string>>();

            WqlObjectQuery wqlQuery =
               new WqlObjectQuery(WMIQuery);
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(wqlQuery);
            
            ManagementObjectCollection test = searcher.Get();
            JavaScriptSerializer JSONBuild = new JavaScriptSerializer();
            int limit = 0;
            foreach (ManagementObject mo in test)
            {
               
                foreach (PropertyData prop in mo.Properties)
                {
                    if (limit < lim)
                    {
                        string name = prop.Name.ToString();
                        string val = "";
                        if (prop.Value != null && prop.Value != "" && prop.Value != "0")
                        {
                            val = JSONBuild.Serialize(prop.Value);
                            data.Add(new KeyValuePair<string, string>(name, val));
                            limit += 1; 
                        }
                        
                    }
                    
                }
                 
            }
            
            
            
           
            //JavaScriptSerializer JSONBuild = new JavaScriptSerializer();
            //return JSONBuild.Serialize(result);
            return data;
        }
         
    }
}
 


 