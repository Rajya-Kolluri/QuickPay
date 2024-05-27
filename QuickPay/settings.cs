using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickPay
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajya\OneDrive\Documents\QuickPayDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewpassTb.Text == "") { MessageBox.Show("Enter New Password"); }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AdminTbl set AdPass=@AP where AdId=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AP", NewpassTb.Text);
                    cmd.Parameters.AddWithValue("@AKey", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Updated");
                    Con.Close();
                    NewpassTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            NewpassTb.Text = "";
            ThemeCb.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ThemeCb.SelectedIndex == -1) { MessageBox.Show("Select a Theme"); }
            else if (ThemeCb.SelectedIndex == 0) { panel1.BackColor = Color.IndianRed; }
            else if (ThemeCb.SelectedIndex == 1) { panel1.BackColor = Color.Brown; }
            else { panel1.BackColor = Color.Red; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
