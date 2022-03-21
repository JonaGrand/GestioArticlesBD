using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioArticlesBD
{
    public partial class FormAfegirStock : Form
    {
        public FormAfegirStock()
        {
            InitializeComponent();
        }

        private void FormAfegirStock_Load(object sender, EventArgs e)
        {
            carregarArticlesSenseStock();
        }

        private void btnAfegir_Click(object sender, EventArgs e)
        {
            String nomArticle = cbxNomArticle.SelectedItem.ToString();
            int stock = Int32.Parse(txbUnitats.Text);
            MessageBox.Show(nomArticle + "  " +stock );

            string select = "UPDATE articles SET stock = " + stock + " WHERE nom like '" + nomArticle + "';";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(select, conexionBD);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: No s'ha pogut trobar" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void carregarArticlesSenseStock()
        {
            MySqlDataReader reader = null;

            string select = "SELECT nom FROM articles where stock <= 0;";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(select, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows) //Si reader encuentra algo
                {
                    while (reader.Read())//Leer lineas
                    {
                        //Si no esta, lo añade
                        cbxNomArticle.Items.Add(reader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("No s'han pogut trobar tipus");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: No s'ha pogut carregar " + ex);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
