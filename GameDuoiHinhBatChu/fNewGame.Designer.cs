namespace GameDuoiHinhBatChu
{
    partial class fNewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNewGame));
            this.ptrExit = new System.Windows.Forms.PictureBox();
            this.ptrNewGame = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptrExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrNewGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrExit
            // 
            this.ptrExit.BackgroundImage = global::GameDuoiHinhBatChu.Properties.Resources.exit1;
            this.ptrExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptrExit.Location = new System.Drawing.Point(182, 199);
            this.ptrExit.Name = "ptrExit";
            this.ptrExit.Size = new System.Drawing.Size(125, 39);
            this.ptrExit.TabIndex = 2;
            this.ptrExit.TabStop = false;
            this.ptrExit.Click += new System.EventHandler(this.ptrExit_Click);
            this.ptrExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptrExit_MouseDown);
            this.ptrExit.MouseLeave += new System.EventHandler(this.ptrExit_MouseLeave);
            this.ptrExit.MouseHover += new System.EventHandler(this.ptrExit_MouseHover);
            this.ptrExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptrExit_MouseUp);
            // 
            // ptrNewGame
            // 
            this.ptrNewGame.BackgroundImage = global::GameDuoiHinhBatChu.Properties.Resources.newgame1;
            this.ptrNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptrNewGame.Location = new System.Drawing.Point(182, 154);
            this.ptrNewGame.Name = "ptrNewGame";
            this.ptrNewGame.Size = new System.Drawing.Size(125, 39);
            this.ptrNewGame.TabIndex = 1;
            this.ptrNewGame.TabStop = false;
            this.ptrNewGame.Click += new System.EventHandler(this.ptrNewGame_Click);
            this.ptrNewGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptrNewGame_MouseDown);
            this.ptrNewGame.MouseLeave += new System.EventHandler(this.ptrNewGame_MouseLeave);
            this.ptrNewGame.MouseHover += new System.EventHandler(this.ptrNewGame_MouseHover);
            this.ptrNewGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptrNewGame_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GameDuoiHinhBatChu.Properties.Resources.zc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(50, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Version 1.0.0";
            // 
            // fNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(492, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptrExit);
            this.Controls.Add(this.ptrNewGame);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(508, 296);
            this.MinimumSize = new System.Drawing.Size(508, 296);
            this.Name = "fNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐUỔI HÌNH BẮT CHỮ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fNewGame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptrExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrNewGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptrNewGame;
        private System.Windows.Forms.PictureBox ptrExit;
        private System.Windows.Forms.Label label1;
    }
}