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

namespace TouristGuide
{
    public partial class Form1 : Form
    {
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TouristGuideDb.mdb";
        OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            connection.Open();
            string query = "SELECT * FROM Visitor WHERE Email LIKE(\"" + email + "\") AND Password LIKE(\"" + password + "\")";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                connection.Close();
                var user = new User()
                {
                    Email = email
                };
                GlobalVariables.connectedUser = user;
                var sessionHistory = new UserHistory();
                GlobalVariables.history = sessionHistory;
                Hide();
                StartPage startPage = new StartPage();
                startPage.Show(); 
            }
            else
            {
                MessageBox.Show("Wrong email and/or password!");
                connection.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            StartPage startPage = new StartPage();
            var user = new User();
            GlobalVariables.connectedUser = user;
            startPage.Show();
        }
    }
}
