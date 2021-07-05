
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
            this.components = new System.ComponentModel.Container();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.show_passwd_cskin_ckbx = new CCWin.SkinControl.SkinCheckBox();
            this.username_cskinLabel = new CCWin.SkinControl.SkinLabel();
            this.passwd_skinLabel = new CCWin.SkinControl.SkinLabel();
            this.login_skin_btn = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(134, 146);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(230, 35);
            this.idTextBox.TabIndex = 1;
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Location = new System.Drawing.Point(134, 242);
            this.passwdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.PasswordChar = '*';
            this.passwdTextBox.Size = new System.Drawing.Size(230, 35);
            this.passwdTextBox.TabIndex = 2;
            // 
            // show_passwd_cskin_ckbx
            // 
            this.show_passwd_cskin_ckbx.AutoSize = true;
            this.show_passwd_cskin_ckbx.BackColor = System.Drawing.Color.Transparent;
            this.show_passwd_cskin_ckbx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.show_passwd_cskin_ckbx.DownBack = null;
            this.show_passwd_cskin_ckbx.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.show_passwd_cskin_ckbx.Location = new System.Drawing.Point(397, 242);
            this.show_passwd_cskin_ckbx.MouseBack = null;
            this.show_passwd_cskin_ckbx.Name = "show_passwd_cskin_ckbx";
            this.show_passwd_cskin_ckbx.NormlBack = null;
            this.show_passwd_cskin_ckbx.SelectedDownBack = null;
            this.show_passwd_cskin_ckbx.SelectedMouseBack = null;
            this.show_passwd_cskin_ckbx.SelectedNormlBack = null;
            this.show_passwd_cskin_ckbx.Size = new System.Drawing.Size(142, 35);
            this.show_passwd_cskin_ckbx.TabIndex = 6;
            this.show_passwd_cskin_ckbx.Text = "显示密码";
            this.show_passwd_cskin_ckbx.UseVisualStyleBackColor = false;
            this.show_passwd_cskin_ckbx.CheckedChanged += new System.EventHandler(this.show_passwd_cskin_ckbx_CheckedChanged);
            // 
            // username_cskinLabel
            // 
            this.username_cskinLabel.AutoSize = true;
            this.username_cskinLabel.BackColor = System.Drawing.Color.Transparent;
            this.username_cskinLabel.BorderColor = System.Drawing.Color.White;
            this.username_cskinLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username_cskinLabel.Location = new System.Drawing.Point(41, 145);
            this.username_cskinLabel.Name = "username_cskinLabel";
            this.username_cskinLabel.Size = new System.Drawing.Size(86, 31);
            this.username_cskinLabel.TabIndex = 7;
            this.username_cskinLabel.Text = "用户名";
            // 
            // passwd_skinLabel
            // 
            this.passwd_skinLabel.AutoSize = true;
            this.passwd_skinLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwd_skinLabel.BorderColor = System.Drawing.Color.White;
            this.passwd_skinLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwd_skinLabel.Location = new System.Drawing.Point(41, 241);
            this.passwd_skinLabel.Name = "passwd_skinLabel";
            this.passwd_skinLabel.Size = new System.Drawing.Size(62, 31);
            this.passwd_skinLabel.TabIndex = 8;
            this.passwd_skinLabel.Text = "密码";
            // 
            // login_skin_btn
            // 
            this.login_skin_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_skin_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.login_skin_btn.DownBack = null;
            this.login_skin_btn.Location = new System.Drawing.Point(134, 333);
            this.login_skin_btn.MouseBack = null;
            this.login_skin_btn.Name = "login_skin_btn";
            this.login_skin_btn.NormlBack = null;
            this.login_skin_btn.Size = new System.Drawing.Size(112, 50);
            this.login_skin_btn.TabIndex = 9;
            this.login_skin_btn.Text = "登录";
            this.login_skin_btn.UseVisualStyleBackColor = false;
            this.login_skin_btn.Click += new System.EventHandler(this.login_skin_btn_Click);
            // 
            // doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.login_skin_btn);
            this.Controls.Add(this.passwd_skinLabel);
            this.Controls.Add(this.username_cskinLabel);
            this.Controls.Add(this.show_passwd_cskin_ckbx);
            this.Controls.Add(this.passwdTextBox);
            this.Controls.Add(this.idTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "doctor";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passwdTextBox;
        private CCWin.SkinControl.SkinCheckBox show_passwd_cskin_ckbx;
        private CCWin.SkinControl.SkinLabel username_cskinLabel;
        private CCWin.SkinControl.SkinLabel passwd_skinLabel;
        private CCWin.SkinControl.SkinButton login_skin_btn;
    }
}