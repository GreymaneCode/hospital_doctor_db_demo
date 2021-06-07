
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
            this.backButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.prescribeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_patient_info
            // 
            this.dataGridView_patient_info.AllowUserToAddRows = false;
            this.dataGridView_patient_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_patient_info.Location = new System.Drawing.Point(98, 50);
            this.dataGridView_patient_info.MultiSelect = false;
            this.dataGridView_patient_info.Name = "dataGridView_patient_info";
            this.dataGridView_patient_info.ReadOnly = true;
            this.dataGridView_patient_info.RowHeadersWidth = 51;
            this.dataGridView_patient_info.RowTemplate.Height = 27;
            this.dataGridView_patient_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_patient_info.Size = new System.Drawing.Size(589, 213);
            this.dataGridView_patient_info.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(567, 323);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 49);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(123, 323);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(120, 49);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "修改";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // prescribeButton
            // 
            this.prescribeButton.Location = new System.Drawing.Point(327, 325);
            this.prescribeButton.Name = "prescribeButton";
            this.prescribeButton.Size = new System.Drawing.Size(132, 46);
            this.prescribeButton.TabIndex = 3;
            this.prescribeButton.Text = "开药";
            this.prescribeButton.UseVisualStyleBackColor = true;
            this.prescribeButton.Click += new System.EventHandler(this.prescribeButton_Click);
            // 
            // patient_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prescribeButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView_patient_info);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
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
    }
}