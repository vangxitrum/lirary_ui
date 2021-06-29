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
    public partial class UserIssuedBookScreen : Form
    {
        string _rID;
        public UserIssuedBookScreen(string rID)
        {
            InitializeComponent();
            this._rID = rID;
            loadData();
        }

        private void loadData()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select MaPhieuMuonSach,FORMAT (NgayMuonSach, 'dd-MM-yyyy') as NgayMuonSach from PhieuMuonSach where MaDocGia=@ID";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@ID", _rID);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            SqlConnection conn1 = DBUtils.GetDBConnection();
                            try
                            {

                                conn1.Open();
                                string newQuerry = "Select A.MaSach,TenSach,A.TrangThai,TriGia From Sach A,(Select * From ChiTietPM where MaPhieuMuonSach = @pMID) B Where A.MaSach = B.MaSach And B.TrangThai = 0";
                                SqlCommand newCmd = new SqlCommand(newQuerry, conn1);
                                newCmd.Parameters.AddWithValue("@pMID", oReader["MaPhieuMuonSach"].ToString());
                                using (SqlDataReader newReader = newCmd.ExecuteReader())
                                {
                                    if (newReader.HasRows)
                                    {
                                        while (newReader.Read())
                                        {
                                            bookData.Rows.Add(newReader["MaSach"].ToString().Trim(), newReader["TenSach"].ToString(), newReader["TrangThai"].ToString(), newReader["TriGia"].ToString(), oReader["NgayMuonSach"].ToString());
                                        }
                                    }
                                }
                            }
                            catch (Exception s)
                            {
                                MessageBox.Show("Failed to connect to database!!! Please try again later");
                            }
                            conn1.Close();
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
                MessageBox.Show("Failed to connect to database!!! Please try again later");
            }
            conn.Close();
        }
    }
}
