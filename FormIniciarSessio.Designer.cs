
namespace GestioArticlesBD
{
    partial class FormIniciarSessio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIniciarSessio = new System.Windows.Forms.Label();
            this.lblNomUsuari = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbContra = new System.Windows.Forms.TextBox();
            this.btnNetjar = new System.Windows.Forms.Button();
            this.btnIniciarSessio = new System.Windows.Forms.Button();
            this.btnTancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIniciarSessio
            // 
            this.lblIniciarSessio.AutoSize = true;
            this.lblIniciarSessio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSessio.Location = new System.Drawing.Point(66, 22);
            this.lblIniciarSessio.Name = "lblIniciarSessio";
            this.lblIniciarSessio.Size = new System.Drawing.Size(171, 29);
            this.lblIniciarSessio.TabIndex = 0;
            this.lblIniciarSessio.Text = "Inciar Sessió";
            // 
            // lblNomUsuari
            // 
            this.lblNomUsuari.AutoSize = true;
            this.lblNomUsuari.Location = new System.Drawing.Point(43, 71);
            this.lblNomUsuari.Name = "lblNomUsuari";
            this.lblNomUsuari.Size = new System.Drawing.Size(45, 17);
            this.lblNomUsuari.TabIndex = 1;
            this.lblNomUsuari.Text = "Nom: ";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(43, 104);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(92, 17);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Contrasenya:";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(137, 68);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(100, 22);
            this.txbNom.TabIndex = 3;
            this.txbNom.TextChanged += new System.EventHandler(this.txbNom_TextChanged);
            // 
            // txbContra
            // 
            this.txbContra.Location = new System.Drawing.Point(137, 104);
            this.txbContra.Name = "txbContra";
            this.txbContra.PasswordChar = '*';
            this.txbContra.Size = new System.Drawing.Size(100, 22);
            this.txbContra.TabIndex = 4;
            this.txbContra.TextChanged += new System.EventHandler(this.txbContra_TextChanged);
            // 
            // btnNetjar
            // 
            this.btnNetjar.Location = new System.Drawing.Point(46, 140);
            this.btnNetjar.Name = "btnNetjar";
            this.btnNetjar.Size = new System.Drawing.Size(89, 23);
            this.btnNetjar.TabIndex = 5;
            this.btnNetjar.Text = "Netejar";
            this.btnNetjar.UseVisualStyleBackColor = true;
            this.btnNetjar.Click += new System.EventHandler(this.btnNetjar_Click);
            // 
            // btnIniciarSessio
            // 
            this.btnIniciarSessio.Location = new System.Drawing.Point(141, 140);
            this.btnIniciarSessio.Name = "btnIniciarSessio";
            this.btnIniciarSessio.Size = new System.Drawing.Size(96, 23);
            this.btnIniciarSessio.TabIndex = 6;
            this.btnIniciarSessio.Text = "Iniciar";
            this.btnIniciarSessio.UseVisualStyleBackColor = true;
            this.btnIniciarSessio.Click += new System.EventHandler(this.btnIniciarSessio_Click);
            // 
            // btnTancar
            // 
            this.btnTancar.Location = new System.Drawing.Point(13, 206);
            this.btnTancar.Name = "btnTancar";
            this.btnTancar.Size = new System.Drawing.Size(75, 23);
            this.btnTancar.TabIndex = 7;
            this.btnTancar.Text = "Tancar";
            this.btnTancar.UseVisualStyleBackColor = true;
            this.btnTancar.Click += new System.EventHandler(this.btnTancar_Click);
            // 
            // FormIniciarSessio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 252);
            this.Controls.Add(this.btnTancar);
            this.Controls.Add(this.btnIniciarSessio);
            this.Controls.Add(this.btnNetjar);
            this.Controls.Add(this.txbContra);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblNomUsuari);
            this.Controls.Add(this.lblIniciarSessio);
            this.Name = "FormIniciarSessio";
            this.Text = "Iniciar Sessio";
            this.Load += new System.EventHandler(this.FormIniciarSessio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIniciarSessio;
        private System.Windows.Forms.Label lblNomUsuari;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbContra;
        private System.Windows.Forms.Button btnNetjar;
        private System.Windows.Forms.Button btnIniciarSessio;
        private System.Windows.Forms.Button btnTancar;
    }
}

