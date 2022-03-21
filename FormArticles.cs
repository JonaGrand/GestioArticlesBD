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

namespace GestioArticlesBD {

    public partial class FormArticles : Form
    {

        public FormArticles()
        {
            InitializeComponent(); 
        }

        private void FormArticles_Load(object sender, EventArgs e)
        {
            carregarNoms();
            carregarTipus();
            comprobarStock();
        }

        public void carregarTipus()
        {
            //Netejo la capsa
            neteja();

            MySqlDataReader reader = null;

            string select = "SELECT * FROM articles;";
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
                        if (cbxTipus.Items.Contains(reader.GetString(5)))
                        {
                        }
                        else {
                            //Si no esta, lo añade
                            cbxTipus.Items.Add(reader.GetString(5));
                        }   
                    }
                }
                else
                {
                    MessageBox.Show("No s'han pogut trobar tipus");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: No s'ha pogut carregar " +ex);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        public void carregarNoms()
        {
            MySqlDataReader reader = null;

            string select = "SELECT nom FROM articles;";
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
                        cbxNom.Items.Add(reader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("No s'han pogut trobar articles");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nom = cbxNom.Text;
            MessageBox.Show(cbxNom.Text);

            if (!nom.Equals(""))
            {
                string select = "DELETE  FROM articles WHERE nom LIKE '" + nom + "';";
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(select, conexionBD);
                    comando.ExecuteNonQuery();

                    txbResul.Text = "Article eliminat amb exit";
                    MessageBox.Show("Article eliminat amb exit");

                }
                catch (MySqlException ex)
                {
                    txbResul.Text = "Error: No s'ha pogut eliminar l'article";
                    MessageBox.Show("Error: No s'ha pogut eliminar l'article" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }

            }
        }

        private void btnCercar_Click(object sender, EventArgs e)
        {
            string nom = cbxNom.Text;

            MySqlDataReader reader = null;

            if (!nom.Equals(""))
            {
                string select = "SELECT * FROM articles WHERE nom LIKE '" + nom + "';";
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
                            txbResul.Text = reader.GetInt32(0).ToString() + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetDouble(3).ToString() + " - " + reader.GetInt32(4).ToString() + " - " + reader.GetString(5) + " - " + reader.GetInt32(6).ToString() + "\n\r";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No s'ha trobat cap aricle amb el nom: " + nom);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: No s'ha pogut cercar l'article. " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
            else {
                MessageBox.Show("Has d'introduir un nom per cercar l'article");
            }

        }

        private void btnTots_Click(object sender, EventArgs e)
        {
            //Netejo la capsa
            neteja();

            MySqlDataReader reader = null;

            string select = "SELECT * FROM articles where stock >0;";
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
                        txbResul.Text = txbResul.Text + "\n\r" + reader.GetInt32(0).ToString() + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetDouble(3).ToString() + " - " + reader.GetInt32(4).ToString() + " - " + reader.GetString(5) + " - " + reader.GetInt32(6).ToString() + "\n\r";
                    }
                }
                else
                {
                    MessageBox.Show("No hi ha cap articles");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: No s'ha pogut cerca l'article " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnNetejar_Click(object sender, EventArgs e)
        {
            neteja();
        }

        private void neteja()
        {
            cbxNom.Text = "";
            txbResul.Text = "";
        }

        private void btnTornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAfegirModificar_Click(object sender, EventArgs e)
        {
            FormAfegirModificarArt famArt = new FormAfegirModificarArt();
            famArt.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            neteja();
            mostrarArticulosTipo(cbxTipus.SelectedItem.ToString()) ;
        }

        private void mostrarArticulosTipo(String categoria) {
            MySqlDataReader reader = null;

            if (!categoria.Equals(""))
            {
                string select = "SELECT * FROM articles WHERE caregoria LIKE '" + categoria + "';";
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
                            txbResul.Text = txbResul.Text + "\n\r" + reader.GetInt32(0).ToString() + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetDouble(3).ToString() + " - " + reader.GetInt32(4).ToString() + " - " + reader.GetString(5) + " - " + reader.GetInt32(6).ToString() + "\n\r";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No s'ha trobat cap usuari amb la categoria:  " + categoria);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: No s'ha pogut trobar cap usuari" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }

            }
        }

        private void comprobarStock() {

            String noms = "";
            MySqlDataReader reader = null;

            string select = "SELECT * FROM articles WHERE stock <=  0;";
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
                        noms = noms + "\n\r" +reader.GetString(1) + "\n\r";
                    }
                    MessageBox.Show("Stock inferior insuficiente de los siguientes articulos: " + "\n\r" +noms);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: No s'ha pogut trobar cap usuari" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        private void btnArticlesOferta_Click(object sender, EventArgs e)
        {
            neteja();
            MySqlDataReader reader = null;

            string select = "SELECT * FROM articles WHERE descompte != 0 and stock > 0;";
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
                        txbResul.Text = txbResul.Text + "\n\r" + reader.GetInt32(0).ToString() + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetDouble(3).ToString() + " - " + reader.GetInt32(4).ToString() + " - " + reader.GetString(5) + " - " + reader.GetInt32(6).ToString() + "\n\r";
                    }
                }
                else
                {
                    MessageBox.Show("No s'ha trobat cap usuari amb descmpte");
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormAfegirStock fas = new FormAfegirStock();
            fas.Show();
        }
    }
    
}
