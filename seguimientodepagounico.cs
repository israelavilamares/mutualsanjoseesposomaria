using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mutualsanjoseesposomaria
{
    public partial class seguimientodepagounico : Form
    {
        

        public seguimientodepagounico()
        {
            InitializeComponent();
        }
        private void actulizar()
        {
            DataTable datatable = new DataTable();
         
            string query = "SELECT pagosunico.idsociopu as numero_socio,socios.apellido , socios.nombre,idpagounico as numero_folio_socio,pagosunico.pago1 AS ABONO ,pagosunico.pagoresultado AS IMPORTE, NOMBREquinfac AS quien_facturo ,pagosunico.fecha,pagosunico.observaciones   FROM pagosunico JOIN pagos ON pagosunico.idsociopu = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id";
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

        private void miperimerpago_Click(object sender, EventArgs e)
        {


            int folio = int.Parse(numerodefacturatxt.Text);


            int numero_socio = int.Parse(idpagounico.Text);
            
            DateTime fecha = DateTime.Now;
            //conversion
            string nueva = fecha.ToString("yyyy/MM/dd hh:mm:ss");
            //mostrar en texbox
            fechatxt.Text = nueva;

            double abono = double.Parse(abonotxt.Text);
            double ultimoabono = double.Parse(ultimoabonotxt.Text);
            //aqui esta diciendo que meter un dato y lo pide
            //obligatoriamente
            //double importeunico = double.Parse(importetxt.Text);
            double importeunico;
            //declaramos una varible inicializada en 0
            double resultado=0;
            //sumamos abono y ultimo abono
            //el resultado lo ponemos en la variable 'resultado'
            resultado = abono + ultimoabono;
            //en la base de datos importeunico
            //va hacer resultado
            importeunico = resultado;
            //para mostrarlo en el texbox la suma
            //la convertimos a string por el campo solo acepta 
            //texto
            string observaciones = observacionestxt.Text;
            importetxt.Text = Convert.ToString(resultado);
            string nombreqf = nombrequinfacturatxt.Text;
           string sql = "INSERT INTO mutualsanjose.pagosunico VALUES( '" + folio + " ','" + numero_socio + "','" + abono + "','" + nueva + "','"+ ultimoabono +"','" + importeunico + "','" + nombreqf +"','" + observaciones +"')";

            MySqlConnection conexionDB = Conexion.conexion();
            conexionDB.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                if (comando.ExecuteNonQuery() == 1)
                {
                    
                   
                    MessageBox.Show("pagado!!");
                    limpia();
                    
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

        private void idpagonormal_Enter(object sender, EventArgs e)
        {
            if (idpagounico.Text == "NUMERO PAGO DEL SOCIO")
            {
              idpagounico.Text = "";
              idpagounico.ForeColor = Color.Black;

            }
        }

        private void idpagonormal_Leave(object sender, EventArgs e)
        {
            if (idpagounico.Text == "")
            {
                idpagounico.Text = "NUMERO PAGO DEL SOCIO";
                idpagounico.ForeColor = Color.Gray;
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

        private void importetxt_Enter(object sender, EventArgs e)
        {
            if (importetxt.Text == "IMPORTE")
            {   
                importetxt.Text = "";
                importetxt.ForeColor = Color.Black;

            }
        }

        private void importetxt_Leave(object sender, EventArgs e)
        {
            if (importetxt.Text == "")
                
                importetxt.Text = "IMPORTE";
                importetxt.ForeColor = Color.Gray;

            }

        private void eliminarnumerosociobutton_Click(object sender, EventArgs e)
        {
            int vdelete = int.Parse(numerosocioeliminartxt.Text);
            DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string borrar = "DELETE FROM pagosunico WHERE idsociopu  = '" + vdelete + "'";



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

        private void eliminanumerofacturabutton_Click(object sender, EventArgs e)
        {
            int vdelete = int.Parse(eliminarnumerofacturatxt.Text);
            DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string borrar = "DELETE FROM pagosunico WHERE idpagounico  = '" + vdelete + "'";



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

        private void BUSCARABONO_Click(object sender, EventArgs e)
        {
           string numerosocio = buscatxt.Text;

           

            MySqlDataReader reader = null;

            string sql = "select pagoresultado from pagosunico WHERE idsociopu = '" + numerosocio + "' ORDER BY idpagounico DESC LIMIT 1";
            MySqlConnection conexionDB = Conexion.conexion();
            conexionDB.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ultimoabonotxt.Text = reader.GetString(0);
                    }

                }else
                {
                    MessageBox.Show("no se encontraron registros");
                }
            }
            catch( MySqlException ex)
            {



                MessageBox.Show("Error al ELIMINAR" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }

        }
        private void seguimientodepagounico_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            
            string query = "SELECT pagosunico.idsociopu as numero_socio,socios.apellido , socios.nombre,idpagounico as numero_folio_socio,pagosunico.pago1 AS ABONO, pagoresultado AS IMPORTE,NOMBREquinfac AS quien_facturo,pagosunico.fecha,pagosunico.observaciones   FROM pagosunico JOIN pagos ON pagosunico.idsociopu = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id";
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

        private void limpia()
        {
            
            idpagounico.Clear();
            fechatxt.Clear();
            abonotxt.Clear();
            ultimoabonotxt.Clear();
            buscatxt.Clear();
            importetxt.Clear();
            observacionestxt.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            actulizar();
        }

        private void ultimoabonotxt_TextChanged(object sender, EventArgs e)
        {
            if(ultimoabonotxt.Text == "")
            {
                ultimoabonotxt.Text = "0";
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
    }
}

      

       




