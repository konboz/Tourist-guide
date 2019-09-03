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
    public partial class Form4 : Form
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

            Festivals sights = new Festivals(this, village, contentType, photos, info);
            sights.Show();
            Hide();
        }

        public Form4(Form form, string contentType)
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

        private void Form4_Load(object sender, EventArgs e)
        {
            Utilities.HistoryAdd(this);
            GlobalVariables.currentForm = this;
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

        private void label4_Click(object sender, EventArgs e)
        {
            FormCreator(label4.Text);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormCreator(label4.Text);
        }



        private void έξοδοςToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void μενούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ιστορικόToolStripMenuItem.DropDownItems.Clear();
            utility.LoadHistoryMenu(ιστορικόToolStripMenuItem);
        }

        private void καθαρισμόςΙστορικούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.ClearHistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }
    }
}
