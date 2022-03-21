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
    public partial class FormAdminEleccion : Form
    {
        public FormAdminEleccion()
        {
            InitializeComponent();
        }

        private void btnTornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFormUsuaris_Click(object sender, EventArgs e)
        {
            FormUsuaris u = new FormUsuaris();
            u.Show();//Abrimos el formulario FomrUsuaris.
        }

        private void btnFormArticles_Click(object sender, EventArgs e)
        {
            FormArticles a = new FormArticles();
            a.Show();//Abrimos formulario FormArticles
        }

        private void FormAdminEleccion_Load(object sender, EventArgs e)
        {

        }
    }
}
