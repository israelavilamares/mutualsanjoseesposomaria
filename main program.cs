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
            ciudadtxt.Clear();
            calletxt.Clear();
            observacionestxb.Clear();
            telefonotxt.Clear();
            
            edadtxt.Clear();
            
            coloniatxb.Clear();
            //estado de la persona
            if(orgarbox1.Text != "")
            {
                orgarbox1.Text = "";
            }
            if (organbox2.Text != "")
            {
                organbox2.Text = "";
            }
            if (orgabox3.Text != "")
            {
                orgabox3.Text = "";

            }
            if (comboxfeN1.Text != "")
            {
                comboxfeN1.Text = "";
            }
            if (comboxfeN2.Text != "")
            {
                comboxfeN2.Text = "";
            }
            if (comboxfeN3.Text != "")
            {
                comboxfeN3.Text = "";
            }

            if (estadoctx.Text == "FALLECIDO")
            {
                estadoctx.Text = "NINGUNO";
            }
            else if (estadoctx.Text == "VIGENTE")
            {
                estadoctx.Text = "NINGUNO";
            }
            if(tipo_pctx.Text != "")
            {
                tipo_pctx.Text = "";
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
            if (orgarbox1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(orgarbox1, "ingresa el Año de Ingreso");

            }
            if (organbox2.Text == "")
            {
                ok = false;
                errorProvider1.SetError(organbox2, "ingresa la el Mes de ingreso");               
            }
            if (orgabox3.Text == "")
            {
                ok = false;
                errorProvider1.SetError(orgabox3, "ingresa la el Dia de ingreso");

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
            if(comboxfeN1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboxfeN1, "Ingresa El Año De Nacimiento Socio");

            }
            if (comboxfeN2.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboxfeN2, "Ingresa El Mes De Nacimiento Socio");

            }
            if (comboxfeN3.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboxfeN3, "Ingresa El Dia De Nacimiento Socio");

            }
            return ok;
        }
        private void borrarerrores()
        {
            errorProvider1.SetError(idtxt,"");
            errorProvider1.SetError(nombretxt, "");
            errorProvider1.SetError(apellidotxt, "");
            errorProvider1.SetError(sexotxt, "");
            errorProvider1.SetError(ciudadtxt, "");
            errorProvider1.SetError(calletxt, "");
          //  errorProvider1.SetError(edadtxt, "");
         
            errorProvider1.SetError(telefonotxt, "");
            //tipo de pago
            errorProvider1.SetError(tipo_pctx, "");
            errorProvider1.SetError(estadoctx, "");
            errorProvider1.SetError(coloniatxb, "");
            //estos son los combox de Año/Mes/Dia
            errorProvider1.SetError(orgabox3, "");
            errorProvider1.SetError(organbox2, "");
            errorProvider1.SetError(orgarbox1, "");

        }



        private void agregar_Click(object sender, EventArgs e)
        {
         if (Validacion())
         {
            string nombre_socio = nombretxt.Text.ToUpper();
            string apellido_socio = apellidotxt.Text.ToUpper();
            string sexo_socio = sexotxt.Text.ToUpper();

                //conversion
                //string formato;
                //este es el acomodo de los combox de
                //la  fecha de ingreso
                string acomdo = orgarbox1.Text+"/"+organbox2.Text+"/"+orgabox3.Text;
                //se pasa a otra variable que esta en
                //la sentecia sql de insert
                string nueva = acomdo;
                


                //el acomodo de la fecha de nacimiento
                //siguientes combox
                //manera dd/MM/yyyy
                //para que tenga erres 
             string acomodofechaNac = comboxfeN1.Text+"/"+comboxfeN2.Text+"/"+comboxfeN3.Text;
                //fecha de nacimiento
            string fecha_naciemnto = acomodofechaNac;
                    

            string ciudad_socio = ciudadtxt.Text.ToUpper();
            string calle_socio = calletxt.Text.ToUpper();
            string estado = estadoctx.Text;
            string colonia = coloniatxb.Text;               
                
                //atrapar los errores y convierte a la edad
                //con  solo la fecha de nacimineto
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
        

                //sentencia sql para incertar
                string sql = "INSERT INTO mutualsanjose.socios(id,nombre,apellido,sexo,fecha_ingreso,ciudad,calle,tipo_p,telefono,edad,fecha_naciento,estado,colonia,observaciones)VALUES('" + idtxt.Text + "','" + nombre_socio + "','" + apellido_socio + "','" + sexo_socio + "','" + nueva + "','" + ciudad_socio + "','" + calle_socio + "','" + tipo_pctx.Text + "','" + telefonotxt.Text + "','" + edadtxt.Text + "','" + fecha_naciemnto + "','" + estado + "','" + colonia + "','"+ observacionestxb.Text + "')";
                //establecemos la conexion 
                MySqlConnection conexionDB = Conexion.conexion();
                //abrimos la conexion 
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

        
        

        private void pAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagos P =  new pagos();
            P.Show();
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

