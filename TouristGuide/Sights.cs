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
    public partial class Sights : Form
    {
        public List<Sight> sights = new List<Sight>();
        public Sights(string villageName, string contentType, List<string> photos, List<string> info, string user)
        {
            InitializeComponent();
            label7.Text = contentType + " - " + villageName;
            var labels = new List<Label> { label1, label2, label3, label4, label5, label6 };
            int i = 0;

            foreach (string item in info)
            {
                var sight = new Sight();
                sight.info = "Data/" + villageName + "/" + contentType + "/info/" + item;
                sight.photo = "Data/" + villageName + "/" + contentType + "/photos/" + photos[i];
                sights.Add(sight);
                labels[i].Visible = true;
                labels[i].Text = Path.GetFileNameWithoutExtension(item);
                i++;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SightForm sight = new SightForm(sights[0]);
            sight.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Sights_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            SightForm sight = new SightForm(sights[0]);
            sight.Show();
            this.Hide();
        }
    }
}
