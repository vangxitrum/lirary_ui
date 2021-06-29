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
    public partial class SignUpScreen : Form
    {
        Form parent;
        public SignUpScreen()
        {
            InitializeComponent();
        }

        public SignUpScreen(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpBt_Click(object sender, EventArgs e)
        {
            string userID = "";
            SqlConnection conn = DBUtils.GetDBConnection();
            if(passwordTaker.Text != rePasswordTaker.Text)
            {
                MessageBox.Show("Vui long nhap lai mat khau!!!");
                return;
            }
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(passwordTaker.Text);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            try
            {
                conn.Open();
                string selectQuerry = "Select MaTK from DocGia where MaDocGia=@rID";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@rID", idTaker.Text);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                   
                   if (!oReader.HasRows)
                    {
                        MessageBox.Show("Ma Doc Gia khong ton tai!!!");
                        return;
                    }
                    else
                    {
                        oReader.Read();
                        if (oReader["MaTK"] != DBNull.Value)
                        {
                            MessageBox.Show("Ma Doc Gia khong hop le!!!");
                            return;
                        }
                    }
                }
            }
            catch (Exception s)
            {
                conn.Close();
                MessageBox.Show("Failed to connect to database!!! Please try again later");
                return;
            }
            conn.Close();
            conn.Open();
            try
            {
                string selectQuerry = "Insert into NguoiDung (ID,TenDangNhap,MatKhau,QuyenHan) values ([dbo].[idNguoiDung](),@user,@pw,0)";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@user", userNameTaker.Text);
                Cmd.Parameters.AddWithValue("@pw", sb.ToString());
                Cmd.ExecuteNonQuery();

            }
            catch (Exception s)
            {
                conn.Close();
                MessageBox.Show("Failed to connect to database!!! Please try again later");
                return;
            }
            conn.Close();

            try
            {
                conn.Open();
                string selectQuerry = "Select ID from NguoiDung where TenDangNhap=@user and MatKhau = @pw";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@user", userNameTaker.Text);
                Cmd.Parameters.AddWithValue("@pw", sb.ToString());
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        oReader.Read();
                        userID = oReader["ID"].ToString();
                    }
                }
            }
            catch (Exception s)
            {
                conn.Close();
                MessageBox.Show("Failed to connect to database!!! Please try again later");
                return;
            }
            conn.Close();
            try
            {
                conn.Open();
                string selectQuerry = "UPDATE DocGia SET MaTK = @uID WHERE MaDocGia = @rID";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@uID", userID);
                Cmd.Parameters.AddWithValue("@rID", idTaker.Text);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to connect to database!!! Please try again later");
            }
            conn.Close();
            this.parent.Show();
            this.Close();
        }
    }
}
