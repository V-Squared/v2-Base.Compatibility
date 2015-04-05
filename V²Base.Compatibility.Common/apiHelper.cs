using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace V_Base.Compatibility.Common
{
    public class apiHelper
    {
        private string uid;
        public apiHelper()
        {
            uid=uidHelper.Value();
        }
        private string SendPost(string uri, List<KeyValuePair<string, string>> content)
        {

          
            FormUrlEncodedContent postvars = new FormUrlEncodedContent(content);
            using (var client = new HttpClient())
            {
                var result = client.PostAsync(uri,postvars ).Result;
                string resultContent = result.Content.ReadAsStringAsync().Result;
                return resultContent;
            }
        }
        public string registerDevice(String deviceName,List<KeyValuePair<string, string>> data)
        {
            SendPost("http://andrewbishara.com/dev/api/record/" + uid + "/device/" + deviceName + "/", data);
            return deviceName + " Registered" + System.Environment.NewLine;
        }
        public string RegisterConfiguration(string email){
            var data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("email", email));
            SendPost("http://andrewbishara.com/dev/api/record/" + uid +"/", data);
            return "Computer Registered Under Email: "+email+ System.Environment.NewLine;
        }

    }
}
