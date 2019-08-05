using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristGuide
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
            pictureBox7.ImageLocation = "Photos/trail.jpg";
            pictureBox1.ImageLocation = "Photos/sight1.png";
        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 sights = new Form3("sight", "kostas");
            sights.Show();
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 sights = new Form3("sight", "kostas");
            sights.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 sights = new Form3("sight", "kostas");
            sights.Show();
            this.Hide();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
