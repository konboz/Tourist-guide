using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Data.OleDb;

namespace TouristGuide
{
    public partial class Calendar : Form
    {
        public List<Location> locations = new List<Location>();
        public Form form;
        Utilities utility = new Utilities();
        SoundPlayer sp = new SoundPlayer();       

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
        public Calendar(Form form, string villageName, string contentType, List<string> photos, List<string> info)
        {
            InitializeComponent();
            this.form = form;
            Text = contentType + " - " + villageName;
            pictureBox12.ImageLocation = "Photos/calendar.png";
            label12.Text = contentType + " - " + villageName;
            var labels = new List<Label> { label1, label2, label3, label4 };
            var pictures = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            sp.SoundLocation = "Sounds/sound.wav";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                Festivals festival = new Festivals(this, locations[0]);

                festival.Show();
                Hide();
            }
        }

        private void έξοδοςtoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {           
            sp.PlayLooping();
            
            Utilities.HistoryAdd(this);
            GlobalVariables.currentForm = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            sp.PlayLooping();

            button2.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            sp.Stop();

            button3.Visible = false;
            button2.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                Festivals festival = new Festivals(this, locations[2]);

                festival.Show();
                sp.Stop();
                Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                Festivals festival = new Festivals(this, locations[3]);

                festival.Show();
                sp.Stop();
                Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                Festivals festival = new Festivals(this, locations[0]);

                festival.Show();
                sp.Stop();
                Hide();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                Festivals festival = new Festivals(this, locations[1]);

                festival.Show();
                sp.Stop();
                Hide();
            }
        }


        private void μενούtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ιστορικόtoolStripMenuItem2.DropDownItems.Clear();
            utility.LoadHistoryMenu(ιστορικόtoolStripMenuItem2);
        }

        private void καθαρισμόςΙστορικούtoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Utilities.ClearHistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            sp.Stop();
            Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {           
            DateTime festival1 = new DateTime(2019, 9, 5);
            DateTime festival2 = new DateTime(2019, 6, 21);
            DateTime festival3 = new DateTime(2019, 8, 15);
            DateTime festival4 = new DateTime(2019, 7, 26);
            DateTime festival5 = new DateTime(2019, 7, 1);
            DateTime festival6 = new DateTime(2019, 7, 25);
            DateTime festival7 = new DateTime(2019, 8, 6);
            DateTime festival8 = new DateTime(2019, 8, 20);
            DateTime festival9 = new DateTime(2019, 9, 14);
            DateTime festival10 = new DateTime(2019, 11, 21);

            monthCalendar1.AddAnnuallyBoldedDate(festival1);
            monthCalendar1.AddAnnuallyBoldedDate(festival2);
            monthCalendar1.AddAnnuallyBoldedDate(festival3);
            monthCalendar1.AddAnnuallyBoldedDate(festival4);
            monthCalendar1.AddAnnuallyBoldedDate(festival5);
            monthCalendar1.AddAnnuallyBoldedDate(festival6);
            monthCalendar1.AddAnnuallyBoldedDate(festival7);
            monthCalendar1.AddAnnuallyBoldedDate(festival8);
            monthCalendar1.AddAnnuallyBoldedDate(festival9);
            monthCalendar1.AddAnnuallyBoldedDate(festival10);
            
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.Day.ToString(" Ώρα για Πανηγύρι! "));
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Show();
            }
            else
            {
                groupBox1.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                Festivals festival = new Festivals(this, locations[1]);

                festival.Show();
                sp.Stop();
                Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                Festivals festival = new Festivals(this, locations[2]);

                festival.Show();
                sp.Stop();
                Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                Festivals festival = new Festivals(this, locations[3]);

                festival.Show();
                sp.Stop();
                Hide();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
