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
using System.IO;
using System.Data.OleDb;

namespace Lab3_main
{
    public partial class AdminAddCar : Form
    {
        private string query;
        private int? id;


        public AdminAddCar()
        {
            InitializeComponent();
        }

        public AdminAddCar(int id)
        {
            InitializeComponent();
            this.id = id;
            string sqlQuery = "SELECT c_brand, c_volume, c_transmission, c_fuel, c_price, c_imagePath FROM cars WHERE c_id = " + id + ';';
            DataTable currCar = Db.GetTableFromDb(sqlQuery);

            carName.Text = currCar.Rows[0][0].ToString();
            carVolume.Value = Convert.ToDecimal(currCar.Rows[0][1]);
            carTransmission.Text = currCar.Rows[0][2].ToString();
            carFuel.Text = currCar.Rows[0][3].ToString();
            carPrice.Text = currCar.Rows[0][4].ToString();
            carImagePath.Text = currCar.Rows[0][5].ToString();
        }

        private void browseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*",
                InitialDirectory = Path.GetFullPath(@"..\..\..\Resources\cars")
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                carImagePath.Text = filename;
            }
                
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (id.HasValue == false)
            {
                query = "INSERT INTO cars (c_brand, c_volume, c_transmission, c_fuel, c_price, c_imagePath) " +
                    "VALUES ('" + carName.Text.ToString() + "'," + carVolume.Value.ToString().Replace(',', '.') + ",'" +
                    carTransmission.Text.ToString() + "','" + carFuel.Text.ToString() + "'," +
                    carPrice.Text.ToString() + ",'" + carImagePath.Text.ToString() + "');";
            }
            else
            {
                query = "UPDATE cars SET " +
                    "c_brand = '" + carName.Text.ToString() + "', " +
                    "c_volume = " + carVolume.Value.ToString().Replace(',', '.') + ", " +
                    "c_transmission = '" + carTransmission.Text.ToString() + "', " +
                    "c_fuel = '" + carFuel.Text.ToString() + "', " +
                    "c_price = " + carPrice.Text.ToString() + ", " +
                    "c_imagePath= '" + carImagePath.Text.ToString() + "' WHERE c_id = " + id + ';';                     
            }
            
            if (carName.Text.Length > 0 && carTransmission.Text.Length > 0 &&
                carFuel.Text.Length > 0 && carPrice.Text.Length > 0)
            {                
                
                try
                {
                    Db.sqlNonQuery(query);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Проверьте соответствие типов и значение введённых полей!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
