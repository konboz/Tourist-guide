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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
            Text = "ΠΑΝΗΓΥΡΙΑ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(groupBox1.Visible == false)
            {
                groupBox1.Show();
            }
            else
            {
                groupBox1.Hide();
            }
        }
    }
}
