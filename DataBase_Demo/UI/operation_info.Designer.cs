namespace DataBase_Demo
{
    partial class operation_info
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
            this.dataGridView_oper_info = new System.Windows.Forms.DataGridView();
            this.reportcheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.operation_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_sec_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_date_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.addreportbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_oper_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_oper_info
            // 
            this.dataGridView_oper_info.AllowUserToAddRows = false;
            this.dataGridView_oper_info.AllowUserToDeleteRows = false;
            this.dataGridView_oper_info.AllowUserToResizeColumns = false;
            this.dataGridView_oper_info.AllowUserToResizeRows = false;
            this.dataGridView_oper_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_oper_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportcheckbox,
            this.operation_id_col,
            this.operation_name_col,
            this.patient_id_col,
            this.patient_name_col,
            this.op_sec_id_col,
            this.op_date_col});
            this.dataGridView_oper_info.Location = new System.Drawing.Point(29, 22);
            this.dataGridView_oper_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_oper_info.Name = "dataGridView_oper_info";
            this.dataGridView_oper_info.RowHeadersVisible = false;
            this.dataGridView_oper_info.RowHeadersWidth = 62;
            this.dataGridView_oper_info.RowTemplate.Height = 30;
            this.dataGridView_oper_info.Size = new System.Drawing.Size(913, 292);
            this.dataGridView_oper_info.TabIndex = 0;
            // 
            // reportcheckbox
            // 
            this.reportcheckbox.HeaderText = "选择";
            this.reportcheckbox.MinimumWidth = 8;
            this.reportcheckbox.Name = "reportcheckbox";
            this.reportcheckbox.Width = 200;
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
            // operation_name_col
            // 
            this.operation_name_col.DataPropertyName = "operation_name";
            this.operation_name_col.HeaderText = "手术名称";
            this.operation_name_col.MinimumWidth = 6;
            this.operation_name_col.Name = "operation_name_col";
            this.operation_name_col.ReadOnly = true;
            this.operation_name_col.Width = 125;
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
            // patient_name_col
            // 
            this.patient_name_col.DataPropertyName = "patient_name";
            this.patient_name_col.HeaderText = "病人姓名";
            this.patient_name_col.MinimumWidth = 6;
            this.patient_name_col.Name = "patient_name_col";
            this.patient_name_col.ReadOnly = true;
            this.patient_name_col.Width = 125;
            // 
            // op_sec_id_col
            // 
            this.op_sec_id_col.DataPropertyName = "sec_id";
            this.op_sec_id_col.HeaderText = "手术时间编号";
            this.op_sec_id_col.MinimumWidth = 6;
            this.op_sec_id_col.Name = "op_sec_id_col";
            this.op_sec_id_col.ReadOnly = true;
            this.op_sec_id_col.Width = 150;
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
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(211, 333);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(153, 54);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addreportbutton
            // 
            this.addreportbutton.Location = new System.Drawing.Point(581, 333);
            this.addreportbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addreportbutton.Name = "addreportbutton";
            this.addreportbutton.Size = new System.Drawing.Size(157, 54);
            this.addreportbutton.TabIndex = 2;
            this.addreportbutton.Text = "添加报告";
            this.addreportbutton.UseVisualStyleBackColor = true;
            this.addreportbutton.Click += new System.EventHandler(this.addreportbutton_Click);
            // 
            // operation_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 532);
            this.Controls.Add(this.addreportbutton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView_oper_info);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "operation_info";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_oper_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_oper_info;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addreportbutton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reportcheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_sec_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_date_col;
    }
}