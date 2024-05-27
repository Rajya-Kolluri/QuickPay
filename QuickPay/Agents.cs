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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajya\OneDrive\Documents\QuickPayDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayAgents()
        {
            Con.Open();
            string Query = "select * from AgentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AgentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            ANameTb.Text = "";
            APasswordTb.Text = "";
            AAddressTb.Text = "";
            APhoneTb.Text = "";

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || APasswordTb.Text == "" || AAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AgentTbl (AName,APass, APhone, Aaddress)values(@AN,@APA,@AP,@AA)", Con);
                    cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                    cmd.Parameters.AddWithValue("@APA", APasswordTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AP", APhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Added");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                { MessageBox.Show(Ex.Message); }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Account");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AgentTbl where AId =@AKey", Con);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Deleted");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                { MessageBox.Show(Ex.Message); }
            }
        }
        int Key = 0;

        private void AgentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*ANameTb.Text = AgentDGV.SelectedRows[0].Cells[1].Value.ToString();
            APasswordTb.Text = AgentDGV.SelectedRows[0].Cells[4].Value.ToString();
            APhoneTb.Text = AgentDGV.SelectedRows[0].Cells[2].Value.ToString();
            AAddressTb.Text = AgentDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (AgentDGV.Text == "") { Key = 0; }
            else { Key = Convert.ToInt32(AgentDGV.SelectedRows[0].Cells[0].Value.ToString()); }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            settings Obj = new settings();
            Obj.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
