using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TouristGuide
{
    public partial class SightForm : Form
    {
        public Form form;
        public SightForm(Form form, Sight sight)
        {
            InitializeComponent();
            label1.Text = Path.GetFileNameWithoutExtension(sight.info);
            pictureBox1.ImageLocation = sight.photo;
            richTextBox1.Text = richTextBox1.Text = File.ReadAllText(sight.info);
            this.form = form;
        }

        private void ΠίσωToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void ΈξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
