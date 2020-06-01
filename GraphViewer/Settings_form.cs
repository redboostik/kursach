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
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();
        }
        private void button_next_step_settings_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            button_add_ver.Visible = false;
            button_del_ver.Visible = false;
            button_add_rebr.Visible = true;
            button_del_rebr.Visible = true;
            button_next_step_settings.Visible = false;
            button_stop_setings.Visible = true;
            Text_box_Mass.Visible = true;

        }

        private void button_stop_setings_Click(object sender, EventArgs e)
        {
            MyData.add_reb_flag = false;
            MyData.add_ver_flag = false;
            MyData.del_reb_flag = false;
            MyData.del_ver_flag = false;
            MyData.flagPainting = false;
            Program.settings.Close();
        }

        private void button_add_rebr_Click(object sender, EventArgs e)
        {
            MyData.add_reb_flag = true;
            MyData.add_ver_flag = false;
            MyData.del_reb_flag = false;
            MyData.del_ver_flag = false;
        }

        private void button_del_rebr_Click(object sender, EventArgs e)
        {
            MyData.add_reb_flag = false;
            MyData.add_ver_flag = false;
            MyData.del_reb_flag = true;
            MyData.del_ver_flag = false;
        }


        private void button_add_ver_Click(object sender, EventArgs e)
        {
            MyData.add_reb_flag = false;
            MyData.add_ver_flag = true;
            MyData.del_reb_flag = false;
            MyData.del_ver_flag = false;
        }
        private void button_del_ver_Click(object sender, EventArgs e)
        {
            MyData.add_reb_flag = false;
            MyData.add_ver_flag = false;
            MyData.del_reb_flag = false;
            MyData.del_ver_flag = true;
        }

        private void Text_box_Mass_TextChanged(object sender, EventArgs e)
        {
            MyData.text_box_mass = Text_box_Mass.Text;
        }
    }
}
