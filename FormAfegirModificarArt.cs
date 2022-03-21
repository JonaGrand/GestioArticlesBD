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
    public partial class FormAfegirModificarArt : Form
    {
        public FormAfegirModificarArt()
        {
            InitializeComponent();
        }

        private void FormAfegirModificarArt_Load(object sender, EventArgs e)
        {
            carregarArticles();
            carregarCategories();
            btnModificar.Enabled = false;
        }

        public void carregarArticles()
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

        public void carregarCategories()
        {
            //Netejo la capsa
            netejar();

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
                        if (cbxCategoria.Items.Contains(reader.GetString(5)))
                        {
                        }
                        else
                        {
                            //Si no esta, lo añade
                            cbxCategoria.Items.Add(reader.GetString(5));
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
                MessageBox.Show("Error: No s'ha pogut carregar " + ex);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public Boolean carregarArticle(String nom)
        {
            Boolean ok = false;
            MySqlDataReader reader = null;

            string select = "SELECT * FROM articles where nom like '" + nom + "';";
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
                        txbDescripcio.Text = reader.GetString(2);
                        txbPreu.Text = reader.GetDouble(3).ToString();
                        txbDescompte.Text = reader.GetInt32(4).ToString();
                        cbxCategoria.Text = reader.GetString(5);
                        txbStock.Text = reader.GetInt32(6).ToString();
                    }
                    //Si hay contenido devuelve true
                    ok = true;
                }
                else
                {
                    //Si no hay contenido devuelve false
                    ok = false;
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

            return ok;
        }

        private void cbxNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregarArticle(cbxNom.SelectedItem.ToString()))
            {
                btnModificar.Enabled = true;
                btnAfegir.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = false;
                btnAfegir.Enabled = true;
            }

        }

        private void btnNetjar_Click(object sender, EventArgs e)
        {
            netejar();
            btnModificar.Enabled = false;
            btnAfegir.Enabled = true;
        }

        private void netejar() {
            cbxNom.Text = "";
            txbDescripcio.Text = "";
            txbPreu.Text = "";
            txbDescompte.Text = "";
            cbxCategoria.Text = "";
            txbStock.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = cbxNom.Text;
                string nouNom = txbNouNom.Text;
                string descripcio = txbDescripcio.Text;
                double preu = Convert.ToDouble(txbPreu.Text);
                int descompte = Convert.ToInt32(txbDescompte.Text);
                string categoria = cbxCategoria.Text;
                int stock = Convert.ToInt32(txbStock.Text);
               
                if (!nom.Equals("") && !nouNom.Equals("") && !descripcio.Equals("") && !descompte.Equals("") && !categoria.Equals("") && !stock.Equals(""))
                {
                    string sql = "UPDATE articles SET nom = '" + nouNom + "', descripcio = '" + descripcio + "', preu = '" + preu + "', descompte = '" + descompte + "', caregoria = '" + categoria + "', stock = '" + stock + "' WHERE nom like '" + nom + "';";
                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Article moficat amb exit!!!");
                        netejar();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al modificar l'usuari: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Clone();
                    }
                }
                else
                {
                    MessageBox.Show("Cal completar totes les dades");
                }
            }
            catch (MySqlException fex)
            {
                MessageBox.Show(" Error: Problemes amb la connexió: " + fex.Message);
            }
        }

        private void btnAfegir_Click(object sender, EventArgs e)
        {
            try
            {
                string id = null;
                string nom = cbxNom.Text;
                string nouNom = txbNouNom.Text;
                string descripcio = txbDescripcio.Text;
                double preu = Convert.ToDouble(txbPreu.Text);
                int descompte = Convert.ToInt32(txbDescompte.Text);
                string categoria = cbxCategoria.Text;
                int stock = Convert.ToInt32(txbStock.Text);

                if (!nom.Equals("") && !descripcio.Equals("") && !descompte.Equals("") && !categoria.Equals("") && !stock.Equals(""))
                {
                    string sql = "INSERT INTO articles (nom, descripcio, preu, descompte, caregoria, stock) VALUES ('" + nom + "', '" + descripcio + "', '" + preu + "', '" + descompte + "', '" + categoria + "', '" + stock + "')";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuari Afegit!!!");
                        netejar();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al desar l'usuari: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Clone();
                    }
                }
                else
                {
                    MessageBox.Show("Cal completar totes les dades");
                }
            }
            catch (MySqlException fex)
            {
                MessageBox.Show(" Error: Problemes amb la connexió: " + fex.Message);
            }
            carregarArticles();
            carregarCategories();
        }
    }
}
