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

namespace interfaz_del_usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sesion()
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=interfaz";
            string query = "select * from registros where usuario = '" + userTxtBox.Text + "' AND password = '" + pswTxtBox.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("BIENVENIDO A LA SPIDERCUEVA");
                }
                else
                {
                    MessageBox.Show("ACCESO DENEGADO");
                }
             
           
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void userTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGINBTN_Click(object sender, EventArgs e)
        {
            sesion();
        }

        private void REGISTERBTN_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2();
            register.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
// boton registrar no me funciona