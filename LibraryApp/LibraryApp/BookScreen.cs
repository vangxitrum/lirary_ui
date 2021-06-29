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
    public partial class BookScreen : Form
    {

        List<string> bAuthorID = new List<string>();
        List<string> bGenreID = new List<string>();
        public BookScreen()
        {
            InitializeComponent();
            loadData();
        }

        private void bookData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddBookScreen child = new AddBookScreen();
            child.ShowDialog();
            loadData();
        }

        private void modifyBt_Click(object sender, EventArgs e)
        {
            int index = bookData.SelectedCells[0].RowIndex;
            ModifyBookScreen child = new ModifyBookScreen(
                bookData.Rows[index].Cells[0].Value.ToString(),
                bookData.Rows[index].Cells[1].Value.ToString(),
                bookData.Rows[index].Cells[10].Value.ToString(),
                bookData.Rows[index].Cells[11].Value.ToString(),
                bookData.Rows[index].Cells[4].Value.ToString(),
                bookData.Rows[index].Cells[5].Value.ToString(),
                bookData.Rows[index].Cells[6].Value.ToString(),
                bookData.Rows[index].Cells[7].Value.ToString(),
                bookData.Rows[index].Cells[8].Value.ToString(),
                bookData.Rows[index].Cells[9].Value.ToString()
                ) ;
            child.ShowDialog();
        }

        private void loadData()
        {
            bookData.Rows.Clear();
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "select *, TenTacGia as TacGia, TenTheLoai as TheLoai  from Sach A, TacGia B, TheLoai C where A.MaTG = B.MaTG and A.MaTL = C.MaTL";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            bookData.Rows.Add(oReader["MaSach"].ToString().Trim(),
                                oReader["TenSach"].ToString(),
                                oReader["TheLoai"].ToString(),
                                oReader["TacGia"].ToString(),
                                 oReader["TrangThai"].ToString(),
                                oReader["SoLuong"].ToString(),
                                oReader["ViTri"].ToString(),
                                oReader["NamSuatBan"].ToString(),
                                oReader["NhaSuatBan"].ToString(),
                                oReader["TriGia"].ToString(),
                                oReader["MaTG"].ToString(),
                                oReader["MaTL"].ToString());
                            bAuthorID.Add(oReader["MaTG"].ToString());
                            bGenreID.Add(oReader["MaTL"].ToString());
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

        private void searchBt_Click(object sender, EventArgs e)
        {
            bookData.Rows.Clear();
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string selectQuerry = "select *, TenTacGia as TacGia, TenTheLoai as TheLoai  from Sach A, TacGia B, TheLoai C where A.MaTG = B.MaTG and A.MaTL = C.MaTL and A.TenSach = @searchText";
                SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                Cmd.Parameters.AddWithValue("@searchText", searchBar.Text);
                using (SqlDataReader oReader = Cmd.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        while (oReader.Read())
                        {
                            bookData.Rows.Add(oReader["MaSach"].ToString().Trim(),
                                oReader["TenSach"].ToString(),
                                oReader["TheLoai"].ToString(),
                                oReader["TacGia"].ToString(),
                                 oReader["TrangThai"].ToString(),
                                oReader["SoLuong"].ToString(),
                                oReader["ViTri"].ToString(),
                                oReader["NamSuatBan"].ToString(),
                                oReader["NhaSuatBan"].ToString(),
                                oReader["TriGia"].ToString(),
                                oReader["MaTG"].ToString(),
                                oReader["MaTL"].ToString());
                            bAuthorID.Add(oReader["MaTG"].ToString());
                            bGenreID.Add(oReader["MaTL"].ToString());
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

        private void searchBar_TextChange(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                loadData();
            }
        }
    }
}
