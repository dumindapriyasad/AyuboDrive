namespace AyuboDrive
{
    partial class CalculateVehicleRent
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
            this.label2 = new System.Windows.Forms.Label();
            this.withDriverCheck = new System.Windows.Forms.CheckBox();
            this.totalRentLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.vehicleNoCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rentedDateDTpicker = new System.Windows.Forms.DateTimePicker();
            this.returnDateDTpicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rented Date :";
            // 
            // withDriverCheck
            // 
            this.withDriverCheck.AutoSize = true;
            this.withDriverCheck.Location = new System.Drawing.Point(131, 151);
            this.withDriverCheck.Name = "withDriverCheck";
            this.withDriverCheck.Size = new System.Drawing.Size(76, 17);
            this.withDriverCheck.TabIndex = 6;
            this.withDriverCheck.Text = "with Driver";
            this.withDriverCheck.UseVisualStyleBackColor = true;
            // 
            // totalRentLbl
            // 
            this.totalRentLbl.AutoSize = true;
            this.totalRentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRentLbl.Location = new System.Drawing.Point(128, 183);
            this.totalRentLbl.Name = "totalRentLbl";
            this.totalRentLbl.Size = new System.Drawing.Size(67, 13);
            this.totalRentLbl.TabIndex = 7;
            this.totalRentLbl.Text = "Total Rent";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(51, 217);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(132, 217);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(213, 217);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Go back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // vehicleNoCombo
            // 
            this.vehicleNoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleNoCombo.FormattingEnabled = true;
            this.vehicleNoCombo.Location = new System.Drawing.Point(131, 45);
            this.vehicleNoCombo.Name = "vehicleNoCombo";
            this.vehicleNoCombo.Size = new System.Drawing.Size(125, 21);
            this.vehicleNoCombo.TabIndex = 1;
            this.vehicleNoCombo.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Return Date :";
            // 
            // rentedDateDTpicker
            // 
            this.rentedDateDTpicker.CustomFormat = "dd-MM-yyyy";
            this.rentedDateDTpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentedDateDTpicker.Location = new System.Drawing.Point(131, 81);
            this.rentedDateDTpicker.Name = "rentedDateDTpicker";
            this.rentedDateDTpicker.Size = new System.Drawing.Size(125, 20);
            this.rentedDateDTpicker.TabIndex = 3;
            // 
            // returnDateDTpicker
            // 
            this.returnDateDTpicker.CustomFormat = "dd-MM-yyyy";
            this.returnDateDTpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDateDTpicker.Location = new System.Drawing.Point(131, 116);
            this.returnDateDTpicker.Name = "returnDateDTpicker";
            this.returnDateDTpicker.Size = new System.Drawing.Size(125, 20);
            this.returnDateDTpicker.TabIndex = 5;
            // 
            // CalculateVehicleRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 288);
            this.Controls.Add(this.returnDateDTpicker);
            this.Controls.Add(this.rentedDateDTpicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vehicleNoCombo);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.totalRentLbl);
            this.Controls.Add(this.withDriverCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculateVehicleRent";
            this.Text = "Calculate Vehicle Rent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox withDriverCheck;
        private System.Windows.Forms.Label totalRentLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox vehicleNoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker rentedDateDTpicker;
        private System.Windows.Forms.DateTimePicker returnDateDTpicker;
    }
}