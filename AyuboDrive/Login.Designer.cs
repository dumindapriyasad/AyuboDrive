namespace AyuboDrive
{
    partial class Login
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
            this.usernameTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTbox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // usernameTbox
            // 
            this.usernameTbox.Location = new System.Drawing.Point(119, 34);
            this.usernameTbox.Name = "usernameTbox";
            this.usernameTbox.Size = new System.Drawing.Size(124, 20);
            this.usernameTbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // passwordTbox
            // 
            this.passwordTbox.Location = new System.Drawing.Point(119, 72);
            this.passwordTbox.Name = "passwordTbox";
            this.passwordTbox.Size = new System.Drawing.Size(124, 20);
            this.passwordTbox.TabIndex = 3;
            this.passwordTbox.UseSystemPasswordChar = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(168, 119);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(87, 119);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 177);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTbox);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Ayubo Drive Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTbox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button loginBtn;
    }
}