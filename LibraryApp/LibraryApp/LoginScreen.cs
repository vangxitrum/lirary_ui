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
        string _rID;
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
                userNameTaker.Clear();
                passwordTaker.Clear();
                newScreen = new UserMainScreen(this,_rID);
                newScreen.Show();
                this.Hide();
            }
            else if (check == 1)
            {
                userNameTaker.Clear();
                passwordTaker.Clear();
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
                string selectQuerry = "Select QuyenHan,ID from NguoiDung where TenDangNhap=@User and MatKhau=@Password";
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
                            SqlConnection conn1 = DBUtils.GetDBConnection();
                            try
                            {
                                conn1.Open();
                                //MessageBox.Show("Success");
                                string newQuerry = "Select MaDocGia from DocGia where MaTK = @ID";
                                SqlCommand newCmd = new SqlCommand(newQuerry, conn1);
                                newCmd.Parameters.AddWithValue("@ID", oReader["ID"].ToString());
                                using (SqlDataReader newReader = newCmd.ExecuteReader())
                                {

                                    if (newReader.HasRows)
                                    {
                                        newReader.Read();
                                        _rID = newReader["MaDocGia"].ToString();
                                    }
                                }

                            }
                            catch (Exception s)
                            {
                                MessageBox.Show("Failed to connect to database!!! Please try again later");
                            }
                            conn1.Close();
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

        private void LoginScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginBt_Click(sender, e);
                e.Handled = true;
            }
            
        }

        private void userNameTaker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginBt_Click(sender, e);
                e.Handled = true;
            }
            
        }
    }
}
