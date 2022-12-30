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
            this.labelInimigo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_Massa = new System.Windows.Forms.Button();
            this.LB_MAceleracao = new System.Windows.Forms.Label();
            this.RB_10 = new System.Windows.Forms.RadioButton();
            this.RB_20 = new System.Windows.Forms.RadioButton();
            this.RB_30 = new System.Windows.Forms.RadioButton();
            this.RB_40 = new System.Windows.Forms.RadioButton();
            this.RB_50 = new System.Windows.Forms.RadioButton();
            this.RB_60 = new System.Windows.Forms.RadioButton();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 40);
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
            this.label1.Location = new System.Drawing.Point(1328, 1221);
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
            this.LB_Massa.Location = new System.Drawing.Point(31, 536);
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
            this.LB_Aceleracao.Location = new System.Drawing.Point(31, 591);
            this.LB_Aceleracao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Aceleracao.Name = "LB_Aceleracao";
            this.LB_Aceleracao.Size = new System.Drawing.Size(220, 38);
            this.LB_Aceleracao.TabIndex = 6;
            this.LB_Aceleracao.Text = "Acelereção:0";
            // 
            // panelArena
            // 
            this.panelArena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelArena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelArena.Location = new System.Drawing.Point(636, 26);
            this.panelArena.Margin = new System.Windows.Forms.Padding(4);
            this.panelArena.Name = "panelArena";
            this.panelArena.Size = new System.Drawing.Size(750, 750);
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
            this.labelRaio.Location = new System.Drawing.Point(35, 413);
            this.labelRaio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRaio.Name = "labelRaio";
            this.labelRaio.Size = new System.Drawing.Size(44, 16);
            this.labelRaio.TabIndex = 4;
            this.labelRaio.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 372);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(188, 369);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 28);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelInimigo
            // 
            this.labelInimigo.AutoSize = true;
            this.labelInimigo.Location = new System.Drawing.Point(35, 440);
            this.labelInimigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInimigo.Name = "labelInimigo";
            this.labelInimigo.Size = new System.Drawing.Size(44, 16);
            this.labelInimigo.TabIndex = 7;
            this.labelInimigo.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Silom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Escolher Velocidade";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(18, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // B_Massa
            // 
            this.B_Massa.BackColor = System.Drawing.Color.DarkOrange;
            this.B_Massa.Font = new System.Drawing.Font("Silom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Massa.Location = new System.Drawing.Point(18, 163);
            this.B_Massa.Name = "B_Massa";
            this.B_Massa.Size = new System.Drawing.Size(289, 38);
            this.B_Massa.TabIndex = 10;
            this.B_Massa.Text = "Massa";
            this.B_Massa.UseVisualStyleBackColor = false;
            this.B_Massa.Click += new System.EventHandler(this.B_Massa_Click);
            // 
            // LB_MAceleracao
            // 
            this.LB_MAceleracao.AutoSize = true;
            this.LB_MAceleracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MAceleracao.Location = new System.Drawing.Point(31, 478);
            this.LB_MAceleracao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_MAceleracao.Name = "LB_MAceleracao";
            this.LB_MAceleracao.Size = new System.Drawing.Size(201, 38);
            this.LB_MAceleracao.TabIndex = 11;
            this.LB_MAceleracao.Text = "Aceleração:";
            // 
            // RB_10
            // 
            this.RB_10.AutoSize = true;
            this.RB_10.BackColor = System.Drawing.Color.Transparent;
            this.RB_10.Checked = true;
            this.RB_10.Font = new System.Drawing.Font("Silom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_10.Location = new System.Drawing.Point(47, 228);
            this.RB_10.Name = "RB_10";
            this.RB_10.Size = new System.Drawing.Size(89, 31);
            this.RB_10.TabIndex = 12;
            this.RB_10.TabStop = true;
            this.RB_10.Text = "10kg";
            this.RB_10.UseVisualStyleBackColor = false;
            // 
            // RB_20
            // 
            this.RB_20.AutoSize = true;
            this.RB_20.BackColor = System.Drawing.Color.Transparent;
            this.RB_20.Font = new System.Drawing.Font("Silom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_20.Location = new System.Drawing.Point(47, 265);
            this.RB_20.Name = "RB_20";
            this.RB_20.Size = new System.Drawing.Size(93, 31);
            this.RB_20.TabIndex = 13;
            this.RB_20.Text = "20kg";
            this.RB_20.UseVisualStyleBackColor = false;
            // 
            // RB_30
            // 
            this.RB_30.AutoSize = true;
            this.RB_30.BackColor = System.Drawing.Color.Transparent;
            this.RB_30.Font = new System.Drawing.Font("Silom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_30.Location = new System.Drawing.Point(47, 302);
            this.RB_30.Name = "RB_30";
            this.RB_30.Size = new System.Drawing.Size(93, 31);
            this.RB_30.TabIndex = 14;
            this.RB_30.Text = "30kg";
            this.RB_30.UseVisualStyleBackColor = false;
            // 
            // RB_40
            // 
            this.RB_40.AutoSize = true;
            this.RB_40.BackColor = System.Drawing.Color.Transparent;
            this.RB_40.Font = new System.Drawing.Font("Silom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_40.Location = new System.Drawing.Point(177, 228);
            this.RB_40.Name = "RB_40";
            this.RB_40.Size = new System.Drawing.Size(93, 31);
            this.RB_40.TabIndex = 15;
            this.RB_40.Text = "40kg";
            this.RB_40.UseVisualStyleBackColor = false;
            // 
            // RB_50
            // 
            this.RB_50.AutoSize = true;
            this.RB_50.BackColor = System.Drawing.Color.Transparent;
            this.RB_50.Font = new System.Drawing.Font("Silom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_50.Location = new System.Drawing.Point(177, 265);
            this.RB_50.Name = "RB_50";
            this.RB_50.Size = new System.Drawing.Size(93, 31);
            this.RB_50.TabIndex = 16;
            this.RB_50.Text = "50kg";
            this.RB_50.UseVisualStyleBackColor = false;
            // 
            // RB_60
            // 
            this.RB_60.AutoSize = true;
            this.RB_60.BackColor = System.Drawing.Color.Transparent;
            this.RB_60.Font = new System.Drawing.Font("Silom", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_60.Location = new System.Drawing.Point(177, 302);
            this.RB_60.Name = "RB_60";
            this.RB_60.Size = new System.Drawing.Size(93, 31);
            this.RB_60.TabIndex = 17;
            this.RB_60.Text = "60kg";
            this.RB_60.UseVisualStyleBackColor = false;
            // 
            // FormPlay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 803);
            this.Controls.Add(this.RB_60);
            this.Controls.Add(this.RB_50);
            this.Controls.Add(this.RB_40);
            this.Controls.Add(this.RB_30);
            this.Controls.Add(this.RB_20);
            this.Controls.Add(this.RB_10);
            this.Controls.Add(this.LB_MAceleracao);
            this.Controls.Add(this.B_Massa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelInimigo);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label labelInimigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_Massa;
        private System.Windows.Forms.Label LB_MAceleracao;
        private System.Windows.Forms.RadioButton RB_10;
        private System.Windows.Forms.RadioButton RB_20;
        private System.Windows.Forms.RadioButton RB_30;
        private System.Windows.Forms.RadioButton RB_40;
        private System.Windows.Forms.RadioButton RB_50;
        private System.Windows.Forms.RadioButton RB_60;
    }
}