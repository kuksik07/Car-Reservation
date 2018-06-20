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
    public partial class AboutCurrRent : Form
    {
        private int id;
        private string currUsername;
        private int bookingPrice;
        private string status;

        public AboutCurrRent(string id)
        {
            InitializeComponent();
            this.id = Convert.ToInt32(id);
            SetValues();
        }


        private void SetValues()
        {
            string query = "SELECT c_brand, r_dateStart, r_dateEnd, r_cost, r_status, c_imagePath, r_paid, user_login FROM cars  " +
                    "INNER JOIN reservation ON cars.c_id = reservation.car_id WHERE r_id = " + id + ";";
            DataTable rent = Db.GetTableFromDb(query);


            carNameValue.Text = rent.Rows[0][0].ToString();
            dateStartValue.Text = Reservation.FormattedData(rent.Rows[0][1].ToString());
            dateEndValue.Text = Reservation.FormattedData(rent.Rows[0][2].ToString());
            bookingPrice = Convert.ToInt32(rent.Rows[0][3].ToString());
            costValue.Text = bookingPrice.ToString();
            status = rent.Rows[0][4].ToString();
            statusValue.Text = status;
            pictureBox1.ImageLocation = rent.Rows[0][5].ToString();
            paid.Text = Convert.ToInt32(rent.Rows[0][6]).ToString() + " $";
            currUsername = rent.Rows[0][7].ToString();
        }

        private void AboutCurrRent_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            CurrentAccount account = (CurrentAccount)this.Owner;
            account.UpdateAll();
            Close();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(costValue.Text.ToString());
            int paidInt = Convert.ToInt32(paid.Text.ToString().Split(' ')[0]);
            PayDialog pay = new PayDialog(id.ToString(), (cost - paidInt), paidInt);
            pay.Owner = this;
            this.DialogResult = DialogResult.None;
            pay.ShowDialog(this);
            if (pay.DialogResult == DialogResult.OK)
            {
                this.paid.Text = pay.value + " $";
            }
        }

        private void buttonFailure_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите этого? Отмена брони несёт за собой штраф",
                "Вы уверены...?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FailureDialog dialog = new FailureDialog(id, currUsername, bookingPrice, status, dateEndValue.Text.ToString());
                dialog.Owner = this;
                dialog.ShowDialog(this);
            }
        }
    }
}
