namespace DataBase_Demo
{
    partial class operationSchedule_info
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
            this.dataGridView_operation_info = new System.Windows.Forms.DataGridView();
            this.op_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_sec_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_date_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operation_info)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(437, 367);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(162, 62);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView_operation_info
            // 
            this.dataGridView_operation_info.AllowUserToAddRows = false;
            this.dataGridView_operation_info.AllowUserToDeleteRows = false;
            this.dataGridView_operation_info.AllowUserToResizeColumns = false;
            this.dataGridView_operation_info.AllowUserToResizeRows = false;
            this.dataGridView_operation_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_operation_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.op_,
            this.doctor_id_col,
            this.operation_id_col,
            this.op_sec_id_col,
            this.patient_id_col,
            this.op_date_col});
            this.dataGridView_operation_info.Location = new System.Drawing.Point(80, 31);
            this.dataGridView_operation_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_operation_info.Name = "dataGridView_operation_info";
            this.dataGridView_operation_info.RowHeadersVisible = false;
            this.dataGridView_operation_info.RowHeadersWidth = 62;
            this.dataGridView_operation_info.RowTemplate.Height = 30;
            this.dataGridView_operation_info.Size = new System.Drawing.Size(939, 263);
            this.dataGridView_operation_info.TabIndex = 1;
           
            // 
            // op_
            // 
            this.op_.DataPropertyName = "operation_name";
            this.op_.HeaderText = "手术名称";
            this.op_.MinimumWidth = 6;
            this.op_.Name = "op_";
            this.op_.ReadOnly = true;
            this.op_.Width = 125;
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
            // operation_id_col
            // 
            this.operation_id_col.DataPropertyName = "operation_id";
            this.operation_id_col.HeaderText = "手术编号";
            this.operation_id_col.MinimumWidth = 6;
            this.operation_id_col.Name = "operation_id_col";
            this.operation_id_col.ReadOnly = true;
            this.operation_id_col.Width = 125;
            // 
            // op_sec_id_col
            // 
            this.op_sec_id_col.DataPropertyName = "sec_id";
            this.op_sec_id_col.HeaderText = "手术时间编号";
            this.op_sec_id_col.MinimumWidth = 6;
            this.op_sec_id_col.Name = "op_sec_id_col";
            this.op_sec_id_col.ReadOnly = true;
            this.op_sec_id_col.Width = 125;
            // 
            // patient_id_col
            // 
            this.patient_id_col.DataPropertyName = "patient_id";
            this.patient_id_col.HeaderText = "病人编号";
            this.patient_id_col.MinimumWidth = 6;
            this.patient_id_col.Name = "patient_id_col";
            this.patient_id_col.ReadOnly = true;
            this.patient_id_col.Width = 125;
            // 
            // op_date_col
            // 
            this.op_date_col.DataPropertyName = "operation_date";
            this.op_date_col.HeaderText = "手术日期";
            this.op_date_col.MinimumWidth = 6;
            this.op_date_col.Name = "op_date_col";
            this.op_date_col.ReadOnly = true;
            this.op_date_col.Width = 125;
            // 
            // operationSchedule_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 487);
            this.Controls.Add(this.dataGridView_operation_info);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "operationSchedule_info";
            this.Text = "手术日程安排";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operation_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView_operation_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_sec_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_date_col;
    }
}