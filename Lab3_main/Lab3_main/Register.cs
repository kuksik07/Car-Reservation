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
    public partial class Register : Form
    {
        private bool errorLogin = false;
        private string currUser;

        public Register()
        {
            InitializeComponent();
        }

        public Register(string currUser)
        {
            InitializeComponent();
            this.currUser = currUser;
            string sqlQuery = "SELECT * FROM users WHERE u_login = '" + currUser + "';";
            DataTable user = Db.GetTableFromDb(sqlQuery);

            textBoxLogin.Text = user.Rows[0][0].ToString();
            textBoxPwrd.Text = user.Rows[0][1].ToString();
            textBoxConfPwrd.Text = textBoxPwrd.Text;
            userRole.Text = user.Rows[0][2].ToString();
            textBoxName.Text = user.Rows[0][3].ToString();
            textBoxSurn.Text = user.Rows[0][4].ToString();
            userFine.Text = user.Rows[0][5].ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string query;
            if (textBoxLogin.Text.Length > 0 && textBoxPwrd.Text.Length > 0 && textBoxConfPwrd.Text.Length > 0 &&
                userRole.Text.Length > 0 && textBoxName.Text.Length > 0 && textBoxSurn.Text.Length > 0)
            {
                if (textBoxPwrd.Text == textBoxConfPwrd.Text)
                {
                    if (currUser == null)
                    {
                        query = "INSERT INTO users (u_login, u_password, u_role, u_name, u_surname) " +
                        "VALUES ('" + textBoxLogin.Text.ToString() + "','" + textBoxPwrd.Text.ToString() + "','" +
                        userRole.Text.ToString() + "','" + textBoxName.Text.ToString() + "','" + textBoxSurn.Text.ToString() + "');";
                    }
                    else
                    {                        
                        query = "UPDATE users SET " +
                            "u_login = '" + textBoxLogin.Text.ToString() + "', " +
                            "u_password = '" + textBoxPwrd.Text.ToString() + "', " +
                            "u_role = '" + userRole.Text.ToString() + "', " +
                            "u_name = '" + textBoxName.Text.ToString() + "', " +
                            "u_surname = '" + textBoxSurn.Text.ToString() + "', " +
                            "u_fine = " + userFine.Text.ToString().Replace(',', '.') + " WHERE u_login = '" + currUser + "';";
                    }
                    
                    try
                    {
                        Db.sqlNonQuery(query);
                        errorLogin = false;
                    }
                    catch(OleDbException)
                    {
                        labelErrLog.Visible = true;
                        errorLogin = true;
                    }

                    if (!errorLogin)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.labelErrLog.Visible = false;
                        Close();
                    }   
                }
                else
                {
                    labelInfo.Visible = true;
                    labelInfo.Text = "Пароли не совпадают!";
                }
            }
            else
            {
                labelInfo.Visible = true;
                labelInfo.Text = "Заполните все поля!";
            }
        }

        private void show1_Click(object sender, EventArgs e)
        {
            if (textBoxPwrd.PasswordChar == '*')
            {
                textBoxPwrd.PasswordChar = '\0';
            }
            else
            {
                textBoxPwrd.PasswordChar = '*';
            }
        }
        
        private void show2_Click(object sender, EventArgs e)
        {
            if (textBoxConfPwrd.PasswordChar == '*')
            {
                textBoxConfPwrd.PasswordChar = '\0';
            }
            else
            {
                textBoxConfPwrd.PasswordChar = '*';
            }
        }
    }
}
