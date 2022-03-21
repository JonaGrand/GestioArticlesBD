
namespace GestioArticlesBD
{
    partial class FormAfegirModificar
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
            this.components = new System.ComponentModel.Container();
            this.btnAfegir = new System.Windows.Forms.Button();
            this.lblRegistre = new System.Windows.Forms.Label();
            this.btnNetjar = new System.Windows.Forms.Button();
            this.txbContra1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomUsuari = new System.Windows.Forms.Label();
            this.txbContra2 = new System.Windows.Forms.TextBox();
            this.btnTornar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipusUsuari = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModificar = new System.Windows.Forms.Button();
            this.txbNouNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfegir
            // 
            this.btnAfegir.Location = new System.Drawing.Point(191, 179);
            this.btnAfegir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfegir.Name = "btnAfegir";
            this.btnAfegir.Size = new System.Drawing.Size(116, 42);
            this.btnAfegir.TabIndex = 15;
            this.btnAfegir.Text = "Afegir";
            this.btnAfegir.UseVisualStyleBackColor = true;
            this.btnAfegir.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblRegistre
            // 
            this.lblRegistre.AutoSize = true;
            this.lblRegistre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegistre.Location = new System.Drawing.Point(88, 25);
            this.lblRegistre.Name = "lblRegistre";
            this.lblRegistre.Size = new System.Drawing.Size(234, 37);
            this.lblRegistre.TabIndex = 14;
            this.lblRegistre.Text = "Afegir/Modificar";
            // 
            // btnNetjar
            // 
            this.btnNetjar.Location = new System.Drawing.Point(58, 222);
            this.btnNetjar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNetjar.Name = "btnNetjar";
            this.btnNetjar.Size = new System.Drawing.Size(249, 23);
            this.btnNetjar.TabIndex = 13;
            this.btnNetjar.Text = "Netejar";
            this.btnNetjar.UseVisualStyleBackColor = true;
            this.btnNetjar.Click += new System.EventHandler(this.btnNetjar_Click);
            // 
            // txbContra1
            // 
            this.txbContra1.Location = new System.Drawing.Point(157, 108);
            this.txbContra1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbContra1.Name = "txbContra1";
            this.txbContra1.PasswordChar = '*';
            this.txbContra1.Size = new System.Drawing.Size(125, 22);
            this.txbContra1.TabIndex = 11;
            this.txbContra1.TextChanged += new System.EventHandler(this.txbContra1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contrasenya:";
            // 
            // lblNomUsuari
            // 
            this.lblNomUsuari.AutoSize = true;
            this.lblNomUsuari.Location = new System.Drawing.Point(58, 71);
            this.lblNomUsuari.Name = "lblNomUsuari";
            this.lblNomUsuari.Size = new System.Drawing.Size(41, 17);
            this.lblNomUsuari.TabIndex = 8;
            this.lblNomUsuari.Text = "Nom:";
            // 
            // txbContra2
            // 
            this.txbContra2.Location = new System.Drawing.Point(309, 108);
            this.txbContra2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbContra2.Name = "txbContra2";
            this.txbContra2.PasswordChar = '*';
            this.txbContra2.Size = new System.Drawing.Size(125, 22);
            this.txbContra2.TabIndex = 16;
            this.txbContra2.TextChanged += new System.EventHandler(this.txbContra2_TextChanged);
            // 
            // btnTornar
            // 
            this.btnTornar.Location = new System.Drawing.Point(9, 250);
            this.btnTornar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTornar.Name = "btnTornar";
            this.btnTornar.Size = new System.Drawing.Size(94, 23);
            this.btnTornar.TabIndex = 17;
            this.btnTornar.Text = "Tornar";
            this.btnTornar.UseVisualStyleBackColor = true;
            this.btnTornar.Click += new System.EventHandler(this.btnTornar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipus Usuari:";
            // 
            // cbxTipusUsuari
            // 
            this.cbxTipusUsuari.FormattingEnabled = true;
            this.cbxTipusUsuari.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxTipusUsuari.Location = new System.Drawing.Point(156, 146);
            this.cbxTipusUsuari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipusUsuari.Name = "cbxTipusUsuari";
            this.cbxTipusUsuari.Size = new System.Drawing.Size(151, 24);
            this.cbxTipusUsuari.TabIndex = 19;
            this.cbxTipusUsuari.SelectedIndexChanged += new System.EventHandler(this.cbxTipusUsuari_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(58, 179);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(127, 42);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txbNouNom
            // 
            this.txbNouNom.Location = new System.Drawing.Point(413, 69);
            this.txbNouNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNouNom.Name = "txbNouNom";
            this.txbNouNom.Size = new System.Drawing.Size(125, 22);
            this.txbNouNom.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nou Nom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.label4.Location = new System.Drawing.Point(428, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "(Nomes al modificar)";
            // 
            // cbxNom
            // 
            this.cbxNom.FormattingEnabled = true;
            this.cbxNom.Location = new System.Drawing.Point(156, 71);
            this.cbxNom.Name = "cbxNom";
            this.cbxNom.Size = new System.Drawing.Size(121, 24);
            this.cbxNom.TabIndex = 24;
            this.cbxNom.SelectedIndexChanged += new System.EventHandler(this.cbxNom_SelectedIndexChanged);
            // 
            // FormAfegirModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 345);
            this.Controls.Add(this.cbxNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNouNom);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cbxTipusUsuari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTornar);
            this.Controls.Add(this.txbContra2);
            this.Controls.Add(this.btnAfegir);
            this.Controls.Add(this.lblRegistre);
            this.Controls.Add(this.btnNetjar);
            this.Controls.Add(this.txbContra1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomUsuari);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAfegirModificar";
            this.Text = "Afegir/Modificar";
            this.Load += new System.EventHandler(this.Registre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfegir;
        private System.Windows.Forms.Label lblRegistre;
        private System.Windows.Forms.Button btnNetjar;
        private System.Windows.Forms.TextBox txbContra1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomUsuari;
        private System.Windows.Forms.TextBox txbContra2;
        private System.Windows.Forms.Button btnTornar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipusUsuari;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNouNom;
        private System.Windows.Forms.ComboBox cbxNom;
    }
}