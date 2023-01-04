using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mutualsanjoseesposomaria
{
    public partial class eliminar : Form
    {
        public eliminar()
        {
            
            InitializeComponent();
        }
        private bool Validacion()
        {
            bool ok = true;
            if (eliminatxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(eliminatxt, "ingresa el numero de socio");
            }
            return ok;
        }
        private void borrarerror()
        {
            errorProvider1.SetError(eliminatxt, "");
        }
        private void eliminarbutton_Click(object sender, EventArgs e)
        {


        //   int vdelete = int.Parse(eliminatxt.Text);
            if (Validacion())
            {
                borrarerror();
                DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string borrar = "DELETE FROM socios WHERE id= '" + eliminatxt.Text + "'";



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
                        MessageBox.Show("elimina primero en pagos y luego aqui");


                    }
                    finally
                    {

                        conexionDB.Close();

                    }
                }
                else { }
            }else
            {
                MessageBox.Show("inserta el valor faltante correspondiente para seguir!!");
            }
        }

        private void eliminar_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            string query = "SELECT * FROM socios";

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

        private void actulizar()
        {
            DataTable datatable = new DataTable();
            string query = "SELECT * FROM socios";

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

        private void REFRESH_Click(object sender, EventArgs e)
        {
            actulizar();
        }

        private void eliminatxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(eliminatxt.Text, out num))
            {
                errorProvider1.SetError(eliminatxt, "Ingresa el numero socio que quieras eliminar");
            }
            else
            {
                errorProvider1.SetError(eliminatxt, "");

            }
        }

        private void eliminatxt_KeyPress(object sender, KeyPressEventArgs e)
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
