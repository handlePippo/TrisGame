namespace Tris
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.partitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaPartitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.trisButton7 = new Tris.TrisButton();
            this.trisButton8 = new Tris.TrisButton();
            this.trisButton9 = new Tris.TrisButton();
            this.trisButton4 = new Tris.TrisButton();
            this.trisButton5 = new Tris.TrisButton();
            this.trisButton6 = new Tris.TrisButton();
            this.trisButton3 = new Tris.TrisButton();
            this.trisButton2 = new Tris.TrisButton();
            this.trisButton1 = new Tris.TrisButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partitaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // partitaToolStripMenuItem
            // 
            this.partitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaPartitaToolStripMenuItem});
            this.partitaToolStripMenuItem.Name = "partitaToolStripMenuItem";
            this.partitaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.partitaToolStripMenuItem.Text = "Partita";
            // 
            // nuovaPartitaToolStripMenuItem
            // 
            this.nuovaPartitaToolStripMenuItem.Name = "nuovaPartitaToolStripMenuItem";
            this.nuovaPartitaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.nuovaPartitaToolStripMenuItem.Text = "Nuova partita";
            this.nuovaPartitaToolStripMenuItem.Click += new System.EventHandler(this.NuovaPartitaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // trisButton7
            // 
            this.trisButton7.Location = new System.Drawing.Point(40, 163);
            this.trisButton7.Name = "trisButton7";
            this.trisButton7.Player = 0;
            this.trisButton7.Size = new System.Drawing.Size(54, 58);
            this.trisButton7.TabIndex = 16;
            this.trisButton7.Text = "trisButton7";
            this.trisButton7.UseVisualStyleBackColor = true;
            // 
            // trisButton8
            // 
            this.trisButton8.Location = new System.Drawing.Point(100, 163);
            this.trisButton8.Name = "trisButton8";
            this.trisButton8.Player = 0;
            this.trisButton8.Size = new System.Drawing.Size(54, 58);
            this.trisButton8.TabIndex = 15;
            this.trisButton8.Text = "trisButton8";
            this.trisButton8.UseVisualStyleBackColor = true;
            // 
            // trisButton9
            // 
            this.trisButton9.Location = new System.Drawing.Point(160, 163);
            this.trisButton9.Name = "trisButton9";
            this.trisButton9.Player = 0;
            this.trisButton9.Size = new System.Drawing.Size(54, 58);
            this.trisButton9.TabIndex = 14;
            this.trisButton9.Text = "trisButton9";
            this.trisButton9.UseVisualStyleBackColor = true;
            // 
            // trisButton4
            // 
            this.trisButton4.Location = new System.Drawing.Point(40, 99);
            this.trisButton4.Name = "trisButton4";
            this.trisButton4.Player = 0;
            this.trisButton4.Size = new System.Drawing.Size(54, 58);
            this.trisButton4.TabIndex = 13;
            this.trisButton4.Text = "trisButton4";
            this.trisButton4.UseVisualStyleBackColor = true;
            // 
            // trisButton5
            // 
            this.trisButton5.Location = new System.Drawing.Point(100, 99);
            this.trisButton5.Name = "trisButton5";
            this.trisButton5.Player = 0;
            this.trisButton5.Size = new System.Drawing.Size(54, 58);
            this.trisButton5.TabIndex = 12;
            this.trisButton5.Text = "trisButton5";
            this.trisButton5.UseVisualStyleBackColor = true;
            // 
            // trisButton6
            // 
            this.trisButton6.Location = new System.Drawing.Point(160, 99);
            this.trisButton6.Name = "trisButton6";
            this.trisButton6.Player = 0;
            this.trisButton6.Size = new System.Drawing.Size(54, 58);
            this.trisButton6.TabIndex = 11;
            this.trisButton6.Text = "trisButton6";
            this.trisButton6.UseVisualStyleBackColor = true;
            // 
            // trisButton3
            // 
            this.trisButton3.Location = new System.Drawing.Point(160, 35);
            this.trisButton3.Name = "trisButton3";
            this.trisButton3.Player = 0;
            this.trisButton3.Size = new System.Drawing.Size(54, 58);
            this.trisButton3.TabIndex = 3;
            this.trisButton3.Text = "trisButton3";
            this.trisButton3.UseVisualStyleBackColor = true;
            // 
            // trisButton2
            // 
            this.trisButton2.Location = new System.Drawing.Point(100, 35);
            this.trisButton2.Name = "trisButton2";
            this.trisButton2.Player = 0;
            this.trisButton2.Size = new System.Drawing.Size(54, 58);
            this.trisButton2.TabIndex = 2;
            this.trisButton2.Text = "trisButton2";
            this.trisButton2.UseVisualStyleBackColor = true;
            // 
            // trisButton1
            // 
            this.trisButton1.Location = new System.Drawing.Point(40, 35);
            this.trisButton1.Name = "trisButton1";
            this.trisButton1.Player = 0;
            this.trisButton1.Size = new System.Drawing.Size(54, 58);
            this.trisButton1.TabIndex = 1;
            this.trisButton1.Text = "trisButton1";
            this.trisButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trisButton7);
            this.Controls.Add(this.trisButton8);
            this.Controls.Add(this.trisButton9);
            this.Controls.Add(this.trisButton4);
            this.Controls.Add(this.trisButton5);
            this.Controls.Add(this.trisButton6);
            this.Controls.Add(this.trisButton3);
            this.Controls.Add(this.trisButton2);
            this.Controls.Add(this.trisButton1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TrisButton trisButton1;
        private TrisButton trisButton2;
        private TrisButton trisButton3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem partitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaPartitaToolStripMenuItem;
        private TrisButton trisButton4;
        private TrisButton trisButton5;
        private TrisButton trisButton6;
        private TrisButton trisButton7;
        private TrisButton trisButton8;
        private TrisButton trisButton9;
        private System.Windows.Forms.Label label1;
    }
}

