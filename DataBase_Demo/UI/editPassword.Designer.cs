
namespace DataBase_Demo
{
    partial class editPassword
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
            this.input_passwd_label = new CCWin.SkinControl.SkinLabel();
            this.confirm_passwd_label = new CCWin.SkinControl.SkinLabel();
            this.confirm_sBtn = new CCWin.SkinControl.SkinButton();
            this.passwd_textBox = new CCWin.SkinControl.SkinTextBox();
            this.confirm_passwd_textBox = new CCWin.SkinControl.SkinTextBox();
            this.return_sBtn = new CCWin.SkinControl.SkinButton();
            this.show_password_sCheckBox = new CCWin.SkinControl.SkinCheckBox();
            this.SuspendLayout();
            // 
            // input_passwd_label
            // 
            this.input_passwd_label.AutoSize = true;
            this.input_passwd_label.BackColor = System.Drawing.Color.Transparent;
            this.input_passwd_label.BorderColor = System.Drawing.Color.White;
            this.input_passwd_label.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.input_passwd_label.Location = new System.Drawing.Point(64, 130);
            this.input_passwd_label.Name = "input_passwd_label";
            this.input_passwd_label.Size = new System.Drawing.Size(150, 35);
            this.input_passwd_label.TabIndex = 0;
            this.input_passwd_label.Text = "输入新密码";
            this.input_passwd_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirm_passwd_label
            // 
            this.confirm_passwd_label.AutoSize = true;
            this.confirm_passwd_label.BackColor = System.Drawing.Color.Transparent;
            this.confirm_passwd_label.BorderColor = System.Drawing.Color.White;
            this.confirm_passwd_label.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.confirm_passwd_label.Location = new System.Drawing.Point(88, 239);
            this.confirm_passwd_label.Name = "confirm_passwd_label";
            this.confirm_passwd_label.Size = new System.Drawing.Size(123, 35);
            this.confirm_passwd_label.TabIndex = 1;
            this.confirm_passwd_label.Text = "确认密码";
            this.confirm_passwd_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirm_sBtn
            // 
            this.confirm_sBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirm_sBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.confirm_sBtn.DownBack = null;
            this.confirm_sBtn.Location = new System.Drawing.Point(446, 309);
            this.confirm_sBtn.MouseBack = null;
            this.confirm_sBtn.Name = "confirm_sBtn";
            this.confirm_sBtn.NormlBack = null;
            this.confirm_sBtn.Size = new System.Drawing.Size(173, 85);
            this.confirm_sBtn.TabIndex = 2;
            this.confirm_sBtn.Text = "确认更改";
            this.confirm_sBtn.UseVisualStyleBackColor = false;
            this.confirm_sBtn.Click += new System.EventHandler(this.confirm_sBtn_Click);
            // 
            // passwd_textBox
            // 
            this.passwd_textBox.BackColor = System.Drawing.Color.Transparent;
            this.passwd_textBox.DownBack = null;
            this.passwd_textBox.Icon = null;
            this.passwd_textBox.IconIsButton = false;
            this.passwd_textBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwd_textBox.IsPasswordChat = '*';
            this.passwd_textBox.IsSystemPasswordChar = false;
            this.passwd_textBox.Lines = new string[0];
            this.passwd_textBox.Location = new System.Drawing.Point(251, 130);
            this.passwd_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwd_textBox.MaxLength = 20;
            this.passwd_textBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.passwd_textBox.MouseBack = null;
            this.passwd_textBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwd_textBox.Multiline = true;
            this.passwd_textBox.Name = "passwd_textBox";
            this.passwd_textBox.NormlBack = null;
            this.passwd_textBox.Padding = new System.Windows.Forms.Padding(5);
            this.passwd_textBox.ReadOnly = false;
            this.passwd_textBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwd_textBox.Size = new System.Drawing.Size(433, 50);
            // 
            // 
            // 
            this.passwd_textBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwd_textBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwd_textBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.passwd_textBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.passwd_textBox.SkinTxt.MaxLength = 20;
            this.passwd_textBox.SkinTxt.Multiline = true;
            this.passwd_textBox.SkinTxt.Name = "BaseText";
            this.passwd_textBox.SkinTxt.Size = new System.Drawing.Size(423, 40);
            this.passwd_textBox.SkinTxt.TabIndex = 0;
            this.passwd_textBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwd_textBox.SkinTxt.WaterText = "";
            this.passwd_textBox.TabIndex = 3;
            this.passwd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwd_textBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwd_textBox.WaterText = "";
            this.passwd_textBox.WordWrap = true;
            // 
            // confirm_passwd_textBox
            // 
            this.confirm_passwd_textBox.BackColor = System.Drawing.Color.Transparent;
            this.confirm_passwd_textBox.DownBack = null;
            this.confirm_passwd_textBox.Icon = null;
            this.confirm_passwd_textBox.IconIsButton = false;
            this.confirm_passwd_textBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.confirm_passwd_textBox.IsPasswordChat = '*';
            this.confirm_passwd_textBox.IsSystemPasswordChar = false;
            this.confirm_passwd_textBox.Lines = new string[0];
            this.confirm_passwd_textBox.Location = new System.Drawing.Point(251, 224);
            this.confirm_passwd_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.confirm_passwd_textBox.MaxLength = 20;
            this.confirm_passwd_textBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.confirm_passwd_textBox.MouseBack = null;
            this.confirm_passwd_textBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.confirm_passwd_textBox.Multiline = true;
            this.confirm_passwd_textBox.Name = "confirm_passwd_textBox";
            this.confirm_passwd_textBox.NormlBack = null;
            this.confirm_passwd_textBox.Padding = new System.Windows.Forms.Padding(5);
            this.confirm_passwd_textBox.ReadOnly = false;
            this.confirm_passwd_textBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirm_passwd_textBox.Size = new System.Drawing.Size(433, 50);
            // 
            // 
            // 
            this.confirm_passwd_textBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirm_passwd_textBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirm_passwd_textBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.confirm_passwd_textBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.confirm_passwd_textBox.SkinTxt.MaxLength = 20;
            this.confirm_passwd_textBox.SkinTxt.Multiline = true;
            this.confirm_passwd_textBox.SkinTxt.Name = "BaseText";
            this.confirm_passwd_textBox.SkinTxt.Size = new System.Drawing.Size(423, 40);
            this.confirm_passwd_textBox.SkinTxt.TabIndex = 0;
            this.confirm_passwd_textBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.confirm_passwd_textBox.SkinTxt.WaterText = "";
            this.confirm_passwd_textBox.TabIndex = 4;
            this.confirm_passwd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.confirm_passwd_textBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.confirm_passwd_textBox.WaterText = "";
            this.confirm_passwd_textBox.WordWrap = true;
            // 
            // return_sBtn
            // 
            this.return_sBtn.BackColor = System.Drawing.Color.Transparent;
            this.return_sBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.return_sBtn.DownBack = null;
            this.return_sBtn.Location = new System.Drawing.Point(142, 309);
            this.return_sBtn.MouseBack = null;
            this.return_sBtn.Name = "return_sBtn";
            this.return_sBtn.NormlBack = null;
            this.return_sBtn.Size = new System.Drawing.Size(174, 85);
            this.return_sBtn.TabIndex = 5;
            this.return_sBtn.Text = "返回";
            this.return_sBtn.UseVisualStyleBackColor = false;
            this.return_sBtn.Click += new System.EventHandler(this.return_sBtn_Click);
            // 
            // show_password_sCheckBox
            // 
            this.show_password_sCheckBox.AutoSize = true;
            this.show_password_sCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.show_password_sCheckBox.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.show_password_sCheckBox.DownBack = null;
            this.show_password_sCheckBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.show_password_sCheckBox.Location = new System.Drawing.Point(716, 239);
            this.show_password_sCheckBox.MouseBack = null;
            this.show_password_sCheckBox.Name = "show_password_sCheckBox";
            this.show_password_sCheckBox.NormlBack = null;
            this.show_password_sCheckBox.SelectedDownBack = null;
            this.show_password_sCheckBox.SelectedMouseBack = null;
            this.show_password_sCheckBox.SelectedNormlBack = null;
            this.show_password_sCheckBox.Size = new System.Drawing.Size(142, 35);
            this.show_password_sCheckBox.TabIndex = 6;
            this.show_password_sCheckBox.Text = "显示密码";
            this.show_password_sCheckBox.UseVisualStyleBackColor = false;
            this.show_password_sCheckBox.CheckedChanged += new System.EventHandler(this.show_password_sCheckBox_CheckedChanged);
            // 
            // editPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 483);
            this.Controls.Add(this.show_password_sCheckBox);
            this.Controls.Add(this.return_sBtn);
            this.Controls.Add(this.confirm_passwd_textBox);
            this.Controls.Add(this.passwd_textBox);
            this.Controls.Add(this.confirm_sBtn);
            this.Controls.Add(this.confirm_passwd_label);
            this.Controls.Add(this.input_passwd_label);
            this.Name = "editPassword";
            this.Text = "更改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel input_passwd_label;
        private CCWin.SkinControl.SkinLabel confirm_passwd_label;
        private CCWin.SkinControl.SkinButton confirm_sBtn;
        private CCWin.SkinControl.SkinTextBox passwd_textBox;
        private CCWin.SkinControl.SkinTextBox confirm_passwd_textBox;
        private CCWin.SkinControl.SkinButton return_sBtn;
        private CCWin.SkinControl.SkinCheckBox show_password_sCheckBox;
    }
}