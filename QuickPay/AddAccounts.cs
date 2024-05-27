using System;
using System.Data.SqlClient;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuickPay
{
    public partial class AddAccounts : Form
    {
        public AddAccounts()
        {
            InitializeComponent();
            DisplayAccounts();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajya\OneDrive\Documents\QuickPayDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayAccounts()
        {
            Con.Open();
            string Query = "select * from AccountTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AccountDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            AcNameTb.Text = "";
            AcPhoneTb.Text = "";
            AcAddressTb.Text = "";
            AcGenderCb.SelectedIndex = -1;
            AcOccupationTb.Text = "";
            AcIncomeTb.Text = "";
            AcEducationCb.SelectedIndex = -1;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == "" || AcPhoneTb.Text == "" || AcAddressTb.Text == "" || AcIncomeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccountTbl(ACName, ACPhone, ACAddress, ACGen, ACOccup, AcEduc, ACInc, AcBal)values(@AN,@AP,@AA,@AG,@AO,@AE,@AI,@AB)", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG", AcGenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", AcOccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AE", AcEducationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("AI", AcIncomeTb.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
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
                    SqlCommand cmd = new SqlCommand("delete from AccountTbl where ACNum =@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Deleted");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                { MessageBox.Show(Ex.Message); }
            }





        }
        int Key = 0;
        private void AccountDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (AccountDGV.SelectedRows.Count > 0)
            {

                AcNameTb.Text = AccountDGV.SelectedRows[0].Cells[1].Value.ToString();
                AcPhoneTb.Text = AccountDGV.SelectedRows[0].Cells[2].Value.ToString();
                AcAddressTb.Text = AccountDGV.SelectedRows[0].Cells[3].Value.ToString();
                AcGenderCb.SelectedItem = AccountDGV.SelectedRows[0].Cells[4].Value.ToString();
                AcOccupationTb.Text = AccountDGV.SelectedRows[0].Cells[5].Value.ToString();
                AcEducationCb.SelectedItem = AccountDGV.SelectedRows[0].Cells[6].Value.ToString();
                AcIncomeTb.Text = AccountDGV.SelectedRows[0].Cells[7].Value.ToString();
                if (AcNameTb.Text == "") { Key = 0; }
                else { Key = Convert.ToInt32(AccountDGV.SelectedRows[0].Cells[0].Value.ToString()); }
            }
            else { MessageBox.Show("Columns out of index"); }*/




        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == "" || AcPhoneTb.Text == "" || AcAddressTb.Text == "" || AcIncomeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AccountTbl ACName=@AN, ACPhone=@AP, ACAddress=@AA, ACGen=@AG, ACOccup=@AO, AcEduc=@AE, ACInc=@AI where ACNum=@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG", AcGenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", AcOccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AE", AcEducationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("AI", AcIncomeTb.Text);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                { MessageBox.Show(Ex.Message); }
            }
        }
    }
}
