namespace Lab3_main
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.carsPage = new System.Windows.Forms.TabPage();
            this.listCars = new System.Windows.Forms.ListView();
            this.changeCar = new System.Windows.Forms.Button();
            this.deleteCar = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.addCar = new System.Windows.Forms.Button();
            this.adminTab = new System.Windows.Forms.TabControl();
            this.usersPage = new System.Windows.Forms.TabPage();
            this.usersList = new System.Windows.Forms.ListView();
            this.userLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userFine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.userTitle = new System.Windows.Forms.Label();
            this.addUser = new System.Windows.Forms.Button();
            this.bookingPage = new System.Windows.Forms.TabPage();
            this.listBooking = new System.Windows.Forms.ListView();
            this.bookingId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.car_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookingDateStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookingDateEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookingCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookingPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookingStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteBooking = new System.Windows.Forms.Button();
            this.bookingTitle = new System.Windows.Forms.Label();
            this.backToUser = new System.Windows.Forms.LinkLabel();
            this.carsPage.SuspendLayout();
            this.adminTab.SuspendLayout();
            this.usersPage.SuspendLayout();
            this.bookingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsPage
            // 
            this.carsPage.Controls.Add(this.listCars);
            this.carsPage.Controls.Add(this.changeCar);
            this.carsPage.Controls.Add(this.deleteCar);
            this.carsPage.Controls.Add(this.title);
            this.carsPage.Controls.Add(this.addCar);
            this.carsPage.Location = new System.Drawing.Point(4, 34);
            this.carsPage.Name = "carsPage";
            this.carsPage.Padding = new System.Windows.Forms.Padding(3);
            this.carsPage.Size = new System.Drawing.Size(578, 373);
            this.carsPage.TabIndex = 0;
            this.carsPage.Text = "Автомобили";
            this.carsPage.UseVisualStyleBackColor = true;
            this.carsPage.Click += new System.EventHandler(this.carsPage_Click);
            // 
            // listCars
            // 
            this.listCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listCars.FullRowSelect = true;
            this.listCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listCars.Location = new System.Drawing.Point(41, 47);
            this.listCars.MultiSelect = false;
            this.listCars.Name = "listCars";
            this.listCars.Size = new System.Drawing.Size(505, 269);
            this.listCars.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listCars.TabIndex = 48;
            this.listCars.UseCompatibleStateImageBehavior = false;
            this.listCars.View = System.Windows.Forms.View.Details;
            this.listCars.Click += new System.EventHandler(this.listCars_Click);
            // 
            // changeCar
            // 
            this.changeCar.BackColor = System.Drawing.SystemColors.Control;
            this.changeCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeCar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeCar.Font = new System.Drawing.Font("Arial", 9F);
            this.changeCar.ForeColor = System.Drawing.Color.Black;
            this.changeCar.Location = new System.Drawing.Point(236, 327);
            this.changeCar.Margin = new System.Windows.Forms.Padding(0);
            this.changeCar.Name = "changeCar";
            this.changeCar.Size = new System.Drawing.Size(116, 30);
            this.changeCar.TabIndex = 50;
            this.changeCar.Text = "Изменить";
            this.changeCar.UseVisualStyleBackColor = false;
            this.changeCar.Click += new System.EventHandler(this.changeCar_Click);
            // 
            // deleteCar
            // 
            this.deleteCar.BackColor = System.Drawing.SystemColors.Control;
            this.deleteCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCar.Font = new System.Drawing.Font("Arial", 9F);
            this.deleteCar.ForeColor = System.Drawing.Color.Black;
            this.deleteCar.Location = new System.Drawing.Point(430, 327);
            this.deleteCar.Margin = new System.Windows.Forms.Padding(0);
            this.deleteCar.Name = "deleteCar";
            this.deleteCar.Size = new System.Drawing.Size(116, 30);
            this.deleteCar.TabIndex = 49;
            this.deleteCar.Text = "Удалить";
            this.deleteCar.UseVisualStyleBackColor = false;
            this.deleteCar.Click += new System.EventHandler(this.deleteCar_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 18F);
            this.title.Location = new System.Drawing.Point(221, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(147, 27);
            this.title.TabIndex = 46;
            this.title.Text = "Автомобили";
            // 
            // addCar
            // 
            this.addCar.BackColor = System.Drawing.Color.DodgerBlue;
            this.addCar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.addCar.FlatAppearance.BorderSize = 0;
            this.addCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.addCar.ForeColor = System.Drawing.Color.White;
            this.addCar.Location = new System.Drawing.Point(41, 327);
            this.addCar.Margin = new System.Windows.Forms.Padding(0);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(116, 30);
            this.addCar.TabIndex = 45;
            this.addCar.Text = "Добавить";
            this.addCar.UseVisualStyleBackColor = false;
            this.addCar.Click += new System.EventHandler(this.addCar_Click);
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.carsPage);
            this.adminTab.Controls.Add(this.usersPage);
            this.adminTab.Controls.Add(this.bookingPage);
            this.adminTab.Font = new System.Drawing.Font("Arial", 9F);
            this.adminTab.ItemSize = new System.Drawing.Size(81, 30);
            this.adminTab.Location = new System.Drawing.Point(-1, 0);
            this.adminTab.Name = "adminTab";
            this.adminTab.SelectedIndex = 0;
            this.adminTab.Size = new System.Drawing.Size(586, 411);
            this.adminTab.TabIndex = 50;
            this.adminTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.adminTab_Selected);
            // 
            // usersPage
            // 
            this.usersPage.Controls.Add(this.usersList);
            this.usersPage.Controls.Add(this.changeUser);
            this.usersPage.Controls.Add(this.deleteUser);
            this.usersPage.Controls.Add(this.userTitle);
            this.usersPage.Controls.Add(this.addUser);
            this.usersPage.Location = new System.Drawing.Point(4, 34);
            this.usersPage.Name = "usersPage";
            this.usersPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersPage.Size = new System.Drawing.Size(578, 373);
            this.usersPage.TabIndex = 1;
            this.usersPage.Text = "Пользователи";
            this.usersPage.UseVisualStyleBackColor = true;
            this.usersPage.Click += new System.EventHandler(this.usersPage_Click);
            // 
            // usersList
            // 
            this.usersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userLogin,
            this.userPassword,
            this.userRole,
            this.user_Name,
            this.user_Surname,
            this.userFine});
            this.usersList.FullRowSelect = true;
            this.usersList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.usersList.Location = new System.Drawing.Point(41, 49);
            this.usersList.MultiSelect = false;
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(505, 269);
            this.usersList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.usersList.TabIndex = 53;
            this.usersList.UseCompatibleStateImageBehavior = false;
            this.usersList.View = System.Windows.Forms.View.Details;
            this.usersList.Click += new System.EventHandler(this.usersList_Click);
            // 
            // userLogin
            // 
            this.userLogin.Text = "Логин";
            this.userLogin.Width = 70;
            // 
            // userPassword
            // 
            this.userPassword.Text = "Пароль";
            this.userPassword.Width = 70;
            // 
            // userRole
            // 
            this.userRole.Text = "Роль";
            this.userRole.Width = 70;
            // 
            // user_Name
            // 
            this.user_Name.Text = "Имя";
            this.user_Name.Width = 100;
            // 
            // user_Surname
            // 
            this.user_Surname.Text = "Фамилия";
            this.user_Surname.Width = 120;
            // 
            // userFine
            // 
            this.userFine.Text = "Штраф";
            this.userFine.Width = 73;
            // 
            // changeUser
            // 
            this.changeUser.BackColor = System.Drawing.SystemColors.Control;
            this.changeUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUser.Font = new System.Drawing.Font("Arial", 9F);
            this.changeUser.ForeColor = System.Drawing.Color.Black;
            this.changeUser.Location = new System.Drawing.Point(235, 329);
            this.changeUser.Margin = new System.Windows.Forms.Padding(0);
            this.changeUser.Name = "changeUser";
            this.changeUser.Size = new System.Drawing.Size(116, 30);
            this.changeUser.TabIndex = 55;
            this.changeUser.Text = "Изменить";
            this.changeUser.UseVisualStyleBackColor = false;
            this.changeUser.Click += new System.EventHandler(this.changeUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.SystemColors.Control;
            this.deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Font = new System.Drawing.Font("Arial", 9F);
            this.deleteUser.ForeColor = System.Drawing.Color.Black;
            this.deleteUser.Location = new System.Drawing.Point(430, 329);
            this.deleteUser.Margin = new System.Windows.Forms.Padding(0);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(116, 30);
            this.deleteUser.TabIndex = 54;
            this.deleteUser.Text = "Удалить";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // userTitle
            // 
            this.userTitle.AutoSize = true;
            this.userTitle.Font = new System.Drawing.Font("Arial", 18F);
            this.userTitle.Location = new System.Drawing.Point(210, 11);
            this.userTitle.Name = "userTitle";
            this.userTitle.Size = new System.Drawing.Size(167, 27);
            this.userTitle.TabIndex = 52;
            this.userTitle.Text = "Пользователи";
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.addUser.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.addUser.ForeColor = System.Drawing.Color.White;
            this.addUser.Location = new System.Drawing.Point(41, 329);
            this.addUser.Margin = new System.Windows.Forms.Padding(0);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(116, 30);
            this.addUser.TabIndex = 51;
            this.addUser.Text = "Добавить";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // bookingPage
            // 
            this.bookingPage.Controls.Add(this.listBooking);
            this.bookingPage.Controls.Add(this.deleteBooking);
            this.bookingPage.Controls.Add(this.bookingTitle);
            this.bookingPage.Location = new System.Drawing.Point(4, 34);
            this.bookingPage.Name = "bookingPage";
            this.bookingPage.Padding = new System.Windows.Forms.Padding(3);
            this.bookingPage.Size = new System.Drawing.Size(578, 373);
            this.bookingPage.TabIndex = 2;
            this.bookingPage.Text = "Бронирование";
            this.bookingPage.UseVisualStyleBackColor = true;
            // 
            // listBooking
            // 
            this.listBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookingId,
            this.user_Login,
            this.car_Id,
            this.bookingDateStart,
            this.bookingDateEnd,
            this.bookingCost,
            this.bookingPaid,
            this.bookingStatus});
            this.listBooking.FullRowSelect = true;
            this.listBooking.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBooking.Location = new System.Drawing.Point(33, 49);
            this.listBooking.MultiSelect = false;
            this.listBooking.Name = "listBooking";
            this.listBooking.Size = new System.Drawing.Size(521, 269);
            this.listBooking.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listBooking.TabIndex = 58;
            this.listBooking.UseCompatibleStateImageBehavior = false;
            this.listBooking.View = System.Windows.Forms.View.Details;
            this.listBooking.Click += new System.EventHandler(this.listBooking_Click);
            // 
            // bookingId
            // 
            this.bookingId.Text = "#";
            this.bookingId.Width = 30;
            // 
            // user_Login
            // 
            this.user_Login.Text = "Клиент";
            this.user_Login.Width = 70;
            // 
            // car_Id
            // 
            this.car_Id.Text = "Id авто";
            this.car_Id.Width = 50;
            // 
            // bookingDateStart
            // 
            this.bookingDateStart.Text = "Дата1";
            this.bookingDateStart.Width = 75;
            // 
            // bookingDateEnd
            // 
            this.bookingDateEnd.Text = "Дата2";
            this.bookingDateEnd.Width = 75;
            // 
            // bookingCost
            // 
            this.bookingCost.Text = "Стоимость";
            this.bookingCost.Width = 75;
            // 
            // bookingPaid
            // 
            this.bookingPaid.Text = "Оплачено";
            this.bookingPaid.Width = 75;
            // 
            // bookingStatus
            // 
            this.bookingStatus.Text = "Отменено";
            this.bookingStatus.Width = 70;
            // 
            // deleteBooking
            // 
            this.deleteBooking.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBooking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBooking.Font = new System.Drawing.Font("Arial", 9F);
            this.deleteBooking.ForeColor = System.Drawing.Color.Black;
            this.deleteBooking.Location = new System.Drawing.Point(438, 329);
            this.deleteBooking.Margin = new System.Windows.Forms.Padding(0);
            this.deleteBooking.Name = "deleteBooking";
            this.deleteBooking.Size = new System.Drawing.Size(116, 30);
            this.deleteBooking.TabIndex = 59;
            this.deleteBooking.Text = "Удалить";
            this.deleteBooking.UseVisualStyleBackColor = false;
            this.deleteBooking.Click += new System.EventHandler(this.deleteBooking_Click);
            // 
            // bookingTitle
            // 
            this.bookingTitle.AutoSize = true;
            this.bookingTitle.Font = new System.Drawing.Font("Arial", 18F);
            this.bookingTitle.Location = new System.Drawing.Point(158, 11);
            this.bookingTitle.Name = "bookingTitle";
            this.bookingTitle.Size = new System.Drawing.Size(271, 27);
            this.bookingTitle.TabIndex = 57;
            this.bookingTitle.Text = "История бронирований";
            // 
            // backToUser
            // 
            this.backToUser.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.backToUser.AutoSize = true;
            this.backToUser.Font = new System.Drawing.Font("Arial", 9F);
            this.backToUser.LinkColor = System.Drawing.Color.Gray;
            this.backToUser.Location = new System.Drawing.Point(427, 10);
            this.backToUser.Name = "backToUser";
            this.backToUser.Size = new System.Drawing.Size(145, 15);
            this.backToUser.TabIndex = 51;
            this.backToUser.TabStop = true;
            this.backToUser.Text = "Зайти как пользователь";
            this.backToUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backToUser_LinkClicked);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.backToUser);
            this.Controls.Add(this.adminTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Административная панель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.carsPage.ResumeLayout(false);
            this.carsPage.PerformLayout();
            this.adminTab.ResumeLayout(false);
            this.usersPage.ResumeLayout(false);
            this.usersPage.PerformLayout();
            this.bookingPage.ResumeLayout(false);
            this.bookingPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage carsPage;
        private System.Windows.Forms.ListView listCars;
        private System.Windows.Forms.Button changeCar;
        private System.Windows.Forms.Button deleteCar;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addCar;
        private System.Windows.Forms.TabControl adminTab;
        private System.Windows.Forms.LinkLabel backToUser;
        private System.Windows.Forms.TabPage usersPage;
        private System.Windows.Forms.TabPage bookingPage;
        private System.Windows.Forms.ListView usersList;
        private System.Windows.Forms.ColumnHeader userLogin;
        private System.Windows.Forms.ColumnHeader userPassword;
        private System.Windows.Forms.ColumnHeader userRole;
        private System.Windows.Forms.ColumnHeader user_Name;
        private System.Windows.Forms.ColumnHeader user_Surname;
        private System.Windows.Forms.ColumnHeader userFine;
        private System.Windows.Forms.Button changeUser;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Label userTitle;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.ListView listBooking;
        private System.Windows.Forms.ColumnHeader bookingId;
        private System.Windows.Forms.ColumnHeader user_Login;
        private System.Windows.Forms.ColumnHeader car_Id;
        private System.Windows.Forms.ColumnHeader bookingDateStart;
        private System.Windows.Forms.ColumnHeader bookingDateEnd;
        private System.Windows.Forms.ColumnHeader bookingCost;
        private System.Windows.Forms.Button deleteBooking;
        private System.Windows.Forms.Label bookingTitle;
        private System.Windows.Forms.ColumnHeader bookingPaid;
        private System.Windows.Forms.ColumnHeader bookingStatus;
    }
}