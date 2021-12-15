namespace flappybird
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playagain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // pipetop
            // 
            this.pipetop.Image = ((System.Drawing.Image)(resources.GetObject("pipetop.Image")));
            this.pipetop.Location = new System.Drawing.Point(353, -15);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(100, 168);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 0;
            this.pipetop.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = ((System.Drawing.Image)(resources.GetObject("pipebottom.Image")));
            this.pipebottom.Location = new System.Drawing.Point(353, 389);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(100, 233);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 572);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(498, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(27, 323);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(82, 68);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 3;
            this.bird.TabStop = false;
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.Location = new System.Drawing.Point(12, 9);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(151, 33);
            this.scorelabel.TabIndex = 4;
            this.scorelabel.Text = "score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playagain
            // 
            this.playagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playagain.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagain.Location = new System.Drawing.Point(152, 224);
            this.playagain.Name = "playagain";
            this.playagain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playagain.Size = new System.Drawing.Size(221, 167);
            this.playagain.TabIndex = 5;
            this.playagain.Text = "play again";
            this.playagain.UseVisualStyleBackColor = true;
            this.playagain.Visible = false;
            this.playagain.Click += new System.EventHandler(this.playagain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(496, 623);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.pipetop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playagain;
    }
}

