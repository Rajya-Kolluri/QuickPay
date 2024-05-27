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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajya\OneDrive\Documents\QuickPayDB.mdf;Integrated Security=True;Connect Timeout=30");
        int Balance;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckBalance()
        {
            Con.Open();
            string Query = "select * from AccountTbl where ACNum=" + CheckBalTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BalanceLbl.Text = "$" + dr["AcBal"].ToString();
                Balance = Convert.ToInt32(dr["AcBal"].ToString());
            }
            Con.Close();
        }
        private void CheckAvailableBal()
        {
            //Con.Open();
            string Query = "select * from AccountTbl where ACNum=" + FromTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BalanceLabel.Text = "$" + dr["AcBal"].ToString();
                Balance = Convert.ToInt32(dr["AcBal"].ToString());
            }
            //Con.Close();
        }
        private void GetNewBalance()
        {
            Con.Open();
            string Query = "select * from AccountTbl where ACNum=" + CheckBalTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //BalanceLbl.Text = "$" + dr["AcBal"].ToString();
                Balance = Convert.ToInt32(dr["AcBal"].ToString());
            }
            Con.Close();
        }
        private void CheckBalBtn_Click(object sender, EventArgs e)
        {
            if (CheckBalTb.Text == "")
            {
                MessageBox.Show("Enter Account Number");

            }
            else
            {
                CheckBalance();
                if (BalanceLbl.Text == "Your Balance")
                {
                    MessageBox.Show("Account Not Found");
                    CheckBalTb.Text = "";
                }


            }

        }
        private void Deposit()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName, TDate,TAmt, TACNum)values(@TN, @TD, @TA,@TAC)", Con);
                cmd.Parameters.AddWithValue("@TN", "Deposit");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", DepAmtTb.Text);
                cmd.Parameters.AddWithValue("@TAC", DepAmtTb.Text);
                cmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }


        private void Withdraw()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName, TDate,TAmt, TACNum)values(@TN, @TD, @TA,@TAC)", Con);
                cmd.Parameters.AddWithValue("@TN", "Withdrawn");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", DepAmtTb.Text);
                cmd.Parameters.AddWithValue("@TAC", DepAmtTb.Text);
                cmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void SubstractBal()
        {
            /*'''''''''''''''''''''''*/GetNewBalance();
            int NewBal = Balance - Convert.ToInt32(TransferAmt.Text);
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNum=@AcKey", Con);
                cmd.Parameters.AddWithValue("@AB", NewBal);
                cmd.Parameters.AddWithValue("@AcKey", FromTb.Text);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Money Deposited");
                Con.Close();
             //   DepAmtTb.Text = "";
               // DepAccTb.Text = "";
                BalanceLbl.Text = "Your Balance";

            }
            catch (Exception Ex)
            { MessageBox.Show(Ex.Message); }
        }
        private void AddBal()
        {
            /************/GetNewBalance();
            int NewBal = Balance + Convert.ToInt32(TransferAmt.Text);
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNum=@AcKey", Con);
                cmd.Parameters.AddWithValue("@AB", NewBal);
                cmd.Parameters.AddWithValue("@AcKey", ToTb.Text);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Money Deposited");
                Con.Close();
                //   DepAmtTb.Text = "";
                // DepAccTb.Text = "";
                BalanceLbl.Text = "Your Balance";

            }
            catch (Exception Ex)
            { MessageBox.Show(Ex.Message); }
        }

        private void DepBtn_Click(object sender, EventArgs e)
        {
            if (DepAccTb.Text == "" || DepAmtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Deposit();
                GetNewBalance();
                int NewBal = Balance + Convert.ToInt32(DepAmtTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNum=@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AB", NewBal);
                    cmd.Parameters.AddWithValue("@AcKey", DepAccTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Deposited");
                    Con.Close();
                    DepAmtTb.Text = "";
                    DepAccTb.Text = "";
                    BalanceLbl.Text = "Your Balance";

                }
                catch (Exception Ex)
                { MessageBox.Show(Ex.Message); }
            }
        }

        private void WdBtn_Click(object sender, EventArgs e)
        {
            if (WdAccountTb.Text == "" || WdAmtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                GetNewBalance();
                Withdraw();
                if (Balance < Convert.ToInt32(WdAmtTb.Text))
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    int NewBal = Balance - Convert.ToInt32(WdAmtTb.Text);



                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNum=@AcKey", Con);
                        cmd.Parameters.AddWithValue("@AB", NewBal);
                        cmd.Parameters.AddWithValue("@AcKey", WdAccountTb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Money Withdraw");
                        Con.Close();
                        WdAmtTb.Text = "";
                        WdAccountTb.Text = "";
                        BalanceLbl.Text = "Your Balance";

                    }
                    catch (Exception Ex)
                    { MessageBox.Show(Ex.Message); }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FromTb.Text == "") { MessageBox.Show("Enter Source Account"); }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count (*) from AccountTbl where ACNum = '" + FromTb.Text + "'" , Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBal();
                    Con.Close();

                }
                else
                {
                    MessageBox.Show("Account does not exist");
                    FromTb.Text = "";



                }
                Con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ToTb.Text == "") { MessageBox.Show("Enter Destination Account"); }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count (*) from AccountTbl where ACNum = '" + ToTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //CheckAvailableBal();
                    MessageBox.Show("Account Found");
                    Con.Close();
                    if (ToTb.Text == FromTb.Text)
                    {
                        MessageBox.Show("Source and Destination Accounts are same");
                        ToTb.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Account does not exist");
                    FromTb.Text = "";



                }
                Con.Close();
            }

        }
        private void Transfer()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransferTbl(TrSrc, TrDest, TrAmt, TrDate) values(@TS, @TD, @TA, @TDA)", Con);
                cmd.Parameters.AddWithValue("@TS", FromTb.Text);
                cmd.Parameters.AddWithValue("@TD", ToTb.Text);
                cmd.Parameters.AddWithValue("@TA", TransferAmt.Text);
                cmd.Parameters.AddWithValue("@TDA", DateTime.Now.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Money Transfered");
                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(ToTb.Text==""|| FromTb.Text=="" || TransferAmt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if( Convert.ToInt16(TransferAmt.Text)>Balance)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                Transfer();
                SubstractBal();
                AddBal();
                FromTb.Text = "";
                ToTb.Text = "";
                TransferAmt.Text = "";
            }

        }
    }
}
