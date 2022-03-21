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
    public partial class FormIniciarSessio : Form
    {
        Cifrado cifrado = new Cifrado();

        public FormIniciarSessio()
        {
            InitializeComponent();
        }

        private void FormIniciarSessio_Load(object sender, EventArgs e)
        {
            btnIniciarSessio.Enabled = false;
        }

        private void btnNetjar_Click(object sender, EventArgs e)
        {
            neteja();
        }
        private void neteja()
        {
            txbNom.Text = "";
            txbContra.Text = "";

        }

        private void comprobarbtn()
        {

            if (!txbNom.Text.Equals("") && !txbContra.Text.Equals(""))
            {
                btnIniciarSessio.Enabled = true; //Mostrem el boto iniciar sessio
            }
            else
            {

                btnIniciarSessio.Enabled = false;
            }
        }

        private void btnTancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormAfegirModificar reg = new FormAfegirModificar();
            reg.Show();
        }

        private void btnIniciarSessio_Click(object sender, EventArgs e)
        {
            String nom = txbNom.Text;
            String contra = txbContra.Text;
            MySqlDataReader reader = null;

            if (!nom.Equals("") && !contra.Equals(""))
            {
                string select = "SELECT * FROM usuaris WHERE nom LIKE '" + nom + "' LIMIT 1";
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
                            //Si el usuario existe y los datos son correctos, abre la ventana AdminEleccion
                            if (nom.Equals(reader.GetString(0)) && contra.Equals(cifrado.descifrar(reader.GetString(1))))
                            {
                                if (reader.GetString(2).ToLower().Equals("admin")) //Miramos el tipo de usuario para saber que ventana abrir
                                {
                                    //Tipo = Admin
                                    FormAdminEleccion ae = new FormAdminEleccion();
                                    ae.Show(); //Abre el formulario AdminEleccion
                                }
                                else if (reader.GetString(2).ToLower().Equals("user"))
                                {
                                    //Tipo = User
                                    FormArticles a = new FormArticles();
                                    a.Show(); //Abre le formulario articles
                                }
                            }
                            else {
                                MessageBox.Show("Usuari o contrasenya incorrecte");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuari o contrasenya incorrecte");
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

        private void txbNom_TextChanged(object sender, EventArgs e)
        {
            comprobarbtn();
        }

        private void txbContra_TextChanged(object sender, EventArgs e)
        {
            comprobarbtn();
        }

    }
}
