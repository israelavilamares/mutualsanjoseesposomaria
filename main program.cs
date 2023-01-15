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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void limpiar_Click(object sender, EventArgs e)
        {
            idtxt.Clear();
            nombretxt.Clear();
            apellidotxt.Clear();
            sexotxt.Clear();
            fecha_ingresotxt.Clear();
            ciudadtxt.Clear();
            calletxt.Clear();
            observacionestxb.Clear();
            telefonotxt.Clear();
            fecha_Ntxt.Clear();
            edadtxt.Clear();
            fecha_ingresotxt.Clear();
            coloniatxb.Clear();
            //estado de la persona
            if (estadoctx.Text == "FALLECIDO")
            {
                estadoctx.Text = "NINGUNO";
            }
            else if (estadoctx.Text == "VIGENTE")
            {
                estadoctx.Text = "NINGUNO";
            }
            
        }
        private bool Validacion()
        {
            bool ok = true;
            if (idtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(idtxt,"ingresa el numero de socio");
            }
            if (nombretxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nombretxt, "ingresa el nombre de socio");
            }
            if (apellidotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(apellidotxt, "ingresa el apellido de socio");
            }
            if (sexotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(sexotxt, "ingresa el sexo de socio");
            }
            if ((fecha_ingresotxt.Text == "") || fecha_ingresotxt.Text == "AAAA/MM/DD")
            {
                ok = false;
                errorProvider1.SetError(fecha_ingresotxt, "Ingresa La Fecha de Ingreso Del Socio");

            }
            if ((fecha_Ntxt.Text == "") || (fecha_Ntxt.Text == "AAAA/MM/DD") )
            {
                ok = false;
                errorProvider1.SetError(fecha_Ntxt, "ingresa la fecha de nacimiento de socio");
            }
            if (ciudadtxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(ciudadtxt, "ingresa la ciudad socio");
            }
            if (calletxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(calletxt, "Ingresa la calle");
            }
       
            if (observacionestxb.Text == "")
            {
                ok = false;
                errorProvider1.SetError(observacionestxb, "Ingresa el numero de casa");
            }
            if (telefonotxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(telefonotxt, "Ingresa el numero de telefono");
            }
            if (tipo_pctx.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tipo_pctx, "Ingresa el numero de segun el pago");
            }
            if (estadoctx.Text == "")
            {
                ok = false;
                errorProvider1.SetError(estadoctx, "ingresa el estado del socio");
            }
            if(coloniatxb.Text == "")
            {
                ok = false;
                errorProvider1.SetError(coloniatxb, "Ingresa El Colonia Del Socio");

            }
            return ok;
        }
        private void borrarerrores()
        {
            errorProvider1.SetError(idtxt,"");
            errorProvider1.SetError(nombretxt, "");
            errorProvider1.SetError(apellidotxt, "");
            errorProvider1.SetError(sexotxt, "");
            errorProvider1.SetError(fecha_Ntxt, "");
            errorProvider1.SetError(ciudadtxt, "");
            errorProvider1.SetError(calletxt, "");
          //  errorProvider1.SetError(edadtxt, "");
            errorProvider1.SetError(observacionestxb, "");
            errorProvider1.SetError(telefonotxt, "");
            errorProvider1.SetError(tipo_pctx, "");
            errorProvider1.SetError(estadoctx, "");
            errorProvider1.SetError(coloniatxb, "");

        }



        private void agregar_Click(object sender, EventArgs e)
        {
         if (Validacion())
         {
                string obser = observacionestxb.Text;
         // int numero_socio = int.Parse(idtxt.Text);                       
            string nombre_socio = nombretxt.Text.ToUpper();
            string apellido_socio = apellidotxt.Text.ToUpper();
            string sexo_socio = sexotxt.Text.ToUpper();

            //conversion
            //string formato;
            string nueva = fecha_ingresotxt.Text;
            //string nueva = fecha.ToString("yyyy/MM/dd hh:mm:ss");
            //mostrar en texbox
            //fecha de nacimiento
            string fecha_naciemnto = fecha_Ntxt.Text;

        
          //  obtfechact - Convert.ToDateTime(fecha_Ntxt);

            string ciudad_socio = ciudadtxt.Text.ToUpper();
            string calle_socio = calletxt.Text.ToUpper();
            string estado = estadoctx.Text;
            string colonia = coloniatxb.Text;

                
                
            DateTime obtfechact = DateTime.Now;
                try
                {
                    DateTime fechanac = DateTime.Parse(fecha_naciemnto);
                    TimeSpan diferencia = obtfechact - fechanac;
                    double dias = diferencia.TotalDays;
                    double edad = Math.Floor(dias / 365);
                    edadtxt.Text = Convert.ToString(edad);
                }
                catch
                {
                    MessageBox.Show("Esta Mal Revisa el formato  de fecha");
                    return;
                }
        


                string sql = "INSERT INTO mutualsanjose.socios(id,nombre,apellido,sexo,fecha_ingreso,ciudad,calle,numero,tipo_p,telefono,edad,fecha_naciento,estado,colonia,observaciones)VALUES('" + idtxt.Text + "','" + nombre_socio + "','" + apellido_socio + "','" + sexo_socio + "','" + nueva + "','" + ciudad_socio + "','" + calle_socio + "','" + tipo_pctx.Text + "','" + telefonotxt.Text + "','" + edadtxt.Text + "','" + fecha_naciemnto + "','" + estado + "','" + colonia + "','"+ obser +"')";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        borrarerrores();
                        
                        MessageBox.Show("registro guardado!!");
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
        private void pAHOSUNICOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagosunicos PU = new pagosunicos();

            PU.Show();
        }

        private void pAGOSNORMALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagos_normal PN = new pagos_normal();
            PN.Show();
        }

     

        private void pAGOSPARCIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagoparcial PP = new pagoparcial();
            PP.Show();
        }

        private void tODOSLOSPAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todosocios TS = new todosocios();
            TS.Show();
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminar delete = new eliminar();
            delete.Show();
        }

        private void aCTULIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificar UP = new modificar();
            UP.Show();
        }

        private void fecha_ingresotxt_Leave(object sender, EventArgs e)
        {
            if(fecha_ingresotxt.Text == "")
            {
                fecha_ingresotxt.Text = "AAAA/MM/DD";
                fecha_ingresotxt.ForeColor = Color.Gray;
            }
        }

        private void fecha_ingresotxt_Enter(object sender, EventArgs e)
        {
            if(fecha_ingresotxt.Text == "AAAA/MM/DD")
            {
                fecha_ingresotxt.Text = "";
                fecha_ingresotxt.ForeColor = Color.Black;
            }
        }

        private void pAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagos P =  new pagos();
            P.Show();
        }

        private void fecha_Ntxt_Enter(object sender, EventArgs e)
        {
            if(fecha_Ntxt.Text == "AAAA/MM/DD" )
            {
                fecha_Ntxt.Text = "";
                fecha_Ntxt.ForeColor = Color.Black;
            }
        }

        private void fecha_Ntxt_Leave(object sender, EventArgs e)
        {
            if (fecha_Ntxt.Text == "")
            {
                fecha_Ntxt.Text = "AAAA/MM/DD";
                fecha_Ntxt.ForeColor = Color.Black;
            }
        }

        private void bENEFICIARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beneficiarios benf = new beneficiarios();
            benf.Show();
        }

        

        private void idtxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if(!int.TryParse(idtxt.Text,out num))
            {
                errorProvider1.SetError(idtxt, "Ingrese numero de socio");
            }else
            {
                errorProvider1.SetError(idtxt,"");

            }
        }

      

        

        private void telefonotxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(telefonotxt.Text, out num))
            {
                errorProvider1.SetError(telefonotxt, "Ingrese numero de telefono");
            }
            else
            {
                errorProvider1.SetError(telefonotxt, "");

            }
        }

        private void fecha_Ntxt_Validating(object sender, CancelEventArgs e)
        {
            DateTime fecha_Nac;
            if (!DateTime.TryParse(fecha_Ntxt.Text, out fecha_Nac))
            {
                errorProvider1.SetError(fecha_Ntxt, "El formato es: AAAA/MM/DD");
            }
            else
            {
                errorProvider1.SetError(fecha_Ntxt, "");

            }
        }

        private void idtxt_Validated(object sender, EventArgs e)
        {
            if(idtxt.Text.Trim() == "")
            {
                errorProvider1.SetError(idtxt,"Introduce un numero");
                idtxt.Focus();
            }else
            {
                errorProvider1.Clear();
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

      
        private void numero_casatxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void telefonotxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Application.Exit();
        }

     
    }
}

