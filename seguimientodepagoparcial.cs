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
    public partial class seguimientodepagoparcial : Form
    {
        public seguimientodepagoparcial()
        {
            InitializeComponent();
        }

        private void numerodefacturatxt_Enter(object sender, EventArgs e)
        {
            if(numerodefacturatxt.Text == "NUMERO FACTURA")
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

        private void idpagoparcial_Enter(object sender, EventArgs e)
        {
            if (idpagoparcial.Text == "NUMERO DE SOCIO")
            {   
                idpagoparcial.Text = "";
                idpagoparcial.ForeColor = Color.Black;

            }
        }

        private void idpagoparcial_Leave(object sender, EventArgs e)
        {
            if (idpagoparcial.Text == "")
            {   
                idpagoparcial.Text = "NUMERO DE SOCIO";
                idpagoparcial.ForeColor = Color.Gray;
            }
        }

        private void mes1_Enter(object sender, EventArgs e)
        {
            if(mes1.Text == "EJE. MAYO 22")
            {
                mes1.Text = "";
                mes1.ForeColor = Color.Black;
            }
        }

        private void mes1_Leave(object sender, EventArgs e)
        {
            if(mes1.Text == "" )
            {
                mes1.Text = "EJE. MAYO 22";
                mes1.ForeColor = Color.Gray;

            }
        }

        private void mes2_Enter(object sender, EventArgs e)
        {
            if(mes2.Text == "EJE. ENERO 23")
            {
                mes2.Text="";
                mes2.ForeColor = Color.Black;
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

        private void mes2_Leave(object sender, EventArgs e)
        {
            if (mes2.Text == "")
            {
                mes2.Text = "EJE. ENERO 23";
                mes2.ForeColor = Color.Gray;

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
        /*
       
         */
        private void nombreqf_Enter(object sender, EventArgs e)
        {
            if (nombreqf.Text == "NOMBRE QUIEN FACTURA")
            {   
                nombreqf.Text = "";
                nombreqf.ForeColor = Color.Black;

            }
        }

        private void nombreqf_Leave(object sender, EventArgs e)
        {
            if (nombreqf.Text == "")
            {
                nombreqf.Text = "NOMBRE QUIEN FACTURA";
                nombreqf.ForeColor = Color.Gray;

            }
        }

        private void ultimotxt_TextChanged(object sender, EventArgs e)
        {
            if (ultimotxt.Text == "")
            {
                ultimotxt.Text = "0";
            }
        }

        private void limpia()
        {

            idpagoparcial.Clear();
            fechatxt.Clear();
            numerodefacturatxt.Clear();
            pagotxt.Clear();
            mes1.Clear();
            mes2.Clear();
            nombreqf.Clear();
            searchnumsociotxt.Clear();
            ultimotxt.Clear();
            observacionestxt.Clear();
            importetxt.Clear();

        }
        private void borrarpagar()
        {
            errorProvider1.SetError(numerodefacturatxt, "");
            errorProvider1.SetError(idpagoparcial, "");
            errorProvider1.SetError(pagotxt, "");
            errorProvider1.SetError(nombreqf, "");

        }
        private bool validationpagar()
        {
            bool ok = true;
            if (numerodefacturatxt.Text == "NUMERO FACTURA")
            {
                ok = false;
                errorProvider1.SetError(numerodefacturatxt, "Ingresa el nuevo numero factura ");
            }else if(numerodefacturatxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(numerodefacturatxt, "Ingresa el nuevo numero factura ");
            }
            if (idpagoparcial.Text == "NUMERO DE SOCIO")
            {
                ok = false;
                errorProvider1.SetError(idpagoparcial, "Ingresa el numero socio que va a pagar");
            }else if(idpagoparcial.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idpagoparcial, "Ingresa el numero socio que va a pagar");

            }
            if (pagotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(pagotxt, "Ingresa la cantidad que pagara");
            }
            if (nombreqf.Text == "NOMBRE QUIEN FACTURA")
            {
                ok = false;
                errorProvider1.SetError(nombreqf, "Ingresa el nombre quien factura");
            }else if(nombreqf.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nombreqf, "Ingresa el nombre quien factura");
            }
            return ok;
        }
        private void pagar_Click(object sender, EventArgs e)
        {
           // int numfactura = int.Parse(numerodefacturatxt.Text);
          //  int numsocio = int.Parse(idpagoparcial.Text);
            //declar la variable de tiempo
            DateTime fecha = DateTime.Now;
            //conversion
            string nueva = fecha.ToString("yyyy/MM/dd hh:mm:ss");
            //mostrar en texbox
            fechatxt.Text = nueva;
           //  double ultimoabono = double.Parse(ultimotxt.Text);
         //   double ultimoabono = Convert.ToDouble(ultimotxt);
           // double pago = double.Parse(pagotxt.Text);
            string primermes = mes1.Text;
            string segundomes = mes2.Text;
            string nombreqfactura = nombreqf.Text;
            
          
               double resultado = 0;

         if (validationpagar())
         {
            string pago01 = pagotxt.Text;
            double pago = Convert.ToDouble(pago01);
               
            double ultimoabono = Convert.ToDouble(ultimotxt.Text);
         //importetxt.Text = pagotxt.Text + ultimotxt.Text;
         //   double importe = Convert.ToDouble(importetxt.Text);
            
           resultado = pago + ultimoabono;
           importetxt.Text = Convert.ToString(resultado);


                string sql = "INSERT INTO mutualsanjose.pagoparcial VALUES( '" + numerodefacturatxt.Text + " ','" + idpagoparcial.Text + "','" + pagotxt.Text + "','" + ultimotxt.Text + "','" + resultado + "','" + nueva + "','" + primermes + "','" + segundomes + "','" + nombreqfactura + "', '" + observacionestxt.Text + "')";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                    if (comando.ExecuteNonQuery() == 1)
                    {


                        MessageBox.Show("pagado!!");
                        limpia();
                        borrarpagar();

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
            else
            {
                MessageBox.Show("Faltan Datos por Rellenar obligatorios");

            }
        }

        private void seguimientodepagoparcial_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();

            string query = "SELECT pagoparcial.idsociopp as numero_socio,socios.apellido , socios.nombre,pagoparcial.idpagoparcial as numero_folio,pagoparcial.abono AS ABONO, pagoresultado AS IMPORTE,pagoparcial.nombreqfact AS quien_facturo,pagoparcial.fecha,mes1normal AS del_mes ,mes2normal AS al_mes ,pagoparcial.observaciones  FROM pagoparcial JOIN pagos ON pagoparcial.idsociopp = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id";
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

        

        private void actulizar_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();

            string query = "SELECT pagoparcial.idsociopp as numero_socio,socios.apellido , socios.nombre,pagoparcial.idpagoparcial as numero_folio,pagoparcial.abono AS ABONO, pagoresultado AS IMPORTE,pagoparcial.nombreqfact AS quien_facturo,pagoparcial.fecha,mes1normal AS del_mes ,mes2normal AS al_mes,pagoparcial.observaciones  FROM pagoparcial JOIN pagos ON pagoparcial.idsociopp = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id";
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

        private void buscaultimo_Click(object sender, EventArgs e)
        {
            string searchnombre = searchnumsociotxt.Text;


            MySqlDataReader reader = null;

            string sql = "select pagoresultado from pagoparcial WHERE idsociopp = '" + searchnombre + "' ORDER BY idpagoparcial DESC LIMIT 1";
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
                        ultimotxt.Text = reader.GetString(0);
                    }

                }
                else
                {
                    MessageBox.Show("no se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {



                MessageBox.Show("Error al en datos" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }


        }

        private void limpiarelinar()
        {
            numerosocioeliminartxt.Clear();
        }
        private void borrarerroreseli()
        {
            errorProvider1.SetError(numerosocioeliminartxt, "");

        }
        private bool validationeliminar()
        {


            bool ok = true;
            if (numerosocioeliminartxt.Text == "NUMERO DEL SOCIO")
            {
                ok = false;
                errorProvider1.SetError(numerosocioeliminartxt, "Ingresa el Numero socio quieras Eliminar");
            }
            else if (numerosocioeliminartxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(numerosocioeliminartxt, "Ingresa el Numero socio quieras Eliminar");
            }
            return ok;
        }
        private void eliminarnumerosociobutton_Click(object sender, EventArgs e)
        {
            if (validationeliminar())
            {
                int vdelete = int.Parse(numerosocioeliminartxt.Text);
                DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string borrar = "DELETE FROM pagoparcial WHERE idsociopp  = '" + vdelete + "'";



                    MySqlConnection conexionDB = Conexion.conexion();
                    conexionDB.Open();
                    try
                    {


                        MySqlCommand comando = new MySqlCommand(borrar, conexionDB);
                        limpiarelinar();
                        borrarerroreseli();
                        comando.ExecuteNonQuery();
                        

                            MessageBox.Show("ELIMINACION CON EXITO");
                            
                       
                            MessageBox.Show("¡ESTA Eliminado! o  ¡NO EXISTE!");
                        
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
                MessageBox.Show("INGRESA EL NUMERO DE SOCIO","ERROR");
            }

        }

        private void limpiarelinarfact()
        {
            eliminarnumerofacturatxt.Clear();
        }
        private void borrarerroreselifact()
        {
            errorProvider1.SetError(eliminarnumerofacturatxt, "");

        }
        //elimina por numero de factura 
        private bool validationeliminarfact()
        {
            bool ok = true;
            if (eliminarnumerofacturatxt.Text == "NUMERO FACTURA")
            {
                ok = false;
                errorProvider1.SetError(eliminarnumerofacturatxt, "Ingresa el Numero de Factura quieras Eliminar");
            }
            else if (eliminarnumerofacturatxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(eliminarnumerofacturatxt, "Ingresa el Numero de Factura quieras Eliminar");
            }
            return ok;
        }
        private void eliminanumerofacturabutton_Click(object sender, EventArgs e)
        {   if (validationeliminarfact())
            {
                int vdelete = int.Parse(eliminarnumerofacturatxt.Text);
                DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string borrar = "DELETE FROM pagoparcial WHERE idpagoparcial  = '" + vdelete + "'";



                    MySqlConnection conexionDB = Conexion.conexion();
                    conexionDB.Open();
                    try
                    {


                        MySqlCommand comando = new MySqlCommand(borrar, conexionDB);

                        comando.ExecuteNonQuery();
                        

                            MessageBox.Show("ELIMINACION CON EXITO");
                            MessageBox.Show("¡ESTA VACIO! o ¡NO EXISTE!");
                        limpiarelinarfact();
                        borrarerroreselifact();
                       
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
                MessageBox.Show("INGRESA EL NUMERO DE FACTURA", "ERROR");

            }
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

        private void idpagoparcial_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ultimotxt_KeyPress(object sender, KeyPressEventArgs e)
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

  

        private void pagotxt_Validating(object sender, CancelEventArgs e)
        {
            double num;
            if (!double.TryParse(pagotxt.Text, out num))
            {
                errorProvider1.SetError(pagotxt, "Ingrese abono que va ha dar");
            }
            else
            {
                errorProvider1.SetError(pagotxt, "");

            }

        }

        private void searchnumsociotxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void fechatxt_Enter(object sender, EventArgs e)
        {
            if (fechatxt.Text == "FECHA AUTOMATICA")
            {
                fechatxt.Text = "";
                fechatxt.ForeColor = Color.Black;
            }

        }

        private void fechatxt_Leave(object sender, EventArgs e)
        {
            if (fechatxt.Text == "")
            {
                fechatxt.Text = "FECHA AUTOMATICA";
                fechatxt.ForeColor = Color.Gray;
            }
        }

        private void contar_Click(object sender, EventArgs e)
        {
           
            int menos = 1;
            int contar = dataGridView1.RowCount - menos;
            contartppxt.Text = contar.ToString();
        }

        private void apellidotxbPP_TextChanged(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();

            string query = "SELECT pagoparcial.idsociopp as numero_socio,socios.apellido , socios.nombre,pagoparcial.idpagoparcial as numero_folio,pagoparcial.abono AS ABONO, pagoresultado AS IMPORTE,pagoparcial.nombreqfact AS quien_facturo,pagoparcial.fecha,mes1normal AS del_mes ,mes2normal AS al_mes,pagoparcial.observaciones  FROM pagoparcial JOIN pagos ON pagoparcial.idsociopp = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id WHERE socios.apellido LIKE '%" + apellidotxbPP.Text + "%'";
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
                foreach(DataGridViewColumn col  in tabla.Columns)
                {
                    indiceColumna++;
                    excel.Cells[indicerows + 1, indiceColumna] = fila.Cells[col.Name].Value;
                }

            }
            excel.Visible = true;
        }

        private void export_Click(object sender, EventArgs e)
        {
            expotarexel(dataGridView1);
        }
    }
}
