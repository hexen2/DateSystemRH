using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;

namespace DateSystemRH
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new FormTelaPrincipal());
            //}
            //catch(Exception ex) { ex.ToString(); }

            try
            {

                //UpdateCheckInfo info;
                var lingua = new CultureInfo("pt-BR");
                Thread.CurrentThread.CurrentCulture = lingua;
                Thread.CurrentThread.CurrentUICulture = lingua;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                FormLoginUsuario LoginUsuario = new FormLoginUsuario();
                LoginUsuario.ShowDialog();
                if (LoginUsuario.logado == true)
                {
                    //LoginUsuario.Nome.ToString();
                    //LoginUsuario.connectionString.ToString();
                    //LoginUsuario.BaseDados.ToString();

                    Application.Run(new FormTelaPrincipal(LoginUsuario.Nome.ToString(), LoginUsuario.connectionString.ToString()));

                }
            }
            catch (Exception Ex)
            {
                Ex.ToString();
            }
        }
    }
}
