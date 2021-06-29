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
    public partial class ReadersScreen : Form
    {
        public bool flat = false;
        public ReadersScreen()
        {
            InitializeComponent();
            loadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddReader child = new AddReader();
            child.ShowDialog();
            loadData();
        }

        private void payBt_Click(object sender, EventArgs e)
        {
            int index = readerData.SelectedCells[0].RowIndex;
            string id, name, date, Debt;
            id = readerData.Rows[index].Cells[0].Value.ToString();
            name = readerData.Rows[index].Cells[1].Value.ToString();
            date = readerData.Rows[index].Cells[3].Value.ToString();
            Debt = readerData.Rows[index].Cells[7].Value.ToString();
            PayDebtScreen child = new PayDebtScreen(null,this,Debt,name,date,id);
            child.ShowDialog();
            loadData();
        }

        private void loadData()
        {
            readerData.Rows.Clear();
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select *, B.TenLoaiDocGia as LoaiDocGia,FORMAT (NgaySinh, 'yyyy-MM-dd') as rNgaySinh,FORMAT (NgayLapThe, 'yyyy-MM-dd') as rNgayLapThe from DocGia A, LoaiDocGia B where A.MaLoaiDocGia = B.MaLoaiDocGIa";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            readerData.Rows.Add(oReader["MaDocGia"].ToString().Trim(),
                                oReader["HoTen"].ToString(),
                                oReader["LoaiDocGia"].ToString(),
                                oReader["rNgaySinh"].ToString(),
                                oReader["DiaChi"].ToString(),
                                oReader["Email"].ToString(),
                                oReader["rNgayLapThe"].ToString(),
                                oReader["TongNo"].ToString(),
                                oReader["MaLoaiDocGia"].ToString()
                                ) ;
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

        private void deleteBt_Click(object sender, EventArgs e)
        {
            int index = readerData.SelectedCells[0].RowIndex;
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Reader", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();
                    
                    string selectQuerry = "Select MaPhieuMuonSach,FORMAT (NgayMuonSach, 'dd-MM-yyyy') as NgayMuonSach from PhieuMuonSach where MaDocGia=@ID";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                    Cmd.Parameters.AddWithValue("@ID", readerData.Rows[index].Cells[0].Value.ToString());
                    using (SqlDataReader oReader = Cmd.ExecuteReader())
                    {
                        if (oReader.HasRows)
                        {
                            while (oReader.Read())
                            {
                                SqlConnection newConn = DBUtils.GetDBConnection();
                                try
                                {

                                    newConn.Open();
                                    string newQuerry = "Select * From Sach A,(Select * From ChiTietPM where MaPhieuMuonSach = @pMID) B Where A.MaSach = B.MaSach And B.TrangThai = 0";
                                    SqlCommand newCmd = new SqlCommand(newQuerry, newConn);
                                    newCmd.Parameters.AddWithValue("@pMID", oReader["MaPhieuMuonSach"].ToString());
                                    using (SqlDataReader newReader = newCmd.ExecuteReader())
                                    {
                                        if (newReader.HasRows)
                                        {
                                            MessageBox.Show("Reader have issued books!!!");
                                            return;
                                        }
                                    }
                                }
                                catch (Exception s)
                                {
                                    MessageBox.Show("Failed to connect to database!!! Please try again later");
                                }
                                newConn.Close();
                            }
                        }
                    }
                }
                catch (Exception s)
                {
                    MessageBox.Show("Failed to connect to database!!! Please try again later");
                }
                conn.Close();
                SqlConnection conn1 = DBUtils.GetDBConnection();
                //Delete
                //Delete Reader
                conn1.Open();
                try
                {
                    string selectQuerry = "Delete from DocGia where MaDocGia = @id";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn1);
                    Cmd.Parameters.AddWithValue("@id",this.readerData.SelectedRows[0].Cells[0].Value.ToString());
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception s)
                {
                    conn1.Close();
                    MessageBox.Show("Error");
                    return;
                }
                conn1.Close();
                readerData.Rows.RemoveAt(index);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                loadData();
            }
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            readerData.Rows.Clear();
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "Select *, B.TenLoaiDocGia as LoaiDocGia,FORMAT (NgaySinh, 'yyyy-MM-dd') as rNgaySinh,FORMAT (NgayLapThe, 'yyyy-MM-dd') as rNgayLapThe from DocGia A, LoaiDocGia B where A.MaLoaiDocGia = B.MaLoaiDocGIa and A.HoTen = @searchText";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@searchText", searchBar.Text);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            readerData.Rows.Add(oReader["MaDocGia"].ToString().Trim(),
                                oReader["HoTen"].ToString(),
                                oReader["LoaiDocGia"].ToString(),
                                oReader["rNgaySinh"].ToString(),
                                oReader["DiaChi"].ToString(),
                                oReader["Email"].ToString(),
                                oReader["rNgayLapThe"].ToString(),
                                oReader["TongNo"].ToString(),
                                oReader["MaLoaiDocGia"].ToString());
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

        private void modifyBt_Click(object sender, EventArgs e)
        {
            int index = readerData.SelectedCells[0].RowIndex;
            ModifyReader child = new ModifyReader(
                 readerData.Rows[index].Cells[0].Value.ToString(),
                 readerData.Rows[index].Cells[1].Value.ToString(),
                 readerData.Rows[index].Cells[4].Value.ToString(),
                 readerData.Rows[index].Cells[3].Value.ToString(),
                 readerData.Rows[index].Cells[7].Value.ToString(),
                 readerData.Rows[index].Cells[5].Value.ToString(),
                 readerData.Rows[index].Cells[6].Value.ToString(),
                 readerData.Rows[index].Cells[8].Value.ToString()
                );
            child.ShowDialog();
            loadData();
        }
    }
}
