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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skindataGridView_oper_info = new CCWin.SkinControl.SkinDataGridView();
            this.reportcheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.operation_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_sec_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_date_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinbackButton = new CCWin.SkinControl.SkinButton();
            this.skinaddreportbutton = new CCWin.SkinControl.SkinButton();
            this.skinviewreportButton = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skindataGridView_oper_info)).BeginInit();
            this.SuspendLayout();
            // 
            // skindataGridView_oper_info
            // 
            this.skindataGridView_oper_info.AllowUserToAddRows = false;
            this.skindataGridView_oper_info.AllowUserToDeleteRows = false;
            this.skindataGridView_oper_info.AllowUserToResizeColumns = false;
            this.skindataGridView_oper_info.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skindataGridView_oper_info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.skindataGridView_oper_info.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skindataGridView_oper_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skindataGridView_oper_info.ColumnFont = null;
            this.skindataGridView_oper_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skindataGridView_oper_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skindataGridView_oper_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skindataGridView_oper_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportcheckbox,
            this.operation_id_col,
            this.operation_name_col,
            this.patient_id_col,
            this.patient_name_col,
            this.op_sec_id_col,
            this.op_date_col});
            this.skindataGridView_oper_info.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skindataGridView_oper_info.DefaultCellStyle = dataGridViewCellStyle3;
            this.skindataGridView_oper_info.EnableHeadersVisualStyles = false;
            this.skindataGridView_oper_info.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skindataGridView_oper_info.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skindataGridView_oper_info.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skindataGridView_oper_info.Location = new System.Drawing.Point(67, 94);
            this.skindataGridView_oper_info.Name = "skindataGridView_oper_info";
            this.skindataGridView_oper_info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skindataGridView_oper_info.RowHeadersVisible = false;
            this.skindataGridView_oper_info.RowHeadersWidth = 62;
            this.skindataGridView_oper_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skindataGridView_oper_info.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skindataGridView_oper_info.RowTemplate.Height = 23;
            this.skindataGridView_oper_info.Size = new System.Drawing.Size(957, 320);
            this.skindataGridView_oper_info.TabIndex = 3;
            this.skindataGridView_oper_info.TitleBack = null;
            this.skindataGridView_oper_info.TitleBackColorBegin = System.Drawing.Color.White;
            this.skindataGridView_oper_info.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // reportcheckbox
            // 
            this.reportcheckbox.HeaderText = "选择";
            this.reportcheckbox.MinimumWidth = 8;
            this.reportcheckbox.Name = "reportcheckbox";
            this.reportcheckbox.Width = 40;
            // 
            // operation_id_col
            // 
            this.operation_id_col.DataPropertyName = "operation_id";
            this.operation_id_col.HeaderText = "手术编号";
            this.operation_id_col.MinimumWidth = 8;
            this.operation_id_col.Name = "operation_id_col";
            this.operation_id_col.Width = 150;
            // 
            // operation_name_col
            // 
            this.operation_name_col.DataPropertyName = "operation_name";
            this.operation_name_col.HeaderText = "手术名称";
            this.operation_name_col.MinimumWidth = 8;
            this.operation_name_col.Name = "operation_name_col";
            this.operation_name_col.Width = 110;
            // 
            // patient_id_col
            // 
            this.patient_id_col.DataPropertyName = "patient_id";
            this.patient_id_col.HeaderText = "病人编号";
            this.patient_id_col.MinimumWidth = 8;
            this.patient_id_col.Name = "patient_id_col";
            this.patient_id_col.Width = 150;
            // 
            // patient_name_col
            // 
            this.patient_name_col.DataPropertyName = "patient_name";
            this.patient_name_col.HeaderText = "病人姓名";
            this.patient_name_col.MinimumWidth = 8;
            this.patient_name_col.Name = "patient_name_col";
            this.patient_name_col.Width = 150;
            // 
            // op_sec_id_col
            // 
            this.op_sec_id_col.DataPropertyName = "sec_id";
            this.op_sec_id_col.HeaderText = "手术时间";
            this.op_sec_id_col.MinimumWidth = 8;
            this.op_sec_id_col.Name = "op_sec_id_col";
            this.op_sec_id_col.Width = 150;
            // 
            // op_date_col
            // 
            this.op_date_col.DataPropertyName = "operation_date";
            this.op_date_col.HeaderText = "手术日期";
            this.op_date_col.MinimumWidth = 8;
            this.op_date_col.Name = "op_date_col";
            this.op_date_col.Width = 150;
            // 
            // skinbackButton
            // 
            this.skinbackButton.BackColor = System.Drawing.Color.Transparent;
            this.skinbackButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinbackButton.DownBack = null;
            this.skinbackButton.Location = new System.Drawing.Point(137, 494);
            this.skinbackButton.MouseBack = null;
            this.skinbackButton.Name = "skinbackButton";
            this.skinbackButton.NormlBack = null;
            this.skinbackButton.Size = new System.Drawing.Size(215, 76);
            this.skinbackButton.TabIndex = 4;
            this.skinbackButton.Text = "返回";
            this.skinbackButton.UseVisualStyleBackColor = false;
            this.skinbackButton.Click += new System.EventHandler(this.skinbackButton_Click);
            // 
            // skinaddreportbutton
            // 
            this.skinaddreportbutton.BackColor = System.Drawing.Color.Transparent;
            this.skinaddreportbutton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinaddreportbutton.DownBack = null;
            this.skinaddreportbutton.Location = new System.Drawing.Point(432, 493);
            this.skinaddreportbutton.MouseBack = null;
            this.skinaddreportbutton.Name = "skinaddreportbutton";
            this.skinaddreportbutton.NormlBack = null;
            this.skinaddreportbutton.Size = new System.Drawing.Size(234, 77);
            this.skinaddreportbutton.TabIndex = 5;
            this.skinaddreportbutton.Text = "编辑报告";
            this.skinaddreportbutton.UseVisualStyleBackColor = false;
            this.skinaddreportbutton.Click += new System.EventHandler(this.skinaddreportbutton_Click);
            // 
            // skinviewreportButton
            // 
            this.skinviewreportButton.BackColor = System.Drawing.Color.Transparent;
            this.skinviewreportButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinviewreportButton.DownBack = null;
            this.skinviewreportButton.Location = new System.Drawing.Point(725, 493);
            this.skinviewreportButton.MouseBack = null;
            this.skinviewreportButton.Name = "skinviewreportButton";
            this.skinviewreportButton.NormlBack = null;
            this.skinviewreportButton.Size = new System.Drawing.Size(213, 76);
            this.skinviewreportButton.TabIndex = 6;
            this.skinviewreportButton.Text = "查看报告";
            this.skinviewreportButton.UseVisualStyleBackColor = false;
            this.skinviewreportButton.Click += new System.EventHandler(this.skinviewreportButton_Click);
            // 
            // operation_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 638);
            this.Controls.Add(this.skinviewreportButton);
            this.Controls.Add(this.skinaddreportbutton);
            this.Controls.Add(this.skinbackButton);
            this.Controls.Add(this.skindataGridView_oper_info);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "operation_info";
            this.Padding = new System.Windows.Forms.Padding(22, 72, 22, 24);
            this.Text = "历史手术记录";
            ((System.ComponentModel.ISupportInitialize)(this.skindataGridView_oper_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinDataGridView skindataGridView_oper_info;
        private CCWin.SkinControl.SkinButton skinbackButton;
        private CCWin.SkinControl.SkinButton skinaddreportbutton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reportcheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_sec_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_date_col;
        private CCWin.SkinControl.SkinButton skinviewreportButton;
    }
}