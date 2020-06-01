using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphViewer
{
    public partial class form_list_of_rebrs : Form
    {
        public form_list_of_rebrs()
        {
            InitializeComponent();
        }

        private void button_build_Click(object sender, EventArgs e)
        {
            try
            {
                MyData.n = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Неверное количество вершин");
                return;
            }
            SetPointDefault();
            string[] s = (textbox_list_rebr.Text).Split('\n');

            for (int i = 0; i < s.Length; i++)
                if (s[i] != "")
                {
                    int fi = 0, se = 0, th = 0;
                    string[] ss = s[i].Split(' ');

                    try
                    {
                        fi = Convert.ToInt32(ss[0]) - 1;
                        se = Convert.ToInt32(ss[1]) - 1;
                        th = Convert.ToInt32(ss[2]);
                    }
                    catch
                    {
                        MessageBox.Show("Неверный ввод (вершина вершина масса)");
                        return;
                    }

                    MyData.rebr[fi, MyData.count_rebr[fi]] = se;
                    MyData.count_rebr[fi]++;
                    MyData.rebr[se, MyData.count_rebr[se]] = fi;
                    MyData.count_rebr[se]++;
                    MyData.a_mass[fi, se] = th;
                    MyData.a_mass[se, fi] = th;
                    MyData.color_lines[fi, se] = Pens.Red;
                    MyData.color_lines[se, fi] = Pens.Red;
                }
            
        }
        private void SetPointDefault()
        {
            for (int i = 0; i < MyData.n; i++)
            {
                MyData.a_x[i] = 100 + i * 20;
                MyData.a_y[i] = 200;
                if (i % 2 == 1) MyData.a_y[i] -= 20;
            }
        }

        private void button_finish_build_Click(object sender, EventArgs e)
        {

        }

        private void textbox_list_rebr_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
