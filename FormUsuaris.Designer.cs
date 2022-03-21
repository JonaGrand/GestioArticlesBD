
namespace GestioArticlesBD
{
    partial class FormUsuaris
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
            this.lblNomUsuari = new System.Windows.Forms.Label();
            this.btnCercar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAfegirModificar = new System.Windows.Forms.Button();
            this.txbResul = new System.Windows.Forms.TextBox();
            this.btnTornar = new System.Windows.Forms.Button();
            this.btnNetejar = new System.Windows.Forms.Button();
            this.btnTots = new System.Windows.Forms.Button();
            this.cbxNom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNomUsuari
            // 
            this.lblNomUsuari.AutoSize = true;
            this.lblNomUsuari.Location = new System.Drawing.Point(47, 38);
            this.lblNomUsuari.Name = "lblNomUsuari";
            this.lblNomUsuari.Size = new System.Drawing.Size(41, 17);
            this.lblNomUsuari.TabIndex = 4;
            this.lblNomUsuari.Text = "Nom:";
            // 
            // btnCercar
            // 
            this.btnCercar.Location = new System.Drawing.Point(31, 226);
            this.btnCercar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCercar.Name = "btnCercar";
            this.btnCercar.Size = new System.Drawing.Size(197, 23);
            this.btnCercar.TabIndex = 8;
            this.btnCercar.Text = "Cercar";
            this.btnCercar.UseVisualStyleBackColor = true;
            this.btnCercar.Click += new System.EventHandler(this.btnCercar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(234, 226);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAfegirModificar
            // 
            this.btnAfegirModificar.Location = new System.Drawing.Point(432, 67);
            this.btnAfegirModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfegirModificar.Name = "btnAfegirModificar";
            this.btnAfegirModificar.Size = new System.Drawing.Size(100, 155);
            this.btnAfegirModificar.TabIndex = 11;
            this.btnAfegirModificar.Text = "Afegir\r\nModificar\r\n";
            this.btnAfegirModificar.UseVisualStyleBackColor = true;
            this.btnAfegirModificar.Click += new System.EventHandler(this.btnAfegirModificar_Click);
            // 
            // txbResul
            // 
            this.txbResul.Location = new System.Drawing.Point(35, 66);
            this.txbResul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbResul.Multiline = true;
            this.txbResul.Name = "txbResul";
            this.txbResul.ReadOnly = true;
            this.txbResul.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResul.Size = new System.Drawing.Size(391, 156);
            this.txbResul.TabIndex = 12;
            // 
            // btnTornar
            // 
            this.btnTornar.Location = new System.Drawing.Point(8, 325);
            this.btnTornar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTornar.Name = "btnTornar";
            this.btnTornar.Size = new System.Drawing.Size(94, 23);
            this.btnTornar.TabIndex = 13;
            this.btnTornar.Text = "Tornar";
            this.btnTornar.UseVisualStyleBackColor = true;
            this.btnTornar.Click += new System.EventHandler(this.btnTornar_Click);
            // 
            // btnNetejar
            // 
            this.btnNetejar.Location = new System.Drawing.Point(31, 282);
            this.btnNetejar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNetejar.Name = "btnNetejar";
            this.btnNetejar.Size = new System.Drawing.Size(395, 23);
            this.btnNetejar.TabIndex = 14;
            this.btnNetejar.Text = "Netejar";
            this.btnNetejar.UseVisualStyleBackColor = true;
            this.btnNetejar.Click += new System.EventHandler(this.btnNetejar_Click);
            // 
            // btnTots
            // 
            this.btnTots.Location = new System.Drawing.Point(31, 254);
            this.btnTots.Name = "btnTots";
            this.btnTots.Size = new System.Drawing.Size(395, 23);
            this.btnTots.TabIndex = 15;
            this.btnTots.Text = "Mostrar tots";
            this.btnTots.UseVisualStyleBackColor = true;
            this.btnTots.Click += new System.EventHandler(this.btnTots_Click);
            // 
            // cbxNom
            // 
            this.cbxNom.FormattingEnabled = true;
            this.cbxNom.Location = new System.Drawing.Point(94, 35);
            this.cbxNom.Name = "cbxNom";
            this.cbxNom.Size = new System.Drawing.Size(121, 24);
            this.cbxNom.TabIndex = 16;
            // 
            // FormUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 363);
            this.Controls.Add(this.cbxNom);
            this.Controls.Add(this.btnTots);
            this.Controls.Add(this.btnNetejar);
            this.Controls.Add(this.btnTornar);
            this.Controls.Add(this.txbResul);
            this.Controls.Add(this.btnAfegirModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCercar);
            this.Controls.Add(this.lblNomUsuari);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUsuaris";
            this.Text = "FormUsuaris";
            this.Load += new System.EventHandler(this.FormUsuaris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomUsuari;
        private System.Windows.Forms.Button btnCercar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAfegirModificar;
        private System.Windows.Forms.TextBox txbResul;
        private System.Windows.Forms.Button btnTornar;
        private System.Windows.Forms.Button btnNetejar;
        private System.Windows.Forms.Button btnTots;
        private System.Windows.Forms.ComboBox cbxNom;
    }
}