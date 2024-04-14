using System.ComponentModel;
using System.Threading;

namespace ImageProcessing {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private bool isImageExtension(string extension) {
            string[] imageExtensions = { ".jpg", ".jpeg", ".gif", ".png", ".jpg", ".bmp" };
            if (imageExtensions.Contains(extension)) {
                return true;
            }
            return false;
        }

        private Bitmap? orgImg;
        private void loadButton_Click(object sender, EventArgs e) {
            openFileDialogImage.ShowDialog();
            var file = openFileDialogImage.FileName;
            if (file != null) {
                string extension = Path.GetExtension(file).ToLower();
                if (isImageExtension(extension)) {
                    orgImg = new Bitmap(file);
                    originalPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    originalPicture.Image = orgImg;
                    loadLabel.Visible = false;
                } else {
                    originalPicture.Image = null;
                    loadLabel.Visible = true;
                    loadLabel.Text = "Loaded file must be an image!";
                }
            }
        }

        private void Negative(Bitmap img) {
            for (int x = 0; x < img.Width; ++x) {
                for (int y = 0; y < img.Height; ++y) {

                    Color pixel = img.GetPixel(x, y);
                    img.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }

            negativeBox.SizeMode = PictureBoxSizeMode.Zoom;
            negativeBox.Image = img;
        }

        private void Desaturate(Bitmap img) {
            for (int x = 0; x < img.Width; ++x) {
                for (int y = 0; y < img.Height; ++y) {

                    Color pixel = img.GetPixel(x, y);
                    int grayScale = (pixel.R + pixel.G + pixel.B) / 3;
                    img.SetPixel(x, y, Color.FromArgb(grayScale, grayScale, grayScale));
                }
            }

            desaturatedBox.SizeMode = PictureBoxSizeMode.Zoom;
            desaturatedBox.Image = img;
        }

        private void Threshholding(Bitmap img, int threshold) {
            for (int x = 0; x < img.Width; ++x) {
                for (int y = 0; y < img.Height; ++y) {

                    Color pixel = img.GetPixel(x, y);
                    if ((pixel.R + pixel.G + pixel.B) / 3 > threshold) {
                        img.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    } else {
                        img.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }

            thresholdedBox.SizeMode = PictureBoxSizeMode.Zoom;
            thresholdedBox.Image = img;
        }

        private void Satanize(Bitmap img) {
            for (int x = 0; x < img.Width; ++x) {
                for (int y = 0; y < img.Height; ++y) {

                    Color pixel = img.GetPixel(x, y);
                    img.SetPixel(x, y, Color.FromArgb(pixel.R, 0, 0));
                }
            }

            satanizedBox.SizeMode = PictureBoxSizeMode.Zoom;
            satanizedBox.Image = img;
        }

        private void processButton_Click(object sender, EventArgs e) {
            if (orgImg == null) {
                loadLabel.Text = "Load an image before processing!";
                return;
            }
            int nThreads = 4;
            Thread[] threads = new Thread[nThreads];

            Bitmap negativeImg = new Bitmap(orgImg);
            Bitmap desaturatedImg = new Bitmap(orgImg);
            Bitmap thresholdedImg = new Bitmap(orgImg);
            Bitmap satanizedImg = new Bitmap(orgImg);

            threads[0] = new Thread(() => Negative(negativeImg));
            threads[0].Start();

            threads[1] = new Thread(() => Desaturate(desaturatedImg));
            threads[1].Start();

            threads[2] = new Thread(() => Threshholding(thresholdedImg, 150));
            threads[2].Start();

            threads[3] = new Thread(() => Satanize(satanizedImg));
            threads[3].Start();
            satanizedLabel.Visible = false;
            thresholdedLabel.Visible = false;
            desaturizedLabel.Visible = false;
            negativeLaber.Visible = false;

            foreach (var thread in threads) {
                thread.Join();
            }

        }
    }
}
