
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doctor_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_doctor_info
            // 
            this.dataGridView_doctor_info.AllowUserToAddRows = false;
            this.dataGridView_doctor_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doctor_info.Location = new System.Drawing.Point(12, 48);
            this.dataGridView_doctor_info.Name = "dataGridView_doctor_info";
            this.dataGridView_doctor_info.ReadOnly = true;
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
    }
}