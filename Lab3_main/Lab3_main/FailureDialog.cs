using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLib; 

namespace Lab3_main
{
    public partial class FailureDialog : Form
    {
        private int id;
        private string login;
        private DateTime dateEnd;
        private int currFine;
        private int bookingPrice;
        private string status;

        public FailureDialog(int id, string login, int bookingPrice, string status, string dateEnd)
        {
            InitializeComponent();
            this.id = id;
            this.login = login;
            this.bookingPrice = bookingPrice;
            this.status = status;
            this.dateEnd = Convert.ToDateTime(dateEnd);
            currDateEnd_value.Text = Reservation.FormattedData(dateEnd);
            dateTimePickerEnd.Value = this.dateEnd;
        }

        private void CancelBooking_Click(object sender, EventArgs e)
        {
            if (dateTimePickerEnd.Value > dateEnd)
            {
                MessageBox.Show("Невозможно указать дату позднее, чем она была!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePickerEnd.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Невозможно указать дату ранее текущей даты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePickerEnd.Value == dateEnd)
            {
                MessageBox.Show("Вы указали ту же дату, что и была изначально!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(status == "False")
                {
                    Db.sqlNonQuery(("UPDATE reservation SET r_dateEnd = '" + Reservation.FormattedData(dateTimePickerEnd.Value.ToString()) + "', r_status = True WHERE r_id = " + id + ";"));
                    currFine = Convert.ToInt32(Convert.ToDecimal(Db.GetTableFromDb("SELECT u_fine FROM users WHERE u_login = '" + login + "';").Rows[0][0].ToString()));
                    Db.sqlNonQuery("UPDATE users SET u_fine = " + (currFine + bookingPrice * 0.3) + " WHERE u_login = '" + login + "'; ");
                    MessageBox.Show("Хорошо, новая дата окончания бронирования : " + Reservation.FormattedData(dateTimePickerEnd.Value.ToString()), "Вы успешно отменили Вашу бронь", MessageBoxButtons.OK, MessageBoxIcon.None);
                    AboutCurrRent currRent = (AboutCurrRent)this.Owner;
                    currRent.statusValue.Text = "True";
                    currRent.dateEndValue.Text = Reservation.FormattedData(dateTimePickerEnd.Value.ToString());
                    Close();
                }
                else
                {
                    MessageBox.Show("Вы уже отменили её!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
