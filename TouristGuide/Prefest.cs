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
    public partial class Prefest : Form
    {
        public Form form;
        public string contentType;
        Utilities utility = new Utilities();

        void FormCreator(string village)
        {
            var photos = new List<string>();
            var info = new List<string>();
            string photoDir = "Data/" + village + "/" + contentType + "/photos";
            string infoDir = "Data/" + village + "/" + contentType + "/info";
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

            Calendar calendar = new Calendar(this, village, contentType, photos, info);
            calendar.Show();
            Hide();
        }
        public Prefest(Form form, string contentType)
        {
            InitializeComponent();
            this.form = form;
            this.contentType = contentType;
            pictureBox1.ImageLocation = "Data/ΧΩΡΑ/ΧΩΡΑ.jpg";
            pictureBox2.ImageLocation = "Data/ΚΑΤΑΠΟΛΑ/ΚΑΤΑΠΟΛΑ.jpg";
            pictureBox3.ImageLocation = "Data/ΑΙΓΙΑΛΗ/ΑΙΓΙΑΛΗ.jpg";
            pictureBox4.ImageLocation = "Data/ΚΑΤΩ ΜΕΡΙΑ/ΚΑΤΩ ΜΕΡΙΑ.jpg";
            Text = contentType;
            label5.Text = contentType;
        }
        

        private void label4_Click(object sender, EventArgs e)
        {
            FormCreator(label4.Text);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            FormCreator(label3.Text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormCreator(label4.Text);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            FormCreator(label3.Text);
        }

        private void Prefest_Load(object sender, EventArgs e)
        {
            Utilities.HistoryAdd(this);
            GlobalVariables.currentForm = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormCreator(label1.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCreator(label1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormCreator(label2.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormCreator(label2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
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

        private void έξοδοςtoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
