namespace Lab3_main
{
    partial class PayDialog
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ConfirmPay = new System.Windows.Forms.Button();
            this.toPay_label = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.inputOfMoney = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inputOfMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.DodgerBlue;
            this.OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(25, 200);
            this.OK.Margin = new System.Windows.Forms.Padding(0);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(96, 30);
            this.OK.TabIndex = 28;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(179, 200);
            this.Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(96, 30);
            this.Cancel.TabIndex = 29;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ConfirmPay
            // 
            this.ConfirmPay.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmPay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ConfirmPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmPay.Font = new System.Drawing.Font("Arial", 9F);
            this.ConfirmPay.ForeColor = System.Drawing.Color.Black;
            this.ConfirmPay.Location = new System.Drawing.Point(75, 123);
            this.ConfirmPay.Margin = new System.Windows.Forms.Padding(0);
            this.ConfirmPay.Name = "ConfirmPay";
            this.ConfirmPay.Size = new System.Drawing.Size(150, 30);
            this.ConfirmPay.TabIndex = 31;
            this.ConfirmPay.Text = "Провести платёж";
            this.ConfirmPay.UseVisualStyleBackColor = false;
            this.ConfirmPay.Click += new System.EventHandler(this.ConfirmPay_Click);
            // 
            // toPay_label
            // 
            this.toPay_label.AutoSize = true;
            this.toPay_label.Font = new System.Drawing.Font("Arial", 9F);
            this.toPay_label.Location = new System.Drawing.Point(28, 22);
            this.toPay_label.Name = "toPay_label";
            this.toPay_label.Size = new System.Drawing.Size(143, 15);
            this.toPay_label.TabIndex = 32;
            this.toPay_label.Text = "Необходимо заплатить:";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.Location = new System.Drawing.Point(198, 22);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(32, 15);
            this.cost.TabIndex = 33;
            this.cost.Text = "cost";
            // 
            // inputOfMoney
            // 
            this.inputOfMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputOfMoney.Font = new System.Drawing.Font("Arial", 9F);
            this.inputOfMoney.Location = new System.Drawing.Point(75, 90);
            this.inputOfMoney.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.inputOfMoney.Name = "inputOfMoney";
            this.inputOfMoney.Size = new System.Drawing.Size(150, 21);
            this.inputOfMoney.TabIndex = 30;
            // 
            // PayDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.toPay_label);
            this.Controls.Add(this.ConfirmPay);
            this.Controls.Add(this.inputOfMoney);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PayDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оплата";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PayDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.inputOfMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button ConfirmPay;
        private System.Windows.Forms.Label toPay_label;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.NumericUpDown inputOfMoney;
    }
}