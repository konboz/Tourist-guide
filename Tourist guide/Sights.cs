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
    public partial class Sights : Form
    {
        public Sights()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sight sight = new Sight(label1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Sight sight = new Sight(label1.Text);
            sight.Show();
            this.Hide();
        }
    }
}
