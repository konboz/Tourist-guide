using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristGuide
{
    public partial class StartPage : Form
    {
        Utilities utility = new Utilities();
        int counter = 1;
        string slideshowDir;
        bool playing = false;

        public StartPage()
        {
            InitializeComponent();
            pictureBox7.ImageLocation = "Photos/trail.jpg";
            pictureBox1.ImageLocation = "Photos/sight1.png";
            pictureBox2.ImageLocation = "Photos/Bar.jpg";
            pictureBox3.ImageLocation = "Photos/Restaurant.jpg";
            pictureBox4.ImageLocation = "Photos/Beach.jpg";
            pictureBox5.ImageLocation = "Photos/villages.jpg";
            pictureBox6.ImageLocation = "Photos/events.jpg";
            Text = "ΑΡΧΙΚΗ ΣΕΛΙΔΑ";
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            slideshowDir = "Data/";
            Utilities.HistoryAdd(this);
            GlobalVariables.currentForm = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            string[] images = Directory.GetFiles(slideshowDir, "*.jpg", SearchOption.AllDirectories);
            if (counter > images.Length - 1)
            {
                counter = 0;
            }
            pictureBox7.Image = Image.FromFile(images[counter]);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΑΞΙΟΘΕΑΤΑ");
            villages.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΑΞΙΟΘΕΑΤΑ");
            villages.Show();
            Hide();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void μενούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ιστορικόToolStripMenuItem.DropDownItems.Clear();
            utility.LoadHistoryMenu(ιστορικόToolStripMenuItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΔΙΑΣΚΕΔΑΣΗ");
            villages.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΔΙΑΣΚΕΔΑΣΗ");
            villages.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΦΑΓΗΤΟ");
            villages.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΦΑΓΗΤΟ");
            villages.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΠΑΡΑΛΙΕΣ");
            villages.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 villages = new Form3(this, "ΠΑΡΑΛΙΕΣ");
            villages.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           //ΘΑ ΦΤΙΑΧΤΟΥΝ ΑΛΛΕΣ ΦΟΡΜΕΣ ΓΙΑ ΧΩΡΙΑ ΚΑΙ ΕΚΔΗΛΩΣΕΙΣ
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //ΘΑ ΦΤΙΑΧΤΟΥΝ ΑΛΛΕΣ ΦΟΡΜΕΣ ΓΙΑ ΧΩΡΙΑ ΚΑΙ ΕΚΔΗΛΩΣΕΙΣ
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //ΘΑ ΦΤΙΑΧΤΟΥΝ ΑΛΛΕΣ ΦΟΡΜΕΣ ΓΙΑ ΧΩΡΙΑ ΚΑΙ ΕΚΔΗΛΩΣΕΙΣ
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //ΘΑ ΦΤΙΑΧΤΟΥΝ ΑΛΛΕΣ ΦΟΡΜΕΣ ΓΙΑ ΧΩΡΙΑ ΚΑΙ ΕΚΔΗΛΩΣΕΙΣ
        }

        private void καθαρισμόςΙστορικούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.ClearHistory();
        }
    }
}
