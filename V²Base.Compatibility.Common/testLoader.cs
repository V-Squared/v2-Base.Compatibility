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
        public static List<Dictionary<string, string>> loadJSONWebTest(String Path)
        {
         String test =  new WebClient().DownloadString(Path);
        JavaScriptSerializer JSONBuild = new JavaScriptSerializer();

        var dict = JSONBuild.Deserialize<List<Dictionary<string,string>>>(test);

        return dict;
    }
    }
}
