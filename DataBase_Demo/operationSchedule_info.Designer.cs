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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operation_info)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(492, 440);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(182, 75);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView_operation_info
            // 
            this.dataGridView_operation_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_operation_info.Location = new System.Drawing.Point(90, 37);
            this.dataGridView_operation_info.Name = "dataGridView_operation_info";
            this.dataGridView_operation_info.RowHeadersWidth = 62;
            this.dataGridView_operation_info.RowTemplate.Height = 30;
            this.dataGridView_operation_info.Size = new System.Drawing.Size(1056, 316);
            this.dataGridView_operation_info.TabIndex = 1;
            // 
            // operationSchedule_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 585);
            this.Controls.Add(this.dataGridView_operation_info);
            this.Controls.Add(this.backButton);
            this.Name = "operationSchedule_info";
            this.Text = "手术日程安排";
            //this.Load += new System.EventHandler(this.operation_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operation_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView_operation_info;
    }
}