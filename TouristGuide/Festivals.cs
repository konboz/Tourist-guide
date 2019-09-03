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
    public partial class Festivals : Form
    {
        public List<Location> locations = new List<Location>();
        public Form form;
        Utilities utility = new Utilities();

        bool UserValidation()
        {
            if (GlobalVariables.connectedUser.Email != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Πρέπει να συνδεθείτε για να δείτε αυτήν την πληροφορία!");
                return false;
            }
        }
        public Festivals(Form form, string villageName, string contentType, List<string> photos, List<string> info)
        {
            InitializeComponent();
            Text = "ΠΑΝΗΓΥΡΙΑ";
            this.form = form;
            Text = contentType + " - " + villageName;
            label1.Text = contentType + " - " + villageName;
            var labels = new List<Label> { label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label2 };
            var pictures = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11 };
            int i = 0;

            foreach (string item in info)
            {
                var location = new Location();
                try
                {
                    location.info = "Data/" + villageName + "/" + contentType + "/info/" + item;
                    location.photo = "Data/" + villageName + "/" + contentType + "/photos/" + photos[i];
                    locations.Add(location);
                    labels[i].Visible = true;
                    pictures[i].Enabled = true;
                    pictures[i].Visible = true;
                    labels[i].Text = Path.GetFileNameWithoutExtension(location.info);
                    pictures[i].ImageLocation = location.photo;
                    i++;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void καθαρισμόςΙστορικούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.ClearHistory();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
