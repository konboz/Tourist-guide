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
    public partial class Form3 : Form
    {
        public string contentType;
        public string user;
        public Form3(string contentType, string user)
        {
            InitializeComponent();
            this.contentType = contentType;
            this.user = user;
            label5.Text = contentType;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (contentType == "sight")
            {
                Sights sights = new Sights(label1.Text, user);
                sights.Show();
                this.Hide();
            }
             
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (contentType == "Αξιοθέατα")
            {
                Sights sights = new Sights(label1.Text, user);
                sights.Show();
                this.Hide();
            }
        }
    }
}
