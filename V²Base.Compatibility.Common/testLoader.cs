using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace V_Base.Compatibility.Common
{
    public class testLoader
    {
    public static Array loadJSONWebTest(String Path){
         String test =  new WebClient().DownloadString(Path);
        JavaScriptSerializer JSONBuild = new JavaScriptSerializer();
        Array result = JSONBuild.DeserializeObject(test) as Array;
         
        return result;
    }
    }
}
