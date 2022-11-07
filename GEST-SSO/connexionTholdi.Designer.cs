
namespace GEST_SSO
{
    partial class connexionTholdi
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
            this.buttonConnexionValidez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConnexionLogin = new System.Windows.Forms.TextBox();
            this.textBoxConnexionMdp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConnexionValidez
            // 
            this.buttonConnexionValidez.Location = new System.Drawing.Point(337, 257);
            this.buttonConnexionValidez.Name = "buttonConnexionValidez";
            this.buttonConnexionValidez.Size = new System.Drawing.Size(75, 23);
            this.buttonConnexionValidez.TabIndex = 0;
            this.buttonConnexionValidez.Text = "Validez";
            this.buttonConnexionValidez.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // textBoxConnexionLogin
            // 
            this.textBoxConnexionLogin.Location = new System.Drawing.Point(312, 96);
            this.textBoxConnexionLogin.Name = "textBoxConnexionLogin";
            this.textBoxConnexionLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxConnexionLogin.TabIndex = 3;
            // 
            // textBoxConnexionMdp
            // 
            this.textBoxConnexionMdp.Location = new System.Drawing.Point(312, 173);
            this.textBoxConnexionMdp.Name = "textBoxConnexionMdp";
            this.textBoxConnexionMdp.Size = new System.Drawing.Size(100, 20);
            this.textBoxConnexionMdp.TabIndex = 4;
            // 
            // connexionTholdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxConnexionMdp);
            this.Controls.Add(this.textBoxConnexionLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnexionValidez);
            this.Name = "connexionTholdi";
            this.Text = "Page de connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnexionValidez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConnexionLogin;
        private System.Windows.Forms.TextBox textBoxConnexionMdp;
    }
}