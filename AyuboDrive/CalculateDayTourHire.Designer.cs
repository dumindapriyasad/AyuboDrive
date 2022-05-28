namespace AyuboDrive
{
    partial class CalculateDayTourHire
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
            this.label1 = new System.Windows.Forms.Label();
            this.pkgTypeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startKMtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endKMtxt = new System.Windows.Forms.TextBox();
            this.baseHireChargeLbl = new System.Windows.Forms.Label();
            this.waitingChargeLbl = new System.Windows.Forms.Label();
            this.extraKMchargeLbl = new System.Windows.Forms.Label();
            this.totalHireValueLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.vehicleNoCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startTimeDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.endTimeDTPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Package Type :";
            // 
            // pkgTypeCombo
            // 
            this.pkgTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pkgTypeCombo.FormattingEnabled = true;
            this.pkgTypeCombo.Location = new System.Drawing.Point(184, 74);
            this.pkgTypeCombo.Name = "pkgTypeCombo";
            this.pkgTypeCombo.Size = new System.Drawing.Size(126, 21);
            this.pkgTypeCombo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start KM Reading :";
            // 
            // startKMtxt
            // 
            this.startKMtxt.Location = new System.Drawing.Point(184, 180);
            this.startKMtxt.Name = "startKMtxt";
            this.startKMtxt.Size = new System.Drawing.Size(126, 20);
            this.startKMtxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "End KM Reading :";
            // 
            // endKMtxt
            // 
            this.endKMtxt.Location = new System.Drawing.Point(184, 215);
            this.endKMtxt.Name = "endKMtxt";
            this.endKMtxt.Size = new System.Drawing.Size(126, 20);
            this.endKMtxt.TabIndex = 11;
            // 
            // baseHireChargeLbl
            // 
            this.baseHireChargeLbl.AutoSize = true;
            this.baseHireChargeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseHireChargeLbl.Location = new System.Drawing.Point(181, 265);
            this.baseHireChargeLbl.Name = "baseHireChargeLbl";
            this.baseHireChargeLbl.Size = new System.Drawing.Size(106, 13);
            this.baseHireChargeLbl.TabIndex = 12;
            this.baseHireChargeLbl.Text = "Base Hire Charge";
            // 
            // waitingChargeLbl
            // 
            this.waitingChargeLbl.AutoSize = true;
            this.waitingChargeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingChargeLbl.Location = new System.Drawing.Point(181, 291);
            this.waitingChargeLbl.Name = "waitingChargeLbl";
            this.waitingChargeLbl.Size = new System.Drawing.Size(94, 13);
            this.waitingChargeLbl.TabIndex = 13;
            this.waitingChargeLbl.Text = "Waiting Charge";
            // 
            // extraKMchargeLbl
            // 
            this.extraKMchargeLbl.AutoSize = true;
            this.extraKMchargeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraKMchargeLbl.Location = new System.Drawing.Point(181, 317);
            this.extraKMchargeLbl.Name = "extraKMchargeLbl";
            this.extraKMchargeLbl.Size = new System.Drawing.Size(102, 13);
            this.extraKMchargeLbl.TabIndex = 14;
            this.extraKMchargeLbl.Text = "Extra KM Charge";
            // 
            // totalHireValueLbl
            // 
            this.totalHireValueLbl.AutoSize = true;
            this.totalHireValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHireValueLbl.Location = new System.Drawing.Point(181, 343);
            this.totalHireValueLbl.Name = "totalHireValueLbl";
            this.totalHireValueLbl.Size = new System.Drawing.Size(99, 13);
            this.totalHireValueLbl.TabIndex = 15;
            this.totalHireValueLbl.Text = "Total Hire Value";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(281, 384);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "Go back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(200, 384);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(119, 384);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 16;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vehicle No :";
            // 
            // vehicleNoCombo
            // 
            this.vehicleNoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleNoCombo.FormattingEnabled = true;
            this.vehicleNoCombo.Location = new System.Drawing.Point(184, 38);
            this.vehicleNoCombo.Name = "vehicleNoCombo";
            this.vehicleNoCombo.Size = new System.Drawing.Size(126, 21);
            this.vehicleNoCombo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Time :";
            // 
            // startTimeDTPicker
            // 
            this.startTimeDTPicker.CustomFormat = "H:mm";
            this.startTimeDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeDTPicker.Location = new System.Drawing.Point(184, 110);
            this.startTimeDTPicker.Name = "startTimeDTPicker";
            this.startTimeDTPicker.ShowUpDown = true;
            this.startTimeDTPicker.Size = new System.Drawing.Size(126, 20);
            this.startTimeDTPicker.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "End Time :";
            // 
            // endTimeDTPicker
            // 
            this.endTimeDTPicker.CustomFormat = "H:mm";
            this.endTimeDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimeDTPicker.Location = new System.Drawing.Point(184, 145);
            this.endTimeDTPicker.Name = "endTimeDTPicker";
            this.endTimeDTPicker.ShowUpDown = true;
            this.endTimeDTPicker.Size = new System.Drawing.Size(126, 20);
            this.endTimeDTPicker.TabIndex = 7;
            // 
            // CalculateDayTourHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 442);
            this.Controls.Add(this.endTimeDTPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startTimeDTPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vehicleNoCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.totalHireValueLbl);
            this.Controls.Add(this.extraKMchargeLbl);
            this.Controls.Add(this.waitingChargeLbl);
            this.Controls.Add(this.baseHireChargeLbl);
            this.Controls.Add(this.endKMtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startKMtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pkgTypeCombo);
            this.Controls.Add(this.label1);
            this.Name = "CalculateDayTourHire";
            this.Text = "Calculate Day Tour Hire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pkgTypeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startKMtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endKMtxt;
        private System.Windows.Forms.Label baseHireChargeLbl;
        private System.Windows.Forms.Label waitingChargeLbl;
        private System.Windows.Forms.Label extraKMchargeLbl;
        private System.Windows.Forms.Label totalHireValueLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox vehicleNoCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startTimeDTPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker endTimeDTPicker;
    }
}