using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme6
{
    public partial class Form1 : Form
    {
        Bitmap resim;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                resim = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = resim;
            }
            Graphics.FromImage(resim).DrawImage(pictureBox1.Image, 0, 0, 300, 300);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Width += 10;
            pictureBox1.Height += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Width -= 10;
            pictureBox1.Height -= 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double w, h, k;
            k = Convert.ToDouble(textBox1.Text);
            w = pictureBox1.Width;
            h = pictureBox1.Height;

            h = h * k;
            w = w * k;
            pictureBox1.Width = Convert.ToInt32(w);
            pictureBox1.Height = Convert.ToInt32(h);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x, y;
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;

            y -= 10;
            pictureBox1.Location = new Point(x, y);
            textBox2.Text = Convert.ToString(x);
            textBox3.Text = Convert.ToString(y);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x, y;
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;

            x -= 10;
            pictureBox1.Location = new Point(x, y);
            textBox2.Text = Convert.ToString(x);
            textBox3.Text = Convert.ToString(y);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x, y;
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;

            y += 10;
            pictureBox1.Location = new Point(x, y);
            textBox2.Text = Convert.ToString(x);
            textBox3.Text = Convert.ToString(y);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x, y;
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;

            x += 10;
            pictureBox1.Location = new Point(x, y);
            textBox2.Text = Convert.ToString(x);
            textBox3.Text = Convert.ToString(y);
        }

        private void button13_Click(object sender, EventArgs e)
        {
          //  pictureBox1.Image.RotateFlip(RotateFlipType.);
           // pictureBox1.Refresh();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox1.Refresh();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            //   pictureBox1.Refresh();
        }

        private void button15_Click(object sender, EventArgs e)
        {
             static Bitmap RotateImage(Image image, float rotateAtX, float rotateAtY, float angle, bool bNoClip)
            {
                int W, H, X, Y;
                if (bNoClip)
                {
                    double dW = (double)image.Width;
                    double dH = (double)image.Height;

                    double degrees = Math.Abs(angle);
                    if (degrees <= 90)
                    {
                        double radians = 0.0174532925 * degrees;
                        double dSin = Math.Sin(radians);
                        double dCos = Math.Cos(radians);
                        W = (int)(dH * dSin + dW * dCos);
                        H = (int)(dW * dSin + dH * dCos);
                        X = (W - image.Width) / 2;
                        Y = (H - image.Height) / 2;
                    }
                    else
                    {
                        degrees -= 90;
                        double radians = 0.0174532925 * degrees;
                        double dSin = Math.Sin(radians);
                        double dCos = Math.Cos(radians);
                        W = (int)(dW * dSin + dH * dCos);
                        H = (int)(dH * dSin + dW * dCos);
                        X = (W - image.Width) / 2;
                        Y = (H - image.Height) / 2;
                    }
                }
                else
                {
                    W = image.Width;
                    H = image.Height;
                    X = 0;
                    Y = 0;
                }

                //create a new empty bitmap to hold rotated image
                Bitmap bmpRet = new Bitmap(W, H);
                bmpRet.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                //make a graphics object from the empty bitmap
                Graphics g = Graphics.FromImage(bmpRet);

                //Put the rotation point in the "center" of the image
                g.TranslateTransform(rotateAtX + X, rotateAtY + Y);

                //rotate the image
                g.RotateTransform(angle);

                //move the image back
                g.TranslateTransform(-rotateAtX - X, -rotateAtY - Y);

                //draw passed in image onto graphics object
                g.DrawImage(image, new PointF(0 + X, 0 + Y));

                return bmpRet;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           // textBox4.Text = "Durdu Kaan Kaltakkıran 201913172065";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
