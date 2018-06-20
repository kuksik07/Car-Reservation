namespace Lab3_main
{
    partial class carBooking
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userName_label = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateStart_label = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateEnd_label = new System.Windows.Forms.Label();
            this.carName_label = new System.Windows.Forms.Label();
            this.Volume_fuel_label = new System.Windows.Forms.Label();
            this.transmission_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.wellcome_label = new System.Windows.Forms.Label();
            this.book_It = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(195, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(210, 18);
            this.title.TabIndex = 0;
            this.title.Text = "Бронирование автомобиля";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName_label.Location = new System.Drawing.Point(121, 5);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(39, 15);
            this.userName_label.TabIndex = 2;
            this.userName_label.Text = "name\r\n";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerStart.Location = new System.Drawing.Point(147, 41);
            this.dateTimePickerStart.MinimumSize = new System.Drawing.Size(4, 25);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(119, 25);
            this.dateTimePickerStart.TabIndex = 6;
            this.dateTimePickerStart.Value = new System.DateTime(2018, 5, 29, 0, 0, 0, 0);
            // 
            // dateStart_label
            // 
            this.dateStart_label.AutoSize = true;
            this.dateStart_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStart_label.Location = new System.Drawing.Point(150, 15);
            this.dateStart_label.Name = "dateStart_label";
            this.dateStart_label.Size = new System.Drawing.Size(112, 16);
            this.dateStart_label.TabIndex = 7;
            this.dateStart_label.Text = "Начало аренды";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(323, 41);
            this.dateTimePickerEnd.MinimumSize = new System.Drawing.Size(4, 25);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(119, 25);
            this.dateTimePickerEnd.TabIndex = 8;
            this.dateTimePickerEnd.Value = new System.DateTime(2018, 5, 29, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dateEnd_label);
            this.panel1.Controls.Add(this.dateTimePickerStart);
            this.panel1.Controls.Add(this.dateTimePickerEnd);
            this.panel1.Controls.Add(this.dateStart_label);
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 87);
            this.panel1.TabIndex = 10;
            // 
            // dateEnd_label
            // 
            this.dateEnd_label.AutoSize = true;
            this.dateEnd_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEnd_label.Location = new System.Drawing.Point(314, 15);
            this.dateEnd_label.Name = "dateEnd_label";
            this.dateEnd_label.Size = new System.Drawing.Size(136, 16);
            this.dateEnd_label.TabIndex = 9;
            this.dateEnd_label.Text = "Окончание аренды";
            // 
            // carName_label
            // 
            this.carName_label.AutoSize = true;
            this.carName_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.carName_label.Location = new System.Drawing.Point(353, 90);
            this.carName_label.Name = "carName_label";
            this.carName_label.Size = new System.Drawing.Size(74, 16);
            this.carName_label.TabIndex = 11;
            this.carName_label.Text = "Car name";
            // 
            // Volume_fuel_label
            // 
            this.Volume_fuel_label.AutoSize = true;
            this.Volume_fuel_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Volume_fuel_label.Location = new System.Drawing.Point(353, 116);
            this.Volume_fuel_label.Name = "Volume_fuel_label";
            this.Volume_fuel_label.Size = new System.Drawing.Size(82, 16);
            this.Volume_fuel_label.TabIndex = 12;
            this.Volume_fuel_label.Text = "volume / fuel";
            // 
            // transmission_label
            // 
            this.transmission_label.AutoSize = true;
            this.transmission_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transmission_label.Location = new System.Drawing.Point(353, 142);
            this.transmission_label.Name = "transmission_label";
            this.transmission_label.Size = new System.Drawing.Size(82, 16);
            this.transmission_label.TabIndex = 13;
            this.transmission_label.Text = "transmission";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.price_label.ForeColor = System.Drawing.Color.DarkGreen;
            this.price_label.Location = new System.Drawing.Point(353, 204);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(40, 16);
            this.price_label.TabIndex = 14;
            this.price_label.Text = "price";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wellcome_label
            // 
            this.wellcome_label.AutoSize = true;
            this.wellcome_label.Font = new System.Drawing.Font("Arial", 9F);
            this.wellcome_label.Location = new System.Drawing.Point(4, 5);
            this.wellcome_label.MaximumSize = new System.Drawing.Size(0, 20);
            this.wellcome_label.Name = "wellcome_label";
            this.wellcome_label.Size = new System.Drawing.Size(118, 15);
            this.wellcome_label.TabIndex = 17;
            this.wellcome_label.Text = "Добро пожаловать,";
            // 
            // book_It
            // 
            this.book_It.BackColor = System.Drawing.Color.DodgerBlue;
            this.book_It.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.book_It.FlatAppearance.BorderSize = 0;
            this.book_It.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_It.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.book_It.ForeColor = System.Drawing.Color.White;
            this.book_It.Location = new System.Drawing.Point(230, 358);
            this.book_It.Margin = new System.Windows.Forms.Padding(0);
            this.book_It.Name = "book_It";
            this.book_It.Size = new System.Drawing.Size(141, 30);
            this.book_It.TabIndex = 18;
            this.book_It.Text = "Забронировать";
            this.book_It.UseVisualStyleBackColor = false;
            this.book_It.Click += new System.EventHandler(this.book_it_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::Lab3_main.Properties.Resources.arrow_left;
            this.button2.Location = new System.Drawing.Point(16, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNext.Image = global::Lab3_main.Properties.Resources.arrow_r1;
            this.buttonNext.Location = new System.Drawing.Point(517, 131);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(55, 55);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button_next_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(125, 90);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 130);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // carBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.book_It);
            this.Controls.Add(this.wellcome_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.transmission_label);
            this.Controls.Add(this.Volume_fuel_label);
            this.Controls.Add(this.carName_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "carBooking";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бронирование автомобиля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.carBooking_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        public System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label dateStart_label;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label carName_label;
        private System.Windows.Forms.Label Volume_fuel_label;
        private System.Windows.Forms.Label transmission_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label dateEnd_label;
        public System.Windows.Forms.Label wellcome_label;
        private System.Windows.Forms.Button book_It;
    }
}

