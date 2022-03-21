
namespace GestioArticlesBD
{
    partial class FormAfegirStock
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
            this.lblRegistre = new System.Windows.Forms.Label();
            this.cbxNomArticle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUnitats = new System.Windows.Forms.TextBox();
            this.btnAfegir = new System.Windows.Forms.Button();
            this.btnTornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistre
            // 
            this.lblRegistre.AutoSize = true;
            this.lblRegistre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegistre.Location = new System.Drawing.Point(98, 29);
            this.lblRegistre.Name = "lblRegistre";
            this.lblRegistre.Size = new System.Drawing.Size(174, 37);
            this.lblRegistre.TabIndex = 15;
            this.lblRegistre.Text = "Afegir Stock";
            // 
            // cbxNomArticle
            // 
            this.cbxNomArticle.FormattingEnabled = true;
            this.cbxNomArticle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxNomArticle.Location = new System.Drawing.Point(166, 94);
            this.cbxNomArticle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxNomArticle.Name = "cbxNomArticle";
            this.cbxNomArticle.Size = new System.Drawing.Size(151, 24);
            this.cbxNomArticle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nom Article:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Unitats: ";
            // 
            // txbUnitats
            // 
            this.txbUnitats.Location = new System.Drawing.Point(166, 138);
            this.txbUnitats.Name = "txbUnitats";
            this.txbUnitats.Size = new System.Drawing.Size(151, 22);
            this.txbUnitats.TabIndex = 2;
            // 
            // btnAfegir
            // 
            this.btnAfegir.Location = new System.Drawing.Point(166, 185);
            this.btnAfegir.Name = "btnAfegir";
            this.btnAfegir.Size = new System.Drawing.Size(151, 35);
            this.btnAfegir.TabIndex = 3;
            this.btnAfegir.Text = "Afegir";
            this.btnAfegir.UseVisualStyleBackColor = true;
            this.btnAfegir.Click += new System.EventHandler(this.btnAfegir_Click);
            // 
            // btnTornar
            // 
            this.btnTornar.Location = new System.Drawing.Point(12, 254);
            this.btnTornar.Name = "btnTornar";
            this.btnTornar.Size = new System.Drawing.Size(151, 35);
            this.btnTornar.TabIndex = 4;
            this.btnTornar.Text = "Tornar";
            this.btnTornar.UseVisualStyleBackColor = true;
            // 
            // FormAfegirStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 305);
            this.Controls.Add(this.btnTornar);
            this.Controls.Add(this.btnAfegir);
            this.Controls.Add(this.txbUnitats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxNomArticle);
            this.Controls.Add(this.lblRegistre);
            this.Name = "FormAfegirStock";
            this.Text = "FormAfegirStock";
            this.Load += new System.EventHandler(this.FormAfegirStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistre;
        private System.Windows.Forms.ComboBox cbxNomArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUnitats;
        private System.Windows.Forms.Button btnAfegir;
        private System.Windows.Forms.Button btnTornar;
    }
}