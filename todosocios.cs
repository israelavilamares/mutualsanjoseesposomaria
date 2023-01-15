using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;



namespace mutualsanjoseesposomaria
{
    public partial class todosocios : Form
    {
        public todosocios()
        {
            InitializeComponent();
        }
        
        private void todosocios_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            //    string query = "SELECT * from socios";
            string query = "SELECT socios.id as numero_socio ,socios.nombre,socios.apellido,socios.sexo,socios.fecha_ingreso,socios.ciudad,socios.calle, socios.colonia, tipo_s.nombre,socios.telefono,socios.edad,socios.fecha_naciento,socios.estado AS vigente_o_fallecido,socios.observaciones From socios JOIN tipo_s ON tipo_s.id = socios.tipo_p";

            MySqlConnection conexionDB = Conexion.conexion();
            MySqlDataReader resultado;
            conexionDB.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand(query, conexionDB);
                comando.CommandType = CommandType.Text;

                resultado = comando.ExecuteReader();
                datatable.Load(resultado);
                dataGridView1.DataSource = datatable;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscartxt_Enter(object sender, EventArgs e)
        {
            if(buscartxt.Text == "NUM. SOCIO")
            {
                buscartxt.Text = "";
                buscartxt.ForeColor = Color.Black;
            }
        }

        private void buscartxt_Leave(object sender, EventArgs e)
        {
            if( buscartxt.Text == "")
            {
                buscartxt.Text = "NUM. SOCIO";
                buscartxt.ForeColor = Color.DarkGray;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            int search = int.Parse(buscartxt.Text);

            DataTable datatable = new DataTable();
            string query = "SELECT socios.id as numero_de_socio, socios.nombre,apellido,sexo,fecha_ingreso,ciudad,socios.colonia,calle,telefono,tipo_s.nombre as tipo_pago,socios.observaciones FROM socios JOIN tipo_s ON socios.tipo_p = tipo_s.id " +
                "WHERE socios.id = '" + search + "' ";

            MySqlConnection conexionDB = Conexion.conexion();
            MySqlDataReader resultado;
            conexionDB.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand(query, conexionDB);
                comando.CommandType = CommandType.Text;

                resultado = comando.ExecuteReader();
                datatable.Load(resultado);
                dataGridView1.DataSource = datatable;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }
        }

        private void actulizar()
        {
            DataTable datatable = new DataTable();
            string query = "SELECT socios.id as numero_socio ,socios.nombre,socios.apellido,socios.sexo,socios.fecha_ingreso,socios.ciudad,socios.colonia,socios.calle, tipo_s.nombre,socios.telefono,socios.edad,socios.fecha_naciento,socios.estado AS vigente_o_fallecido,socios.observaciones From socios JOIN tipo_s ON tipo_s.id = socios.tipo_p";

            MySqlConnection conexionDB = Conexion.conexion();
            MySqlDataReader resultado;
            conexionDB.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand(query, conexionDB);
                comando.CommandType = CommandType.Text;

                resultado = comando.ExecuteReader();
                datatable.Load(resultado);
                dataGridView1.DataSource = datatable;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error " + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }
        }
        private void REFRESH_Click(object sender, EventArgs e)
        {
            actulizar();
        }

        private void contar_Click(object sender, EventArgs e)
        {
            int  menos= 1;
            int contar = dataGridView1.RowCount - menos;
            contartxt.Text = contar.ToString();

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("yyyy-MM-d-mm-HH-ss") + ".pdf";
          //  guardar.AddExtension()
            
            //guardar.ShowDialog();

            if(guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName,FileMode.Create))
                {

                Document pdfdocument = new Document(PageSize.A4.Rotate(),25,25,25,25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfdocument,stream);
                    pdfdocument.Open();
                    pdfdocument.AddTitle("MUTUAL SAN JOSE ESPOSO DE MARIA");
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.WhatsApp_Image_2022_12_06_at_2_37_51_PM__1_,System.Drawing.Imaging.ImageFormat.Jpeg);
                    img.ScaleToFit(100,100);
                   // img.SetAbsolutePosition(pdfdocument.TopMargin,Top -70);
                    img.SetAbsolutePosition(14, pdfdocument.Top-70);
                    pdfdocument.Add(img);


                    BaseFont fuente = BaseFont.CreateFont(BaseFont.COURIER,BaseFont.CP1250,true);                    
                    iTextSharp.text.Font fuentetitulo = new iTextSharp.text.Font(fuente, 20f, iTextSharp.text.Font.NORMAL);
                    
                    BaseFont fuente2 = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1250, true);
                    
                    iTextSharp.text.Font fuentehorario = new iTextSharp.text.Font(fuente2, 14f, iTextSharp.text.Font.NORMAL);


                    pdfdocument.Add(new Phrase("             REPORTE TOTAL DE SOCIOS MUTUAL SAN JOSE\n ", fuentetitulo));
                    pdfdocument.Add(new Phrase("                    LUNES A VIERNES 6:00pm A 8:00pm SABADOS 10:00am A 12:00pm", fuentehorario));
                    pdfdocument.Add(new Phrase("\n"));
                    pdfdocument.Add(new Phrase("\n"));
                    pdfdocument.Add(new Phrase("\n"));
                    pdfdocument.Add(new Phrase("\n"));
                    PdfPTable tablas = new PdfPTable(new float[] { 7, 20, 20, 4, 15, 18, 18, 20,7, 14, 15, 5, 20, 15 }) { WidthPercentage = 105 };
                    
                    for (int filas = 0; filas < dataGridView1.Rows.Count - 1; filas++)
                    {
                        for (int column = 0; column < dataGridView1.Rows[filas].Cells.Count; column++)
                        {
                            
                            string mostrar = dataGridView1.Rows[filas].Cells[column].Value.ToString();
                            tablas.AddCell(mostrar);

                        }
                    }
                    pdfdocument.Add(tablas);

                    pdfdocument.Close();
                    stream.Close();
                }
               // using(filestrin)
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string apell = apellidotxb.Text;

            DataTable datatable = new DataTable();
            string query = "SELECT socios.id as numero_de_socio, socios.nombre,apellido,sexo,fecha_ingreso,ciudad,socios.colonia,calle,telefono,tipo_s.nombre as tipo_pago,socios.observaciones FROM socios JOIN tipo_s ON socios.tipo_p = tipo_s.id " +
                "WHERE socios.apellido like ('%" + apell + "%' )";

            MySqlConnection conexionDB = Conexion.conexion();
            MySqlDataReader resultado;
            conexionDB.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand(query, conexionDB);
                comando.CommandType = CommandType.Text;

                resultado = comando.ExecuteReader();
                datatable.Load(resultado);
                dataGridView1.DataSource = datatable;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }
        }

      
    }
}
