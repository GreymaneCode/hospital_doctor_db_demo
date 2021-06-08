
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
            this.dataGridView_doctor_info = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.doctor_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_passwd_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_num_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doctor_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_doctor_info
            // 
            this.dataGridView_doctor_info.AllowUserToAddRows = false;
            this.dataGridView_doctor_info.AllowUserToDeleteRows = false;
            this.dataGridView_doctor_info.AllowUserToResizeColumns = false;
            this.dataGridView_doctor_info.AllowUserToResizeRows = false;
            this.dataGridView_doctor_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doctor_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctor_id_col,
            this.doc_passwd_col,
            this.doc_name,
            this.dept_name_col,
            this.phone_num_col,
            this.title_col});
            this.dataGridView_doctor_info.Location = new System.Drawing.Point(12, 48);
            this.dataGridView_doctor_info.Name = "dataGridView_doctor_info";
            this.dataGridView_doctor_info.ReadOnly = true;
            this.dataGridView_doctor_info.RowHeadersVisible = false;
            this.dataGridView_doctor_info.RowHeadersWidth = 51;
            this.dataGridView_doctor_info.RowTemplate.Height = 27;
            this.dataGridView_doctor_info.Size = new System.Drawing.Size(924, 173);
            this.dataGridView_doctor_info.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(376, 310);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 43);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // doctor_id_col
            // 
            this.doctor_id_col.DataPropertyName = "doctor_id";
            this.doctor_id_col.HeaderText = "医生编号";
            this.doctor_id_col.MinimumWidth = 6;
            this.doctor_id_col.Name = "doctor_id_col";
            this.doctor_id_col.ReadOnly = true;
            this.doctor_id_col.Width = 125;
            // 
            // doc_passwd_col
            // 
            this.doc_passwd_col.DataPropertyName = "doctor_password";
            this.doc_passwd_col.HeaderText = "登录密码";
            this.doc_passwd_col.MinimumWidth = 6;
            this.doc_passwd_col.Name = "doc_passwd_col";
            this.doc_passwd_col.ReadOnly = true;
            this.doc_passwd_col.Visible = false;
            this.doc_passwd_col.Width = 125;
            // 
            // doc_name
            // 
            this.doc_name.DataPropertyName = "doctor_name";
            this.doc_name.HeaderText = "姓名";
            this.doc_name.MinimumWidth = 6;
            this.doc_name.Name = "doc_name";
            this.doc_name.ReadOnly = true;
            this.doc_name.Width = 125;
            // 
            // dept_name_col
            // 
            this.dept_name_col.DataPropertyName = "dept_name";
            this.dept_name_col.HeaderText = "科室";
            this.dept_name_col.MinimumWidth = 6;
            this.dept_name_col.Name = "dept_name_col";
            this.dept_name_col.ReadOnly = true;
            this.dept_name_col.Width = 125;
            // 
            // phone_num_col
            // 
            this.phone_num_col.DataPropertyName = "phone_number";
            this.phone_num_col.HeaderText = "手机号码";
            this.phone_num_col.MinimumWidth = 6;
            this.phone_num_col.Name = "phone_num_col";
            this.phone_num_col.ReadOnly = true;
            this.phone_num_col.Width = 125;
            // 
            // title_col
            // 
            this.title_col.DataPropertyName = "title";
            this.title_col.HeaderText = "职称";
            this.title_col.MinimumWidth = 6;
            this.title_col.Name = "title_col";
            this.title_col.ReadOnly = true;
            this.title_col.Width = 125;
            // 
            // doctor_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView_doctor_info);
            this.MaximumSize = new System.Drawing.Size(966, 497);
            this.MinimumSize = new System.Drawing.Size(966, 497);
            this.Name = "doctor_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doctor_info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doctor_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_doctor_info;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_passwd_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_num_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_col;
    }
}