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
        public Form form;
        public string contentType;
        Utilities utility = new Utilities();

        void FormCreator(string fest)
        {
            var photos = new List<string>();
            var info = new List<string>();
            string photoDir = "Festivals/" + contentType + "/photos";
            string infoDir = "Festivals/" + contentType + "/info";
            try
            {
                photos = Directory.GetFiles(photoDir, "*", SearchOption.AllDirectories).Select(x => Path.GetFileName(x)).ToList();
                info = Directory.GetFiles(infoDir, "*", SearchOption.AllDirectories).Select(x => Path.GetFileName(x)).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            Festivals festivals = new Festivals();
            festivals.Show();
            Hide();
        }

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
        public Calendar(Form form, string contentType)
        {
            InitializeComponent();
            this.form = form;
            this.contentType = contentType;
            pictureBox1.ImageLocation = "Photos/calendar.png";
            Text = contentType;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void έξοδοςtoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "Sounds/sound.wav";
            sp.PlayLooping();

            Utilities.HistoryAdd(this);
            GlobalVariables.currentForm = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "Sounds/sound.wav";
            sp.PlayLooping();

            button2.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "Sounds/sound.wav";
            sp.Stop();

            button3.Visible = false;
            button2.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label3.Text);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label5.Text);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label4.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label1.Text);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label7.Text);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label2.Text);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label6.Text);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label8.Text);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label9.Text);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label10.Text);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (UserValidation())
            {
                FormCreator(label11.Text);
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
            Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            /*
            monthCalendar1.AnnuallyBoldedDates =
            new DateTime[] { new DateTime(2019, 9, 5),
                             new DateTime(2019, 6, 21),
                             new DateTime(2019, 8, 15),
                             new DateTime(2019, 7, 26),
                             new DateTime(2019, 7, 1),
                             new DateTime(2019, 7, 25),
                             new DateTime(2019, 8, 6),
                             new DateTime(2019, 8, 20),
                             new DateTime(2019, 9, 14),
                             new DateTime(2019, 11, 21)};
             */

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

            monthCalendar1.AddBoldedDate(festival1);
            monthCalendar1.AddBoldedDate(festival2);
            monthCalendar1.AddBoldedDate(festival3);
            monthCalendar1.AddBoldedDate(festival4);
            monthCalendar1.AddBoldedDate(festival5);
            monthCalendar1.AddBoldedDate(festival6);
            monthCalendar1.AddBoldedDate(festival7);
            monthCalendar1.AddBoldedDate(festival8);
            monthCalendar1.AddBoldedDate(festival9);
            monthCalendar1.AddBoldedDate(festival10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
