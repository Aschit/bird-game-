namespace quiz_game
{
    partial class floppybird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(floppybird));
            this.Top = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.Bottom = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.Image = ((System.Drawing.Image)(resources.GetObject("Top.Image")));
            this.Top.Location = new System.Drawing.Point(535, -2);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(100, 86);
            this.Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Top.TabIndex = 0;
            this.Top.TabStop = false;
            this.Top.Click += new System.EventHandler(this.Top_Click);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(291, 134);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(108, 80);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            this.bird.UseWaitCursor = true;
            this.bird.Click += new System.EventHandler(this.floppybird_Load);
            // 
            // Bottom
            // 
            this.Bottom.Image = ((System.Drawing.Image)(resources.GetObject("Bottom.Image")));
            this.Bottom.Location = new System.Drawing.Point(535, 320);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(100, 113);
            this.Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bottom.TabIndex = 2;
            this.Bottom.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoretext.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.scoretext.ForeColor = System.Drawing.Color.Red;
            this.scoretext.Location = new System.Drawing.Point(36, 33);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(114, 33);
            this.scoretext.TabIndex = 3;
            this.scoretext.Text = "Score: 0";
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(-6, 439);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(674, 42);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 4;
            this.Ground.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // floppybird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(668, 478);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.Bottom);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.Top);
            this.Name = "floppybird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "floppy game";
            this.Activated += new System.EventHandler(this.floppybird_Load);
            this.Load += new System.EventHandler(this.floppybird_Load);
            this.Click += new System.EventHandler(this.floppybird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Top;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox Bottom;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Timer gametimer;
    }
}

