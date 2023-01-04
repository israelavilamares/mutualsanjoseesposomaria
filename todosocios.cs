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
    public partial class todosocios : Form
    {
        public todosocios()
        {
            InitializeComponent();
        }

        private void todosocios_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            string query = "SELECT * from socios";

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
            string query = "SELECT socios.id as numero_de_socio, socios.nombre,apellido,sexo,fecha_ingreso,ciudad,calle,numero,telefono,tipo_s.nombre as tipo_pago FROM socios JOIN tipo_s ON socios.tipo_p = tipo_s.id " +
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

                MessageBox.Show("Error al guardar" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }
        }
    }
}
