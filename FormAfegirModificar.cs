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
    public partial class FormAfegirModificar : Form
    {
        string[] tipus_Usuari = { "Admin", "User" };
        Cifrado cifrado = new Cifrado();

        public FormAfegirModificar()
        {
            InitializeComponent();
        }

        private void btnTornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarTipo()
        {
            for (int i = 0; i < tipus_Usuari.Length; i++)
            {
                cbxTipusUsuari.Items.Add(tipus_Usuari[i]);
            }
        }


        private void Registre_Load(object sender, EventArgs e)
        {
            carregarNoms();
            cargarTipo(); //Carreguem les dades al comboBox tipusUsuari
            btnModificar.Enabled = false;
        }

        private void comprobarbtn()
        {
            
            if (!cbxNom.Text.Equals("") && !txbContra1.Text.Equals("") && !txbContra2.Text.Equals("") && !cbxTipusUsuari.Text.ToString().Equals(""))
            {
                btnAfegir.Enabled = true; //Mostrem el boto iniciar sessio
                btnModificar.Enabled = true;
            }
            else
            {

                btnAfegir.Enabled = false;
                btnModificar.Enabled = true;
            }
        }

        public Boolean comprobarUsuari(String nom)
        {
            Boolean ok = false;
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
                        ok = true;  
                    }
                    else
                    {
                        MessageBox.Show("No s'ha trobat cap usuari amb el nom: " + nom);
                        ok = false;
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
            return ok;
        }

        private void neteja()
        {
            cbxNom.Text = "";
            txbNouNom.Text = "";
            txbContra1.Text = "";
            txbContra2.Text = "";
            cbxTipusUsuari.Text = "";

        }

        private void btnNetjar_Click(object sender, EventArgs e)
        {
            neteja();
            btnAfegir.Enabled = true;
            btnModificar.Enabled = false;
        }

        private Boolean control()
        {
            Boolean ok = true;
            if (cbxNom.Text.Equals(""))
            {
                errorProvider1.SetError(cbxNom, "Has d'indicar un nom");
                ok = false;
            }
            if (txbContra1.Text.Equals(""))
            {
                errorProvider1.SetError(txbContra1, "Has d'omplir la contrasenya");
                ok = false;
            }
            if (txbContra2.Text.Equals(""))
            {
                errorProvider1.SetError(txbContra2, "Has d'omplir la contrasenya");
                ok = false;
            }
            if (!txbContra1.Text.Equals(txbContra2)) {
                errorProvider1.SetError(txbContra2, "Les dos contrasenyes han de ser iguals");
                ok = false;
            }
            if (cbxTipusUsuari.Text.Equals("")) {
                errorProvider1.SetError(cbxTipusUsuari, "Has d'indicar el tipus d'usuari");
                ok = false;
            }

            return ok;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = cbxNom.Text;
                string contra1 = txbContra1.Text;
                string contra2 = txbContra2.Text;
                string tipusUsuari = cbxTipusUsuari.Text.ToString();


                if (!nom.Equals("") && !contra1.Equals("") && !contra2.Equals("") && !tipusUsuari.Equals(""))
                {
                    if (contra1.Equals(contra2))
                    {
                        string sql = "INSERT INTO usuaris (nom, contra, tipus) VALUES ('" + nom + "', '" + cifrado.cifrar(contra1) + "', '" + tipusUsuari + "')";

                        MySqlConnection conexionBD = Conexion.conexion();
                        conexionBD.Open();

                        try
                        {
                            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Usuari Afegit!!!");
                            neteja();
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
                    else {
                        MessageBox.Show("Les dos contrasenyes han de ser iguals");
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

            //Tornem a carregar els noms
            carregarNoms();
        }

        private void txbNom_TextChanged(object sender, EventArgs e)
        {
            comprobarbtn();
        }


        private void cbxTipusUsuari_SelectedIndexChanged(object sender, EventArgs e)
        {
            comprobarbtn();
        }

        private void txbContra1_TextChanged(object sender, EventArgs e)
        {
            comprobarbtn();
        }

        private void txbContra2_TextChanged(object sender, EventArgs e)
        {
            comprobarbtn();
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

        public Boolean carregarUsuari(String nom)
        {
            Boolean ok = false;
            MySqlDataReader reader = null;

            string select = "SELECT * FROM usuaris where nom like '" + nom + "';";
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
                        //Lo añade
                        cbxNom.Text = reader.GetString(0);
                        txbContra1.Text = cifrado.descifrar(reader.GetString(1));
                        cbxTipusUsuari.Text = reader.GetString(2);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = cbxNom.Text;
                string contra1 = txbContra1.Text;
                string contra2 = txbContra2.Text;
                string tipusUsuari = cbxTipusUsuari.Text.ToString();
                string nouNom = txbNouNom.Text;


                if (!nom.Equals("") && !nouNom.Equals("") && !contra1.Equals("") && !contra2.Equals("") && !tipusUsuari.Equals(""))
                {
                    if (comprobarUsuari(nom))
                    {
                        if (contra1.Equals(contra2))
                        {
                            string sql = "UPDATE usuaris SET nom = '" + nouNom + "', contra = '" + cifrado.cifrar(contra1) + "', tipus = '" + tipusUsuari + "' WHERE nom = '" + nom + "';";

                            MySqlConnection conexionBD = Conexion.conexion();
                            conexionBD.Open();

                            try
                            {
                                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                                comando.ExecuteNonQuery();
                                MessageBox.Show("Usuari moficat amb exit!!!");
                                neteja();
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
                            MessageBox.Show("Les dos contrasenyes han de ser iguals");
                        }
                    }
                    else {
                        MessageBox.Show("No es pot modificar un usuari que no existeix");
                        btnModificar.Enabled = false;
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

            //Tornem a carregar els noms
            carregarNoms();
        }

        private void cbxNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregarUsuari(cbxNom.SelectedItem.ToString())) {
                btnModificar.Enabled = true;
                btnAfegir.Enabled = false;
            }
            else {
                btnModificar.Enabled = false;
                btnAfegir.Enabled = true;
            }
            
        }
    }
   
}
