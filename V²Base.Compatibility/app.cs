using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Base.Compatibility.Common;
using V_Base.Compatibility.Core;

namespace V_Base.Compatibility
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
 
        }

        private void app_Load(object sender, EventArgs e)
        {

           
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> tests = testLoader.loadJSONWebTest("lookup.json");
            apiHelper aph = new apiHelper();
            this.setText(this.Text += aph.RegisterConfiguration(email.Text)); 
            String result = "";//aph.SendSystemInfo("test", "Test");
            foreach (Dictionary<string, string> item in tests)
            {
                var device = item["search"];
                var query = item["details"];
                result = aph.registerDevice(device, wmiHelper.searchWMI(query, 9000));
                this.setText(this.Text+=result);
            }
                this.setText("Your computer has been scanned. You may not close the application.");
        }
    }
}
