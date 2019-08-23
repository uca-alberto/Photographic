
using Exactus.Tools.Conexion;
using System;
using System.Windows.Forms;

namespace Photographic
{

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] argvs)
        {
            string user, userx = "", pass, passx = "", db, owner, server = "", var2,Row="";
            if (argvs.Length == 0)
            {
                //user = "sa";
                //pass = "clfsa";
                //db = "SOFTLAND";
                //owner = "CLFSA";
                //server = "192.168.0.99";

                server = ".";
                user = "sa";
                pass = "123";
                db = "CONIPISOS";
                owner = "CONIPISOS";
                
              /*server = "200.1.1.140";
               user = "sa";
                pass = "123";
                db = "BCFOODS";
                owner = "ALINSA";*/
            }

            else
            {
                user = argvs[0];
                pass = argvs[1];
                db = argvs[2];
                owner = argvs[3];
                server = argvs[4];
                Row = argvs[5];
            }

            // }/*     try
            //  {

            //   StaticData.ObtenerServidorODBC(db, out server, out var2);

            StaticData.oCnn = new Conexion(TipoBDEnum.SqlServer, server, db, owner, user, pass);
            StaticData.oCnn.Open();
            if (StaticData.oCnn.IsOpen)
            {

                StaticData.oCnn.Close();
                if (user.ToUpper() != "SA" && user.ToUpper() != "SYSTEM")
                    StaticData.GetUserX(user, out userx, out passx);
                else
                {
                    userx = user;
                    passx = pass;
                }
                StaticData.oCnn = new Conexion(TipoBDEnum.SqlServer, server, db, owner, userx, passx);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(Row));
                StaticData.oCnn.Close();
            }
            //  }
            /*  catch (Exception ex)
              {

                  MessageBox.Show(null, "Error con:" + user + "-" + userx + "-" + pass + "-" + passx + "-" + db + "-" + owner + "-" + server + " \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  StaticData.oCnn.Close();
              }*/


        }
    }
}






















