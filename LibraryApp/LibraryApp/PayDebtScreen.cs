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
        String _userID, _debt, _name, _dateOfBirth;
        ReturnBookScreen _parent;
        ReadersScreen _parent1;
        private void saveBt_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(_debt) < Int32.Parse(payTaker.Text))
            {
                MessageBox.Show("Error!!!");
            }
            else
            {
                int value = Int32.Parse(_debt) - Int32.Parse(payTaker.Text);
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
                if (_parent != null) _parent._flat = true;
                if (_parent1 != null) _parent1._flat = true;
                
                
            }
            this.Close();
        }

        public PayDebtScreen(ReturnBookScreen parent,ReadersScreen parent1, String debt, String Name, String dateOfBirth, String ID)
        {
            this._parent1 = parent1;
            this._parent = parent;
            InitializeComponent();
            this._debt = debt;
            this._name = Name;
            this._dateOfBirth = dateOfBirth;
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
