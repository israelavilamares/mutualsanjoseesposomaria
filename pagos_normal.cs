﻿using System;
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
    public partial class pagos_normal : Form
    {
        public pagos_normal()
        {
            InitializeComponent();
        }

        private void pagos_normal_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            string query = "SELECT socios.id as numero_de_socio, socios.nombre,apellido,sexo,fecha_ingreso,ciudad,colonia,calle,telefono,edad,fecha_naciento,tipo_s.nombre as tipo_pago ,socios.observaciones FROM socios,tipo_s WHERE socios.tipo_p = tipo_s.id AND tipo_s.nombre = 'PAGO NORMAL'";

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

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void busquedatxt_Enter(object sender, EventArgs e)
        {
            if(busquedatxt.Text == "NUM. SOCIO")
            {
                busquedatxt.Text = "";
                busquedatxt.ForeColor = Color.Black;
            }
        }

        private void busquedatxt_Leave(object sender, EventArgs e)
        {
            if(busquedatxt.Text == "")
            {
                busquedatxt.Text = "NUM. SOCIO";
                busquedatxt.ForeColor = Color.DarkGray;
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            
                
             

                DataTable datatable = new DataTable();
                string query = "SELECT socios.id as numero_de_socio, socios.nombre,apellido,sexo,fecha_ingreso,ciudad,colonia,calle,telefono,edad,tipo_s.nombre as tipo_pago,socios.observaciones FROM socios JOIN tipo_s ON socios.tipo_p = tipo_s.id " +
                    "WHERE socios.id = '" + busquedatxt.Text + "' AND tipo_s.id = 1 ";

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
                if (datatable.Rows.Count > 0)
                {
                    MessageBox.Show("encontrado");
                }
                else
                {
                    MessageBox.Show("no se encontro");

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

        private void apellidotxbPN_TextChanged(object sender, EventArgs e)
        {

            

            DataTable datatable = new DataTable();
            string query = "SELECT socios.id as numero_de_socio, socios.nombre,apellido,sexo,fecha_ingreso,ciudad,colonia,calle,telefono,edad,tipo_s.nombre as tipo_pago, socios.observaciones FROM socios JOIN tipo_s ON socios.tipo_p = tipo_s.id " +
                "WHERE socios.apellido LIKE  '%" + apellidotxbPN.Text + "%' AND tipo_s.id = 1 ";

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
