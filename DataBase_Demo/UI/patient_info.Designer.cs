
namespace DataBase_Demo
{
    partial class patient_info
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
            this.dataGridView_patient_info = new System.Windows.Forms.DataGridView();
            this.patient_id_check_box = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patient_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ill_con_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.need_operation_col = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.advice_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.prescribeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_patient_info
            // 
            this.dataGridView_patient_info.AllowUserToAddRows = false;
            this.dataGridView_patient_info.AllowUserToDeleteRows = false;
            this.dataGridView_patient_info.AllowUserToResizeColumns = false;
            this.dataGridView_patient_info.AllowUserToResizeRows = false;
            this.dataGridView_patient_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_patient_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patient_id_check_box,
            this.patient_id_col,
            this.state_time_col,
            this.ill_con_col,
            this.need_operation_col,
            this.advice_col});
            this.dataGridView_patient_info.Location = new System.Drawing.Point(18, 19);
            this.dataGridView_patient_info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_patient_info.MultiSelect = false;
            this.dataGridView_patient_info.Name = "dataGridView_patient_info";
            this.dataGridView_patient_info.RowHeadersVisible = false;
            this.dataGridView_patient_info.RowHeadersWidth = 51;
            this.dataGridView_patient_info.RowTemplate.Height = 27;
            this.dataGridView_patient_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_patient_info.Size = new System.Drawing.Size(1157, 457);
            this.dataGridView_patient_info.TabIndex = 0;
            this.dataGridView_patient_info.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patient_info_CellContentDoubleClick);
            // 
            // patient_id_check_box
            // 
            this.patient_id_check_box.HeaderText = "选择";
            this.patient_id_check_box.MinimumWidth = 6;
            this.patient_id_check_box.Name = "patient_id_check_box";
            this.patient_id_check_box.Width = 65;
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
            // state_time_col
            // 
            this.state_time_col.DataPropertyName = "state_time";
            this.state_time_col.HeaderText = "更新时间";
            this.state_time_col.MinimumWidth = 6;
            this.state_time_col.Name = "state_time_col";
            this.state_time_col.ReadOnly = true;
            this.state_time_col.Width = 125;
            // 
            // ill_con_col
            // 
            this.ill_con_col.DataPropertyName = "illness_condition";
            this.ill_con_col.HeaderText = "病情";
            this.ill_con_col.MinimumWidth = 6;
            this.ill_con_col.Name = "ill_con_col";
            this.ill_con_col.ReadOnly = true;
            this.ill_con_col.Width = 125;
            // 
            // need_operation_col
            // 
            this.need_operation_col.DataPropertyName = "need_operation";
            this.need_operation_col.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.need_operation_col.HeaderText = "是否需要手术";
            this.need_operation_col.MinimumWidth = 6;
            this.need_operation_col.Name = "need_operation_col";
            this.need_operation_col.ReadOnly = true;
            this.need_operation_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.need_operation_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.need_operation_col.Width = 125;
            // 
            // advice_col
            // 
            this.advice_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.advice_col.DataPropertyName = "advice";
            this.advice_col.HeaderText = "医嘱";
            this.advice_col.MinimumWidth = 6;
            this.advice_col.Name = "advice_col";
            this.advice_col.ReadOnly = true;
            this.advice_col.Width = 97;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(884, 570);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(180, 78);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(150, 570);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(180, 78);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "修改";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // prescribeButton
            // 
            this.prescribeButton.Location = new System.Drawing.Point(504, 571);
            this.prescribeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prescribeButton.Name = "prescribeButton";
            this.prescribeButton.Size = new System.Drawing.Size(198, 74);
            this.prescribeButton.TabIndex = 3;
            this.prescribeButton.Text = "开药";
            this.prescribeButton.UseVisualStyleBackColor = true;
            this.prescribeButton.Click += new System.EventHandler(this.prescribeButton_Click);
            // 
            // patient_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 682);
            this.Controls.Add(this.prescribeButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView_patient_info);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1214, 753);
            this.MinimumSize = new System.Drawing.Size(1214, 753);
            this.Name = "patient_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patient_info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_patient_info;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button prescribeButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn patient_id_check_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_time_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ill_con_col;
        private System.Windows.Forms.DataGridViewComboBoxColumn need_operation_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn advice_col;
    }
}