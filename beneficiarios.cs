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
    public partial class beneficiarios : Form
    {
        public beneficiarios()
        {
            InitializeComponent();
        }

        private void borrarerroresagregar()
        {
            errorProvider1.SetError(numbeneficiario, "");
            errorProvider1.SetError(idtxt, "");
            errorProvider1.SetError(nombretxt, "");
            errorProvider1.SetError(parentescoctx, "");
            errorProvider1.SetError(sexocxt, "");
            errorProvider1.SetError(edadtxt, "");
        }
        private bool validacionagregar()
        {
            bool ok = true;
            if(numbeneficiario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(numbeneficiario, "ingresa el numero de beneficiario");

            }
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "ingresa el numero de socio");

                if (nombretxt.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(nombretxt, "ingresa el nombre del beneficiario");

                }
                if (parentescoctx.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(parentescoctx, "ingresa el parentesco con socio");

                }
                if (sexocxt.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(sexocxt, "ingresa el sexo de beneficiario");
                    
                }
                if (edadtxt.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(edadtxt, "ingresa la edad de beneficiario");
                    
                }
            }
            return ok;
        }
        private void agregar_Click(object sender, EventArgs e)
        {
          //  int numero_beneficiorio = int.Parse(numbeneficiario.Text);
            //int numero_socio = int.Parse(idtxt.Text);
            string nombreCompleto = nombretxt.Text;
            DateTime fecha = DateTime.Now;
            //conversion
            string nuevaf = fecha.ToString("yyyy/MM/dd hh:mm:ss");
            //mostrar en texbox
            fecha_ingresotxt.Text = nuevaf;
            string parentesco = parentescoctx.Text;
            string sexo = sexocxt.Text;
           // int edad = int.Parse(edadtxt.Text);
            if (validacionagregar())
            {
                borrarerroresagregar();
                string sql = "INSERT INTO mutualsanjose.beneficiarios VALUES('" + numbeneficiario.Text + "','" + idtxt.Text + "','" + nombreCompleto + "','" + nuevaf + "','" + parentesco + "','" + sexo + "','" + edadtxt.Text + "')";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                    if (comando.ExecuteNonQuery() == 1)
                    {

                        MessageBox.Show("registro guardado!!");
                        limpiar();
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

        private void limpiar()
        {
            idtxt.Clear();
            fecha_ingresotxt.Clear();
            nombretxt.Clear();
            numbeneficiario.Clear();
            edadtxt.Clear();
            if (parentescoctx.Text == "HIJO")
            {
                parentescoctx.Text = "NINGUNO";

            }
            else if (parentescoctx.Text == "HIJA")
            {
                parentescoctx.Text = "NINGUNO";
            }
            else if (parentescoctx.Text == "CONYUGUE")
            {
                parentescoctx.Text = "NINGUNO";
            }
            if (sexocxt.Text == "HOMBRE")
            {
                sexocxt.Text = "NINGUNO";

            }
            else if (sexocxt.Text == "MUJER")
            {
                sexocxt.Text = "NINGUNO";
            }

        }

        private void beneficiarios_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();

            string query = "SELECT  beneficiarios.idbenefsocio as numero_socio,socios.nombre AS nombre_socio,socios.apellido as apellido_socio,socios.estado as vigencia ,beneficiarios.idbenef as numero_folio,beneficiarios.nombre_beneficiario , beneficiarios.fecha,beneficiarios.parentesco,beneficiarios.sexo  FROM beneficiarios JOIN socios ON beneficiarios.idbenefsocio = socios.id;";
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

            string query = "SELECT beneficiarios.idbenefsocio as numero_socio,socios.nombre AS nombre_socio,socios.apellido as apellido_socio,socios.estado as vigencia ,beneficiarios.idbenef as numero_folio,beneficiarios.nombre_beneficiario , beneficiarios.fecha,beneficiarios.parentesco,beneficiarios.sexo FROM beneficiarios JOIN socios ON beneficiarios.idbenefsocio = socios.id;";
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
        private bool validacionES()
        {
            bool ok = true;
            if (numerosocioeliminartxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(numerosocioeliminartxt, "ingresa el numero de socio que deseas eliminar");

            }
        
            return ok;
        }
        private void borrarerrores()
        {
            errorProvider1.SetError(numerosocioeliminartxt, "");
        }
        private void eliminarnumerosociobutton_Click(object sender, EventArgs e)
        {
            //  int vdelete = int.Parse(numerosocioeliminartxt.Text);
            if (validacionES())
            {
                borrarerrores();
                DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string borrar = "DELETE FROM beneficiarios WHERE idbenefsocio = '" + numerosocioeliminartxt.Text + "'";



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

            }else
            {
                MessageBox.Show("¡Ingrese el dato a eliminar!");
            }
        }

        private bool validacionEF()
        {
            bool ok = true;
            if (eliminarnumerofacturatxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(eliminarnumerofacturatxt, "ingresa el numero de socio que deseas eliminar");

            }

            return ok;
        }
        private void eliminanumerofacturabutton_Click(object sender, EventArgs e)
        {
            // int vdelete = int.Parse(eliminarnumerofacturatxt.Text);
            if (validacionEF())
            {
                DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string borrar = "DELETE FROM beneficiarios WHERE  idbenef = '" + eliminarnumerofacturatxt.Text + "'";



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
            else
            {
                MessageBox.Show("Ingresa el dato de beneficiario");
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

        private void eliminarnumerofacturatxt_Enter(object sender, EventArgs e)
        {


            if (eliminarnumerofacturatxt.Text == "NUMERO BENEFICIARIO")
            {
                eliminarnumerofacturatxt.Text = "";
                eliminarnumerofacturatxt.ForeColor = Color.Black;
            }
        }

        private void eliminarnumerofacturatxt_Leave(object sender, EventArgs e)
        {
            if (eliminarnumerofacturatxt.Text == "")
            {
                eliminarnumerofacturatxt.Text = "NUMERO BENEFICIARIO";
                eliminarnumerofacturatxt.ForeColor = Color.Gray;
            }
        }

        private void searchnumerosocioeliminartxt_Enter(object sender, EventArgs e)
        {
            if (searchnumerosocioeliminartxt.Text == "NUMERO DEL SOCIO")
            {
                searchnumerosocioeliminartxt.Text = "";
                searchnumerosocioeliminartxt.ForeColor = Color.Black;
            }
        }

        private void searchnumerosocioeliminartxt_Leave(object sender, EventArgs e)
        {
            if (searchnumerosocioeliminartxt.Text == "")
            {
                searchnumerosocioeliminartxt.Text = "NUMERO DEL SOCIO";
                searchnumerosocioeliminartxt.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataTable datatable = new DataTable();
            string query = "SELECT DISTINCT beneficiarios.idbenefsocio as numero_socio,socios.nombre AS nombre_socio,socios.apellido as apellido_socio,socios.estado as vigencia ,beneficiarios.idbenef as numero_folio,beneficiarios.nombre_beneficiario , beneficiarios.fecha,beneficiarios.parentesco,beneficiarios.sexo FROM beneficiarios JOIN socios ON beneficiarios.idbenefsocio = socios.id WHERE beneficiarios.idbenefsocio = " + searchnumerosocioeliminartxt.Text + "  ORDER BY beneficiarios.idbenef ASC";


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

        private void numbeneficiario_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(numbeneficiario.Text, out num))
            {
                errorProvider1.SetError(numbeneficiario, "Ingrese numero de beneficiario");
            }
            else
            {
                errorProvider1.SetError(numbeneficiario, "");

            }
        }

        private void idtxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(idtxt.Text, out num))
            {
                errorProvider1.SetError(idtxt, "Ingrese numero de socio");
            }
            else
            {
                errorProvider1.SetError(idtxt, "");

            }
        }

        private void nombretxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(nombretxt.Text, out num))
            {
                errorProvider1.SetError(nombretxt, "Ingrese numero de socio");
            }
            else
            {
                errorProvider1.SetError(nombretxt, "");

            }
        }

        private void parentescoctx_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(parentescoctx.Text, out num))
            {
                errorProvider1.SetError(parentescoctx, "Ingrese parentesco con socio");
            }
            else
            {
                errorProvider1.SetError(parentescoctx, "");

            }
        }

        private void sexocxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(sexocxt.Text, out num))
            {
                errorProvider1.SetError(sexocxt, "Ingrese sexo del beneficiario");
            }
            else
            {
                errorProvider1.SetError(sexocxt, "");

            }
        }

        private void edadtxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(edadtxt.Text, out num))
            {
                errorProvider1.SetError(edadtxt, "Ingrese edad del beneficiario");
            }
            else
            {
                errorProvider1.SetError(edadtxt,"");

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

        private void eliminarnumerofacturatxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(eliminarnumerofacturatxt.Text, out num))
            {
                errorProvider1.SetError(eliminarnumerofacturatxt, "Ingrese numero de socio");
            }
            else
            {
                errorProvider1.SetError(eliminarnumerofacturatxt, "");

            }
        }

        private void searchnumerosocioeliminartxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(searchnumerosocioeliminartxt.Text, out num))
            {
                errorProvider1.SetError(searchnumerosocioeliminartxt, "Ingrese numero de socio");
            }
            else
            {
                errorProvider1.SetError(searchnumerosocioeliminartxt, "");

            }
        }

        private void numbeneficiario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void idtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void edadtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void searchnumerosocioeliminartxt_KeyPress(object sender, KeyPressEventArgs e)
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
