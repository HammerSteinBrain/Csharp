using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCrud;

namespace BasicCrud
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmTeste());

            //Dados Teste = new Dados();

            //Teste.Gravar("Rodrigo", "rua bacon", "123456", "m", true, System.DateTime.Now);
        }
    }
}
