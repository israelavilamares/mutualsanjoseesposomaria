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
            if (idpagonormal.Text == "NUMERO DEL SOCIO")
            {
                idpagonormal.Text = "";
                idpagonormal.ForeColor = Color.Black;
            }
        }

        private void idpagonormal_Leave(object sender, EventArgs e)
        {
            if (idpagonormal.Text == "")
            {
                idpagonormal.Text = "NUMERO DEL SOCIO";
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


        private void borrareliminar()
        {
            errorProvider1.SetError(numerodefacturatxt, "");
            errorProvider1.SetError(idpagonormal, "");
            errorProvider1.SetError(mes1, "");
            errorProvider1.SetError(mes2, "");
            errorProvider1.SetError(importe, "");
            errorProvider1.SetError(nombrequinfacturatxt, "");            
        }
        private bool validacionpago()
        {
            bool ok = true;


            if(numerodefacturatxt.Text == "")
            {
                errorProvider1.SetError(numerodefacturatxt, "Ingresar numero de factura que corresponde");
                ok = false;
                
            }else if(numerodefacturatxt.Text == "NUMERO FACTURA")
            {
                errorProvider1.SetError(numerodefacturatxt, "Ingresar numero de factura que corresponde");
                ok = false;
            }
            if(idpagonormal.Text == "NUMERO DEL SOCIO")
            {
                errorProvider1.SetError(idpagonormal, "Ingresar numero de socio que corresponde");
                ok = false;
            }
            else if(idpagonormal.Text == "")
            {
                errorProvider1.SetError(idpagonormal, "Ingresar numero de socio que corresponde");
                ok = false;
            }if(mes1.Text == "")
            {
                errorProvider1.SetError(mes1, "Ingresar el mes corresponde");
                ok = false;
            }
            else if(mes1.Text == "EJE.MAYO 22")
            {
                errorProvider1.SetError(mes1, "Ingresar mes corresponde");
                ok = false;
            }
            if (mes2.Text == "")
            {
                errorProvider1.SetError(mes2, "Ingresar el mes corresponde");
                ok = false;
            }
            else if (mes2.Text == "EJEM. ENERO 23")
            {
                errorProvider1.SetError(mes2, "Ingresar mes corresponde");
                ok = false;
            }
            if (importe.Text == "")
            {
                errorProvider1.SetError(importe,"Ingresar el pago aqui");
                ok = false;
            }
            else if (importe.Text == "IMPORTE")
            {
                errorProvider1.SetError(importe,"Ingresar el pago aqui");
                ok = false;
                
            }
            if (nombrequinfacturatxt.Text == "")
            {
                errorProvider1.SetError(nombrequinfacturatxt, "Ingresar el nombre Quien Factura");
                ok = false;
            }
            else if (nombrequinfacturatxt.Text == "NOMBRE QUIEN FACTURA")
            {
                errorProvider1.SetError(nombrequinfacturatxt, "Ingresar el nombre Quien Factura");
                ok = false;
                
            }

            return ok;
        }
     /*  private void borrarlostxt()
        {
            idpagonormal.Clear();
            numerodefacturatxt.Clear();
            fechatxt.Clear();
            nombrequinfacturatxt.Clear();
            mes1.Clear();
            mes2.Clear();
            observacionestxt.Clear();
            importe.Clear();
        }   */
        private void miperimerpago_Click(object sender, EventArgs e)
        { if (validacionpago())
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

                string sql = "INSERT INTO mutualsanjose.pagosnormal VALUES( '" + numero_factura + " ','" + numero_socio + "','" + mes1normal + "','" + mes2normal + "','" + nueva + "','" + importenormal + "','" + nombreqf + "','" + observaciones + "')";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                    comando.ExecuteNonQuery();
                    
                        MessageBox.Show("pagado!!");
                        borrarlostxt();
                        borrareliminar();
                    
                                       

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al agregar el pago" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }else
            {
                MessageBox.Show("Faltan Datos obligatorios");
            }
        }

      

        private void numerosocioeliminartxt_Enter(object sender, EventArgs e)
        {
            if (numerosocioeliminartxt.Text == "NUMERO DEL SOCIO")
            {   
                numerosocioeliminartxt.Text = "";
                numerosocioeliminartxt.ForeColor = Color.Black;
            }
        }

        private void numerosocioeliminartxt_Leave(object sender, EventArgs e)
        {
            if (numerosocioeliminartxt.Text == "")
            {   
                numerosocioeliminartxt.Text = "NUMERO DEL SOCIO";
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

        private void borrarnumseliminar()
        {
            errorProvider1.SetError(numerosocioeliminartxt, "");
           
        }
        private bool validationbonelimnums()
        {
            bool ok = true;


            if (numerosocioeliminartxt.Text == "")
            {
                errorProvider1.SetError(numerosocioeliminartxt, "Ingresar numero de socio Quieras borrar");
                ok = false;

            }
            else if (numerosocioeliminartxt.Text == "NUMERO DEL SOCIO")
            {
                errorProvider1.SetError(numerosocioeliminartxt, "Ingresar numero de socio Quieras borrar");
                ok = false;
            }
            return ok;
        }
        private void limpiaelinums()
        {
            numerosocioeliminartxt.Clear();
        }
            private void eliminarnumerosocio_Click(object sender, EventArgs e)
            {
            if (validationbonelimnums())
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

                        comando.ExecuteNonQuery();
                        

                            MessageBox.Show("ELIMINACION CON EXITO");
                        borrarnumseliminar();
                        limpiaelinums();



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
            else
            {
                MessageBox.Show("Ingresa el Dato Faltante");
            }
        }

        private void borrarnumseliminarfact()
        {
            errorProvider1.SetError(eliminarnumerofacturatxt, "");

        }
        private bool validationbonelimnumfact()
        {
            bool ok = true;


            if (eliminarnumerofacturatxt.Text == "")
            {
                errorProvider1.SetError(eliminarnumerofacturatxt, "Ingresar numero de Factura Quieras borrar");
                ok = false;

            }
            else if (eliminarnumerofacturatxt.Text == "NUMERO FACTURA")
            {
                errorProvider1.SetError(eliminarnumerofacturatxt, "Ingresar numero de Factura Quieras borrar");
                ok = false;
            }
            return ok;
        }
        private void limpiaelinumf()
        {
            eliminarnumerofacturatxt.Clear();
        }
        private void eliminanumerofactura_Click(object sender, EventArgs e)
        {if (validationbonelimnumfact())
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
                        limpiaelinumf();
                        borrarnumseliminarfact();
                        comando.ExecuteNonQuery();
                        
                            limpiaelinumf();
                            borrarnumseliminarfact();
                            MessageBox.Show("ELIMINACION CON EXITO");

                        
                            MessageBox.Show("¡ESTA VACIO! o ¡NO EXISTE!");
                        
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
            else
            {
                MessageBox.Show("Ingrese el dato faltante","!Error¡");
            }
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

        private void numerodefacturatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
            }
        }

        private void idpagonormal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
            }
        }

        private void importe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
            }
        }

        private void numerosocioeliminartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
            }
        }

        private void eliminarnumerofacturatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
            }
        }

        private void nombrequinfacturatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
            }
        }

        private void nombrequinfacturatxt_Enter_1(object sender, EventArgs e)
        {

            if (nombrequinfacturatxt.Text == "NOMBRE QUIEN FACTURA")
            {
                nombrequinfacturatxt.Text = "";
                nombrequinfacturatxt.ForeColor = Color.Black;
            }
        }

        private void nombrequinfacturatxt_Leave_1(object sender, EventArgs e)
        {
            if (nombrequinfacturatxt.Text == "")
            {
                nombrequinfacturatxt.Text = "NOMBRE QUIEN FACTURA";
                nombrequinfacturatxt.ForeColor = Color.Gray;
            }
        }

        private void eliminanumerofactura_Click_1(object sender, EventArgs e)
        {
            if (validationbonelimnumfact())
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
                        limpiaelinumf();
                        borrarnumseliminarfact();
                        comando.ExecuteNonQuery();

                        limpiaelinumf();
                        borrarnumseliminarfact();
                        MessageBox.Show("ELIMINACION CON EXITO");


                        MessageBox.Show("¡ESTA VACIO! o ¡NO EXISTE!");

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
            else
            {
                MessageBox.Show("Ingrese el dato faltante", "!Error¡");
            }
        }

        private void contar_Click(object sender, EventArgs e)
        {
            int menos = 1;
            int contar = dataGridView1.RowCount - menos;
            contartpntxt.Text = contar.ToString();
        }

        private void apellidotxbPN_TextChanged(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            string query = "SELECT pagosnormal.idsociopn AS numero_socio,socios.apellido , socios.nombre,idpagonormal as numero_pago,mes1,mes2, pagosnormal.fecha,pagosnormal.pago, NOMBREquinfac AS nombre_quien_factura FROM pagosnormal JOIN pagos ON pagosnormal.idsociopn = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id WHERE socios.apellido LIKE '%"+ apellidotxbPN.Text +"%'";



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

        private void expotarexel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[1, indiceColumna] = col.Name;
            }

            int indicerows = 0;
            foreach (DataGridViewRow fila in tabla.Rows)
            {
                indicerows++;
                indiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;
                    excel.Cells[indicerows + 1, indiceColumna] = fila.Cells[col.Name].Value;
                }

            }
            excel.Visible = true;
        }
        private void exportpu_Click(object sender, EventArgs e)
        {
            expotarexel(dataGridView1);
        }
    }

     
    }
