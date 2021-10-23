
namespace PoemLearning
{
    partial class GameScreen
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
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxCube = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCube)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxImage.Location = new System.Drawing.Point(342, 192);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(683, 384);
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // pictureBoxCube
            // 
            this.pictureBoxCube.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCube.Location = new System.Drawing.Point(1147, 563);
            this.pictureBoxCube.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCube.Name = "pictureBoxCube";
            this.pictureBoxCube.Size = new System.Drawing.Size(194, 157);
            this.pictureBoxCube.TabIndex = 1;
            this.pictureBoxCube.TabStop = false;
            this.pictureBoxCube.Click += new System.EventHandler(this.pictureBoxCube_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBoxCube);
            this.Controls.Add(this.pictureBoxImage);
            this.MaximizeBox = false;
            this.Name = "GameScreen";
            this.Text = "Verstanulás";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.SizeChanged += new System.EventHandler(this.GameScreen_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCube)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxCube;
    }
}

