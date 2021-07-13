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
    public partial class IssuedBooks : Form
    {
        String _id, _bName, _bStatus, _bPrice;
        String _readerID, _readerName, _readerAddress, _readerEmail, _readerBirth;
        String _brFromID;

        void createNewBorrowForm()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "INSERT INTO PhieuMuonSach (MaPhieuMuonSach,NgayMuonSach,MaDocGia) VALUES([dbo].[idPhieuMuon](),@date,@id)";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@id", _readerID);
                Cmd.Parameters.AddWithValue("@date", dateGetter.Text);
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
        private void saveBt_Click(object sender, EventArgs e)
        {
            if (_bName != null && _readerName != null)
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();
                    string selectQuerry = "Select MaPhieuMuonSach from PhieuMuonSach where MaDocGia=@ID and NgayMuonSach = @date";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                    Cmd.Parameters.AddWithValue("@ID", rIdTaker.Text);
                    Cmd.Parameters.AddWithValue("@date", dateGetter.Text);
                    using (SqlDataReader oReader = Cmd.ExecuteReader())
                    {
                        if (oReader.HasRows)
                        {
                            oReader.Read();
                            _brFromID = oReader["MaPhieuMuonSach"].ToString();
                        }
                        else
                        {
                            conn.Close();
                            createNewBorrowForm();
                            try
                            {
                                conn.Open();
                                string selectQuerry1 = "Select MaPhieuMuonSach from PhieuMuonSach where MaDocGia=@ID and NgayMuonSach = @date";
                                SqlCommand Cmd1 = new SqlCommand(selectQuerry1, conn);
                                Cmd1.Parameters.AddWithValue("@ID", rIdTaker.Text);
                                Cmd1.Parameters.AddWithValue("@date", dateGetter.Text);
                                using (SqlDataReader oReader1 = Cmd1.ExecuteReader())
                                {
                                    oReader1.Read();
                                    _brFromID = oReader1["MaPhieuMuonSach"].ToString();
                                }
                            }
                            catch (Exception s)
                            {
                                conn.Close();
                                MessageBox.Show("Failed to connect to database!!! Please try again later");
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
            }
            else
            {
                MessageBox.Show("Error");
            }
            SqlConnection conn1 = DBUtils.GetDBConnection();
            conn1.Open();
            for (int i = 0; i < bookData.RowCount; i++)
            {
                
                try
                {
                    string selectQuerry = "INSERT INTO ChiTietPM (MaCTPM,MaSach,MaPhieuMuonSach,TrangThai) VALUES([dbo].[idChiTietPM](),@bookID,@brID,0)";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn1);
                    Cmd.Parameters.AddWithValue("@bookID", bookData.Rows[i].Cells[0].Value.ToString());
                    Cmd.Parameters.AddWithValue("@brID", _brFromID);
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception s)
                {
                    conn1.Close();
                    MessageBox.Show("Failed to connect to database!!! Please try again later");
                    return;
                }
            }
            conn1.Close();
            Reset();
           
        }

        private void bookData_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            MessageBox.Show("Check");
        }


        private void addBookBt_Click(object sender, EventArgs e)
        {
            if (_id != null)
            {
                bookData.Rows.Add(_id, _bName, _bStatus, _bPrice);
                _id = null;
                nameBook.Clear();
                bIdTaker.Clear();
            }
        }

        private void delBt_Click(object sender, EventArgs e)
        {
            bookData.Rows.RemoveAt(this.bookData.SelectedRows[0].Index);
        }

        private void rSearchBt_Click(object sender, EventArgs e)
        {
            DateTime signInDate = new DateTime();
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select MaDocGia,HoTen,DiaChi,FORMAT (NgaySinh, 'dd-MM-yyyy') as NgaySinh,Email,FORMAT(NgayLapThe, 'yyyy-MM-dd') as NgayLapThe from DocGia where MaDocGia=@ID";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@ID", rIdTaker.Text);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            _readerID = oReader["MaDocGia"].ToString();
                            _readerName = oReader["HoTen"].ToString();
                            _readerEmail = oReader["Email"].ToString();
                            _readerAddress = oReader["DiaChi"].ToString();
                            _readerBirth = oReader["NgaySinh"].ToString();
                            signInDate = DateTime.Parse(oReader["NgayLapThe"].ToString());
                            rEmail.Text = _readerEmail;
                            rAddress.Text = _readerAddress;
                            rBirth.Text = _readerBirth;
                            rName.Text = _readerName;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Infomation!!!");
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to connect to database!!! Please try again later");
            }
            conn.Close();
            int userSignInTime = 0;
            if (signInDate != DateTime.MinValue) {
                userSignInTime = (int)DateTime.Today.Subtract(signInDate).TotalDays / 30;
            }
            if (userSignInTime >= AppValue._cardDuration) {
                MessageBox.Show("Reader's card expired!!!");
                Reset();
            }

        }

        public IssuedBooks()
        {
            InitializeComponent();
            dateGetter.Format = DateTimePickerFormat.Custom;
            dateGetter.CustomFormat = "yyyy-MM-dd";
        }

        private void bIdTaker_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bSearchBt_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                string selectQuerry = "Select MaSach,TenSach,TrangThai,TriGia from Sach where MaSach=@ID";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@ID", bIdTaker.Text);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            _id = oReader["MaSach"].ToString().Trim();
                            _bName = oReader["TenSach"].ToString();
                            _bStatus = oReader["TrangThai"].ToString();
                            _bPrice = oReader["TriGia"].ToString();
                            nameBook.Text = _bName;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Infomation!!!");
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to connect to database!!! Please try again later");
            }
            conn.Close();
            //MessageBox.Show(id + Name + bStatus + bPrice);
            
        }

        private void Reset()
        {
            bookData.Rows.Clear();
            _id = _bName = _bStatus = _bPrice =
            _readerID = _readerName = _readerAddress = _readerEmail = _readerBirth =
            _brFromID = null;
            rIdTaker.Clear();
            bIdTaker.Clear();
            rName.Clear();
            rEmail.Clear();
            rAddress.Clear();
            rBirth.Clear();
            nameBook.Clear();
        }
    }
}
