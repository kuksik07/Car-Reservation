namespace Lab3_main
{
    partial class Register
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
            this.title = new System.Windows.Forms.Label();
            this.textBoxSurn = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.textBoxPwrd = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSur = new System.Windows.Forms.Label();
            this.labelPwrd = new System.Windows.Forms.Label();
            this.labelPwrd2 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxConfPwrd = new System.Windows.Forms.TextBox();
            this.show1 = new System.Windows.Forms.Button();
            this.show2 = new System.Windows.Forms.Button();
            this.labelErrLog = new System.Windows.Forms.Label();
            this.userRole = new System.Windows.Forms.ComboBox();
            this.labelFine = new System.Windows.Forms.Label();
            this.userFine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 24F);
            this.title.Location = new System.Drawing.Point(200, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 36);
            this.title.TabIndex = 13;
            this.title.Text = "Регистрация";
            // 
            // textBoxSurn
            // 
            this.textBoxSurn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurn.Location = new System.Drawing.Point(46, 235);
            this.textBoxSurn.MaximumSize = new System.Drawing.Size(4, 25);
            this.textBoxSurn.MinimumSize = new System.Drawing.Size(200, 30);
            this.textBoxSurn.Name = "textBoxSurn";
            this.textBoxSurn.Size = new System.Drawing.Size(200, 30);
            this.textBoxSurn.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textBoxName.Location = new System.Drawing.Point(46, 166);
            this.textBoxName.MaximumSize = new System.Drawing.Size(4, 25);
            this.textBoxName.MinimumSize = new System.Drawing.Size(200, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 30);
            this.textBoxName.TabIndex = 10;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.labelInfo.Location = new System.Drawing.Point(229, 342);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(142, 15);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = "Информационное поле";
            this.labelInfo.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(200, 366);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 30);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Зарегистрировать";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // textBoxPwrd
            // 
            this.textBoxPwrd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPwrd.Location = new System.Drawing.Point(350, 97);
            this.textBoxPwrd.MaximumSize = new System.Drawing.Size(4, 25);
            this.textBoxPwrd.MinimumSize = new System.Drawing.Size(200, 30);
            this.textBoxPwrd.Name = "textBoxPwrd";
            this.textBoxPwrd.PasswordChar = '*';
            this.textBoxPwrd.Size = new System.Drawing.Size(200, 30);
            this.textBoxPwrd.TabIndex = 14;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9F);
            this.labelName.Location = new System.Drawing.Point(43, 139);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 15);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Имя";
            // 
            // labelSur
            // 
            this.labelSur.AutoSize = true;
            this.labelSur.Font = new System.Drawing.Font("Arial", 9F);
            this.labelSur.Location = new System.Drawing.Point(43, 208);
            this.labelSur.Name = "labelSur";
            this.labelSur.Size = new System.Drawing.Size(60, 15);
            this.labelSur.TabIndex = 16;
            this.labelSur.Text = "Фамилия";
            // 
            // labelPwrd
            // 
            this.labelPwrd.AutoSize = true;
            this.labelPwrd.Font = new System.Drawing.Font("Arial", 9F);
            this.labelPwrd.Location = new System.Drawing.Point(347, 70);
            this.labelPwrd.Name = "labelPwrd";
            this.labelPwrd.Size = new System.Drawing.Size(51, 15);
            this.labelPwrd.TabIndex = 17;
            this.labelPwrd.Text = "Пароль";
            // 
            // labelPwrd2
            // 
            this.labelPwrd2.AutoSize = true;
            this.labelPwrd2.Font = new System.Drawing.Font("Arial", 9F);
            this.labelPwrd2.Location = new System.Drawing.Point(347, 139);
            this.labelPwrd2.Name = "labelPwrd2";
            this.labelPwrd2.Size = new System.Drawing.Size(112, 15);
            this.labelPwrd2.TabIndex = 18;
            this.labelPwrd2.Text = "Повторить пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial", 9F);
            this.labelLogin.Location = new System.Drawing.Point(43, 70);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 15);
            this.labelLogin.TabIndex = 19;
            this.labelLogin.Text = "Логин";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Arial", 9F);
            this.labelRole.Location = new System.Drawing.Point(347, 208);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(35, 15);
            this.labelRole.TabIndex = 20;
            this.labelRole.Text = "Роль";
            this.labelRole.Visible = false;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(46, 97);
            this.textBoxLogin.MaximumSize = new System.Drawing.Size(4, 25);
            this.textBoxLogin.MinimumSize = new System.Drawing.Size(200, 30);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(200, 30);
            this.textBoxLogin.TabIndex = 21;
            // 
            // textBoxConfPwrd
            // 
            this.textBoxConfPwrd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConfPwrd.Location = new System.Drawing.Point(350, 166);
            this.textBoxConfPwrd.MaximumSize = new System.Drawing.Size(4, 25);
            this.textBoxConfPwrd.MinimumSize = new System.Drawing.Size(200, 30);
            this.textBoxConfPwrd.Name = "textBoxConfPwrd";
            this.textBoxConfPwrd.PasswordChar = '*';
            this.textBoxConfPwrd.Size = new System.Drawing.Size(200, 30);
            this.textBoxConfPwrd.TabIndex = 22;
            // 
            // show1
            // 
            this.show1.BackColor = System.Drawing.Color.Transparent;
            this.show1.BackgroundImage = global::Lab3_main.Properties.Resources.eye;
            this.show1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show1.FlatAppearance.BorderSize = 0;
            this.show1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show1.Location = new System.Drawing.Point(516, 98);
            this.show1.Name = "show1";
            this.show1.Size = new System.Drawing.Size(33, 28);
            this.show1.TabIndex = 24;
            this.show1.UseVisualStyleBackColor = false;
            this.show1.Click += new System.EventHandler(this.show1_Click);
            // 
            // show2
            // 
            this.show2.BackColor = System.Drawing.Color.Transparent;
            this.show2.BackgroundImage = global::Lab3_main.Properties.Resources.eye;
            this.show2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show2.FlatAppearance.BorderSize = 0;
            this.show2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show2.Location = new System.Drawing.Point(515, 167);
            this.show2.Name = "show2";
            this.show2.Size = new System.Drawing.Size(33, 28);
            this.show2.TabIndex = 25;
            this.show2.UseVisualStyleBackColor = false;
            this.show2.Click += new System.EventHandler(this.show2_Click);
            // 
            // labelErrLog
            // 
            this.labelErrLog.AutoSize = true;
            this.labelErrLog.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrLog.ForeColor = System.Drawing.Color.Red;
            this.labelErrLog.Location = new System.Drawing.Point(142, 70);
            this.labelErrLog.Name = "labelErrLog";
            this.labelErrLog.Size = new System.Drawing.Size(104, 15);
            this.labelErrLog.TabIndex = 26;
            this.labelErrLog.Text = "Логин уже занят!";
            this.labelErrLog.Visible = false;
            // 
            // userRole
            // 
            this.userRole.Font = new System.Drawing.Font("Arial", 9F);
            this.userRole.FormattingEnabled = true;
            this.userRole.ItemHeight = 15;
            this.userRole.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.userRole.Location = new System.Drawing.Point(350, 236);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(200, 23);
            this.userRole.TabIndex = 43;
            this.userRole.Text = "user";
            this.userRole.Visible = false;
            // 
            // labelFine
            // 
            this.labelFine.AutoSize = true;
            this.labelFine.Font = new System.Drawing.Font("Arial", 9F);
            this.labelFine.Location = new System.Drawing.Point(43, 281);
            this.labelFine.Name = "labelFine";
            this.labelFine.Size = new System.Drawing.Size(46, 15);
            this.labelFine.TabIndex = 44;
            this.labelFine.Text = "Штраф";
            this.labelFine.Visible = false;
            // 
            // userFine
            // 
            this.userFine.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFine.Location = new System.Drawing.Point(46, 303);
            this.userFine.MaximumSize = new System.Drawing.Size(4, 25);
            this.userFine.MinimumSize = new System.Drawing.Size(200, 30);
            this.userFine.Name = "userFine";
            this.userFine.Size = new System.Drawing.Size(200, 30);
            this.userFine.TabIndex = 45;
            this.userFine.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.userFine);
            this.Controls.Add(this.labelFine);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.labelErrLog);
            this.Controls.Add(this.show2);
            this.Controls.Add(this.show1);
            this.Controls.Add(this.textBoxConfPwrd);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPwrd2);
            this.Controls.Add(this.labelPwrd);
            this.Controls.Add(this.labelSur);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPwrd);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBoxSurn);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBoxSurn;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelInfo;
        public System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.TextBox textBoxPwrd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSur;
        private System.Windows.Forms.Label labelPwrd;
        private System.Windows.Forms.Label labelPwrd2;
        private System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.Label labelRole;
        public System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxConfPwrd;
        private System.Windows.Forms.Button show1;
        private System.Windows.Forms.Button show2;
        private System.Windows.Forms.Label labelErrLog;
        public System.Windows.Forms.ComboBox userRole;
        public System.Windows.Forms.Label labelFine;
        public System.Windows.Forms.TextBox userFine;
    }
}