using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace TouristGuide
{
    public partial class Form3 : Form
    {
        public string contentType;
        public string user;

        void FormCreator(string village)
        {
            if (contentType == "ΑΞΙΟΘΕΑΤΑ")
            {
                var photos = new List<string>();
                var info = new List<string>();
                string photoDir = "Data/" + village + "/" + contentType + "/photos";
                string infoDir = "Data/" + village + "/" + contentType + "/info";

                photos = Directory.GetFiles(photoDir, "*", SearchOption.AllDirectories).Select(x => Path.GetFileName(x)).ToList();
                info = Directory.GetFiles(infoDir, "*", SearchOption.AllDirectories).Select(x => Path.GetFileName(x)).ToList();
                Sights sights = new Sights(village, contentType, photos, info, user);
                sights.Show();
                Hide();
            }
        }
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
            FormCreator(label1.Text);
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            FormCreator(label1.Text);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            FormCreator(label2.Text);
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            FormCreator(label2.Text);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            FormCreator(label3.Text);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            FormCreator(label3.Text);
        }
    }
}
