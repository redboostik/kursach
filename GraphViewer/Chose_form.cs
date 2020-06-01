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
    public partial class Chose_form : Form
    {
        public Chose_form()
        {
            InitializeComponent();
        }

        private void button_drawing_Click(object sender, EventArgs e)
        {
            MyData.flush_data();
            MyData.flagPainting = true;
            Program.RunGraphView();
            Program.RunDrawingSettings();
        }

        private void button_list_of_rebr_Click(object sender, EventArgs e)
        {
            MyData.flush_data();
            Program.RunGraphView();
            Program.RunListOfRebr();
        }

        private void button_graph_view_Click(object sender, EventArgs e)
        {
            Program.RunGraphView();
        }

        private void button_start_Deextra_Click(object sender, EventArgs e)
        {
            Program.RunAlgo();
        }
    }
}
