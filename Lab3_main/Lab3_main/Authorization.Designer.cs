namespace Lab3_main
{
    partial class Authorization
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
            this.SignIn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.title = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SignIn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.Location = new System.Drawing.Point(200, 274);
            this.SignIn.Margin = new System.Windows.Forms.Padding(0);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(200, 30);
            this.SignIn.TabIndex = 2;
            this.SignIn.Text = "Войти";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoLabel.Location = new System.Drawing.Point(200, 242);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(142, 15);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "Информационное поле";
            this.infoLabel.Visible = false;
            // 
            // userName_textBox
            // 
            this.userName_textBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.userName_textBox.Location = new System.Drawing.Point(200, 130);
            this.userName_textBox.MaximumSize = new System.Drawing.Size(4, 25);
            this.userName_textBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(200, 30);
            this.userName_textBox.TabIndex = 4;
            this.userName_textBox.Enter += new System.EventHandler(this.userName_Enter);
            this.userName_textBox.Leave += new System.EventHandler(this.userName_Leave);
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textBox.Location = new System.Drawing.Point(200, 192);
            this.password_textBox.MaximumSize = new System.Drawing.Size(4, 25);
            this.password_textBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(200, 30);
            this.password_textBox.TabIndex = 5;
            this.password_textBox.Enter += new System.EventHandler(this.Password_Enter);
            this.password_textBox.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // linkRegister
            // 
            this.linkRegister.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Arial", 9F);
            this.linkRegister.LinkColor = System.Drawing.Color.Gray;
            this.linkRegister.Location = new System.Drawing.Point(256, 320);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(88, 15);
            this.linkRegister.TabIndex = 6;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Нет аккаунта?";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 24F);
            this.title.Location = new System.Drawing.Point(258, 45);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(85, 36);
            this.title.TabIndex = 7;
            this.title.Text = "Вход";
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.Transparent;
            this.show.BackgroundImage = global::Lab3_main.Properties.Resources.eye;
            this.show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show.FlatAppearance.BorderSize = 0;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.Location = new System.Drawing.Point(366, 193);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(33, 28);
            this.show.TabIndex = 26;
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.show);
            this.Controls.Add(this.title);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.userName_textBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.SignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authorization";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Label infoLabel;
        public System.Windows.Forms.TextBox userName_textBox;
        public System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button show;
    }
}