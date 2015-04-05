using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Base.Compatibility.Common;
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
            app myapp = new app();
            myapp.setText("Please enter your email to press 'Log Configuration' to start recording your computer's information.");
            

            Application.Run(myapp);
            
    
        
          
            
        }
    }
}
