using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace GraphViewer
{
    public partial class Draw_form : Form
    {
        public Draw_form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            if (!MyData.flagPainting) setnewpoint();
        }

        private double rast(double x1, double y1, double x2, double y2)
        {
            return (Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
        }

        private void setnewpoint()
        {
            for (int i = 0; i < MyData.n; i++)
            {
                for (int j = 0; j < MyData.n; j++)
                    if (i != j && i != MyData.tt)
                    {
                        double ras = rast(MyData.a_x[i], MyData.a_y[i], MyData.a_x[j], MyData.a_y[j]);
                        double fr = MyData.constmass / ras / ras;
                        MyData.sdvigx[i] += (-MyData.a_x[j] + MyData.a_x[i]) / ras * fr / 2;
                        MyData.sdvigy[i] += (-MyData.a_y[j] + MyData.a_y[i]) / ras * fr / 2;
                    }
            }

            for (int i = 0; i < MyData.n; i++)
            {
                for (int j = 0; j < MyData.count_rebr[i]; j++) if (i != MyData.tt)
                    {
                        double ras = rast(MyData.a_x[i], MyData.a_y[i], MyData.a_x[MyData.rebr[i,j]], MyData.a_y[MyData.rebr[i,j]]);
                        double fr = (ras - 40);
                        MyData.sdvigx[i] += (MyData.a_x[MyData.rebr[i,j]] - MyData.a_x[i]) / ras * fr / 3;
                        MyData.sdvigy[i] += (MyData.a_y[MyData.rebr[i,j]] - MyData.a_y[i]) / ras * fr / 3;
                    }
            }

            for (int i = 0; i < MyData.n; i++)
            {

                MyData.a_x[i] += (int)(MyData.sdvigx[i]);
                MyData.a_y[i] += (int)(MyData.sdvigy[i]);
                MyData.sdvigx[i] = 0;
                MyData.sdvigy[i] = 0;
            }
        }
        private void print_line(Pen col, int x1, int y1, int x2, int y2, PaintEventArgs e)
        {
            Graphics pogr = e.Graphics;
            pogr.DrawLine(col, x1, y1, x2, y2);
        }

        private void print_corner(Color col, int x, int y, int d1, int d2, PaintEventArgs e)
        {
            Graphics pogr = e.Graphics;
            pogr.FillEllipse(new SolidBrush(col), x, y, d1, d2);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics pogr = e.Graphics;

            pogr.Clear(Color.DarkGray);
            for (int i = 0; i < MyData.n; i++)
                for (int j = 0;j < MyData.count_rebr[i];j++)
                {
                    int k = i;
                    print_line(MyData.color_lines[i, MyData.rebr[i,j]], (int)((MyData.a_x[MyData.rebr[i,j]] + 6) * MyData.zoom), (int)((MyData.a_y[MyData.rebr[i,j]] + 6) * MyData.zoom), (int)((MyData.a_x[i] + 6) * MyData.zoom), (int)((MyData.a_y[i] + 6) * MyData.zoom), e);
                }

            for (int i = 0; i < MyData.n; i++) print_corner(MyData.color_corners[i], (int)((MyData.a_x[i]) * MyData.zoom), (int)((MyData.a_y[i]) * MyData.zoom), (int)(11 * MyData.zoom), (int)(11 * MyData.zoom), e);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MyData.flagPainting == false)
            {
                int xx = e.X, yy = e.Y, k = (int)(11 / MyData.zoom);
                xx = (int)(xx / MyData.zoom);
                yy = (int)(yy / MyData.zoom);

                if (e.Button == MouseButtons.Left)
                {
                    MyData.tt = -1;
                    for (int i = 0; i < MyData.n; i++)
                        if ((xx >= MyData.a_x[i] - 5) && (xx <= MyData.a_x[i] + k + 5) && (yy >= MyData.a_y[i] - 5) && (yy <= MyData.a_y[i] + k + 5))
                        {
                            MyData.tt = i;
                            MyData.flagclickL = true;
                            MyData.ff = true;
                            break;
                        }
                }
                if (e.Button == MouseButtons.Right)
                {
                    for (int i = 0; i < MyData.n; i++)
                        if ((xx >= MyData.a_x[i] - 5) && (xx <= MyData.a_x[i] + k + 5) && (yy >= MyData.a_y[i] - 5) && (yy <= MyData.a_y[i] + k + 5))
                        {
                            MessageBox.Show("Вершина " + (1 + i).ToString() + " Расстояние " + (MyData.distance[i]).ToString());
                            break;
                        }
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int xx = e.X , yy = e.Y, k = (int)(11 / MyData.zoom);
            xx = (int)(xx / MyData.zoom);
            yy = (int)(yy / MyData.zoom);

            if (!MyData.flagPainting)
            {
                MyData.flagclickL = false;
                MyData.tt = -1;
                MyData.ff = false;
            }
            else
            if (MyData.add_ver_flag)
            {
                MyData.color_corners[MyData.n] = Color.Black;
                MyData.a_x[MyData.n] = (int)((Cursor.Position.X - this.Location.X - 11) / MyData.zoom);
                MyData.a_y[MyData.n] = (int)((Cursor.Position.Y - 31 - this.Location.Y) / MyData.zoom);
                MyData.n++;
            }
            else
            if (MyData.del_ver_flag)
            {

                for (int i = 0; i < MyData.n; i++)
                    if ((xx >= MyData.a_x[i] - 5) && (xx <= MyData.a_x[i] + k + 5) && (yy >= MyData.a_y[i] - 5) && (yy <= MyData.a_y[i] + k + 5))
                    {
                        MyData.tt = i;
                        MyData.ff = true;
                        break;
                    }

                if (MyData.ff)
                {

                    for (int i = MyData.tt; i < MyData.n - 1; i++)
                    {
                        int temp = MyData.a_x[i];
                        MyData.a_x[i] = MyData.a_x[i + 1];
                        MyData.a_x[i + 1] = temp;
                        temp = MyData.a_y[i];
                        MyData.a_y[i] = MyData.a_y[i + 1];
                        MyData.a_y[i + 1] = temp;
                    }
                    MyData.n--;
                    MyData.ff = false;
                }
                MyData.tt = 0;
            }
            else
            if (MyData.del_reb_flag)
            {
                if (MyData.first_ver == -1)
                {
                    for (int i = 0; i < MyData.n; i++)
                        if ((xx >= MyData.a_x[i] - 5) && (xx <= MyData.a_x[i] + k + 5) && (yy >= MyData.a_y[i] - 5) && (yy <= MyData.a_y[i] + k + 5))
                        {
                            MyData.first_ver = i;
                            break;
                        }
                    if (MyData.first_ver != -1) MyData.color_corners[MyData.first_ver] = Color.Red;
                }
                else
                {
                    int second_ver = -1;
                    MyData.color_corners[MyData.first_ver] = Color.Black;
                    for (int i = 0; i < MyData.n; i++)
                        if ((xx >= MyData.a_x[i] - 5) && (xx <= MyData.a_x[i] + k + 5) && (yy >= MyData.a_y[i] - 5) && (yy <= MyData.a_y[i] + k + 5))
                        {
                            second_ver = i;
                            break;
                        }

                    if(second_ver == -1)
                    {
                        MyData.first_ver = -1;
                        return;
                    }

                    MyData.color_corners[MyData.first_ver] = Color.Black;
                    for (int i = 0; i < MyData.count_rebr[MyData.first_ver]; i++)
                        if (MyData.rebr[MyData.first_ver, i] == second_ver)
                        {
                            for(i = 0; i < MyData.count_rebr[MyData.first_ver] - 1; i++)
                            {
                                int temp = MyData.rebr[MyData.first_ver, i];
                                MyData.rebr[MyData.first_ver, i] = MyData.rebr[MyData.first_ver, i + 1];
                                MyData.rebr[MyData.first_ver, i + 1] = temp;
                            }
                        }
                    MyData.count_rebr[MyData.first_ver]--;

                    for (int i = 0; i < MyData.count_rebr[second_ver]; i++)
                        if (MyData.rebr[second_ver, i] == MyData.first_ver)
                        {
                            int temp = MyData.rebr[MyData.first_ver, i];
                            MyData.rebr[second_ver, i] = MyData.rebr[second_ver, i + 1];
                            MyData.rebr[second_ver, i + 1] = temp;
                        }
                    MyData.count_rebr[second_ver]--;
                    MyData.first_ver = -1;
                }

            }
            else
            if (MyData.add_reb_flag)
            {
                if (MyData.first_ver == -1)
                {
                    for (int i = 0; i < MyData.n; i++)
                        if ((xx >= MyData.a_x[i] - 5) && (xx <= MyData.a_x[i] + k + 5) && (yy >= MyData.a_y[i] - 5) && (yy <= MyData.a_y[i] + k + 5))
                        {
                            MyData.first_ver = i;
                            break;
                        }
                    if (MyData.first_ver != -1) MyData.color_corners[MyData.first_ver] = Color.Green;
                }
                else
                {
                    MyData.color_corners[MyData.first_ver] = Color.Black;
                    int second_ver = -1;
                    for (int i = 0; i < MyData.n; i++)
                        if ((xx >= MyData.a_x[i] - 5) && (xx <= MyData.a_x[i] + k + 5) && (yy >= MyData.a_y[i] - 5) && (yy <= MyData.a_y[i] + k + 5))
                        {
                            second_ver = i;
                            break;
                        }
                    if (second_ver == -1)
                    {
                        MyData.color_corners[MyData.first_ver] = Color.Black;
                        MyData.first_ver = -1;
                        return;
                    }
                    bool flag_add = true;
                    for (int i = 0; i < MyData.count_rebr[MyData.first_ver]; i++) 
                        if (MyData.rebr[MyData.first_ver, i] == second_ver) flag_add = false;

                    if (flag_add)
                    {
                        try
                        {
                            MyData.a_mass[second_ver, MyData.first_ver] = Convert.ToInt32(MyData.text_box_mass);
                            MyData.a_mass[MyData.first_ver, second_ver] = Convert.ToInt32(MyData.text_box_mass);
                        }
                        catch
                        {
                            MessageBox.Show("введите массу ребра");
                            return;
                        }
                        MyData.rebr[MyData.first_ver, MyData.count_rebr[MyData.first_ver]] = second_ver;
                        MyData.rebr[second_ver, MyData.count_rebr[second_ver]] = MyData.first_ver;
                        MyData.count_rebr[MyData.first_ver]++;
                        MyData.count_rebr[second_ver]++;
                        MyData.color_lines[MyData.first_ver, second_ver] = Pens.Red;
                        MyData.color_lines[second_ver, MyData.first_ver] = Pens.Red;
                    }
                    MyData.first_ver = -1;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MyData.flagclickL)
            {
                int xx = e.X, yy = e.Y, k = (int)(11 / MyData.zoom);
                xx = (int)(xx / MyData.zoom);
                yy = (int)(yy / MyData.zoom);
                if (MyData.tt > -1)
                {
                    MyData.a_x[MyData.tt] = xx;
                    MyData.a_y[MyData.tt] = yy;

                }
            }
        }
    }
    
}
