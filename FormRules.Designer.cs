namespace beyblade
{
    partial class FormRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRules));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_GoBack = new System.Windows.Forms.Label();
            this.LB_Niveis = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 43);
            this.menuStrip1.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.MenuStrip.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(90, 39);
            this.MenuStrip.Text = "File";
            this.MenuStrip.Click += new System.EventHandler(this.MenuStrip_Click);
            this.MenuStrip.MouseHover += new System.EventHandler(this.MenuStrip_MouseHover);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseHover += new System.EventHandler(this.exitToolStripMenuItem_MouseHover);
            // 
            // LB_GoBack
            // 
            this.LB_GoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_GoBack.AutoSize = true;
            this.LB_GoBack.BackColor = System.Drawing.Color.Transparent;
            this.LB_GoBack.Font = new System.Drawing.Font("Silom", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_GoBack.Location = new System.Drawing.Point(12, 706);
            this.LB_GoBack.Name = "LB_GoBack";
            this.LB_GoBack.Size = new System.Drawing.Size(318, 76);
            this.LB_GoBack.TabIndex = 2;
            this.LB_GoBack.Text = "Go back";
            this.LB_GoBack.Click += new System.EventHandler(this.LB_GoBack_Click);
            this.LB_GoBack.MouseLeave += new System.EventHandler(this.LB_GoBack_MouseLeave);
            this.LB_GoBack.MouseHover += new System.EventHandler(this.LB_GoBack_MouseHover);
            // 
            // LB_Niveis
            // 
            this.LB_Niveis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Niveis.AutoSize = true;
            this.LB_Niveis.BackColor = System.Drawing.Color.Transparent;
            this.LB_Niveis.Font = new System.Drawing.Font("Silom", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Niveis.Location = new System.Drawing.Point(352, 115);
            this.LB_Niveis.Name = "LB_Niveis";
            this.LB_Niveis.Size = new System.Drawing.Size(678, 238);
            this.LB_Niveis.TabIndex = 3;
            this.LB_Niveis.Text = "Rules";
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 803);
            this.Controls.Add(this.LB_Niveis);
            this.Controls.Add(this.LB_GoBack);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRules";
            this.Text = "FormRules";
            this.Load += new System.EventHandler(this.FormRules_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LB_GoBack;
        private System.Windows.Forms.Label LB_Niveis;
    }
}