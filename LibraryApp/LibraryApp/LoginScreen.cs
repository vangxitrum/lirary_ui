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
            


            MainScreen newScreen = new MainScreen();
            if (checkLoginInfo() == 0)
            {
                newScreen.Show();
                this.Hide();
            }
            else if (checkLoginInfo() == 1) MessageBox.Show("User or password invalid");
            
        }

        private int checkLoginInfo()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                //MessageBox.Show("Success");
                string selectQuerry = "Select Count(*) from staff where sUser=@User and sPassword=@Password";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@User", this.userNameTaker.Text);
                Cmd.Parameters.AddWithValue("@Password", this.passwordTaker.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(Cmd);
                sda.Fill(dt);
                
                
                if (dt.Rows[0][0].ToString() == "1")
                {
                    conn.Close();
                    return 0;
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to connect to database!!! Please try again later");
            }
            conn.Close();
            return 1;
        }
    }
}
