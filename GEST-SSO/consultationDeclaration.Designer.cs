
namespace GEST_SSO
{
    partial class consultationDeclaration
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
            this.menuStripConsultation = new System.Windows.Forms.MenuStrip();
            this.saluyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.module1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.module2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStripConsultation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripConsultation
            // 
            this.menuStripConsultation.Location = new System.Drawing.Point(0, 0);
            this.menuStripConsultation.Name = "menuStripConsultation";
            this.menuStripConsultation.Size = new System.Drawing.Size(800, 24);
            this.menuStripConsultation.TabIndex = 3;
            this.menuStripConsultation.Text = "menuStrip1";
            // 
            // saluyToolStripMenuItem
            // 
            this.saluyToolStripMenuItem.Name = "saluyToolStripMenuItem";
            this.saluyToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.saluyToolStripMenuItem.Text = "Saisie";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // suppressionToolStripMenuItem
            // 
            this.suppressionToolStripMenuItem.Name = "suppressionToolStripMenuItem";
            this.suppressionToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.suppressionToolStripMenuItem.Text = "Suppression";
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.module1ToolStripMenuItem,
            this.module2ToolStripMenuItem});
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.statistiqueToolStripMenuItem.Text = "Statistique";
            // 
            // module1ToolStripMenuItem
            // 
            this.module1ToolStripMenuItem.Name = "module1ToolStripMenuItem";
            this.module1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.module1ToolStripMenuItem.Text = "Module 1";
            // 
            // module2ToolStripMenuItem
            // 
            this.module2ToolStripMenuItem.Name = "module2ToolStripMenuItem";
            this.module2ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.module2ToolStripMenuItem.Text = "Module 2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 295);
            this.dataGridView1.TabIndex = 26;
            // 
            // consultationDeclaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStripConsultation);
            this.Name = "consultationDeclaration";
            this.Text = "Consultation de déclaration";
            this.menuStripConsultation.ResumeLayout(false);
            this.menuStripConsultation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripConsultation;
        private System.Windows.Forms.ToolStripMenuItem saluyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem module1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem module2ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}