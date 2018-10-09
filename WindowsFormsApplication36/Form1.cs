using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication36
{
    public partial class EmreEkinciler : Form
    {
        Bitmap kaynak, sonuc;
        public EmreEkinciler()
        {
            InitializeComponent();
        }

        private void resimSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                cerceve1.Image = kaynak;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bT709AlgoritmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            sonuc = new Bitmap(gen, yuk);

            for (int j = 0; j < yuk; j++)
            {
                for (int i = 0; i < gen; i++)
                {
                    Color Renk1 = kaynak.GetPixel(i, j);
                    int Yenigri = (int)((double)(Renk1.R * 0.2125) + (double)(Renk1.G * 0.7154) + (double)(Renk1.B * 0.072));
                    Color gri1 = Color.FromArgb(Yenigri, Yenigri, Yenigri);
                    sonuc.SetPixel(i, j, gri1);


                }

                cerceve2.Image = sonuc;
            }
        }

        private void lumaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            sonuc = new Bitmap(gen, yuk);

            for (int j = 0; j < yuk; j++)
            {
                for (int i = 0; i < gen; i++)
                {
                    Color Renk1 = kaynak.GetPixel(i, j);
                    int Yenigri = (int)(double)((Renk1.R * 0.3) + (Renk1.G * 0.59) + (Renk1.B * 0.11));
                    Color gri1 = Color.FromArgb(Yenigri, Yenigri, Yenigri);
                    sonuc.SetPixel(i, j, gri1);


                }

                cerceve2.Image = sonuc;
            }
        }

        private void açıklıkYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            sonuc = new Bitmap(gen, yuk);

            for (int j = 0; j < yuk; j++)
            {
                for (int i = 0; i < gen; i++)
                {
                    Color Renk1 = kaynak.GetPixel(i, j);
                    int Yenigri = Math.Max(Renk1.B, (Math.Max(Renk1.R, Renk1.G)) + Math.Min(Renk1.B, Math.Min(Renk1.R, Renk1.G))) / 2;
                    Color gri1 = Color.FromArgb(Yenigri, Yenigri, Yenigri);
                    sonuc.SetPixel(i, j, gri1);


                }

                cerceve2.Image = sonuc;
            }
        }

        private void EmreEkinciler_Load(object sender, EventArgs e)
        {

        }

        private void kanalÇıkarımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;


            sonuc = new Bitmap(gen, yuk);

            for (int j = 0; j < yuk; j++)
            {
                for (int i = 0; i < gen; i++)
                {
                    Color Renk1 = kaynak.GetPixel(i, j);
                    int Yenigri = (Renk1.R | Renk1.G | Renk1.B);
                    Color gri1 = Color.FromArgb(Yenigri, Yenigri, Yenigri);
                    sonuc.SetPixel(i, j, gri1);


                }

                cerceve2.Image = sonuc;
            }
        }
    }
}

