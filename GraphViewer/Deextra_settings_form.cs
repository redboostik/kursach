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
    public partial class Deextra_settings_form : Form
    {
        public Deextra_settings_form()
        {
            InitializeComponent();
        }
        private void DeextraTimer_Tick(object sender, EventArgs e)
        {
            if (MyData.color_lines[MyData.index_fi, MyData.index_se] == Pens.Red) MyData.color_lines[MyData.index_fi, MyData.index_se] = Pens.Green;
            else MyData.color_lines[MyData.index_fi, MyData.index_se] = Pens.Red;
            if (MyData.color_lines[MyData.index_se, MyData.index_fi] == Pens.Red) MyData.color_lines[MyData.index_se, MyData.index_fi] = Pens.Green;
            else MyData.color_lines[MyData.index_se, MyData.index_fi] = Pens.Red;
            MyData.tick_deextra++;
            if (MyData.tick_deextra == 5)
            {
                MyData.tick_deextra = 0;
                deekstra_algo();
            }
        }
        private void flush_deextra_info()
        {
            MyData.tick_deextra = 4;
            MyData.Deextra_set.Clear();
            textBox_info.Clear();
            for (int i = 0; i < MyData.maxCorners; i++)
            {
                MyData.prevCorner[i] = i;
                MyData.distance[i] = 999999999;
                MyData.color_corners[i] = Color.Black;
                for(int j = 0; j < 100; j++) MyData.color_lines[i, j] = Pens.Red;
            }
            
        }
        private void button_start_algo_Click(object sender, EventArgs e)
        {
            flush_deextra_info();
            try
            {
                MyData.start = Convert.ToInt32(textBox_start_ver.Text) - 1;
            }
            catch
            {
                MessageBox.Show("введите номер стартовой вершины");
                return;
            }

            try
            {
                MyData.finish = Convert.ToInt32(textBox_finish_ver.Text) - 1;
            }
            catch
            {
                MessageBox.Show("введите номер конечной вершины");
                return;
            }

            MyData.add_reb_flag = false;
            MyData.del_reb_flag = false;
            deekstra_algo();
        }

        private void deekstra_algo()
        {
            DeextraTimer.Enabled = false;
            (int, (int, int)) tup;
            if (MyData.distance[MyData.start] != 0)
            {
                tup = (0, (MyData.start, MyData.start));
                MyData.Deextra_set.Add(tup);
            }

            while (MyData.Deextra_set.Count() > 0)
            {
                tup = MyData.Deextra_set.First();
                MyData.prevCorner[tup.Item2.Item2] = tup.Item2.Item1;
                int start = tup.Item2.Item2;
                MyData.distance[start] = tup.Item1;

                for (int i = 0; i < MyData.count_rebr[start]; i++)
                {

                    if (MyData.a_mass[start, MyData.rebr[start, i]] + MyData.distance[start] < MyData.distance[MyData.rebr[start, i]])
                    {
                        MyData.Deextra_set.Add((MyData.a_mass[start, MyData.rebr[start,i]] + MyData.distance[start], (start, MyData.rebr[start,i])));
                    }
                }

                MyData.Deextra_set.Remove(tup);
                MyData.index_fi = tup.Item2.Item2;
                MyData.index_se = tup.Item2.Item1;
                MyData.color_corners[tup.Item2.Item1] = Color.Purple;
                DeextraTimer.Enabled = true;
                return;
            }
            string out_distanse = "", outWay = "";
            for (int i = 0; i < MyData.n; i++)
            {
                out_distanse += Convert.ToString((int)(i + 1)) + " = ";
                if(MyData.distance[i] < 999999999) out_distanse += Convert.ToString(MyData.distance[i]) + "\r\n";
                else out_distanse += "невозможно добраться\r\n";
            }

            int x = MyData.finish;
            while(MyData.prevCorner[x] != x)
            {
                outWay += (x + 1).ToString() + "\r\n";
                x = MyData.prevCorner[x];
            }
            outWay += (x + 1).ToString() + "\r\n";

            if (x != MyData.start) textBox_way.Text = "невозможно добраться\r\n";
            else textBox_way.Text = outWay;

            textBox_info.Text = out_distanse;
        }


    }
}
