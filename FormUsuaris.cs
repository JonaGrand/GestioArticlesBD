using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace GestioArticlesBD
{
    public partial class FormUsuaris : Form
    {
        public FormUsuaris()
        {
            InitializeComponent();
        }

        private void FormUsuaris_Load(object sender, EventArgs e)
        {
            carregarNoms();
        }

        private void btnCercar_Click(object sender, EventArgs e)
        {

            string nom = cbxNom.Text;
            
            MySqlDataReader reader = null;

            if (!nom.Equals(""))
            {
                string select = "SELECT * FROM usuaris WHERE nom LIKE '" + nom + "';";
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
                            txbResul.Text = txbResul.Text + "\n\r" + reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + "\n\r";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No s'ha trobat cap usuari amb el nom: " + nom);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: No s'ha pogut cercar l'usuari " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }

            }
        }

        private void btnTornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void neteja() 
        {
            cbxNom.Text = "";
            txbResul.Text = "";
        }

        private void btnNetejar_Click(object sender, EventArgs e)
        {
            neteja();
        }

        private void btnAfegirModificar_Click(object sender, EventArgs e)
        {
            FormAfegirModificar fam = new FormAfegirModificar();
            fam.Show();
        }

        private void btnTots_Click(object sender, EventArgs e)
        {
            //Netejo la capsa
            neteja();

            MySqlDataReader reader = null;

            string select = "SELECT * FROM usuaris;";
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
                        txbResul.Text = txbResul.Text + "\n\r" + reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + "\n\r";
                    }
                }
                else
                {
                    MessageBox.Show("No hi ha usuaris");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: No s'ha pogut cercar l'usuari " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }
        public void carregarNoms()
        {
            cbxNom.Items.Clear();
            MySqlDataReader reader = null;

            string select = "SELECT nom FROM usuaris;";
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
                    MessageBox.Show("No s'han pogut trobar noms d'usuari");
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
            //Netejo la capsa
            neteja();

            string nom = cbxNom.Text;

            if (!nom.Equals(""))
            {
                string select = "DELETE  FROM users WHERE nom LIKE '" + nom + "';";
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(select, conexionBD);
                    comando.ExecuteNonQuery();

                    txbResul.Text = "Usuario eliminado con exito";

                }
                catch (MySqlException ex)
                {
                    txbResul.Text = "Error: No s'ha pogut eliminar l'usuari";
                    MessageBox.Show("Error: No s'ha pogut eliminar l'usuari " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }

            }
        }
    }
}
