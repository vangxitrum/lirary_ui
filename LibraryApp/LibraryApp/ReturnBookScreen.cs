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
using System.Configuration;

namespace LibraryApp
{
    public partial class ReturnBookScreen : Form
    {
        String _readerName, _readerEmail, _readerBirth, _readerAddress, _readerID;
        String _returnFormID;
        String _debt;
        public bool _flat = false;
        List<bool> _bookReturned = new List<bool>();


        void reset()
        {
            _debt = _readerName = _readerEmail = _readerBirth = _readerAddress = _readerID =  _returnFormID = null;
            rIdTaker.Clear();
            rName.Clear();
            rEmail.Clear();
            rAddress.Clear();
            rBirth.Clear();
            total.Clear();
            bookData.Rows.Clear();
            _flat = false;
        }
        void createReturnedForm()
        {
            int count = 0;
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select Count(*) as SL from PhieuTraSach";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);

                using (SqlDataReader reader = Cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        count = Int32.Parse(reader["SL"].ToString()) + 1;
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            catch (Exception s)
            {
                conn.Close();
                MessageBox.Show("Failed to connect to database!!! Please try again later");
                return;
            }
            _returnFormID = "PT000" + count.ToString(); 
            conn.Close();
            try
            {
                conn.Open();
                string selectQuerry = "INSERT INTO PhieuTraSach (MaPTS,NgayTraSach,MaDocGia,SoTienThu) VALUES(@bid,@date,@id,@Sum)";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@bid", _returnFormID);
                Cmd.Parameters.AddWithValue("@id", _readerID);
                Cmd.Parameters.AddWithValue("@date", dateGetter.Text);
                Cmd.Parameters.AddWithValue("@Sum", total.Text);
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
            totalBt_Click(sender, e);
            
            int rDebt = Int32.Parse(_debt) + Int32.Parse(total.Text);
            DialogResult dialogResult = MessageBox.Show("Thanh toan hoa don?", "Pay bill", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PayDebtScreen child = new PayDebtScreen(this,null,rDebt.ToString(), _readerName, _readerBirth, _readerID);
                child.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                _flat = true;
                SqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    
                    conn.Open();
                    string selectQuerry = "UPDATE DocGia SET TongNo = @debt where MaDocGia = @ID";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                    Cmd.Parameters.AddWithValue("@ID", rIdTaker.Text);
                    Cmd.Parameters.AddWithValue("@debt", rDebt);
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception s)
                {
                    MessageBox.Show("Failed to connect to database!!! Please try again later");
                }
                conn.Close();
            }
            
            if (_flat)
            {
                if (_readerName != null && bookData.Rows.Count != 0 && total.Text != "0")
                {
                    createReturnedForm();
                }
                else
                {
                    MessageBox.Show("Error");
                    return;
                }
                SqlConnection conn1 = DBUtils.GetDBConnection();
                int rowCount = bookData.RowCount;
                for (int i = 0; i < rowCount; i++)
                {
                    DataGridViewCheckBoxCell checkBox = bookData.Rows[i].Cells[5] as DataGridViewCheckBoxCell;
                    if ((bool)checkBox.Value)
                    {
                        try
                        {
                            List<int> temp = splitData(bookData.Rows[i].Cells[4].Value.ToString());
                            string date = temp[2].ToString() + '-' + temp[1].ToString() + '-' + temp[0].ToString();
                            conn1.Open();
                            string selectQuerry = "INSERT INTO ChiTietPT (MaCTPT,MaSach,MaPTS,NgayMuonSach) VALUES([dbo].[idChiTietPT](),@bookID,@rID,@date)";
                            SqlCommand Cmd = new SqlCommand(selectQuerry, conn1);
                            Cmd.Parameters.AddWithValue("@bookID", bookData.Rows[i].Cells[0].Value.ToString());
                            Cmd.Parameters.AddWithValue("@rID", _returnFormID);
                            Cmd.Parameters.AddWithValue("@date", date);
                            Cmd.ExecuteNonQuery();
                        }
                        catch (Exception s)
                        {
                            conn1.Close();
                            MessageBox.Show("Failed to connect to database!!! Please try again later");
                            return;
                        }
                        conn1.Close();

                    }

                }
                for (int i = rowCount - 1; i >= 0; i--)
                {
                    DataGridViewCheckBoxCell checkBox = bookData.Rows[i].Cells[5] as DataGridViewCheckBoxCell;
                    if ((bool)checkBox.Value)
                    {
                        try
                        {
                            conn1.Open();
                            string selectQuerry = "UPDATE ChiTietPM SET TrangThai = 'true' From ChiTietPM A, PhieuMuonSach B WHERE A.MaSach = @bID and A.MaPhieuMuonSach = B.MaPhieuMuonSach and B.NgayMuonSach = @date";
                            SqlCommand Cmd = new SqlCommand(selectQuerry, conn1);
                            Cmd.Parameters.AddWithValue("@bID", bookData.Rows[i].Cells[0].Value.ToString());
                            List<int> temp = splitData(bookData.Rows[i].Cells[4].Value.ToString());
                            String date = temp[2].ToString() + '-' + temp[1].ToString() + '-' + temp[0].ToString();
                            Cmd.Parameters.AddWithValue("@date", date);
                            Cmd.ExecuteNonQuery();
                        }
                        catch (Exception s)
                        {
                            conn1.Close();
                            MessageBox.Show("Failed to connect to database!!! Please try again later");
                            return;
                        }
                        conn1.Close();
                        bookData.Rows.RemoveAt(i);
                    }
                }
            }
            reset();
        }

        private void totalBt_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            for (int i = 0 ; i < bookData.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkBox = bookData.Rows[i].Cells[5] as DataGridViewCheckBoxCell;
                if ((bool)checkBox.Value)
                {
                    List<int> temp = splitData(dateGetter.Text);
                    DateTime returnDate = new DateTime(temp[0], temp[1], temp[2]);
                    temp = splitData(bookData.Rows[i].Cells[4].Value.ToString());
                    DateTime issuedDate = new DateTime(temp[2], temp[1], temp[0]);
                    int dateCount = Int32.Parse((returnDate - issuedDate).TotalDays.ToString());
                    if (dateCount < 0)
                    {
                        MessageBox.Show("Date Error !!!");
                        return;
                    }
                    if (dateCount == 0)
                    {
                        Sum += AppValue._dailyFee;
                    }
                    else if (dateCount <= AppValue._maxIssuedDay)
                    {
                        Sum += dateCount * AppValue._dailyFee;
                    }
                    else
                    {
                        Sum += dateCount * AppValue._dailyFee;
                        Sum += (dateCount - AppValue._maxIssuedDay) * AppValue._overDueFee;
                    }
                }
            }
            total.Text = Sum.ToString();
        }


        public ReturnBookScreen()
        {
            InitializeComponent();
            dateGetter.Format = DateTimePickerFormat.Custom;
            dateGetter.CustomFormat = "yyyy-MM-dd";
        }

        private void rSearchBt_Click(object sender, EventArgs e)
        {
            bookData.Rows.Clear();
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select MaDocGia,HoTen,DiaChi,FORMAT (NgaySinh, 'dd-MM-yyyy') as NgaySinh,Email,TongNo from DocGia where MaDocGia=@ID";
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
                            _debt = oReader["TongNo"].ToString();
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

            try
            {
                conn.Open();
                string selectQuerry = "Select MaPhieuMuonSach,FORMAT (NgayMuonSach, 'dd-MM-yyyy') as NgayMuonSach from PhieuMuonSach where MaDocGia=@ID";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@ID", rIdTaker.Text);
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
                                            bookData.Rows.Add(newReader["MaSach"].ToString().Trim(), newReader["TenSach"].ToString(), newReader["TrangThai"].ToString(), newReader["TriGia"].ToString(), oReader["NgayMuonSach"].ToString(), false);
                                            _bookReturned.Add(false);
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
                        MessageBox.Show("No infomation !!!");                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed to connect to database!!! Please try again later");
            }
            conn.Close();
            if(bookData.Rows.Count == 0)
            {
                MessageBox.Show("No issued book!!!!");
            }
        }

        private List<int> splitData(String date)
        {
            List<int> rs =new List<int>();
            int pos = date.IndexOf('-', 0), start = 0;
            while (pos != -1)
            {
                string temp = date.Substring(start, pos - start);
                rs.Add(Int32.Parse(temp));
                start = pos + 1;
                pos = date.IndexOf('-', start);
            }
            string temp1 = date.Substring(start, date.Length - start);
            rs.Add(Int32.Parse(temp1));
            return rs;
        }
    }
}
