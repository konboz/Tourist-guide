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

namespace TouristGuide
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "Photos/calendar.png";
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

        private void έξοδοςtoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "Sounds/sound.wav";
            sp.PlayLooping();
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
    }
}
