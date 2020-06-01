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
    public static class MyData
    {
        public const int maxCorners = 100;
        public static int[,] rebr = new int[maxCorners, maxCorners];
        public static bool ff, flagclickL = false, flagPainting = false, add_reb_flag = false, add_ver_flag = false, del_reb_flag = false, del_ver_flag = false;
        public static int tt, n = 0, start, finish, first_ver = -1, index_fi, index_se, tick_deextra = 4;
        public static int[] a_y = new int[maxCorners], distance = new int[maxCorners];
        public static int[] a_x = new int[maxCorners], count_rebr = new int [maxCorners];
        public static int[] prevCorner = new int[maxCorners];
        public static Color[] color_corners = new Color[maxCorners];
        public static Pen[,] color_lines = new Pen[maxCorners, maxCorners];
        public static int[,] a_mass = new int[maxCorners, maxCorners];
        public static double[] sdvigy = new double[maxCorners], sdvigx = new double[maxCorners];
        public const double constmass = 25000;
        public static HashSet<(int, (int, int))> Deextra_set = new HashSet<(int, (int, int))>();
        public static double zoom = 1;
        public static string text_box_mass = "";
        public static void flush_data()
        {
            flagclickL = false;
            flagPainting = false;
            add_reb_flag = false;
            add_ver_flag = false;
            del_reb_flag = false;
            del_ver_flag = false;
            n = 0;
            Deextra_set.Clear();
            zoom = 1;
            text_box_mass = "";
            for (int i = 0; i < maxCorners; i++)
            {
                prevCorner[i] = i;
                distance[i] = int.MaxValue;
                count_rebr[i] = 0;
                color_corners[i] = Color.Black;
            }
        }
    }
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Form settings, draw, choose, rebrs, algo;
        [STAThread]
        static void Main()
        {
            MyData.flush_data();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            choose = new Chose_form();
            Application.Run(choose);
        }

        public static void RunDrawingSettings()
        {
            settings = new Settings_form();
            settings.Show();
        }
        public static void RunListOfRebr()
        {
            rebrs = new form_list_of_rebrs();
            rebrs.Show();
        }

        public static void RunGraphView()
        {
            draw = new Draw_form();
            draw.Show();
        }

        public static void RunAlgo()
        {
            algo = new Deextra_settings_form();
            algo.Show();
        }

    }
}
