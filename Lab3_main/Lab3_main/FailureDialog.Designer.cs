namespace Lab3_main
{
    partial class FailureDialog
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
            this.currDateEnd_value = new System.Windows.Forms.Label();
            this.currentDateEnd_label = new System.Windows.Forms.Label();
            this.CancelBooking = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // currDateEnd_value
            // 
            this.currDateEnd_value.AutoSize = true;
            this.currDateEnd_value.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currDateEnd_value.Location = new System.Drawing.Point(190, 26);
            this.currDateEnd_value.Name = "currDateEnd_value";
            this.currDateEnd_value.Size = new System.Drawing.Size(64, 15);
            this.currDateEnd_value.TabIndex = 39;
            this.currDateEnd_value.Text = "Значение";
            // 
            // currentDateEnd_label
            // 
            this.currentDateEnd_label.AutoSize = true;
            this.currentDateEnd_label.Font = new System.Drawing.Font("Arial", 9F);
            this.currentDateEnd_label.Location = new System.Drawing.Point(20, 26);
            this.currentDateEnd_label.Name = "currentDateEnd_label";
            this.currentDateEnd_label.Size = new System.Drawing.Size(150, 15);
            this.currentDateEnd_label.TabIndex = 38;
            this.currentDateEnd_label.Text = "Текущая дата окончания:";
            // 
            // CancelBooking
            // 
            this.CancelBooking.BackColor = System.Drawing.SystemColors.Control;
            this.CancelBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBooking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBooking.Font = new System.Drawing.Font("Arial", 9F);
            this.CancelBooking.ForeColor = System.Drawing.Color.Black;
            this.CancelBooking.Location = new System.Drawing.Point(67, 127);
            this.CancelBooking.Margin = new System.Windows.Forms.Padding(0);
            this.CancelBooking.Name = "CancelBooking";
            this.CancelBooking.Size = new System.Drawing.Size(150, 30);
            this.CancelBooking.TabIndex = 1;
            this.CancelBooking.Text = "Отменить бронь";
            this.CancelBooking.UseVisualStyleBackColor = false;
            this.CancelBooking.Click += new System.EventHandler(this.CancelBooking_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(67, 93);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(150, 21);
            this.dateTimePickerEnd.TabIndex = 0;
            this.dateTimePickerEnd.Value = new System.DateTime(2018, 5, 29, 0, 0, 0, 0);
            // 
            // FailureDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.currDateEnd_value);
            this.Controls.Add(this.currentDateEnd_label);
            this.Controls.Add(this.CancelBooking);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FailureDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отмена бронирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currDateEnd_value;
        private System.Windows.Forms.Label currentDateEnd_label;
        private System.Windows.Forms.Button CancelBooking;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
    }
}