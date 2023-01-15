using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mutualsanjoseesposomaria
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //SANJOSE 
            //ESPOSODEMARIA
            if ((contrasenatxb.Text == "ESPOSODEMARIA") && (usuariotxb.Text == "SANJOSE"))
            {
                Form1 menuprincipal = new Form1();
                menuprincipal.Show();
                this.Hide();
                
            }   
            
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
                contrasenatxb.Text = "";
                usuariotxb.Text = "";
                return;
            }
        }
    }
}
