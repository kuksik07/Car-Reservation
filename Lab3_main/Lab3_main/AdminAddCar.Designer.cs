namespace Lab3_main
{
    partial class AdminAddCar
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
            this.carName = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelTransmission = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.carTitle = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.carTransmission = new System.Windows.Forms.ComboBox();
            this.carVolume = new System.Windows.Forms.NumericUpDown();
            this.carFuel = new System.Windows.Forms.ComboBox();
            this.carImagePath = new System.Windows.Forms.TextBox();
            this.carPrice = new System.Windows.Forms.TextBox();
            this.browseImage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.carVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // carName
            // 
            this.carName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carName.Location = new System.Drawing.Point(42, 124);
            this.carName.MaximumSize = new System.Drawing.Size(4, 25);
            this.carName.MinimumSize = new System.Drawing.Size(200, 20);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(200, 22);
            this.carName.TabIndex = 39;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Arial", 9F);
            this.labelImage.Location = new System.Drawing.Point(343, 235);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(87, 15);
            this.labelImage.TabIndex = 38;
            this.labelImage.Text = "Изображение";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9F);
            this.labelName.Location = new System.Drawing.Point(39, 97);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(135, 15);
            this.labelName.TabIndex = 37;
            this.labelName.Text = "Название автомобиля";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arial", 9F);
            this.labelPrice.Location = new System.Drawing.Point(343, 166);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(37, 15);
            this.labelPrice.TabIndex = 36;
            this.labelPrice.Text = "Цена";
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("Arial", 9F);
            this.labelFuel.Location = new System.Drawing.Point(343, 97);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(54, 15);
            this.labelFuel.TabIndex = 35;
            this.labelFuel.Text = "Топливо";
            // 
            // labelTransmission
            // 
            this.labelTransmission.AutoSize = true;
            this.labelTransmission.Font = new System.Drawing.Font("Arial", 9F);
            this.labelTransmission.Location = new System.Drawing.Point(39, 235);
            this.labelTransmission.Name = "labelTransmission";
            this.labelTransmission.Size = new System.Drawing.Size(32, 15);
            this.labelTransmission.TabIndex = 34;
            this.labelTransmission.Text = "КПП";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Arial", 9F);
            this.labelVolume.Location = new System.Drawing.Point(39, 166);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(107, 15);
            this.labelVolume.TabIndex = 33;
            this.labelVolume.Text = "Объём двигателя";
            // 
            // carTitle
            // 
            this.carTitle.AutoSize = true;
            this.carTitle.Font = new System.Drawing.Font("Arial", 24F);
            this.carTitle.Location = new System.Drawing.Point(196, 26);
            this.carTitle.Name = "carTitle";
            this.carTitle.Size = new System.Drawing.Size(193, 36);
            this.carTitle.TabIndex = 31;
            this.carTitle.Text = "Автомобиль";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DodgerBlue;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(196, 355);
            this.add.Margin = new System.Windows.Forms.Padding(0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(200, 30);
            this.add.TabIndex = 27;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // carTransmission
            // 
            this.carTransmission.Font = new System.Drawing.Font("Arial", 9F);
            this.carTransmission.FormattingEnabled = true;
            this.carTransmission.ItemHeight = 15;
            this.carTransmission.Items.AddRange(new object[] {
            "Механика",
            "Автомат",
            "Вариатор",
            "Робот"});
            this.carTransmission.Location = new System.Drawing.Point(42, 263);
            this.carTransmission.Name = "carTransmission";
            this.carTransmission.Size = new System.Drawing.Size(196, 23);
            this.carTransmission.TabIndex = 42;
            // 
            // carVolume
            // 
            this.carVolume.DecimalPlaces = 1;
            this.carVolume.Font = new System.Drawing.Font("Arial", 9F);
            this.carVolume.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.carVolume.Location = new System.Drawing.Point(42, 195);
            this.carVolume.Name = "carVolume";
            this.carVolume.Size = new System.Drawing.Size(200, 21);
            this.carVolume.TabIndex = 43;
            // 
            // carFuel
            // 
            this.carFuel.Font = new System.Drawing.Font("Arial", 9F);
            this.carFuel.FormattingEnabled = true;
            this.carFuel.ItemHeight = 15;
            this.carFuel.Items.AddRange(new object[] {
            "Бензин",
            "Дизель",
            "Бензин / газ",
            "Газ",
            "Электричество",
            "Гибрид"});
            this.carFuel.Location = new System.Drawing.Point(346, 125);
            this.carFuel.Name = "carFuel";
            this.carFuel.Size = new System.Drawing.Size(196, 23);
            this.carFuel.TabIndex = 44;
            // 
            // carImagePath
            // 
            this.carImagePath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carImagePath.Location = new System.Drawing.Point(346, 262);
            this.carImagePath.Name = "carImagePath";
            this.carImagePath.Size = new System.Drawing.Size(196, 22);
            this.carImagePath.TabIndex = 47;
            // 
            // carPrice
            // 
            this.carPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carPrice.Location = new System.Drawing.Point(346, 193);
            this.carPrice.Name = "carPrice";
            this.carPrice.Size = new System.Drawing.Size(196, 22);
            this.carPrice.TabIndex = 48;
            // 
            // browseImage
            // 
            this.browseImage.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.browseImage.AutoSize = true;
            this.browseImage.Font = new System.Drawing.Font("Arial", 9F);
            this.browseImage.LinkColor = System.Drawing.Color.Gray;
            this.browseImage.Location = new System.Drawing.Point(493, 235);
            this.browseImage.Name = "browseImage";
            this.browseImage.Size = new System.Drawing.Size(49, 15);
            this.browseImage.TabIndex = 52;
            this.browseImage.TabStop = true;
            this.browseImage.Text = "Browse";
            this.browseImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.browseImage_LinkClicked);
            // 
            // AdminAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.browseImage);
            this.Controls.Add(this.carPrice);
            this.Controls.Add(this.carImagePath);
            this.Controls.Add(this.carFuel);
            this.Controls.Add(this.carVolume);
            this.Controls.Add(this.carTransmission);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.labelTransmission);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.carTitle);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminAddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAddCar";
            ((System.ComponentModel.ISupportInitialize)(this.carVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox carName;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelTransmission;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label carTitle;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox carTransmission;
        private System.Windows.Forms.NumericUpDown carVolume;
        private System.Windows.Forms.ComboBox carFuel;
        private System.Windows.Forms.TextBox carImagePath;
        private System.Windows.Forms.TextBox carPrice;
        private System.Windows.Forms.LinkLabel browseImage;
    }
}