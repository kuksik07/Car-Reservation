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
    public partial class AdminPanel : Form
    {
        private string userName;
        private int currSelectedCar;
        private string currSelectedUser;
        private int currSelectedBooking;
        private bool showAuth = true;

        public AdminPanel(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        public void UpdateCars()
        {
            listCars.Clear();
            string query = "SELECT * FROM cars;";
            DataTable carsTable = Db.GetTableFromDb(query);
            string[] arr = new string[carsTable.Columns.Count];
            ImageList imageList = new ImageList();

            foreach (DataRow row in carsTable.Rows)
            {
                try
                {
                    imageList.Images.Add(Image.FromFile(row[carsTable.Columns.Count - 1].ToString()));
                    listCars.View = View.LargeIcon;
                    imageList.ImageSize = new Size(125, 90);
                    listCars.LargeImageList = imageList;
                }
                catch
                {
                    imageList.Images.Add(Properties.Resources.default_image_small);
                }                                     
            }

            for (int i = 0; i < imageList.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Tag = Convert.ToInt16(carsTable.Rows[i][0].ToString());
                for (int j = 0; j < carsTable.Columns.Count - 1; j++)
                {
                    arr[j] = carsTable.Rows[i][j].ToString();
                }
                item.Text = string.Join(" ", arr) + '$';
                listCars.Items.Add(item);
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            UpdateCars();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing && showAuth)
            {
                Authorization auth = (Authorization)this.Owner;
                auth.Show();
            }                                
        }

        private void backToUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authorization auth = (Authorization)this.Owner;
            CurrentAccount account = new CurrentAccount(userName);
            account.Owner = auth;
            account.Show();
            showAuth = false;
            Close();
        }

        private void addCar_Click(object sender, EventArgs e)
        {
            AdminAddCar addCar = new AdminAddCar();
            addCar.ShowDialog();
            if (addCar.DialogResult == DialogResult.OK)
            {
                UpdateCars();
            }
        }


        private void listCars_Click(object sender, EventArgs e)
        {
            if (listCars.SelectedItems.Count == 1)
            {
                currSelectedCar = Convert.ToInt16(listCars.SelectedItems[0].Tag);
            }
            else
            {
                currSelectedCar = 0;
            }
        }

        private void changeCar_Click(object sender, EventArgs e)
        {
            if (listCars.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одного автомобиля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AdminAddCar changeCar = new AdminAddCar(currSelectedCar);
                changeCar.ShowDialog();
                if (changeCar.DialogResult == DialogResult.OK)
                {
                    UpdateCars();
                }
            }
        }

        private void deleteCar_Click(object sender, EventArgs e)
        {
            if (listCars.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одного автомобиля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Db.sqlNonQuery("DELETE FROM cars WHERE c_id = " + currSelectedCar + ";");
                UpdateCars();
            }
        }

        private void carsPage_Click(object sender, EventArgs e)
        {
            UpdateCars();
        }

        public void UpdateUsers()
        {
            usersList.Items.Clear();
            string query = "SELECT * FROM users;";
            DataTable usersTable = Db.GetTableFromDb(query);
            string[] arr = new string[usersTable.Columns.Count];
            ListViewItem item;

            for (int i = 0; i < usersTable.Rows.Count; i++)
            {
                for (int j = 0; j < usersTable.Columns.Count; j++)
                {
                    arr[j] = usersTable.Rows[i][j].ToString();
                }
                item = new ListViewItem(arr);
                usersList.Items.Add(item);
            }
        }

        private void usersList_Click(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count == 1)
            {
                currSelectedUser = usersList.SelectedItems[0].Text.ToString();
            }
            else
            {
                currSelectedUser = null;
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            Register addUser = new Register();
            addUser.title.Text = "Добавление";
            addUser.labelRole.Visible = true;
            addUser.userRole.Visible = true;
            addUser.btnRegister.Text = "Добавить";
            addUser.ShowDialog();
            if (addUser.DialogResult == DialogResult.OK)
            {
                UpdateUsers();
            }
        }

        private void changeUser_Click(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одного пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Register changeUser = new Register(currSelectedUser);
                changeUser.title.Text = "Обновление";
                changeUser.labelRole.Visible = true;
                changeUser.userRole.Visible = true;
                changeUser.labelFine.Visible = true;
                changeUser.userFine.Visible = true;
                changeUser.btnRegister.Text = "Обновить";
                changeUser.ShowDialog();
                if (changeUser.DialogResult == DialogResult.OK)
                {
                    UpdateUsers();
                }
            }            
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одного пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Db.sqlNonQuery("DELETE FROM users WHERE u_login = '" + currSelectedUser + "';");
                UpdateUsers();
            }
        }

        private void usersPage_Click(object sender, EventArgs e)
        {
            UpdateUsers();
        }

        public void UpdateBooking()
        {
            listBooking.Items.Clear();
            string query = "SELECT * FROM reservation;";
            DataTable bookingTable = Db.GetTableFromDb(query);
            string[] arr = new string[bookingTable.Columns.Count];
            ListViewItem item;

            for (int i = 0; i < bookingTable.Rows.Count; i++)
            {
                for (int j = 0; j < bookingTable.Columns.Count; j++)
                {
                    arr[j] = bookingTable.Rows[i][j].ToString();
                    if (j == 3 || j == 4)
                    {
                        arr[j] = Reservation.FormattedData(arr[j]);
                    }
                }
                item = new ListViewItem(arr);
                listBooking.Items.Add(item);
            }
        }

        private void listBooking_Click(object sender, EventArgs e)
        {
            if (listBooking.SelectedItems.Count == 1)
            {
                currSelectedBooking = Convert.ToInt32(listBooking.SelectedItems[0].Text.ToString());
            }
            else
            {
                currSelectedBooking = 0;
            }
        }

        private void deleteBooking_Click(object sender, EventArgs e)
        {
            if (listBooking.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одно бронирование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Db.sqlNonQuery("DELETE FROM reservation WHERE r_id = " + currSelectedBooking + ";");
                UpdateBooking();
            }
        }

        private void adminTab_Selected(object sender, TabControlEventArgs e)
        {
            if (adminTab.SelectedTab.Name == "carsPage")
            {
                UpdateCars();
            }
            else if (adminTab.SelectedTab.Name == "usersPage")
            {
                UpdateUsers();
            }
            else if (adminTab.SelectedTab.Name == "bookingPage")
            {
                UpdateBooking();
            }
        }
    }
}
