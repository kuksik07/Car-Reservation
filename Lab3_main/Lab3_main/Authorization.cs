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
    public partial class Authorization : Form
    {
        private string role;

        public Authorization()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "";
            infoLabel.Visible = true;
            
            if (userName_textBox.Text.Length > 0 && password_textBox.Text.Length > 0)
            {
                string userName = userName_textBox.Text.ToString();
                string query = "SELECT u_name, u_surname, u_role FROM users WHERE u_login = '" +
                    userName + "' AND u_password = '" + password_textBox.Text.ToString() + "';";

                try
                {
                    DataTable user = Db.GetTableFromDb(query);
                    infoLabel.Text = "Добро пожаловать, " + user.Rows[0][0] + " " + user.Rows[0][1];
                    role = user.Rows[0][2].ToString();
                    CurrentAccount account = new CurrentAccount(userName);
                    account.Owner = this;

                    if (role == "admin")
                    {
                        DialogResult result = MessageBox.Show(infoLabel.Text + '\n' +
                            "У вас роль: 'админ'." + '\n' + "Желаете зайти в административную панель?",
                            "Админ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            AdminPanel adminPanel = new AdminPanel(userName);
                            adminPanel.Owner = this;
                            adminPanel.Show();
                        }
                        else
                        {
                            account.Show();
                        }
                    } else if (role == "user")
                    {
                        MessageBox.Show(infoLabel.Text);
                        account.Show();
                    }                    
                    this.Hide();
                }
                catch (Exception)
                {
                    infoLabel.Text = "Проверьте введённые данные!";
                }
            }
            else
            {
                infoLabel.Text = "Заполните все поля!";
            }
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (userName_textBox.Text == "Login")
            {
                userName_textBox.ForeColor = Color.Black;
                userName_textBox.Text = "";                
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (userName_textBox.Text == "")
            {
                userName_textBox.ForeColor = Color.Gray;
                userName_textBox.Text = "Login";                
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (password_textBox.Text == "Password")
            {
                password_textBox.ForeColor = Color.Black;
                password_textBox.Text = "";                
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (password_textBox.Text == "")
            {
                password_textBox.ForeColor = Color.Gray;
                password_textBox.Text = "Password";                
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            userName_textBox.ForeColor = Color.Gray;
            password_textBox.ForeColor = Color.Gray;
            if (userName_textBox.Text == "" && userName_textBox.Text == "")
            {
                userName_textBox.Text = "Login";
                password_textBox.Text = "Password";
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Owner = this;
            register.ShowDialog();    
            if (register.DialogResult == DialogResult.OK)
            {
                userName_textBox.ForeColor = Color.Black;
                password_textBox.ForeColor = Color.Black;
                userName_textBox.Text = register.textBoxLogin.Text;
                password_textBox.Text = register.textBoxPwrd.Text;
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (password_textBox.PasswordChar == '*')
            {
                password_textBox.PasswordChar = '\0';
            }
            else
            {
                password_textBox.PasswordChar = '*';
            }
        }
    }
}
