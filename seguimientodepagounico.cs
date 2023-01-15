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
    public partial class seguimientodepagounico : Form
    {
        

        public seguimientodepagounico()
        {
            InitializeComponent();
        }
        private void actulizar()
        {
            DataTable datatable = new DataTable();
         
            string query = "SELECT pagosunico.idsociopu as numero_socio,socios.apellido , socios.nombre,idpagounico as numero_folio_socio,pagosunico.pago1 AS ABONO ,pagosunico.pagoresultado AS IMPORTE, NOMBREquinfac AS quien_facturo ,pagosunico.fecha,pagosunico.observaciones   FROM pagosunico JOIN pagos ON pagosunico.idsociopu = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id";
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

        private void borrarpago()
        {
            errorProvider1.SetError(numerodefacturatxt, "");
            errorProvider1.SetError(idpagounico, "");
            errorProvider1.SetError(abonotxt, "");
            errorProvider1.SetError(nombrequinfacturatxt, "");

        }
        private bool validationprimerpago()
        {
            bool ok = true;
        if (numerodefacturatxt.Text == "")
        {
            ok = false;
            errorProvider1.SetError(numerodefacturatxt, "Ingresa el numero de Factura");
        }
        else if(numerodefacturatxt.Text == "NUMERO FACTURA")
        {
                ok = false;
                errorProvider1.SetError(numerodefacturatxt, "Ingresa el numero de Factura");
        }
        if (idpagounico.Text == "")
        {
             ok = false;
            errorProvider1.SetError(idpagounico, "ingresa el nombre del socio");

        }
        else if(idpagounico.Text == "NUMERO DEL SOCIO")
        {
                ok = false;
                errorProvider1.SetError(idpagounico, "Ingresa el Numero del socio");

        }

        if (abonotxt.Text == "")
        {
            ok = false;
            errorProvider1.SetError(abonotxt, "Ingresa el abono que va dar el socio");

        }
        if(nombrequinfacturatxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nombrequinfacturatxt, "Ingresa el nombre Quien Factura");

            }
            else if(nombrequinfacturatxt.Text == "NOMBRE QUIEN FACTURA")
            {
                ok = false;
                errorProvider1.SetError(nombrequinfacturatxt, "Ingresa el nombre Quien Factura");

            }


            return ok;

        }
        private void miperimerpago_Click(object sender, EventArgs e)
        {
            if (validationprimerpago())
            {

                int folio = int.Parse(numerodefacturatxt.Text);


                int numero_socio = int.Parse(idpagounico.Text);
                
                DateTime fecha = DateTime.Now;
                //conversion
                string nueva = fecha.ToString("yyyy/MM/dd hh:mm:ss");
                //mostrar en texbox
                fechatxt.Text = nueva;

                double abono = double.Parse(abonotxt.Text);
                double ultimoabono = double.Parse(ultimoabonotxt.Text);
                //aqui esta diciendo que meter un dato y lo pide
                //obligatoriamente
                //double importeunico = double.Parse(importetxt.Text);
                double importeunico;
                //declaramos una varible inicializada en 0
                double resultado = 0;
                //sumamos abono y ultimo abono
                //el resultado lo ponemos en la variable 'resultado'
                resultado = abono + ultimoabono;
                //en la base de datos importeunico
                //va hacer resultado
                importeunico = resultado;
                //para mostrarlo en el texbox la suma
                //la convertimos a string por el campo solo acepta 
                //texto
                string observaciones = observacionestxt.Text;
                importetxt.Text = Convert.ToString(resultado);
                string nombreqf = nombrequinfacturatxt.Text;
                string sql = "INSERT INTO mutualsanjose.pagosunico VALUES( '" + folio + " ','" + numero_socio + "','" + abono + "','" + nueva + "','" + ultimoabono + "','" + importeunico + "','" + nombreqf + "','" + observaciones + "')";

                MySqlConnection conexionDB = Conexion.conexion();
                conexionDB.Open();

                try
                {

                    MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                    if (comando.ExecuteNonQuery() == 1)
                    {


                        MessageBox.Show("pagado!!");
                        limpia();
                        borrarpago();

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
                MessageBox.Show("Faltan de Rellenar Campos obligatorios","Error!");
            }
        }

        private void numerodefacturatxt_Enter(object sender, EventArgs e)
        {
            if (numerodefacturatxt.Text == "NUMERO FACTURA")
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

        private void idpagonormal_Enter(object sender, EventArgs e)
        {
            if (idpagounico.Text == "NUMERO DEL SOCIO")
            {
              idpagounico.Text = "";
              idpagounico.ForeColor = Color.Black;

            }
        }

        private void idpagonormal_Leave(object sender, EventArgs e)
        {
            if (idpagounico.Text == "")
            {
                idpagounico.Text = "NUMERO DEL SOCIO";
                idpagounico.ForeColor = Color.Gray;
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

        private void importetxt_Enter(object sender, EventArgs e)
        {
            if (importetxt.Text == "IMPORTE")
            {   
                importetxt.Text = "";
                importetxt.ForeColor = Color.Black;

            }
        }

        private void importetxt_Leave(object sender, EventArgs e)
        {
            if (importetxt.Text == "")
                
                importetxt.Text = "IMPORTE";
                importetxt.ForeColor = Color.Gray;

            }
        private void borrarpagounicoeliminar()
        {
            errorProvider1.SetError(numerosocioeliminartxt, "");
           
        }
        private bool validationeliminarpu()
        {
            bool ok = true;
            if (numerosocioeliminartxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(numerosocioeliminartxt, "Ingresa el numero de Socio Que Quiere Eliminar");
            }
            else if (numerosocioeliminartxt.Text == "NUMERO DEL SOCIO")
            {
                ok = false;
                errorProvider1.SetError(numerosocioeliminartxt, "Ingresa el numero de Socio Que Quiere Eliminar");
            }           
            return ok;

        }
        private void limpiaelpu()
        {
            numerosocioeliminartxt.Clear();
        }

        private void eliminarnumerosociobutton_Click(object sender, EventArgs e)
        {
            if (validationeliminarpu())
            {
                int vdelete = int.Parse(numerosocioeliminartxt.Text);
                DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string borrar = "DELETE FROM pagosunico WHERE idsociopu  = '" + vdelete + "'";



                    MySqlConnection conexionDB = Conexion.conexion();
                    conexionDB.Open();
                    try
                    {


                        MySqlCommand comando = new MySqlCommand(borrar, conexionDB);

                        comando.ExecuteNonQuery();
                        borrarpagounicoeliminar();
                        limpiaelpu();
                        
                        MessageBox.Show("ELIMINACION CON EXITO");
                        MessageBox.Show("¡ESTA VACIO! o ¡NO EXISTE!");

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
                MessageBox.Show("Faltan de Rellenar Datos ","Error¡");
            }
        }
        private void borrarpagounicoeliminarfact()
        {
            errorProvider1.SetError(eliminarnumerofacturatxt, "");

        }
        private bool validationeliminarpufact()
        {
            bool ok = true;
            if (eliminarnumerofacturatxt.Text == "")
            {
                ok = false;
                errorProvider1.SetError(eliminarnumerofacturatxt, "Ingresa el numero de factura Que Quiere Eliminar");
            }
            else if (eliminarnumerofacturatxt.Text == "NUMERO FACTURA")
            {
                ok = false;
                errorProvider1.SetError(eliminarnumerofacturatxt, "Ingresa el numero de factura Que Quiere Eliminar");
            }
            return ok;

        }
        private void limpiaelpufact()
        {
            eliminarnumerofacturatxt.Clear();
        }

        private void eliminanumerofacturabutton_Click(object sender, EventArgs e)
        {
            if (validationeliminarpufact())
            {
                int vdelete = int.Parse(eliminarnumerofacturatxt.Text);
                DialogResult dialogResult = MessageBox.Show("estas seguro", "eliminacion de socio", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string borrar = "DELETE FROM pagosunico WHERE idpagounico  = '" + vdelete + "'";



                    MySqlConnection conexionDB = Conexion.conexion();
                    conexionDB.Open();
                    try
                    {


                        MySqlCommand comando = new MySqlCommand(borrar, conexionDB);

                        comando.ExecuteNonQuery();
                        

                            MessageBox.Show("ELIMINACION CON EXITO");

                        
                        
                            MessageBox.Show("¡ESTA VACIO! o ¡NO EXISTE!");
                        limpiaelpufact();
                        borrarpagounicoeliminarfact();
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
                MessageBox.Show("Faltan Datos Para Continuar","!Error¡");
            }
        }

        private void BUSCARABONO_Click(object sender, EventArgs e)
        {
           string numerosocio = buscatxt.Text;

           

            MySqlDataReader reader = null;

            string sql = "select pagoresultado from pagosunico WHERE idsociopu = '" + numerosocio + "' ORDER BY idpagounico DESC LIMIT 1";
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
                        ultimoabonotxt.Text = reader.GetString(0);
                    }

                }else
                {
                    MessageBox.Show("no se encontraron registros");
                }
            }
            catch( MySqlException ex)
            {



                MessageBox.Show("Error al ELIMINAR" + ex.Message);


            }
            finally
            {

                conexionDB.Close();

            }

        }
        private void seguimientodepagounico_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            
            string query = "SELECT pagosunico.idsociopu as numero_socio,socios.apellido , socios.nombre,idpagounico as numero_folio_socio,pagosunico.pago1 AS ABONO, pagoresultado AS IMPORTE,NOMBREquinfac AS quien_facturo,pagosunico.fecha,pagosunico.observaciones   FROM pagosunico JOIN pagos ON pagosunico.idsociopu = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id";
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

        private void limpia()
        {
            
            idpagounico.Clear();
            fechatxt.Clear();
            abonotxt.Clear();
            ultimoabonotxt.Clear();
            buscatxt.Clear();
            importetxt.Clear();
            observacionestxt.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            actulizar();
        }

        private void ultimoabonotxt_TextChanged(object sender, EventArgs e)
        {
            if(ultimoabonotxt.Text == "")
            {
                ultimoabonotxt.Text = "0";
            }
        }

        private void nombrequinfacturatxt_Enter(object sender, EventArgs e)
        {
            if(nombrequinfacturatxt.Text == "NOMBRE QUIEN FACTURA")
            {
                nombrequinfacturatxt.Text = "";
                nombrequinfacturatxt.ForeColor = Color.Black;
            }
        }

        private void nombrequinfacturatxt_Leave(object sender, EventArgs e)
        {
            if (nombrequinfacturatxt.Text == "")
            {
                nombrequinfacturatxt.Text = "NOMBRE QUIEN FACTURA";
                nombrequinfacturatxt.ForeColor = Color.Gray;
            }
        }

        private void idpagounico_KeyPress(object sender, KeyPressEventArgs e)
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

        private void abonotxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buscatxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void contar_Click(object sender, EventArgs e)
        {
            int menos = 1;
            int contar = dataGridView1.RowCount - menos;
            contartputxt.Text = contar.ToString();
        }

        private void apellidotxbPU_TextChanged(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();

            string query = "SELECT pagosunico.idsociopu as numero_socio,socios.apellido , socios.nombre,idpagounico as numero_folio_socio,pagosunico.pago1 AS ABONO ,pagosunico.pagoresultado AS IMPORTE, NOMBREquinfac AS quien_facturo ,pagosunico.fecha,pagosunico.observaciones   FROM pagosunico JOIN pagos ON pagosunico.idsociopu = pagos.idpagos JOIN socios ON pagos.idpagos = socios.id WHERE socios.apellido LIKE '%"+ apellidotxbPU.Text  +"%' ";
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
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;
                    excel.Cells[indicerows + 1, indiceColumna] = fila.Cells[col.Name].Value;
                }

            }
            excel.Visible = true;
        }
        private void exportpu_Click(object sender, EventArgs e)
        {
            expotarexel(dataGridView1);
        }
    }
}

      

       




