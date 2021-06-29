using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpScreen signUpScreen = new SignUpScreen(this);
            signUpScreen.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBt_Click(object sender, EventArgs e)
        {
            Form newScreen;
            int check = checkLoginInfo();
            if (check == 0)
            {
                //newScreen = new MainScreen();
                //newScreen.Show();
                //this.Hide();
            }
            else if (check == 1)
            {
               
                newScreen = new MainScreen(this);
                newScreen.Show();
                this.Hide();
            }
        }

        private int checkLoginInfo()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(passwordTaker.Text);
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                //MessageBox.Show("Success");
                string selectQuerry = "Select QuyenHan from NguoiDung where TenDangNhap=@User and MatKhau=@Password";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@User", this.userNameTaker.Text);
                Cmd.Parameters.AddWithValue("@Password", sb.ToString());
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {

                    if (oReader.HasRows)
                    {
                        oReader.Read();
                        if (oReader["QuyenHan"].ToString() == "0")
                        {
                            return 0;
                        }
                        else if (oReader["QuyenHan"].ToString() == "1")
                        {
                            return 1;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Thong tin dang nhap sai!!!");
                        return -1;
                    }
                }

            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to connect to database!!! Please try again later");
                return -1;
            }
            conn.Close();
            return 1;
        }
    }
}
