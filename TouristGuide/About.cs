using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristGuide
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            richTextBox1.Text = File.ReadAllText("About.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
