using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Base.Compatibility.Core;
namespace V_Base.Compatibility
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
         
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new app());
            
            
        }
    }
}
