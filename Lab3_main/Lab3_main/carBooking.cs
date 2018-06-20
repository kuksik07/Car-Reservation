using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLib;
using System.Data.OleDb;
using System.IO;

namespace Lab3_main
{
    public partial class carBooking : Form
    {
        private int idCounter = 0;
        private int price;
        private int carId;
        private string imagePath;
        private string userName;
        DataTable carsTable;
        Reservation reservation = new Reservation();

        public carBooking(string userName)
        {
            InitializeComponent();
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
            userName_label.Text = userName;
            this.userName = userName;
            string query = "SELECT c_id, c_brand, c_volume, c_transmission, c_fuel, c_price, c_imagePath FROM cars;";
            this.carsTable = Db.GetTableFromDb(query);
            showCar(idCounter);

            // Круглые кнопки
            System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path.AddEllipse(0, 0, this.buttonNext.Width, this.buttonNext.Height);
            Region Button_Region = new Region(Button_Path);
            this.buttonNext.Region = this.button2.Region = Button_Region;         
        }

        public void showCar(int idCounter)
        {            
            carId = Convert.ToInt32(carsTable.Rows[idCounter][0]);
            carName_label.Text = carsTable.Rows[idCounter][1].ToString();
            Volume_fuel_label.Text = carsTable.Rows[idCounter][2].ToString() + " / " + carsTable.Rows[idCounter][4].ToString();
            transmission_label.Text = carsTable.Rows[idCounter][3].ToString();
            price_label.Text = "Цена в сутки: " + carsTable.Rows[idCounter][5].ToString() + " $";
            imagePath = carsTable.Rows[idCounter][6].ToString();
            if (File.Exists(imagePath))
            {
                pictureBox.ImageLocation = imagePath;
            }
            else
            {
                pictureBox.Image = Properties.Resources.default_image_small;
            }

            price = Convert.ToInt32(carsTable.Rows[idCounter][5]);
        }

        private void carBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentAccount account = (CurrentAccount)this.Owner;
            account.UpdateAll();
            account.Show();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            idCounter++;
            try
            {
                showCar(idCounter);
            }
            catch(Exception)
            {
                idCounter = 0;
                showCar(idCounter);
            }            
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            idCounter--;
            try
            {
                showCar(idCounter);
            }
            catch (Exception)
            {
                idCounter = carsTable.Rows.Count - 1;
                showCar(idCounter);
            }
        }

        private bool isAvailible(DateTime start1, int duration, DataTable datesReservation)
        {
            foreach (DataRow row in datesReservation.Rows)
            {
                DateTime start2 = Convert.ToDateTime(row[0]);
                DateTime end = Convert.ToDateTime(row[1]);
                int duration2 = Convert.ToInt32(reservation.GetLenReservation(end, start2));
                for (int i = 0; i < duration; i++)
                {
                    for (int j = 0; j < duration2; j++)
                    {
                        if (start1.AddDays(i).Date == start2.AddDays(j).Date)
                        {
                            return false;
                        }
                    }
                }
            }            
            return true;
        }

        private void book_it_Click(object sender, EventArgs e)
        {
            if (dateTimePickerStart.Value < dateTimePickerEnd.Value && dateTimePickerStart.Value.Date >= DateTime.Now.Date)
            {
                string query = "SELECT r_dateStart, r_dateEnd " +
                    "FROM reservation WHERE car_id = " + carId + "; ";
                DataTable datesReservation = Db.GetTableFromDb(query);

                reservation.SetDates(dateTimePickerStart.Value, dateTimePickerEnd.Value);
                int duration = reservation.GetLenReservation();
                if (isAvailible(reservation.GetDateStart(), duration, datesReservation))
                {
                    MessageBox.Show("Спасибо, бронь добавлена в систему", "ОК", MessageBoxButtons.OK, MessageBoxIcon.None);
                    int cost = duration * price;
                    query = "INSERT INTO reservation (user_login, car_id, r_dateStart, r_dateEnd, r_cost) " +
                    "VALUES ('" + userName + "','" + carId + "','" +
                    dateTimePickerStart.Value.ToString() + "','" + dateTimePickerEnd.Value.ToString() + "','" + cost + "');";
                    Db.sqlNonQuery(query);
                }
                else
                {
                    DialogResult newDate = MessageBox.Show("Простите, такие даты заняты" + '\n' +
                        "Хотите, подберём Вам дату?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult dialog = DialogResult.Yes;
                    DateTime newStart, newEnd;
                    int counter = 0;
                    if (newDate == DialogResult.Yes)
                    {
                        while(dialog == DialogResult.Yes)
                        {
                            while (isAvailible(reservation.GetDateStart().AddDays(counter), duration, datesReservation) == false)
                            {
                                counter++;
                            }
                            newStart = reservation.GetDateStart().AddDays(counter);
                            newEnd = reservation.GetDateStart().AddDays((counter) + duration);
                            dialog = MessageBox.Show("Можем посоветовать даты: " + '\n' +
                                Reservation.FormattedData(newStart) + " - " +
                                Reservation.FormattedData(newEnd) + '\n' +
                                "Сгенерировать новую (Yes), Установить эту дату (No), Отмена",
                                "Свободные дни", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
                            if (dialog == DialogResult.No)
                            {
                                dateTimePickerStart.Value = newStart;
                                dateTimePickerEnd.Value = newEnd;
                            }
                            if (dialog == DialogResult.Yes) counter++;
                        }                        
                    }
                    
                }
            }
            else if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
            {
                MessageBox.Show("Дата начала не может быть позже даты окончания!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePickerStart.Value == dateTimePickerEnd.Value)
            {
                MessageBox.Show("Дата начала равна дате окончания!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePickerStart.Value.Date != DateTime.Now.Date)
            {
                MessageBox.Show("Дата начала должна быть равной текущей или позже!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
