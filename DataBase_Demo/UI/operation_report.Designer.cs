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
            this.submitbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.reportdataGridView = new System.Windows.Forms.DataGridView();
            this.reporttextBox = new System.Windows.Forms.TextBox();
            this.oper_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusion_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(156, 444);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(213, 54);
            this.submitbutton.TabIndex = 0;
            this.submitbutton.Text = "提交";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click_1);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(674, 442);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(218, 56);
            this.backbutton.TabIndex = 1;
            this.backbutton.Text = "返回";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click_1);
            // 
            // reportdataGridView
            // 
            this.reportdataGridView.AllowUserToAddRows = false;
            this.reportdataGridView.AllowUserToDeleteRows = false;
            this.reportdataGridView.AllowUserToResizeColumns = false;
            this.reportdataGridView.AllowUserToResizeRows = false;
            this.reportdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oper_id_col,
            this.conclusion_col,
            this.report_time_col});
            this.reportdataGridView.Location = new System.Drawing.Point(121, 57);
            this.reportdataGridView.Name = "reportdataGridView";
            this.reportdataGridView.RowHeadersVisible = false;
            this.reportdataGridView.RowHeadersWidth = 62;
            this.reportdataGridView.RowTemplate.Height = 30;
            this.reportdataGridView.Size = new System.Drawing.Size(843, 103);
            this.reportdataGridView.TabIndex = 2;
            this.reportdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportdataGridView_CellContentClick);
            // 
            // reporttextBox
            // 
            this.reporttextBox.AcceptsReturn = true;
            this.reporttextBox.AcceptsTab = true;
            this.reporttextBox.BackColor = System.Drawing.SystemColors.Info;
            this.reporttextBox.Location = new System.Drawing.Point(121, 183);
            this.reporttextBox.Multiline = true;
            this.reporttextBox.Name = "reporttextBox";
            this.reporttextBox.Size = new System.Drawing.Size(843, 227);
            this.reporttextBox.TabIndex = 3;
            this.reporttextBox.TextChanged += new System.EventHandler(this.reporttextBox_TextChanged);
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
            this.conclusion_col.HeaderText = "报告内容";
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
            this.Controls.Add(this.reporttextBox);
            this.Controls.Add(this.reportdataGridView);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.submitbutton);
            this.Name = "operation_report";
            this.Text = "operation_report";
            this.Load += new System.EventHandler(this.operation_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.DataGridView reportdataGridView;
        private System.Windows.Forms.TextBox reporttextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusion_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_time_col;
    }
}