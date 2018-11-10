using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBTan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            Rectangle[,] rec = new Rectangle[5, 8];
            Pen red = new Pen(Color.Red);
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                {
                    rec[i, j] = new Rectangle(j * 50 + 2 + j*2, i * 50 + 2 + i*2, 50, 50);
                    e.Graphics.DrawRectangle(red, rec[i,j]);
                }

        }
    }
}
