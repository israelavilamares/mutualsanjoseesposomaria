using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mutualsanjoseesposomaria
{
    public partial class pagos : Form
    {
        public pagos()
        {
            InitializeComponent();
        }

        private void numerosocio_Enter(object sender, EventArgs e)
        {
            if( numerosocio.Text == "NUMERO SOCIO")
            {

               numerosocio.Text = "";
                numerosocio.ForeColor = Color.Black;

            }
        }
        private void limpiar()
        {
            numerosocio.Clear();
           
            fechatxt.Clear();
            cantidad.Clear();
        }
        private void numerosocio_Leave(object sender, EventArgs e)
        {
            if(numerosocio.Text == "")
            {
                numerosocio.Text = "NUMERO SOCIO";
                numerosocio.ForeColor = Color.DarkGray;
            }
        }

       
       

       

      
        private void borrarerrores()
        {
            errorProvider1.SetError(numerosocio, "");
            errorProvider1.SetError(tipo_p, "");
            errorProvider1.SetError(cantidad, "");
         
        }
        private bool Validacion()
        {
            bool ok = true;
            if (numerosocio.Text == "")
            {
                ok = false;
                errorProvider1.SetError(numerosocio, "ingresa el numero de socio");
            }
            if (tipo_p.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tipo_p, "ingresa tipo de pago");
            }
            if (cantidad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cantidad, "ingresa la cantidad de inscripcion");
            }                       
            return ok;
        }
        private void agregar_Click(object sender, EventArgs e)
        {
            //   int numerosociosintxt = int.Parse(numerosocio.Text);

            //automatizar la fecha hoy 
            DateTime fecha = DateTime.Now;
            //conversion
            string nueva = fecha.ToString("yyyy/MM/dd hh:mm:ss");
            //mostrar en texbox

            fechatxt.Text = nueva;

            //     int tipopagosintxt = int.Parse(tipo_p.Text);

            //double cantidadsintxt = double.Parse(cantidad.Text);
            if (Validacion()) {

                string sql = "INSERT INTO mutualsanjose.pagos VALUES('" + numerosocio.Text + "','" + tipo_p.Text + "','" + nueva + "','" + cantidad.Text + "')";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                    if (comando.ExecuteNonQuery() == 1)
                    {

                        MessageBox.Show("registro guardado!!");
                        limpiar();
                        borrarerrores();
                    }
                    else
                    {
                        MessageBox.Show("ERROR REGISTRO NO GURDADO!!");
                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al guardar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }


            }
            else
            {
                MessageBox.Show("inserta el valor faltante correspondiente para seguir!!");
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pAGOSNORMALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seguimientopagonormal spn = new seguimientopagonormal();
            spn.Show();
        }

        private void pAGOSUNICOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seguimientodepagounico spu = new seguimientodepagounico();
            spu.Show();
        }

        private void pAGOSPARCIALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seguimientodepagoparcial spp = new seguimientodepagoparcial();

            spp.Show();
        }

        private void numerosocio_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(numerosocio.Text, out num))
            {
                errorProvider1.SetError(numerosocio, "Ingrese numero de socio");
            }
            else
            {
                errorProvider1.SetError(numerosocio, "");

            }
        }

     

    
        private void cantidad_Enter(object sender, EventArgs e)
        {
            if (cantidad.Text == "CANTIDAD")
            {
                cantidad.Text = "";
                cantidad.ForeColor = Color.Black;
            }
        }

        private void cantidad_Leave(object sender, EventArgs e)
        {
            if (cantidad.Text == "")
            {
                cantidad.Text = "CANTIDAD";
                cantidad.ForeColor = Color.Gray;
            }
        }

        private void cantidad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(cantidad.Text, out num))
            {
                errorProvider1.SetError(cantidad, "Ingrese la cantidad pago de Inscripcion");
            }
            else
            {
                errorProvider1.SetError(cantidad, "");

            }
        }

        private void pagos_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            string query = "SELECT * FROM pagos";

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

                MessageBox.Show("Error al guardar" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }
        }

        private void REFRESCAR_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            string query = "SELECT * FROM pagos";

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

                MessageBox.Show("Error al guardar" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }
        }

        private bool validarE()
        {
            bool ok = true;
            if (numerosocioeliminartxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(numerosocioeliminartxt, "ingresa el numero de socio");
            }
            return ok;
        }

        private void eliminarnumerosociobutton_Click(object sender, EventArgs e)
        {

            if (validarE())
            {
                DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string borrar = "DELETE FROM pagos WHERE idpagos  = '" + numerosocioeliminartxt.Text + "'";



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
                        MessageBox.Show("elimina antes tambien en \n  segun tipo pago que sea el socio \n sea el seguimiento pago normal o \n, seguimiento parcial o,\n  seguimiento unico");

                    }
                    finally
                    {

                        conexionDB.Close();

                    }
                }
                else { }
            }else
            {
                MessageBox.Show("Inserte el numero de socio que quiere eliminar!!");
            }
        }

        private void numerosocioeliminartxt_Enter(object sender, EventArgs e)
        {
            if(numerosocioeliminartxt.Text == "NUMERO  DEL SOCIO")
            {
                numerosocioeliminartxt.Text = "";
                numerosocioeliminartxt.ForeColor = Color.Black;
            }
        }

        private void numerosocioeliminartxt_Leave(object sender, EventArgs e)
        {
            if (numerosocioeliminartxt.Text == "")
            {
                numerosocioeliminartxt.Text = "NUMERO  DEL SOCIO";
                numerosocioeliminartxt.ForeColor = Color.Gray;
            }
        }

        private void numerosocioeliminartxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(numerosocioeliminartxt.Text, out num))
            {
                errorProvider1.SetError(numerosocioeliminartxt, "Ingrese numero de socio");
            }
            else
            {
                errorProvider1.SetError(numerosocioeliminartxt, "");

            }
        }

        private void numerosocio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
