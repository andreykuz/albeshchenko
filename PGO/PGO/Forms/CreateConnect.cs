using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PGO.Source;

namespace PGO.Forms
{
    public partial class CreateConnect : Form
    {
        public CreateConnect()
        {
            InitializeComponent();
        }

        public Action<string> CallBack;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fName_Leave(object sender, EventArgs e)
        {
            if (((TextBox) sender).Text.Trim() == "" ||
                ((TextBox) sender).Text.Trim() == ((TextBox) sender).Tag.ToString().Trim())
            {
                ((TextBox) sender).ForeColor = Color.Silver;
                ((TextBox) sender).Text = ((TextBox) sender).Tag.ToString().Trim();
            }
            else
                ((TextBox) sender).ForeColor = Color.Black;
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox) sender).Text.Trim() != "" &&
                ((TextBox) sender).Text.Trim() != ((TextBox) sender).Tag.ToString().Trim())
            {
                ((TextBox) sender).ForeColor = Color.Black;
            }
            else
                ((TextBox) sender).ForeColor = Color.Silver;
            label2.Text = "";
        }

        private void fName_Click(object sender, EventArgs e)
        {
            ((TextBox) sender).SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var strconnect = "server=" + textBox1.Text.Trim() +
                ";User Id=" + textBox2.Text.Trim() +
                ";password=" + textBox3.Text.Trim() +
                ";Persist Security Info=True;database=pgo";
            try
            {
                var conn = new MySqlConnection(strconnect);
                conn.Open();
                conn.Close();
                conn.Dispose();
                MySqlData.ConnectionString = strconnect;

                CallBack(strconnect);
                Close();
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }

    }
}
