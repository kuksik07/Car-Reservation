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
    public partial class CurrentAccount : Form
    {
        private string userName;
        private int fine;

        public CurrentAccount(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void CurrentAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Authorization auth = (Authorization)this.Owner;
            auth.Show();
        }

        private void CurrentAccount_Load(object sender, EventArgs e)
        {
            UpdateAll();
        }

        public void UpdateAll()
        {
            userName_Value.Text = userName;
            bookingList.Items.Clear();
            //ProfileInfo
            string query = "SELECT u_name, u_surname, u_fine FROM users WHERE u_login = '" +
            this.userName + "';";
            DataTable user = Db.GetTableFromDb(query);
            name_Value.Text = user.Rows[0][0].ToString();
            surName_Value.Text = user.Rows[0][1].ToString();
            fine = Convert.ToInt32(user.Rows[0][2]);
            fine_Value.Text = fine.ToString() + " $";

            //listView
            query = "SELECT r_id, c_brand, r_dateStart, r_dateEnd, r_cost, r_status FROM cars  " +
                "INNER JOIN reservation ON cars.c_id = reservation.car_id WHERE user_login = '" +
                userName_Value.Text.ToString() + "';";
            DataTable reservations = Db.GetTableFromDb(query);
            string[] arr = new string[reservations.Columns.Count];
            ListViewItem itm;                

            foreach (DataRow row in reservations.Rows)
            {
                //add items to ListView
                for (int j = 0; j < reservations.Columns.Count; j++)
                {
                    if(j == 2 || j == 3)
                        arr[j] = Reservation.FormattedData(row[j].ToString());
                    else arr[j] = row[j].ToString();
                        
                }
                itm = new ListViewItem(arr);
                bookingList.Items.Add(itm);
            }                
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            carBooking reservation = new carBooking(userName);
            reservation.Owner = this;
            reservation.Show();
            Hide();
        }

        private void bookingList_DoubleClick(object sender, EventArgs e)
        {
            // user clicked an item of listview control
            if (bookingList.SelectedItems.Count == 1)
            {
                AboutCurrRent currRent = new AboutCurrRent(bookingList.SelectedItems[0].Text);
                currRent.Owner = this;
                currRent.ShowDialog();
                
            }
        }

        private void FinePay_Click(object sender, EventArgs e)
        {
            PayDialog pay = new PayDialog(("'" + userName + "'"), fine, 0, true);
            this.DialogResult = DialogResult.None;
            pay.ShowDialog();
            if (pay.DialogResult == DialogResult.OK)
            {
                fine = pay.value;
                fine_Value.Text = fine + " $";
            }
        }
    }
}
