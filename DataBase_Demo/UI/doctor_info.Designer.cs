
namespace DataBase_Demo
{
    partial class doctor_info
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
            this.backButton = new System.Windows.Forms.Button();
            this.doctor_name_label = new System.Windows.Forms.Label();
            this.doctor_name_query_label = new System.Windows.Forms.Label();
            this.doctor_id_label = new System.Windows.Forms.Label();
            this.doctor_id_query_label = new System.Windows.Forms.Label();
            this.doctor_dept_label = new System.Windows.Forms.Label();
            this.doctor_dept_query_label = new System.Windows.Forms.Label();
            this.doctor_title_label = new System.Windows.Forms.Label();
            this.doctor_title_query_label = new System.Windows.Forms.Label();
            this.phone_num_label = new System.Windows.Forms.Label();
            this.phone_num_query_label = new System.Windows.Forms.Label();
            this.doc_passwd_label = new System.Windows.Forms.Label();
            this.flag_passwd_checkBox = new System.Windows.Forms.CheckBox();
            this.passwd_query_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(564, 496);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(214, 69);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // doctor_name_label
            // 
            this.doctor_name_label.AutoSize = true;
            this.doctor_name_label.Location = new System.Drawing.Point(59, 60);
            this.doctor_name_label.Name = "doctor_name_label";
            this.doctor_name_label.Size = new System.Drawing.Size(82, 24);
            this.doctor_name_label.TabIndex = 2;
            this.doctor_name_label.Text = "姓名：";
            // 
            // doctor_name_query_label
            // 
            this.doctor_name_query_label.AutoSize = true;
            this.doctor_name_query_label.Location = new System.Drawing.Point(160, 60);
            this.doctor_name_query_label.Name = "doctor_name_query_label";
            this.doctor_name_query_label.Size = new System.Drawing.Size(46, 24);
            this.doctor_name_query_label.TabIndex = 3;
            this.doctor_name_query_label.Text = "   ";
            // 
            // doctor_id_label
            // 
            this.doctor_id_label.AutoSize = true;
            this.doctor_id_label.Location = new System.Drawing.Point(59, 140);
            this.doctor_id_label.Name = "doctor_id_label";
            this.doctor_id_label.Size = new System.Drawing.Size(130, 24);
            this.doctor_id_label.TabIndex = 4;
            this.doctor_id_label.Text = "医生编号：";
            // 
            // doctor_id_query_label
            // 
            this.doctor_id_query_label.AutoSize = true;
            this.doctor_id_query_label.Location = new System.Drawing.Point(195, 140);
            this.doctor_id_query_label.Name = "doctor_id_query_label";
            this.doctor_id_query_label.Size = new System.Drawing.Size(46, 24);
            this.doctor_id_query_label.TabIndex = 5;
            this.doctor_id_query_label.Text = "   ";
            // 
            // doctor_dept_label
            // 
            this.doctor_dept_label.AutoSize = true;
            this.doctor_dept_label.Location = new System.Drawing.Point(59, 220);
            this.doctor_dept_label.Name = "doctor_dept_label";
            this.doctor_dept_label.Size = new System.Drawing.Size(82, 24);
            this.doctor_dept_label.TabIndex = 6;
            this.doctor_dept_label.Text = "科室：";
            // 
            // doctor_dept_query_label
            // 
            this.doctor_dept_query_label.AutoSize = true;
            this.doctor_dept_query_label.Location = new System.Drawing.Point(152, 220);
            this.doctor_dept_query_label.Name = "doctor_dept_query_label";
            this.doctor_dept_query_label.Size = new System.Drawing.Size(46, 24);
            this.doctor_dept_query_label.TabIndex = 7;
            this.doctor_dept_query_label.Text = "   ";
            // 
            // doctor_title_label
            // 
            this.doctor_title_label.AutoSize = true;
            this.doctor_title_label.Location = new System.Drawing.Point(59, 295);
            this.doctor_title_label.Name = "doctor_title_label";
            this.doctor_title_label.Size = new System.Drawing.Size(82, 24);
            this.doctor_title_label.TabIndex = 8;
            this.doctor_title_label.Text = "职称：";
            // 
            // doctor_title_query_label
            // 
            this.doctor_title_query_label.AutoSize = true;
            this.doctor_title_query_label.Location = new System.Drawing.Point(148, 295);
            this.doctor_title_query_label.Name = "doctor_title_query_label";
            this.doctor_title_query_label.Size = new System.Drawing.Size(46, 24);
            this.doctor_title_query_label.TabIndex = 9;
            this.doctor_title_query_label.Text = "   ";
            // 
            // phone_num_label
            // 
            this.phone_num_label.AutoSize = true;
            this.phone_num_label.Location = new System.Drawing.Point(696, 60);
            this.phone_num_label.Name = "phone_num_label";
            this.phone_num_label.Size = new System.Drawing.Size(130, 24);
            this.phone_num_label.TabIndex = 10;
            this.phone_num_label.Text = "手机号码：";
            // 
            // phone_num_query_label
            // 
            this.phone_num_query_label.AutoSize = true;
            this.phone_num_query_label.Location = new System.Drawing.Point(833, 60);
            this.phone_num_query_label.Name = "phone_num_query_label";
            this.phone_num_query_label.Size = new System.Drawing.Size(46, 24);
            this.phone_num_query_label.TabIndex = 11;
            this.phone_num_query_label.Text = "   ";
            // 
            // doc_passwd_label
            // 
            this.doc_passwd_label.AutoSize = true;
            this.doc_passwd_label.Location = new System.Drawing.Point(700, 140);
            this.doc_passwd_label.Name = "doc_passwd_label";
            this.doc_passwd_label.Size = new System.Drawing.Size(130, 24);
            this.doc_passwd_label.TabIndex = 12;
            this.doc_passwd_label.Text = "登录密码：";
            // 
            // flag_passwd_checkBox
            // 
            this.flag_passwd_checkBox.AutoSize = true;
            this.flag_passwd_checkBox.Location = new System.Drawing.Point(700, 179);
            this.flag_passwd_checkBox.Name = "flag_passwd_checkBox";
            this.flag_passwd_checkBox.Size = new System.Drawing.Size(138, 28);
            this.flag_passwd_checkBox.TabIndex = 14;
            this.flag_passwd_checkBox.Text = "显示密码";
            this.flag_passwd_checkBox.UseVisualStyleBackColor = true;
            this.flag_passwd_checkBox.CheckedChanged += new System.EventHandler(this.flag_passwd_checkBox_CheckedChanged);
            // 
            // passwd_query_textBox
            // 
            this.passwd_query_textBox.Location = new System.Drawing.Point(836, 137);
            this.passwd_query_textBox.Name = "passwd_query_textBox";
            this.passwd_query_textBox.ReadOnly = true;
            this.passwd_query_textBox.Size = new System.Drawing.Size(197, 35);
            this.passwd_query_textBox.TabIndex = 15;
            // 
            // doctor_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 682);
            this.Controls.Add(this.passwd_query_textBox);
            this.Controls.Add(this.flag_passwd_checkBox);
            this.Controls.Add(this.doc_passwd_label);
            this.Controls.Add(this.phone_num_query_label);
            this.Controls.Add(this.phone_num_label);
            this.Controls.Add(this.doctor_title_query_label);
            this.Controls.Add(this.doctor_title_label);
            this.Controls.Add(this.doctor_dept_query_label);
            this.Controls.Add(this.doctor_dept_label);
            this.Controls.Add(this.doctor_id_query_label);
            this.Controls.Add(this.doctor_id_label);
            this.Controls.Add(this.doctor_name_query_label);
            this.Controls.Add(this.doctor_name_label);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1436, 753);
            this.MinimumSize = new System.Drawing.Size(1436, 753);
            this.Name = "doctor_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doctor_info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label doctor_name_label;
        private System.Windows.Forms.Label doctor_name_query_label;
        private System.Windows.Forms.Label doctor_id_label;
        private System.Windows.Forms.Label doctor_id_query_label;
        private System.Windows.Forms.Label doctor_dept_label;
        private System.Windows.Forms.Label doctor_dept_query_label;
        private System.Windows.Forms.Label doctor_title_label;
        private System.Windows.Forms.Label doctor_title_query_label;
        private System.Windows.Forms.Label phone_num_label;
        private System.Windows.Forms.Label phone_num_query_label;
        private System.Windows.Forms.Label doc_passwd_label;
        private System.Windows.Forms.CheckBox flag_passwd_checkBox;
        private System.Windows.Forms.TextBox passwd_query_textBox;
    }
}