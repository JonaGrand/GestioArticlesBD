
namespace GestioArticlesBD
{
    partial class FormArticles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTots = new System.Windows.Forms.Button();
            this.btnNetejar = new System.Windows.Forms.Button();
            this.btnTornar = new System.Windows.Forms.Button();
            this.txbResul = new System.Windows.Forms.TextBox();
            this.btnAfegirModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCercar = new System.Windows.Forms.Button();
            this.lblNomUsuari = new System.Windows.Forms.Label();
            this.cbxTipus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArticlesOferta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxNom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTots
            // 
            this.btnTots.Location = new System.Drawing.Point(35, 350);
            this.btnTots.Name = "btnTots";
            this.btnTots.Size = new System.Drawing.Size(276, 51);
            this.btnTots.TabIndex = 24;
            this.btnTots.Text = "Mostrar articles amb stock";
            this.btnTots.UseVisualStyleBackColor = true;
            this.btnTots.Click += new System.EventHandler(this.btnTots_Click);
            // 
            // btnNetejar
            // 
            this.btnNetejar.Location = new System.Drawing.Point(35, 406);
            this.btnNetejar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNetejar.Name = "btnNetejar";
            this.btnNetejar.Size = new System.Drawing.Size(534, 53);
            this.btnNetejar.TabIndex = 23;
            this.btnNetejar.Text = "Netejar";
            this.btnNetejar.UseVisualStyleBackColor = true;
            this.btnNetejar.Click += new System.EventHandler(this.btnNetejar_Click);
            // 
            // btnTornar
            // 
            this.btnTornar.Location = new System.Drawing.Point(12, 475);
            this.btnTornar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTornar.Name = "btnTornar";
            this.btnTornar.Size = new System.Drawing.Size(94, 23);
            this.btnTornar.TabIndex = 22;
            this.btnTornar.Text = "Tornar";
            this.btnTornar.UseVisualStyleBackColor = true;
            this.btnTornar.Click += new System.EventHandler(this.btnTornar_Click);
            // 
            // txbResul
            // 
            this.txbResul.Location = new System.Drawing.Point(35, 47);
            this.txbResul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbResul.Multiline = true;
            this.txbResul.Name = "txbResul";
            this.txbResul.ReadOnly = true;
            this.txbResul.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResul.Size = new System.Drawing.Size(534, 239);
            this.txbResul.TabIndex = 21;
            // 
            // btnAfegirModificar
            // 
            this.btnAfegirModificar.Location = new System.Drawing.Point(575, 49);
            this.btnAfegirModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfegirModificar.Name = "btnAfegirModificar";
            this.btnAfegirModificar.Size = new System.Drawing.Size(100, 237);
            this.btnAfegirModificar.TabIndex = 20;
            this.btnAfegirModificar.Text = "Afegir\r\nModificar\r\nArticles";
            this.btnAfegirModificar.UseVisualStyleBackColor = true;
            this.btnAfegirModificar.Click += new System.EventHandler(this.btnAfegirModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(317, 294);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(252, 51);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCercar
            // 
            this.btnCercar.Location = new System.Drawing.Point(35, 292);
            this.btnCercar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCercar.Name = "btnCercar";
            this.btnCercar.Size = new System.Drawing.Size(276, 51);
            this.btnCercar.TabIndex = 18;
            this.btnCercar.Text = "Cercar per nom";
            this.btnCercar.UseVisualStyleBackColor = true;
            this.btnCercar.Click += new System.EventHandler(this.btnCercar_Click);
            // 
            // lblNomUsuari
            // 
            this.lblNomUsuari.AutoSize = true;
            this.lblNomUsuari.Location = new System.Drawing.Point(47, 21);
            this.lblNomUsuari.Name = "lblNomUsuari";
            this.lblNomUsuari.Size = new System.Drawing.Size(41, 17);
            this.lblNomUsuari.TabIndex = 16;
            this.lblNomUsuari.Text = "Nom:";
            // 
            // cbxTipus
            // 
            this.cbxTipus.FormattingEnabled = true;
            this.cbxTipus.Location = new System.Drawing.Point(407, 16);
            this.cbxTipus.Name = "cbxTipus";
            this.cbxTipus.Size = new System.Drawing.Size(121, 24);
            this.cbxTipus.TabIndex = 25;
            this.cbxTipus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tipus:";
            // 
            // btnArticlesOferta
            // 
            this.btnArticlesOferta.Location = new System.Drawing.Point(317, 350);
            this.btnArticlesOferta.Name = "btnArticlesOferta";
            this.btnArticlesOferta.Size = new System.Drawing.Size(252, 51);
            this.btnArticlesOferta.TabIndex = 27;
            this.btnArticlesOferta.Text = "Mostrar articles en oferta";
            this.btnArticlesOferta.UseVisualStyleBackColor = true;
            this.btnArticlesOferta.Click += new System.EventHandler(this.btnArticlesOferta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 169);
            this.button1.TabIndex = 28;
            this.button1.Text = "Afegir Stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxNom
            // 
            this.cbxNom.FormattingEnabled = true;
            this.cbxNom.Location = new System.Drawing.Point(95, 17);
            this.cbxNom.Name = "cbxNom";
            this.cbxNom.Size = new System.Drawing.Size(175, 24);
            this.cbxNom.TabIndex = 29;
            // 
            // FormArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 509);
            this.Controls.Add(this.cbxNom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnArticlesOferta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTipus);
            this.Controls.Add(this.btnTots);
            this.Controls.Add(this.btnNetejar);
            this.Controls.Add(this.btnTornar);
            this.Controls.Add(this.txbResul);
            this.Controls.Add(this.btnAfegirModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCercar);
            this.Controls.Add(this.lblNomUsuari);
            this.Name = "FormArticles";
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.FormArticles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTots;
        private System.Windows.Forms.Button btnNetejar;
        private System.Windows.Forms.Button btnTornar;
        private System.Windows.Forms.TextBox txbResul;
        private System.Windows.Forms.Button btnAfegirModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCercar;
        private System.Windows.Forms.Label lblNomUsuari;
        private System.Windows.Forms.ComboBox cbxTipus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArticlesOferta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxNom;
    }
}