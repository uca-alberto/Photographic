using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photographic
{
    public partial class Photographic : Form
    {
        string arto= "";
        string RowArto = "";
        public Photographic(string Articulo)
        {
            InitializeComponent();
            arto = Articulo;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("SELECT ARTICULO FROM {0}.ARTICULO WHERE RowPointer ='{1}'", StaticData.oCnn.CompaniaActual, arto);
                DataTable dataTable = StaticData.oCnn.ExecuteDatatable(sql);
                RowArto = dataTable.Rows[0]["ARTICULO"].ToString();
                Articulo_Row.Text = RowArto.ToString();

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }

        }
        //Metodo para obtener la foto
        private byte[] imageData;
        private void CapturarImagen_Click(object sender, EventArgs e)
        {
            Image image = cameraControl1.TakeSnapshot();
            pictureEdit1.EditValue = image;
            UpdateImageData(image);

        }
        //Metodo para actualizar la foto
        private void UpdateImageData(Image image)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                image.Save(stream,System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = stream.ToArray();
            }
        }
        public byte[] ImageData
        {
            get { return imageData; }
        }
        //Metodo para guardar la imagen en la base de datos
        private void GuardarImagen_Click(object sender, EventArgs e)
        {
            bool validacion;
            string Prioridad = "1";
            string Secuencia = "1";
            try
            {
                Prioridad = Verificar_Prioridad(RowArto).ToString();
                Secuencia = Verificar_Secuencia(RowArto).ToString();
                validacion = (StaticData.oCnn.ExecuteNonQuery(string.Format("EXEC {0}.INSERTAR_FOTO @ARTICULO,@SECUENCIA,@FOTO, @PRIORIDAD, @ARCHIVO,@DESCRIPCION,@FECHA", StaticData.oCnn.CompaniaActual), new SqlParameter[] { new SqlParameter("@ARTICULO", RowArto), new SqlParameter("@SECUENCIA", Secuencia), new SqlParameter("@FOTO", imageData), new SqlParameter("@PRIORIDAD", Prioridad), new SqlParameter("@ARCHIVO", "BMP"), new SqlParameter("@DESCRIPCION", "FOTO NUEVA"), new SqlParameter("@FECHA", System.DateTime.Today) }) > 0);

                if (!validacion)
                {
                    throw new Exception("Error en insertar los datos");
                }
                else
                {
                    MessageBox.Show("Exito!");
                    this.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public int Verificar_Prioridad( string articulo)
        {
            int contador=0;
            string sql = string.Format("SELECT COUNT(ARTICULO) as 'CONTADOR' FROM {0}.ARTICULO_FOTO WHERE ARTICULO ='{1}'", StaticData.oCnn.CompaniaActual,articulo);

            DataTable dataTable = StaticData.oCnn.ExecuteDatatable(sql);
            if (dataTable.Rows.Count < 0)
            {
                contador = 1;
                
            }
            else
            {
                contador = Convert.ToInt32(dataTable.Rows[0]["CONTADOR"]);
                contador++;

                StaticData.oCnn.ExecuteNonQuery(string.Format("UPDATE {0}.ARTICULO_FOTO SET PRIORIDAD ='{1}' WHERE ARTICULO ='{2}'", StaticData.oCnn.CompaniaActual, contador, articulo));
                contador = 1;
            }
            return contador;
        }

        public int Verificar_Secuencia(string articulo)
        {
            int contador = 0;
            string sql = string.Format("SELECT COUNT(SECUENCIA) as 'SECUENCIA' FROM {0}.ARTICULO_FOTO WHERE ARTICULO ='{1}'", StaticData.oCnn.CompaniaActual, articulo);

            DataTable dataTable = StaticData.oCnn.ExecuteDatatable(sql);
            if (dataTable.Rows.Count < 0)
            {
                contador = 1;

            }
            else
            {
                contador = Convert.ToInt32(dataTable.Rows[0]["SECUENCIA"]);
                contador++;
                //StaticData.oCnn.ExecuteNonQuery(string.Format("UPDATE {0}.ARTICULO_FOTO SET PRIORIDAD ='{1}' WHERE ARTICULO ='{2}'", StaticData.oCnn.CompaniaActual, contador, articulo));
            }
            return contador;
        }


    }
}
