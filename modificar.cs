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
    public partial class modificar : Form
    {
        public modificar()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fecha_ingresotxtviejo_Enter(object sender, EventArgs e)
        {
            if(fecha_ingresotxtviejo.Text == "AAAA/MM/DD")
            {
                fecha_ingresotxtviejo.Text = "";
                fecha_ingresotxtviejo.ForeColor = Color.Black;
            }
        }

        private void fecha_ingresotxtviejo_Leave(object sender, EventArgs e)
        {
            if(fecha_ingresotxtviejo.Text == "")
            {
                fecha_ingresotxtviejo.Text = "AAAA/MM/DD";
                fecha_ingresotxtviejo.ForeColor = Color.DarkGray;
            }

        }

        private void fecha_ingresonuevotxt_Enter(object sender, EventArgs e)
        {
            if(fecha_ingresonuevotxt.Text == "AAAA/MM/DD")
            {
                fecha_ingresonuevotxt.Text = "";
                fecha_ingresonuevotxt.ForeColor = Color.Black;
            }
        }

        private void fecha_ingresonuevotxt_Leave(object sender, EventArgs e)
        {
            if(fecha_ingresonuevotxt.Text == "")
            {
                fecha_ingresonuevotxt.Text = "AAAA/MM/DD";
                fecha_ingresonuevotxt.ForeColor = Color.DarkGray;
            }
        }
        private void limpiaid()
        {
            idtxt.Clear();
            nuevoidtxt.Clear();
        }
        private void borrarerroresid()
        {
            errorProvider1.SetError(idtxt, "");
            errorProvider1.SetError(nuevoidtxt, "");
       
        }
        private bool validaid()
        {
            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "ingresa el numero de socio");
            }
            if (nuevoidtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nuevoidtxt, "ingresa el nuevo nombre de socio");
            }
            return ok;
        }
        private void numeroid_Click(object sender, EventArgs e)
        { 
            
         //   int numerodesocioviejo = int.Parse(idtxt.Text);
           // int numerodesocionuevo = int.Parse(nuevoidtxt.Text);
            if (validaid())
            {
                
                string modificar = "update socios SET id =  '" + nuevoidtxt.Text + "' WHERE id = '" + idtxt.Text + "'";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);
                    comando.ExecuteNonQuery();
                    borrarerroresid();
                    MessageBox.Show("registro actulizar");
                    limpiaid();
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al actulizar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }

            }else
            {
                MessageBox.Show(" te falta de Ingresar algun dato", "Error");
                borrarerroresid();
            }
        }

        private void limpianomb()
        {
            idtxt.Clear();
            viejonombretxt.Clear();
            nuevonombretxt.Clear();
        }
        private void borrarerroresnomb()
        {
            errorProvider1.SetError(idtxt, "");
            errorProvider1.SetError(nuevonombretxt, "");
            errorProvider1.SetError(viejonombretxt, "");



        }
        private bool validanomb()
        {
            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "ingresa el numero de socio actual");
            }
          
            if (nuevonombretxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nuevonombretxt, "ingresa el nuevo nombre de socio");
            }
            if (viejonombretxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(viejonombretxt, "ingresa el nombre actual del socio");
            }
        

            return ok;
        }

        private void nombre_Click(object sender, EventArgs e)
        { 
            //int numerodesocioviejo = int.Parse(idtxt.Text);
            
            string nombreviejo = viejonombretxt.Text;
            string nombrenuevo = nuevonombretxt.Text;
            if (validanomb())
            {
                string modificar = "update socios SET nombre =  '" + nombrenuevo + "' WHERE id = '" + idtxt.Text + "' AND nombre = '" + nombreviejo + "' ";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("registro actulizado");
                        limpianomb();
                        borrarerroresnomb();

                    }
                    else
                    {
                        MessageBox.Show("registro actulizado");
                        MessageBox.Show("nesario poner numero de socio al cual hace el cambio");
                        MessageBox.Show("ó");
                        MessageBox.Show("error en sintaxis o es el mismo dato");


                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al actulizar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }else
            {
                MessageBox.Show("Ingresa los campos necesarios para continuar");
                
            }
        }
        private void limpiaciudad()
        {
            idtxt.Clear();
            nuevociudadtxt.Clear();
            ciudadtxt.Clear();

        }
        private void borrarvaliciudad()
        {

            errorProvider1.SetError(idtxt, "");
            errorProvider1.SetError(nuevociudadtxt, "");
            errorProvider1.SetError(ciudadtxt, "");
        }
        private bool validacionciuda()
        {

            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "ingresa el numero de socio actual");
            }
            if (nuevociudadtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nuevociudadtxt, "ingresa el nuevo ciudad de socio");
            }
            if (ciudadtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(ciudadtxt, "ingresa la ciudad actual del socio");
            }

            return ok;
        }

        private void ciudad_Click(object sender, EventArgs e)
        {     
           // int numerodesocioviejo = int.Parse(idtxt.Text);
            
            string ciudadvieja = ciudadtxt.Text;
            string ciudadnuevo = nuevociudadtxt.Text;

            if (validacionciuda())
            {
                string modificar = "update socios SET ciudad =  '" + ciudadnuevo + "' WHERE id = '" + idtxt.Text + "' AND ciudad = '" + ciudadvieja + "'  ";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("registro actulizado");
                        borrarvaliciudad();
                        limpiaciudad();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                        MessageBox.Show("nesario poner numero de socio correc al cual hace el cambio \n ó");
                        MessageBox.Show("INCORRECTO LOS DATOS");

                    }
                    


                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al actulizar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }else
            {
                MessageBox.Show("hay datos faltantes");
                
            }
        }
        private void limpianucasa()
        {
            idtxt.Clear();
            numerocasatxt.Clear();
            nuevonuemerocasatxt.Clear();
        }
        private void borranucasa()
        {
            errorProvider1.SetError(idtxt, "");
            errorProvider1.SetError(nuevonuemerocasatxt, "");
            errorProvider1.SetError(numerocasatxt, "");
        }
        private bool validanucasa()

        {
            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "ingresa el numero de socio actual");
            }
            if (nuevonuemerocasatxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nuevonuemerocasatxt, "ingresa el nuevo numero de casa del socio");
            }
            if (numerocasatxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(numerocasatxt, "ingresa el actual numero de casa del socio");
            }

            return ok;
        }

        private void numerocasa_Click(object sender, EventArgs e)
        {   
          //  int numerodesocioviejo = int.Parse(idtxt.Text);
            
         //   int viejonumerodecasa = int.Parse(numerocasatxt.Text);
         //   int nuevonumerodecasa = int.Parse(nuevonuemerocasatxt.Text);
            if (validanucasa())
            {


                string modificar = "update socios SET numero =  '" + nuevonuemerocasatxt.Text + "' WHERE id = '" + idtxt.Text + "' AND numero = '" + numerocasatxt.Text + "'  ";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);
                    comando.ExecuteNonQuery();
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("registro actulizado");
                        limpianucasa();
                        borranucasa();
                    }

                    else
                    {
                        MessageBox.Show("nesario poner numero de socio al cual hace el cambio");
                        MessageBox.Show("ó");
                        MessageBox.Show("error en sintaxis o es el mismo dato");
                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al ACTUALIZAR" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }else
            {
                MessageBox.Show("hay campos faltantes de rellenar");
            }
        }

        private void limpiatelef()
        {
            telefonotxt.Clear();
            nuevotelefonotxt.Clear();
        }
        private void borrarvalitelef()
        {
            errorProvider1.SetError(telefonotxt, "");
            errorProvider1.SetError(nuevotelefonotxt, "");
        }
        private bool validationtele()
        {
            bool ok = true;
            if (telefonotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(telefonotxt, "ingresa el telefono del actual");
            }
            if (nuevotelefonotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nuevotelefonotxt, "ingresa el nuevo numero de telefono del socio");
            }
            return ok;
        }
        private void telefono_Click(object sender, EventArgs e)
        {
          //  int viejontelefono = int.Parse(telefonotxt.Text);
           // int nuevotelefono = int.Parse(nuevotelefonotxt.Text);
            if (validationtele())
            {


                string modificar = "update socios SET telefono =  '" + nuevotelefonotxt.Text + "' WHERE telefono = '" + nuevotelefonotxt.Text + "' ";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);
                    comando.ExecuteNonQuery();
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("registro actulizado");
                        borrarvalitelef();
                    }
                    else
                    {
                        MessageBox.Show("nesario poner numero de socio al cual hace el cambio");
                        MessageBox.Show("ó");
                        MessageBox.Show("error en sintaxis o es el mismo dato");


                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al actulizar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }
            else
            {
                MessageBox.Show("No Ha rellenado todos los campos");
            }

        }
        private void limpiatipop()
        {
            idtxt.Clear();
            tipo_ptxt.Clear();
            nuevotipopagotxt.Clear();
        }

        private void borrartipo_p()
        {
            errorProvider1.SetError(tipo_ptxt, "");
            errorProvider1.SetError(idtxt, "");
            errorProvider1.SetError(nuevotipopagotxt, "");

        }
        private bool validaciontipo_p()
        {
            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "ingresa el numero socio del actual");
            }
            if (tipo_ptxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tipo_ptxt, "Ingresa el actual tipo de pago ");
            }
            if (nuevotipopagotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nuevotipopagotxt, "Ingresa el nuevo tipo de pago");
            }
            return ok ;
        }

        private void tipo_pago_Click(object sender, EventArgs e)
        {


            //  int viejontipopago = int.Parse(tipo_ptxt.Text);
            //  int nuevotipopago = int.Parse(nuevotipopagotxt.Text);
            if (validaciontipo_p())
            {
                string modificar = "update socios SET tipo_p =  '" + nuevotipopagotxt.Text + "' WHERE tipo_p = '" + tipo_ptxt.Text + "' AND id = '" + idtxt.Text + "'";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("registro actulizado");
                        limpiatipop();
                        borrartipo_p();
                    }
                    else
                    {
                        MessageBox.Show("nesario poner numero de socio al cual hace el cambio");
                        MessageBox.Show("ó");
                        MessageBox.Show("error en sintaxis o es el mismo dato");

                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al actulizar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }else
            {
                MessageBox.Show("Falta Datos por llenar revisa");
            }
        }

        private void limpiaappel()
        {
            idtxt.Clear();
            apellidotxt.Clear();
            nuevoapellidotxt.Clear();
        }

        private void borrarapellido()
        {
            errorProvider1.SetError(apellidotxt, "");
            errorProvider1.SetError(idtxt, "");
            errorProvider1.SetError(nuevoapellidotxt, "");

        }
        private bool validationapell()
        {
            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "ingresa el numero socio actual");
            }
            if (apellidotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(apellidotxt, "Ingresa el actual apellido ");
            }
            if (nuevoapellidotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nuevoapellidotxt, "Ingresa el nuevo apellido o apellidos");
            }
            return ok;
        }
        private void APELLIDO_Click(object sender, EventArgs e)
        {  
           // int numerodesocioviejo = int.Parse(idtxt.Text);
           
            string viejonapellido = apellidotxt.Text;
            string nuevoapellido = nuevoapellidotxt.Text;

            if (validationapell())
            {


                string modificar = "update socios SET apellido =  '" + nuevoapellido + "' WHERE apellido = '" + viejonapellido + "' AND id = '" + idtxt.Text + "'";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("registro actulizado");
                        borrarapellido();
                        limpiaappel();
                        
                    }
                    else
                    {
                        MessageBox.Show("nesario poner numero de socio al cual hace el cambio");
                        MessageBox.Show("ó");
                        MessageBox.Show("error en sintaxis o es el mismo dato");


                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al actulizar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }else
            {
                MessageBox.Show("Falta algun campo por rellenar");
            }
        }
        private void limpiasexo()
        {
            idtxt.Clear();
            sexotxt.Clear();
            nuevosexotxt.Clear();
        }

        private void borrarsexo()
        {
            errorProvider1.SetError(sexotxt, "");
            errorProvider1.SetError(idtxt, "");
            errorProvider1.SetError(nuevosexotxt, "");

        }
        private bool validationsexo()
        {
            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "Ingresa el numero socio actual");
            }
            if (sexotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(sexotxt, "Ingresa el actual sexo del socio ");
            }
            if (nuevosexotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nuevosexotxt, "Ingresa el nuevo sexo del socio");
            }
            return ok;
        }
        private void actulizarsexo_Click(object sender, EventArgs e)
        {
           
          // int numerodesocioviejo = int.Parse(idtxt.Text);
            string viejosexo = sexotxt.Text;
            string nuevosexo = nuevosexotxt.Text;
            if (validationsexo())
            {


                string modificar = "update socios SET sexo =  '" + nuevosexo + "' WHERE sexo = '" + viejosexo + "' AND id = '" + idtxt.Text + "'";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("registro actulizado");
                        limpiasexo();
                        borrarsexo();
                    }
                    else
                    {
                        MessageBox.Show("nesario poner numero de socio al cual hace el cambio");
                        MessageBox.Show("ó");
                        MessageBox.Show("error en sintaxis o es el mismo dato");


                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al actulizar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }
            else
            {
                MessageBox.Show("Faltan Datos por Rellenar");
            }
        }

        private void limpiafecha_in()
        {
            idtxt.Clear();
            fecha_ingresotxtviejo.Clear();
            fecha_ingresonuevotxt.Clear();
        }

        private void borrarfecha_in()
        {
            errorProvider1.SetError(fecha_ingresonuevotxt, "");
            errorProvider1.SetError(idtxt, "");
            errorProvider1.SetError(fecha_ingresotxtviejo, "");

        }
        private bool validationfecha_in()
        {
            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "Ingresa el numero socio del actual");
            }
            if (fecha_ingresotxtviejo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(fecha_ingresotxtviejo, "Ingresa el actual fecha de ingreso del socio ");
            }
            if (fecha_ingresonuevotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(fecha_ingresonuevotxt, "Ingresa la nueva fecha ingreso del socio");
            }
            return ok;
        }
        private void actulizarfecha_ingreso_Click(object sender, EventArgs e)
        {

            // int numerodesocioviejo = int.Parse(idtxt.Text);
            string viejofecha = fecha_ingresotxtviejo.Text;
            string nuevofecha = fecha_ingresonuevotxt.Text;
            if (validationfecha_in())
            {
                string modificar = "update socios SET fecha_ingreso =  '" + nuevofecha + "' WHERE fecha_ingreso = '" + viejofecha + "' AND id = '" + idtxt.Text + "' ";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("registro actulizado");
                        limpiafecha_in();
                        borrarfecha_in();
                    }
                    else
                    {
                        MessageBox.Show("nesario poner numero de socio al cual hace el cambio");
                        MessageBox.Show("ó");
                        MessageBox.Show("error en sintaxis o es el mismo dato");

                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al actulizar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }

            }
            else
            {
                MessageBox.Show("Faltan Datos por Rellenar");
                
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

                MessageBox.Show("Error al mostrar" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }
        }

        private void modificar_Load(object sender, EventArgs e)
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

        private void REFRESCAR_Click(object sender, EventArgs e)
        {
            actulizar();
        }

        private void limpiaedad()
        {
            idtxt.Clear();
            viejoedadtxt.Clear();
            nuevoedadtxt.Clear();
        }

        private void borraredad()
        {
            errorProvider1.SetError(viejoedadtxt, "");
            errorProvider1.SetError(idtxt, "");
            errorProvider1.SetError(nuevoedadtxt, "");

        }
        private bool validationedad()
        {
            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "Ingresa el numero socio del actual");
            }
            if (nuevoedadtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nuevoedadtxt, "Ingresa la nueva edad del socio ! En numero ");
            }
            if (viejoedadtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(viejoedadtxt, "Ingresa la vieja edad del socio ! En numero");
            }
            return ok;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // int numerodesocioviejo = int.Parse(idtxt.Text);
            //   int viejoedad = int.Parse(viejoedadtxt.Text);
            // int nuevoedad = int.Parse(nuevoedadtxt.Text);
            if (validationedad())
            {
                string modificar = "update socios SET edad =  '" + nuevoedadtxt.Text + "' WHERE edad = '" + viejoedadtxt.Text + "' AND id = '" + idtxt.Text + "' ";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("registro actulizado");
                        limpiaedad();
                        borraredad();

                    }
                    else
                    {
                        MessageBox.Show("nesario poner numero de socio al cual hace el cambio");
                        MessageBox.Show("ó");
                        MessageBox.Show("error en sintaxis o es el mismo dato");

                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al actulizar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }else
            {
                MessageBox.Show("Faltan Datos por Rellenar");
            }
        }

        private void limpiavige()
        {
            idtxt.Clear();
            if(viejoestadoctx.Text == "FALLECIDO")
            {
                viejoestadoctx.Text = "NINGUNO";
            }
            else if(viejoestadoctx.Text == "VIGENTE")
            {
                viejoestadoctx.Text = "NINGUNO";
            }

            if(nuevovigenciactx.Text == "FALLECIDO")
            {
                nuevovigenciactx.Text = "NINGUNO";

            }else if(nuevovigenciactx.Text == "VIGENTE")
            {
                nuevovigenciactx.Text = "NINGUNO";
            }
        }

        private void borrarvigencia()
        {
            errorProvider1.SetError(viejoedadtxt, "");
            errorProvider1.SetError(nuevovigenciactx, "");
            errorProvider1.SetError(viejoestadoctx, "");

        }
        private bool validationvigencia()
        {
            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt, "Ingresa el numero socio del actual");
            }
            if (nuevovigenciactx.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nuevovigenciactx, "Ingresa la nueva estado del socio fallecida/vigente");
            }
            if (viejoestadoctx.Text == "")
            {
                ok = false;
                errorProvider1.SetError(viejoestadoctx, "Ingresa la estado del socio fallecida/vigente");
            }
            return ok;
        }
        private void actulizarvigencia_Click(object sender, EventArgs e)
        {

            // int numerodesocioviejo = int.Parse(idtxt.Text);
            string viejoestado = viejoestadoctx.Text;
            string nuevoestado = nuevovigenciactx.Text;
            if (validationvigencia())
            {


                string modificar = "update socios SET estado =  '" + nuevoestado + "' WHERE estado = '" + viejoestado + "' AND id = '" + idtxt.Text + "' ";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(modificar, conexionDB);

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("registro actulizado");
                        borrarvigencia();
                        limpiavige();
                    }
                    else
                    {
                        MessageBox.Show("nesario poner numero de socio al cual hace el cambio");
                        MessageBox.Show("ó");
                        MessageBox.Show("error en sintaxis o es el mismo dato");

                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al actulizar" + ex.Message);


                }
                finally
                {

                    conexionDB.Close();

                }
            }
            else
            {
                MessageBox.Show("Faltan Datos por Rellenar");
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

        private void nuevoidtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void idtxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(idtxt.Text, out num))
            {
                errorProvider1.SetError(idtxt, "Ingrese numero de socio actual");
            }
            else
            {
                errorProvider1.SetError(idtxt, "");

            }
        }

        private void nuevoidtxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(nuevoidtxt.Text, out num))
            {
                errorProvider1.SetError(nuevoidtxt, "Ingrese numero de socio nuevo");
            }
            else
            {
                errorProvider1.SetError(nuevoidtxt, "");

            }
        }

        private void viejonombretxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(viejonombretxt.Text, out num))
            {
                errorProvider1.SetError(viejonombretxt, "Ingrese nombre de socio actual");
            }
            else
            {
                errorProvider1.SetError(viejonombretxt, "");

            }
        }

        private void nuevonombretxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(nuevonombretxt.Text, out num))
            {
                errorProvider1.SetError(nuevonombretxt, "Ingrese nombre nuevo del socio");
            }
            else
            {
                errorProvider1.SetError(nuevonombretxt, "");

            }
        }

        private void tipo_ptxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nuevotipopagotxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void viejoedadtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nuevoedadtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void numerocasatxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nuevonuemerocasatxt_KeyPress(object sender, KeyPressEventArgs e)
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

        
    
