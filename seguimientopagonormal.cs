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

namespace mutualsanjoseesposomaria
{
    public partial class seguimientopagonormal : Form
    {
        public seguimientopagonormal()
        {
            InitializeComponent();
        }

        private void idpagonormal_Enter(object sender, EventArgs e)
        {
            if (idpagonormal.Text == "NUMERO PAGO DEL SOCIO")
            {
                idpagonormal.Text = "";
                idpagonormal.ForeColor = Color.Black;
            }
        }

        private void idpagonormal_Leave(object sender, EventArgs e)
        {
            if (idpagonormal.Text == "")
            {
                idpagonormal.Text = "NUMERO PAGO DEL SOCIO";
                idpagonormal.ForeColor = Color.Gray;

            }
        }

        private void mes1_Enter(object sender, EventArgs e)
        {
            if (mes1.Text == "EJE. MAYO 22")
            {
                mes1.Text = "";
                mes1.ForeColor = Color.Black;
            }
        }

        private void mes1_Leave(object sender, EventArgs e)
        {
            if (mes1.Text == "")
            {
                mes1.Text = "EJE. MAYO 22";
                mes1.ForeColor = Color.Gray;

            }
        }

        private void mes2_Enter(object sender, EventArgs e)
        {
            if (mes2.Text == "EJEM. ENERO 23")
            {
                mes2.Text = "";
                mes2.ForeColor = Color.Black;
            }
        }

        private void mes2_Leave(object sender, EventArgs e)
        {
            if (mes2.Text == "")
            {
                mes2.Text = "EJEM. ENERO 23";
                mes2.ForeColor = Color.Gray;
            }
        }

        private void importe_Enter(object sender, EventArgs e)
        {
            if (importe.Text == "IMPORTE")
            {
                importe.Text = "";
                importe.ForeColor = Color.Black;
            }
        }

        private void importe_Leave(object sender, EventArgs e)
        {
            if (importe.Text == "")
            {
                importe.ForeColor = Color.Gray;
                importe.Text = "IMPORTE";
            }
        }



        private void miperimerpago_Click(object sender, EventArgs e)
        {
            int numero_socio = int.Parse(idpagonormal.Text);
            int numero_factura = int.Parse(numerodefacturatxt.Text);
            DateTime fecha = DateTime.Now;
            //conversion
            string nueva = fecha.ToString("yyyy/MM/dd hh:mm:ss");
            //mostrar en texbox
            fechatxt.Text = nueva;
            string nombreqf = nombrequinfacturatxt.Text;
            string mes1normal = mes1.Text;
            string mes2normal = mes2.Text;
            string observaciones = observacionestxt.Text;
            double importenormal = double.Parse(importe.Text);

            string sql = "INSERT INTO mutualsanjose.pagosnormal VALUES( '"+ numero_factura +" ','" + numero_socio + "','" + mes1normal + "','" + mes2normal + "','" + nueva + "','" + importenormal + "','"+ nombreqf +"','" + observaciones +"')";

            MySqlConnection conexionDB = Conexion.conexion();
            conexionDB.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                if (comando.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("pagado!!");
                    borrarlostxt();
                }
                else
                {
                    MessageBox.Show("ERROR REGISTRO NO HAY PAGO!!");
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error al agregar el pago" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }

        }

      

        private void numerosocioeliminartxt_Enter(object sender, EventArgs e)
        {
            if (numerosocioeliminartxt.Text == "NUMERO PAGO DEL SOCIO")
            {   
                numerosocioeliminartxt.Text = "";
                numerosocioeliminartxt.ForeColor = Color.Black;
            }
        }

        private void numerosocioeliminartxt_Leave(object sender, EventArgs e)
        {
            if (numerosocioeliminartxt.Text == "")
            {   
                numerosocioeliminartxt.Text = "NUMERO PAGO DEL SOCIO";
                numerosocioeliminartxt.ForeColor = Color.Gray;
            }
        }

        private void seguimientopagonormal_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
     
            string query = "SELECT pagosnormal.idsociopn as numero_socio,socios.apellido , socios.nombre,idpagonormal as numero_pago_socio,mes1,mes2, pagosnormal.fecha,pagosnormal.pago , NOMBREquinfac AS nombre_quien_factura,pagosnormal.observaciones FROM pagosnormal JOIN pagos ON pagosnormal.idsociopn = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id";
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

                MessageBox.Show("Error al mostrar" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }
        }

        private void eliminarnumerofacturatxt_Enter(object sender, EventArgs e)
        {
            if (eliminarnumerofacturatxt.Text == "NUMERO FACTURA")
            {   
                eliminarnumerofacturatxt.Text = "";
                eliminarnumerofacturatxt.ForeColor = Color.Black;
            }
        }
        

      

        private void eliminarnumerofacturatxt_Leave(object sender, EventArgs e)
        {
            if (eliminarnumerofacturatxt.Text == "")
            {   
                eliminarnumerofacturatxt.Text = "NUMERO FACTURA";
                eliminarnumerofacturatxt.ForeColor = Color.Gray;
            }
        }

        private void numerodefacturatxt_Enter(object sender, EventArgs e)
        {
            if (numerodefacturatxt.Text == "NUMERO FACTURA")
            {
                numerodefacturatxt.Text = "";
                numerodefacturatxt.ForeColor = Color.Black;
            }
        }

        private void numerodefacturatxt_Leave(object sender, EventArgs e)
        {
            if (numerodefacturatxt.Text == "")
            {
                numerodefacturatxt.Text = "NUMERO FACTURA";
                numerodefacturatxt.ForeColor = Color.Gray;
            }
        }

        private void actulizartabla()
        {
            DataTable datatable = new DataTable();
            string query = "SELECT pagosnormal.idsociopn AS numero_socio,socios.apellido , socios.nombre,idpagonormal as numero_pago,mes1,mes2, pagosnormal.fecha,pagosnormal.pago, NOMBREquinfac AS nombre_quien_factura FROM pagosnormal JOIN pagos ON pagosnormal.idsociopn = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id";



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

                MessageBox.Show("Error al mostrar" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actulizartabla();
        }

        private void eliminarnumerosocio_Click(object sender, EventArgs e)
        {
            int vdelete = int.Parse(numerosocioeliminartxt.Text);
            DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string borrar = "DELETE FROM pagosnormal WHERE idsociopn = '" + vdelete + "'";



                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();
                try
                {


                    MySqlCommand comando = new MySqlCommand(borrar, conexionDB);

                    if (comando.ExecuteNonQuery() == 1)
                    {

                        MessageBox.Show("ELIMINACION CON EXITO");

                    }
                    else
                    {
                        MessageBox.Show("¡ESTA VACIO! o ¡NO EXISTE!");
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al ELIMINAR" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }
            else { }
        }

        private void eliminanumerofactura_Click(object sender, EventArgs e)
        {
            int vdelete = int.Parse(eliminarnumerofacturatxt.Text);
            DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string borrar = "DELETE FROM pagosnormal WHERE idpagonormal  = '" + vdelete + "'";



                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();
                try
                {


                    MySqlCommand comando = new MySqlCommand(borrar, conexionDB);

                    if (comando.ExecuteNonQuery() == 1)
                    {

                        MessageBox.Show("ELIMINACION CON EXITO");

                    }
                    else
                    {
                        MessageBox.Show("¡ESTA VACIO! o ¡NO EXISTE!");
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al ELIMINAR" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }
            else { }
        }

        private void nombrequinfacturatxt_Enter(object sender, EventArgs e)
        {
            if(nombrequinfacturatxt.Text == "NOMBRE QUIEN FACTURA")
            {
                nombrequinfacturatxt.Text = "";
                nombrequinfacturatxt.ForeColor = Color.Black;
            }
        }

        private void nombrequinfacturatxt_Leave(object sender, EventArgs e)
        {
            if (nombrequinfacturatxt.Text == "")
            {
                nombrequinfacturatxt.Text = "NOMBRE QUIEN FACTURA";
                nombrequinfacturatxt.ForeColor = Color.Gray;
            }
        }
        private void borrarlostxt()
        {
            numerodefacturatxt.Clear();
            idpagonormal.Clear();
            fechatxt.Clear();
            mes1.Clear();
            mes2.Clear();
            importe.Clear();
            nombrequinfacturatxt.Clear();
            observacionestxt.Clear();
        }
        
    }
}
