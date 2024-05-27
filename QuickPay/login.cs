using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuickPay
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajya\OneDrive\Documents\QuickPayDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
            RoleCb.SelectedIndex = -1;
            RoleCb.Text = "Role";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Selected the Role");
            }
            else if (RoleCb.SelectedIndex == 0)
            {
                if (UnameTb.Text == "" || PasswordTb.Text == "") { MessageBox.Show("Enter Both Admin Name and Password"); }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count (*) from AdminTbl where AdName = '" + UnameTb.Text + "' and AdPass= '" + PasswordTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Agents Obj = new Agents();
                        Obj.Show();
                        this.Hide();
                        Con.Close();

                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin Name or Password");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";



                    }
                    Con.Close();
                }
            }
            else
            {
                if (UnameTb.Text == "" || PasswordTb.Text == "") { MessageBox.Show("Enter Both User Name and Password"); }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count (*) from AgentTbl where AName = '" + UnameTb.Text + "' and APass= '" + PasswordTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MainMenu Obj = new MainMenu();
                        Obj.Show();
                        this.Hide();
                        Con.Close();

                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name or Password");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";



                    }
                    Con.Close();
                }

            }
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
