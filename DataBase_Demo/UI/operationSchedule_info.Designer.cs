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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skin_backButton = new CCWin.SkinControl.SkinButton();
            this.skinDataGridView_operation_info = new CCWin.SkinControl.SkinDataGridView();
            this.operation_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_sec_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_date_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinComboBox1 = new CCWin.SkinControl.SkinComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_operation_info)).BeginInit();
            this.SuspendLayout();
            // 
            // skin_backButton
            // 
            this.skin_backButton.BackColor = System.Drawing.Color.Transparent;
            this.skin_backButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skin_backButton.DownBack = null;
            this.skin_backButton.Location = new System.Drawing.Point(459, 448);
            this.skin_backButton.MouseBack = null;
            this.skin_backButton.Name = "skin_backButton";
            this.skin_backButton.NormlBack = null;
            this.skin_backButton.Size = new System.Drawing.Size(217, 81);
            this.skin_backButton.TabIndex = 2;
            this.skin_backButton.Text = "返回";
            this.skin_backButton.UseVisualStyleBackColor = false;
            this.skin_backButton.Click += new System.EventHandler(this.skin_backButton_Click);
            // 
            // skinDataGridView_operation_info
            // 
            this.skinDataGridView_operation_info.AllowUserToAddRows = false;
            this.skinDataGridView_operation_info.AllowUserToDeleteRows = false;
            this.skinDataGridView_operation_info.AllowUserToResizeColumns = false;
            this.skinDataGridView_operation_info.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView_operation_info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.skinDataGridView_operation_info.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView_operation_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView_operation_info.ColumnFont = null;
            this.skinDataGridView_operation_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView_operation_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.skinDataGridView_operation_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView_operation_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operation_id_col,
            this.op_name_col,
            this.patient_id_col,
            this.patient_name,
            this.op_sec_id_col,
            this.op_date_col});
            this.skinDataGridView_operation_info.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView_operation_info.DefaultCellStyle = dataGridViewCellStyle7;
            this.skinDataGridView_operation_info.EnableHeadersVisualStyles = false;
            this.skinDataGridView_operation_info.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView_operation_info.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView_operation_info.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_operation_info.Location = new System.Drawing.Point(107, 131);
            this.skinDataGridView_operation_info.Name = "skinDataGridView_operation_info";
            this.skinDataGridView_operation_info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView_operation_info.RowHeadersVisible = false;
            this.skinDataGridView_operation_info.RowHeadersWidth = 62;
            this.skinDataGridView_operation_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_operation_info.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.skinDataGridView_operation_info.RowTemplate.Height = 23;
            this.skinDataGridView_operation_info.Size = new System.Drawing.Size(966, 288);
            this.skinDataGridView_operation_info.TabIndex = 3;
            this.skinDataGridView_operation_info.TitleBack = null;
            this.skinDataGridView_operation_info.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView_operation_info.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // operation_id_col
            // 
            this.operation_id_col.DataPropertyName = "operation_id";
            this.operation_id_col.HeaderText = "手术编号";
            this.operation_id_col.MinimumWidth = 6;
            this.operation_id_col.Name = "operation_id_col";
            this.operation_id_col.Width = 150;
            // 
            // op_name_col
            // 
            this.op_name_col.DataPropertyName = "operation_name";
            this.op_name_col.HeaderText = "手术名称";
            this.op_name_col.MinimumWidth = 6;
            this.op_name_col.Name = "op_name_col";
            this.op_name_col.Width = 120;
            // 
            // patient_id_col
            // 
            this.patient_id_col.DataPropertyName = "patient_id";
            this.patient_id_col.HeaderText = "病人编号";
            this.patient_id_col.MinimumWidth = 6;
            this.patient_id_col.Name = "patient_id_col";
            this.patient_id_col.Width = 150;
            // 
            // patient_name
            // 
            this.patient_name.DataPropertyName = "patient_name";
            this.patient_name.HeaderText = "病人姓名";
            this.patient_name.MinimumWidth = 6;
            this.patient_name.Name = "patient_name";
            this.patient_name.Width = 120;
            // 
            // op_sec_id_col
            // 
            this.op_sec_id_col.DataPropertyName = "sec_id";
            this.op_sec_id_col.HeaderText = "手术时间";
            this.op_sec_id_col.MinimumWidth = 6;
            this.op_sec_id_col.Name = "op_sec_id_col";
            this.op_sec_id_col.Width = 150;
            // 
            // op_date_col
            // 
            this.op_date_col.DataPropertyName = "operation_date";
            this.op_date_col.HeaderText = "手术日期";
            this.op_date_col.MinimumWidth = 6;
            this.op_date_col.Name = "op_date_col";
            this.op_date_col.Width = 150;
            // 
            // skinComboBox1
            // 
            this.skinComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox1.FormattingEnabled = true;
            this.skinComboBox1.Items.AddRange(new object[] {
            "未来手术",
            "历史手术"});
            this.skinComboBox1.Location = new System.Drawing.Point(107, 77);
            this.skinComboBox1.Name = "skinComboBox1";
            this.skinComboBox1.Size = new System.Drawing.Size(131, 29);
            this.skinComboBox1.TabIndex = 4;
            this.skinComboBox1.WaterText = "";
            this.skinComboBox1.SelectedIndexChanged += new System.EventHandler(this.skinComboBox1_SelectedIndexChanged);
            // 
            // operationSchedule_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 584);
            this.Controls.Add(this.skinComboBox1);
            this.Controls.Add(this.skinDataGridView_operation_info);
            this.Controls.Add(this.skin_backButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "operationSchedule_info";
            this.Text = "手术日程安排";
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_operation_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton skin_backButton;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView_operation_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_sec_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_date_col;
        private CCWin.SkinControl.SkinComboBox skinComboBox1;
    }
}