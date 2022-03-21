
namespace GestioArticlesBD
{
    partial class FormAdminEleccion
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
            this.btnFormUsuaris = new System.Windows.Forms.Button();
            this.btnFormArticles = new System.Windows.Forms.Button();
            this.btnTornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormUsuaris
            // 
            this.btnFormUsuaris.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFormUsuaris.Location = new System.Drawing.Point(85, 96);
            this.btnFormUsuaris.Name = "btnFormUsuaris";
            this.btnFormUsuaris.Size = new System.Drawing.Size(202, 63);
            this.btnFormUsuaris.TabIndex = 0;
            this.btnFormUsuaris.Text = "USUARIS";
            this.btnFormUsuaris.UseVisualStyleBackColor = true;
            this.btnFormUsuaris.Click += new System.EventHandler(this.btnFormUsuaris_Click);
            // 
            // btnFormArticles
            // 
            this.btnFormArticles.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFormArticles.Location = new System.Drawing.Point(85, 215);
            this.btnFormArticles.Name = "btnFormArticles";
            this.btnFormArticles.Size = new System.Drawing.Size(202, 63);
            this.btnFormArticles.TabIndex = 1;
            this.btnFormArticles.Text = "ARTICLES";
            this.btnFormArticles.UseVisualStyleBackColor = true;
            this.btnFormArticles.Click += new System.EventHandler(this.btnFormArticles_Click);
            // 
            // btnTornar
            // 
            this.btnTornar.Location = new System.Drawing.Point(12, 372);
            this.btnTornar.Name = "btnTornar";
            this.btnTornar.Size = new System.Drawing.Size(94, 29);
            this.btnTornar.TabIndex = 18;
            this.btnTornar.Text = "Tornar";
            this.btnTornar.UseVisualStyleBackColor = true;
            this.btnTornar.Click += new System.EventHandler(this.btnTornar_Click);
            // 
            // FormAdminEleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 413);
            this.Controls.Add(this.btnTornar);
            this.Controls.Add(this.btnFormArticles);
            this.Controls.Add(this.btnFormUsuaris);
            this.Name = "FormAdminEleccion";
            this.Text = "AdminEleccion";
            this.Load += new System.EventHandler(this.FormAdminEleccion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormUsuaris;
        private System.Windows.Forms.Button btnFormArticles;
        private System.Windows.Forms.Button btnTornar;
    }
}