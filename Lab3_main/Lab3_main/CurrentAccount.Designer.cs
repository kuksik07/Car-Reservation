namespace Lab3_main
{
    partial class CurrentAccount
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSur = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btnReservation = new System.Windows.Forms.Button();
            this.userName_Value = new System.Windows.Forms.Label();
            this.surName_Value = new System.Windows.Forms.Label();
            this.name_Value = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FinePay = new System.Windows.Forms.Button();
            this.fine_Value = new System.Windows.Forms.Label();
            this.fine_Label = new System.Windows.Forms.Label();
            this.bookingList = new System.Windows.Forms.ListView();
            this.bookingId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.car_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookingDate1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookingDate2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookingCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isClosed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title_History = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial", 9F);
            this.labelLogin.Location = new System.Drawing.Point(32, 19);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 15);
            this.labelLogin.TabIndex = 37;
            this.labelLogin.Text = "Логин";
            // 
            // labelSur
            // 
            this.labelSur.AutoSize = true;
            this.labelSur.Font = new System.Drawing.Font("Arial", 9F);
            this.labelSur.Location = new System.Drawing.Point(32, 71);
            this.labelSur.Name = "labelSur";
            this.labelSur.Size = new System.Drawing.Size(60, 15);
            this.labelSur.TabIndex = 34;
            this.labelSur.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9F);
            this.labelName.Location = new System.Drawing.Point(32, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 15);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Имя";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 18F);
            this.title.Location = new System.Drawing.Point(219, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(152, 27);
            this.title.TabIndex = 31;
            this.title.Text = "Ваш аккаунт";
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReservation.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Location = new System.Drawing.Point(35, 367);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(200, 30);
            this.btnReservation.TabIndex = 27;
            this.btnReservation.Text = "К бронированию";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // userName_Value
            // 
            this.userName_Value.AutoSize = true;
            this.userName_Value.Font = new System.Drawing.Font("Arial", 9F);
            this.userName_Value.Location = new System.Drawing.Point(135, 19);
            this.userName_Value.Name = "userName_Value";
            this.userName_Value.Size = new System.Drawing.Size(62, 15);
            this.userName_Value.TabIndex = 40;
            this.userName_Value.Text = "Значение";
            // 
            // surName_Value
            // 
            this.surName_Value.AutoSize = true;
            this.surName_Value.Font = new System.Drawing.Font("Arial", 9F);
            this.surName_Value.Location = new System.Drawing.Point(135, 71);
            this.surName_Value.Name = "surName_Value";
            this.surName_Value.Size = new System.Drawing.Size(62, 15);
            this.surName_Value.TabIndex = 39;
            this.surName_Value.Text = "Значение";
            // 
            // name_Value
            // 
            this.name_Value.AutoSize = true;
            this.name_Value.Font = new System.Drawing.Font("Arial", 9F);
            this.name_Value.Location = new System.Drawing.Point(135, 45);
            this.name_Value.Name = "name_Value";
            this.name_Value.Size = new System.Drawing.Size(62, 15);
            this.name_Value.TabIndex = 38;
            this.name_Value.Text = "Значение";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.FinePay);
            this.panel1.Controls.Add(this.fine_Value);
            this.panel1.Controls.Add(this.fine_Label);
            this.panel1.Controls.Add(this.surName_Value);
            this.panel1.Controls.Add(this.userName_Value);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelSur);
            this.panel1.Controls.Add(this.name_Value);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Location = new System.Drawing.Point(35, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 127);
            this.panel1.TabIndex = 41;
            // 
            // FinePay
            // 
            this.FinePay.BackColor = System.Drawing.SystemColors.Control;
            this.FinePay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinePay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FinePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinePay.Font = new System.Drawing.Font("Arial", 9F);
            this.FinePay.ForeColor = System.Drawing.Color.Black;
            this.FinePay.Location = new System.Drawing.Point(414, 89);
            this.FinePay.Margin = new System.Windows.Forms.Padding(0);
            this.FinePay.Name = "FinePay";
            this.FinePay.Size = new System.Drawing.Size(116, 30);
            this.FinePay.TabIndex = 45;
            this.FinePay.Text = "Оплатить штраф";
            this.FinePay.UseVisualStyleBackColor = false;
            this.FinePay.Click += new System.EventHandler(this.FinePay_Click);
            // 
            // fine_Value
            // 
            this.fine_Value.AutoSize = true;
            this.fine_Value.Font = new System.Drawing.Font("Arial", 9F);
            this.fine_Value.ForeColor = System.Drawing.Color.Red;
            this.fine_Value.Location = new System.Drawing.Point(135, 97);
            this.fine_Value.Name = "fine_Value";
            this.fine_Value.Size = new System.Drawing.Size(62, 15);
            this.fine_Value.TabIndex = 42;
            this.fine_Value.Text = "Значение";
            // 
            // fine_Label
            // 
            this.fine_Label.AutoSize = true;
            this.fine_Label.Font = new System.Drawing.Font("Arial", 9F);
            this.fine_Label.Location = new System.Drawing.Point(32, 97);
            this.fine_Label.Name = "fine_Label";
            this.fine_Label.Size = new System.Drawing.Size(46, 15);
            this.fine_Label.TabIndex = 41;
            this.fine_Label.Text = "Штраф";
            // 
            // bookingList
            // 
            this.bookingList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookingId,
            this.car_Name,
            this.bookingDate1,
            this.bookingDate2,
            this.bookingCost,
            this.isClosed});
            this.bookingList.FullRowSelect = true;
            this.bookingList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.bookingList.Location = new System.Drawing.Point(35, 240);
            this.bookingList.MultiSelect = false;
            this.bookingList.Name = "bookingList";
            this.bookingList.Size = new System.Drawing.Size(530, 113);
            this.bookingList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.bookingList.TabIndex = 43;
            this.bookingList.UseCompatibleStateImageBehavior = false;
            this.bookingList.View = System.Windows.Forms.View.Details;
            this.bookingList.DoubleClick += new System.EventHandler(this.bookingList_DoubleClick);
            // 
            // bookingId
            // 
            this.bookingId.Text = "#";
            this.bookingId.Width = 0;
            // 
            // car_Name
            // 
            this.car_Name.Text = "Автомобиль";
            this.car_Name.Width = 190;
            // 
            // bookingDate1
            // 
            this.bookingDate1.Text = "Дата начала";
            this.bookingDate1.Width = 90;
            // 
            // bookingDate2
            // 
            this.bookingDate2.Text = "Дата окончания";
            this.bookingDate2.Width = 100;
            // 
            // bookingCost
            // 
            this.bookingCost.DisplayIndex = 5;
            this.bookingCost.Text = "Стоимость";
            this.bookingCost.Width = 80;
            // 
            // isClosed
            // 
            this.isClosed.DisplayIndex = 4;
            this.isClosed.Text = "Отменена";
            this.isClosed.Width = 70;
            // 
            // title_History
            // 
            this.title_History.AutoSize = true;
            this.title_History.Font = new System.Drawing.Font("Arial", 12F);
            this.title_History.ForeColor = System.Drawing.SystemColors.WindowText;
            this.title_History.Location = new System.Drawing.Point(207, 208);
            this.title_History.Name = "title_History";
            this.title_History.Size = new System.Drawing.Size(177, 18);
            this.title_History.TabIndex = 44;
            this.title_History.Text = "История бронирований";
            // 
            // CurrentAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.title_History);
            this.Controls.Add(this.bookingList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnReservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CurrentAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аккаунт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurrentAccount_FormClosing);
            this.Load += new System.EventHandler(this.CurrentAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSur;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnReservation;
        public System.Windows.Forms.Label userName_Value;
        private System.Windows.Forms.Label surName_Value;
        private System.Windows.Forms.Label name_Value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fine_Value;
        private System.Windows.Forms.Label fine_Label;
        private System.Windows.Forms.ListView bookingList;
        private System.Windows.Forms.Label title_History;
        private System.Windows.Forms.Button FinePay;
        private System.Windows.Forms.ColumnHeader bookingId;
        private System.Windows.Forms.ColumnHeader car_Name;
        private System.Windows.Forms.ColumnHeader bookingDate1;
        private System.Windows.Forms.ColumnHeader bookingDate2;
        private System.Windows.Forms.ColumnHeader bookingCost;
        private System.Windows.Forms.ColumnHeader isClosed;
    }
}