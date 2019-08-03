using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourist_guide
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
            Sights sights = new Sights();
            sights.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
