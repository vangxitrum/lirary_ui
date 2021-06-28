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
    public partial class PayDebtScreen : Form
    {
        String userID,debt,name,dateOfBirth;
        ReturnBookScreen parent;
        ReadersScreen parent1;
        private void saveBt_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(debt) <= Int32.Parse(payTaker.Text))
            {
                MessageBox.Show("Error!!!");
            }
            else
            {
                int value = Int32.Parse(debt) - Int32.Parse(payTaker.Text);
                SqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();
                    string selectQuerry = "UPDATE DocGia SET TongNo = @debt where MaDocGia = @ID";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                    Cmd.Parameters.AddWithValue("@ID", idTaker.Text);
                    Cmd.Parameters.AddWithValue("@debt", value);
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception s)
                {
                    MessageBox.Show("Failed to connect to database!!! Please try again later");
                }
                conn.Close();

                try
                {
                    conn.Open();
                    string selectQuerry = "INSERT INTO PhieuThuTien (MaPTT,MaDocGia,SoTienThu,NgayThu) VALUES([dbo].[idPhieuTT](),@rID,@SoTienThu,@date)";
                    SqlCommand Cmd = new SqlCommand(selectQuerry, conn);
                    Cmd.Parameters.AddWithValue("@rID", idTaker.Text);
                    Cmd.Parameters.AddWithValue("@date", todayGetter.Value.ToString());
                    Cmd.Parameters.AddWithValue("@SoTienThu", payTaker.Text);
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception s)
                {
                    MessageBox.Show("Failed to connect to database!!! Please try again later");
                }
                conn.Close();
                if (parent != null) parent.flat = true;
                if (parent1 != null) parent1.flat = true;
                
                
            }
            this.Close();
        }

        public PayDebtScreen(ReturnBookScreen parent,ReadersScreen parent1, String debt, String Name, String dateOfBirth, String ID)
        {
            this.parent1 = parent1;
            this.parent = parent;
            InitializeComponent();
            this.debt = debt;
            this.name = Name;
            this.dateOfBirth = dateOfBirth;
            this.rDebt.Text = debt;
            this.nameTaker.Text = Name;
            this.birthDayTaker.Text = dateOfBirth;
            this.idTaker.Text = ID;
            todayGetter.Format = DateTimePickerFormat.Custom;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
