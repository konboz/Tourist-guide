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
        public Sights(Form form, string villageName, string contentType, List<string> photos, List<string> info)
        {
            InitializeComponent();
            this.form = form;
            Text = contentType + " - " + villageName;
            label7.Text = contentType + " - " + villageName;
            var labels = new List<Label> { label1, label2, label3, label4, label5, label6 };
            var pictures = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            int i = 0;

            foreach (string item in info)
            {
                var sight = new Sight();
                sight.info = "Data/" + villageName + "/" + contentType + "/info/" + item;
                sight.photo = "Data/" + villageName + "/" + contentType + "/photos/" + photos[i];
                sights.Add(sight);
                labels[i].Visible = true;
                pictures[i].Enabled = true;
                pictures[i].Visible = true;
                labels[i].Text = Path.GetFileNameWithoutExtension(sight.info);
                pictures[i].ImageLocation = sight.photo;
                i++;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[0]);
                
                sight.Show();
                Hide();
            }
        }

        private void Sights_Load(object sender, EventArgs e)
        {
            Utilities.HistoryAdd(this);
            GlobalVariables.currentForm = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[1]);

                sight.Show();
                Hide();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[0]);
                
                sight.Show();
                Hide();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[1]);
                
                sight.Show();
                Hide();
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[2]);
                
                sight.Show();
                Hide();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[2]);
                
                sight.Show();
                Hide();
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[3]);
                
                sight.Show();
                Hide();
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[3]);
                
                sight.Show();
                Hide();
            }
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[4]);
                
                sight.Show();
                Hide();
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[4]);
                
                sight.Show();
                Hide();
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[5]);
                
                sight.Show();
                Hide();
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                SightForm sight = new SightForm(this, sights[5]);
                
                sight.Show();
                Hide();
            }
        }

        private void μενούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ιστορικόToolStripMenuItem.DropDownItems.Clear();
            utility.LoadHistoryMenu(ιστορικόToolStripMenuItem);
        }

        private void πίσωToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
