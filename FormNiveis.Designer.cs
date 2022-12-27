namespace beyblade
{
    partial class FormNiveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNiveis));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_NIVEL_01 = new System.Windows.Forms.Label();
            this.LB_Niveis = new System.Windows.Forms.Label();
            this.LB_BACK = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1038, 43);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(90, 39);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // LB_NIVEL_01
            // 
            this.LB_NIVEL_01.AutoSize = true;
            this.LB_NIVEL_01.BackColor = System.Drawing.Color.Transparent;
            this.LB_NIVEL_01.Font = new System.Drawing.Font("Silom", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NIVEL_01.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_NIVEL_01.Location = new System.Drawing.Point(173, 302);
            this.LB_NIVEL_01.Name = "LB_NIVEL_01";
            this.LB_NIVEL_01.Size = new System.Drawing.Size(272, 76);
            this.LB_NIVEL_01.TabIndex = 1;
            this.LB_NIVEL_01.Text = "Nivel 1";
            this.LB_NIVEL_01.Click += new System.EventHandler(this.LB_NIVEL_01_Click);
            // 
            // LB_Niveis
            // 
            this.LB_Niveis.AutoSize = true;
            this.LB_Niveis.BackColor = System.Drawing.Color.Transparent;
            this.LB_Niveis.Font = new System.Drawing.Font("Silom", 100.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Niveis.Location = new System.Drawing.Point(289, 111);
            this.LB_Niveis.Name = "LB_Niveis";
            this.LB_Niveis.Size = new System.Drawing.Size(498, 160);
            this.LB_Niveis.TabIndex = 2;
            this.LB_Niveis.Text = "Niveis";
            // 
            // LB_BACK
            // 
            this.LB_BACK.AutoSize = true;
            this.LB_BACK.BackColor = System.Drawing.Color.Transparent;
            this.LB_BACK.Font = new System.Drawing.Font("Silom", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BACK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_BACK.Location = new System.Drawing.Point(432, 476);
            this.LB_BACK.Name = "LB_BACK";
            this.LB_BACK.Size = new System.Drawing.Size(195, 76);
            this.LB_BACK.TabIndex = 3;
            this.LB_BACK.Text = "Back";
            this.LB_BACK.Click += new System.EventHandler(this.LB_BACK_Click);
            // 
            // FormNiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 617);
            this.Controls.Add(this.LB_BACK);
            this.Controls.Add(this.LB_Niveis);
            this.Controls.Add(this.LB_NIVEL_01);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FormNiveis";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormNiveis_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LB_NIVEL_01;
        private System.Windows.Forms.Label LB_Niveis;
        private System.Windows.Forms.Label LB_BACK;
    }
}