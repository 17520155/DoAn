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
            Pen red = new Pen(Color.Red,2);
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                {
                    int a;
                    a = rnd.Next(0, 2);
                    if (a == 0) continue;
                    a = rnd.Next(0, 2);
                    if (a==0)
                    {
                        Rectangle rec = new Rectangle(j * 50 + 4 + j * 4, i * 50 + 4 + i * 4, 50, 50);
                        e.Graphics.DrawRectangle(red, rec);
                    }
                    else
                    {
                        Point p1, p2, p3, p4;
                        p1 = new Point(j * 50 + 4 + j * 4, i * 50 + 4 + i * 4);
                        p2 = new Point(j * 50 + 4 + j * 4, i * 50 + 4 + i * 4 + 50);
                        p3 = new Point(j * 50 + 4 + j * 4 + 50, i * 50 + 4 + i * 4);
                        p4 = new Point(j * 50 + 4 + j * 4 + 50, i * 50 + 4 + i * 4 + 50);
                        a = rnd.Next(0, 4);
                        switch (a)
                        {
                            case 0:
                                e.Graphics.DrawLine(red, p1, p2);
                                e.Graphics.DrawLine(red, p1, p3);
                                e.Graphics.DrawLine(red, p2, p3);
                                break;
                            case 1:
                                e.Graphics.DrawLine(red, p1, p2);
                                e.Graphics.DrawLine(red, p1, p4);
                                e.Graphics.DrawLine(red, p2, p4);
                                break;
                            case 2:
                                e.Graphics.DrawLine(red, p2, p3);
                                e.Graphics.DrawLine(red, p2, p4);
                                e.Graphics.DrawLine(red, p3, p4);
                                break;
                            case 3:
                                e.Graphics.DrawLine(red, p1, p3);
                                e.Graphics.DrawLine(red, p1, p4);
                                e.Graphics.DrawLine(red, p4, p3);
                                break;
                        }
                    }
                }

        }
    }
}
