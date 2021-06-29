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
    
    public partial class UserInfoScreen : Form
    {
        string _rID;
        public UserInfoScreen(string rID)
        {
            InitializeComponent();
            this._rID = rID;
        }

        private void UserInfoScreen_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select *, B.TenLoaiDocGia as LoaiDocGia,FORMAT (NgaySinh, 'yyyy-MM-dd') as rNgaySinh,FORMAT (NgayLapThe, 'yyyy-MM-dd') as rNgayLapThe from DocGia A, LoaiDocGia B where A.MaLoaiDocGia = B.MaLoaiDocGIa and A.MaDocGia = @rID";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@rID", _rID);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        oReader.Read();
                        this.nameTaker.Text = oReader["HoTen"].ToString();
                        this.addressTaker.Text = oReader["DiaChi"].ToString();
                        this.birthDayTaker.Text = oReader["rNgaySinh"].ToString();
                        this.debtTaker.Text = oReader["TongNo"].ToString();
                        this.emailTaker.Text = oReader["Email"].ToString();
                        this.signInDateTaker.Text = oReader["rNgayLapThe"].ToString();
                        this.typeTaker.Text = oReader["LoaiDocGia"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No infomation !!!");
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to connect to database!!! Please try again later");
            }
            conn.Close();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            bool flat = false;
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select MatKhau From DocGia ,NguoiDung  WHERE NguoiDung.ID = DocGia.MaTK and MaDocGia = @rID";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@rID", _rID);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        MD5 mh = MD5.Create();
                        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(oPasswordTaker.Text);
                        byte[] hash = mh.ComputeHash(inputBytes);
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < hash.Length; i++)
                        {
                            sb.Append(hash[i].ToString("X2"));
                        }
                        oReader.Read();
                        if (sb.ToString().Trim() != oReader["MatKhau"].ToString().Trim())
                        {
                            MessageBox.Show("Thong tin khong chinh xac!!!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No infomation !!!");
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
            if (nPasswordTaker.Text == rePasswordTaker.Text && nPasswordTaker.Text != "")
            {
                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(nPasswordTaker.Text);
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                
                conn.Open();
                try
                {
                    string selectQuerry = "UPDATE NguoiDung SET MatKhau = @password From DocGia,NguoiDung WHERE NguoiDung.ID = DocGia.MaTK and MaDocGia = @rID";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                    Cmd.Parameters.AddWithValue("@password", sb.ToString());
                    Cmd.Parameters.AddWithValue("@rID", _rID);
                    Cmd.ExecuteNonQuery();

                }
                catch (Exception s)
                {
                    conn.Close();
                    MessageBox.Show("Failed to connect to database!!! Please try again later");
                    return;
                }
                conn.Close();
            }
            MessageBox.Show("Success!!!");
        }
    }
}
