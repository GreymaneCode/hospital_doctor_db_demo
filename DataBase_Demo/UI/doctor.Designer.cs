
namespace DataBase_Demo
{
    partial class doctor
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
            this.loginButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.show_passwd_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(134, 222);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 37);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(132, 46);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(230, 35);
            this.idTextBox.TabIndex = 1;
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Location = new System.Drawing.Point(134, 118);
            this.passwdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.PasswordChar = '*';
            this.passwdTextBox.Size = new System.Drawing.Size(228, 35);
            this.passwdTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(45, 51);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(82, 24);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "用户名";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(68, 123);
            this.passwdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(58, 24);
            this.passwdLabel.TabIndex = 4;
            this.passwdLabel.Text = "密码";
            // 
            // show_passwd_checkBox
            // 
            this.show_passwd_checkBox.AutoSize = true;
            this.show_passwd_checkBox.Location = new System.Drawing.Point(394, 124);
            this.show_passwd_checkBox.Name = "show_passwd_checkBox";
            this.show_passwd_checkBox.Size = new System.Drawing.Size(138, 28);
            this.show_passwd_checkBox.TabIndex = 5;
            this.show_passwd_checkBox.Text = "显示密码";
            this.show_passwd_checkBox.UseVisualStyleBackColor = true;
            this.show_passwd_checkBox.CheckedChanged += new System.EventHandler(this.show_passwd_checkBox_CheckedChanged);
            // 
            // doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 365);
            this.Controls.Add(this.show_passwd_checkBox);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.passwdTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.loginButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(586, 436);
            this.MinimumSize = new System.Drawing.Size(586, 436);
            this.Name = "doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.CheckBox show_passwd_checkBox;
    }
}