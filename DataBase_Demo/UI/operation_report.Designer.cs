namespace DataBase_Demo
{
    partial class operation_report
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
            this.skinsubmitButton = new CCWin.SkinControl.SkinButton();
            this.skinbackbutton = new CCWin.SkinControl.SkinButton();
            this.skinreportdataGridView = new CCWin.SkinControl.SkinDataGridView();
            this.skinreportTextBox = new CCWin.SkinControl.SkinTextBox();
            this.oper_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusion_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.skinreportdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // skinsubmitButton
            // 
            this.skinsubmitButton.BackColor = System.Drawing.Color.Transparent;
            this.skinsubmitButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinsubmitButton.DownBack = null;
            this.skinsubmitButton.Location = new System.Drawing.Point(223, 451);
            this.skinsubmitButton.MouseBack = null;
            this.skinsubmitButton.Name = "skinsubmitButton";
            this.skinsubmitButton.NormlBack = null;
            this.skinsubmitButton.Size = new System.Drawing.Size(177, 69);
            this.skinsubmitButton.TabIndex = 4;
            this.skinsubmitButton.Text = "保存";
            this.skinsubmitButton.UseVisualStyleBackColor = false;
            this.skinsubmitButton.Click += new System.EventHandler(this.skinsubmitButton_Click);
            // 
            // skinbackbutton
            // 
            this.skinbackbutton.BackColor = System.Drawing.Color.Transparent;
            this.skinbackbutton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinbackbutton.DownBack = null;
            this.skinbackbutton.Location = new System.Drawing.Point(534, 451);
            this.skinbackbutton.MouseBack = null;
            this.skinbackbutton.Name = "skinbackbutton";
            this.skinbackbutton.NormlBack = null;
            this.skinbackbutton.Size = new System.Drawing.Size(176, 69);
            this.skinbackbutton.TabIndex = 5;
            this.skinbackbutton.Text = "返回";
            this.skinbackbutton.UseVisualStyleBackColor = false;
            this.skinbackbutton.Click += new System.EventHandler(this.skinbackbutton_Click);
            // 
            // skinreportdataGridView
            // 
            this.skinreportdataGridView.AllowUserToAddRows = false;
            this.skinreportdataGridView.AllowUserToDeleteRows = false;
            this.skinreportdataGridView.AllowUserToResizeColumns = false;
            this.skinreportdataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinreportdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.skinreportdataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinreportdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinreportdataGridView.ColumnFont = null;
            this.skinreportdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinreportdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.skinreportdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinreportdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oper_id_col,
            this.conclusion_col,
            this.report_time_col});
            this.skinreportdataGridView.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinreportdataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.skinreportdataGridView.EnableHeadersVisualStyles = false;
            this.skinreportdataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinreportdataGridView.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinreportdataGridView.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinreportdataGridView.Location = new System.Drawing.Point(132, 73);
            this.skinreportdataGridView.Name = "skinreportdataGridView";
            this.skinreportdataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinreportdataGridView.RowHeadersVisible = false;
            this.skinreportdataGridView.RowHeadersWidth = 62;
            this.skinreportdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinreportdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.skinreportdataGridView.RowTemplate.Height = 23;
            this.skinreportdataGridView.Size = new System.Drawing.Size(591, 123);
            this.skinreportdataGridView.TabIndex = 6;
            this.skinreportdataGridView.TitleBack = null;
            this.skinreportdataGridView.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinreportdataGridView.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // skinreportTextBox
            // 
            this.skinreportTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinreportTextBox.DownBack = null;
            this.skinreportTextBox.Icon = null;
            this.skinreportTextBox.IconIsButton = false;
            this.skinreportTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinreportTextBox.IsPasswordChat = '\0';
            this.skinreportTextBox.IsSystemPasswordChar = false;
            this.skinreportTextBox.Lines = new string[0];
            this.skinreportTextBox.Location = new System.Drawing.Point(132, 212);
            this.skinreportTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.skinreportTextBox.MaxLength = 32767;
            this.skinreportTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinreportTextBox.MouseBack = null;
            this.skinreportTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinreportTextBox.Multiline = true;
            this.skinreportTextBox.Name = "skinreportTextBox";
            this.skinreportTextBox.NormlBack = null;
            this.skinreportTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.skinreportTextBox.ReadOnly = false;
            this.skinreportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinreportTextBox.Size = new System.Drawing.Size(739, 209);
            // 
            // 
            // 
            this.skinreportTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinreportTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinreportTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinreportTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinreportTextBox.SkinTxt.Multiline = true;
            this.skinreportTextBox.SkinTxt.Name = "BaseText";
            this.skinreportTextBox.SkinTxt.Size = new System.Drawing.Size(729, 199);
            this.skinreportTextBox.SkinTxt.TabIndex = 0;
            this.skinreportTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinreportTextBox.SkinTxt.WaterText = "";
            this.skinreportTextBox.TabIndex = 7;
            this.skinreportTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinreportTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinreportTextBox.WaterText = "";
            this.skinreportTextBox.WordWrap = true;
            // 
            // oper_id_col
            // 
            this.oper_id_col.DataPropertyName = "operation_id";
            this.oper_id_col.HeaderText = "手术编号";
            this.oper_id_col.MinimumWidth = 8;
            this.oper_id_col.Name = "oper_id_col";
            this.oper_id_col.Width = 150;
            // 
            // conclusion_col
            // 
            this.conclusion_col.DataPropertyName = "conclusion";
            this.conclusion_col.HeaderText = "提交状态";
            this.conclusion_col.MinimumWidth = 8;
            this.conclusion_col.Name = "conclusion_col";
            this.conclusion_col.Width = 150;
            // 
            // report_time_col
            // 
            this.report_time_col.DataPropertyName = "report_time";
            this.report_time_col.HeaderText = "提交时间";
            this.report_time_col.MinimumWidth = 8;
            this.report_time_col.Name = "report_time_col";
            this.report_time_col.Width = 150;
            // 
            // operation_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 556);
            this.Controls.Add(this.skinreportTextBox);
            this.Controls.Add(this.skinreportdataGridView);
            this.Controls.Add(this.skinbackbutton);
            this.Controls.Add(this.skinsubmitButton);
            this.Name = "operation_report";
            this.Text = "手术报告";
            ((System.ComponentModel.ISupportInitialize)(this.skinreportdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton skinsubmitButton;
        private CCWin.SkinControl.SkinButton skinbackbutton;
        private CCWin.SkinControl.SkinDataGridView skinreportdataGridView;
        private CCWin.SkinControl.SkinTextBox skinreportTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusion_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_time_col;
    }
}