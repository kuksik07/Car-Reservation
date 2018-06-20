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
    public partial class PayDialog : Form
    {
        private string valueWhere;
        private int totalCost;        
        private int paid;
        public int value;
        private bool showBalance;

        public PayDialog(string valueWhere, int totalCost, int paid, bool showBalance = false)
        {
            InitializeComponent();
            this.totalCost = totalCost;            
            this.paid = paid;
            this.showBalance = showBalance;
            this.valueWhere = valueWhere;
            cost.Text = this.totalCost.ToString();
            inputOfMoney.Value = this.totalCost;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string query;
            if (!showBalance)
            {
                /* shows how much paid */
                value = paid;
                query = "UPDATE reservation " + "SET r_paid = " + value + " WHERE r_id = " + valueWhere + ';';
            }
            else
            {
                value = totalCost;
                query = "UPDATE users " + "SET u_fine = " + value + " WHERE u_login = " + valueWhere + ';';
            }


            Db.sqlNonQuery(query);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfirmPay_Click(object sender, EventArgs e)
        {
            int buf;
            if (inputOfMoney.Value > 0)
            {                
                buf = totalCost - Convert.ToInt32(inputOfMoney.Value);
                if (buf < 0)
                {
                    ShowErrorTransaction();
                }
                else
                {
                    paid += Convert.ToInt32(inputOfMoney.Value);
                    totalCost = buf;
                    cost.Text = totalCost.ToString();
                }
            }
            else if (inputOfMoney.Value == 0)
            {
                ShowErrorTransaction();
            }
        }

        private void ShowErrorTransaction()
        {
            MessageBox.Show("Невозможно выполнить транзакцию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PayDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
