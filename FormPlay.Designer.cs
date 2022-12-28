namespace beyblade
{
    partial class FormPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlay));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_GoBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Massa = new System.Windows.Forms.Label();
            this.LB_Aceleracao = new System.Windows.Forms.Label();
            this.panelArena = new System.Windows.Forms.Panel();
            this.timerAnima = new System.Windows.Forms.Timer(this.components);
            this.labelRaio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(1422, 43);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(90, 39);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            this.fileToolStripMenuItem.MouseLeave += new System.EventHandler(this.fileToolStripMenuItem_MouseLeave);
            this.fileToolStripMenuItem.MouseHover += new System.EventHandler(this.fileToolStripMenuItem_MouseHover);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // LB_GoBack
            // 
            this.LB_GoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_GoBack.AutoSize = true;
            this.LB_GoBack.BackColor = System.Drawing.Color.Transparent;
            this.LB_GoBack.Font = new System.Drawing.Font("Silom", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_GoBack.Location = new System.Drawing.Point(15, 718);
            this.LB_GoBack.Name = "LB_GoBack";
            this.LB_GoBack.Size = new System.Drawing.Size(236, 76);
            this.LB_GoBack.TabIndex = 2;
            this.LB_GoBack.Text = "Niveis";
            this.LB_GoBack.Click += new System.EventHandler(this.LB_GoBack_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Silom", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1328, 1220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reiniciar";
            // 
            // LB_Massa
            // 
            this.LB_Massa.AutoSize = true;
            this.LB_Massa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Massa.Location = new System.Drawing.Point(13, 284);
            this.LB_Massa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Massa.Name = "LB_Massa";
            this.LB_Massa.Size = new System.Drawing.Size(148, 38);
            this.LB_Massa.TabIndex = 5;
            this.LB_Massa.Text = "Massa:0";
            // 
            // LB_Aceleracao
            // 
            this.LB_Aceleracao.AutoSize = true;
            this.LB_Aceleracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Aceleracao.Location = new System.Drawing.Point(21, 343);
            this.LB_Aceleracao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Aceleracao.Name = "LB_Aceleracao";
            this.LB_Aceleracao.Size = new System.Drawing.Size(220, 38);
            this.LB_Aceleracao.TabIndex = 6;
            this.LB_Aceleracao.Text = "Acelereção:0";
            // 
            // panelArena
            // 
            this.panelArena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelArena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelArena.Location = new System.Drawing.Point(294, 91);
            this.panelArena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelArena.Name = "panelArena";
            this.panelArena.Size = new System.Drawing.Size(1084, 630);
            this.panelArena.TabIndex = 3;
            this.panelArena.Paint += new System.Windows.Forms.PaintEventHandler(this.panelArena_Paint);
            // 
            // timerAnima
            // 
            this.timerAnima.Interval = 30;
            this.timerAnima.Tick += new System.EventHandler(this.timerAnima_Tick);
            // 
            // labelRaio
            // 
            this.labelRaio.AutoSize = true;
            this.labelRaio.Location = new System.Drawing.Point(31, 231);
            this.labelRaio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRaio.Name = "labelRaio";
            this.labelRaio.Size = new System.Drawing.Size(44, 16);
            this.labelRaio.TabIndex = 4;
            this.labelRaio.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 5;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(19, 144);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 28);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 803);
            this.Controls.Add(this.LB_Aceleracao);
            this.Controls.Add(this.LB_Massa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelRaio);
            this.Controls.Add(this.panelArena);
            this.Controls.Add(this.LB_GoBack);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPlay";
            this.Text = "FormPlay";
            this.Load += new System.EventHandler(this.FormPlay_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LB_GoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Massa;
        private System.Windows.Forms.Label LB_Aceleracao;
        private System.Windows.Forms.Panel panelArena;
        private System.Windows.Forms.Timer timerAnima;
        private System.Windows.Forms.Label labelRaio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPlay;
    }
}