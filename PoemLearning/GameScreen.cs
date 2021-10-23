namespace PoemLearning
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class GameScreen : Form
    {
        private GameScreenController controller;

        public GameScreen()
        {
            InitializeComponent();
            this.controller = new GameScreenController();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.LocalizeAndResizePictureboxes();

            #region Set ImageLayout, SizeMode and Image properties
            this.Icon = Properties.Resources.icon;

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.bg;

            this.pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.Image = Properties.Resources.defaultImage;

            this.pictureBoxCube.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBoxCube.Image = Properties.Resources.cube;
            #endregion
        }

        private void LocalizeAndResizePictureboxes()
        {
            #region pictureBocImage
            this.pictureBoxImage.Size = new Size
                    (
                        Convert.ToInt32(this.Height * 0.6),
                        Convert.ToInt32(this.Height * 0.6)
                    );
            this.pictureBoxImage.Location = new Point
                    (
                        Convert.ToInt32( (this.Width * 0.5) - this.pictureBoxImage.Height * 0.5 ),
                        Convert.ToInt32( this.Height * 0.2 )
                    );

            #endregion

            #region pictureBoxCube
            this.pictureBoxCube.Size = new Size
                    (
                        Convert.ToInt32(this.Width * 0.17),
                        Convert.ToInt32(this.Height * 0.17)
                    );
            this.pictureBoxCube.Location = new Point
                    (
                        this.Width - this.pictureBoxCube.Width - (Convert.ToInt32(this.Width * 0.01)),
                        this.Height - this.pictureBoxCube.Height - (Convert.ToInt32(this.Height * 0.08))
                    );
            #endregion
        }

        private void GameScreen_SizeChanged(object sender, EventArgs e)
            => this.LocalizeAndResizePictureboxes();

        private async void pictureBoxCube_Click(object sender, EventArgs e)
        {
            this.pictureBoxCube.Click -= this.pictureBoxCube_Click;

            this.pictureBoxImage.Image = Properties.Resources.cubeCountDown;
            await Task.Run
                (
                    delegate ()
                    { 
                        Thread.Sleep(3000);

                        try { this.pictureBoxImage.Image = this.controller.GetRandomImage(); }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message,"Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                );
            this.pictureBoxCube.Click += this.pictureBoxCube_Click;
        }
    }
}
