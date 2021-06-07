
namespace DataBase_Demo
{
    partial class doctor_menu
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
            this.doctorInfoButton = new System.Windows.Forms.Button();
            this.patientInfoButton = new System.Windows.Forms.Button();
            this.operationScheduleButton = new System.Windows.Forms.Button();
            this.operationReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doctorInfoButton
            // 
            this.doctorInfoButton.Location = new System.Drawing.Point(179, 44);
            this.doctorInfoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doctorInfoButton.Name = "doctorInfoButton";
            this.doctorInfoButton.Size = new System.Drawing.Size(169, 112);
            this.doctorInfoButton.TabIndex = 0;
            this.doctorInfoButton.Text = "查看个人信息";
            this.doctorInfoButton.UseVisualStyleBackColor = true;
            this.doctorInfoButton.Click += new System.EventHandler(this.doctorInfoButton_Click);
            // 
            // patientInfoButton
            // 
            this.patientInfoButton.Location = new System.Drawing.Point(482, 44);
            this.patientInfoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patientInfoButton.Name = "patientInfoButton";
            this.patientInfoButton.Size = new System.Drawing.Size(169, 112);
            this.patientInfoButton.TabIndex = 1;
            this.patientInfoButton.Text = "查看病人信息";
            this.patientInfoButton.UseVisualStyleBackColor = true;
            this.patientInfoButton.Click += new System.EventHandler(this.patientInfoButton_Click);
            // 
            // operationScheduleButton
            // 
            this.operationScheduleButton.Location = new System.Drawing.Point(179, 264);
            this.operationScheduleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operationScheduleButton.Name = "operationScheduleButton";
            this.operationScheduleButton.Size = new System.Drawing.Size(169, 112);
            this.operationScheduleButton.TabIndex = 2;
            this.operationScheduleButton.Text = "查看手术日程";
            this.operationScheduleButton.UseVisualStyleBackColor = true;
            this.operationScheduleButton.Click += new System.EventHandler(this.operationScheduleButton_Click);
            // 
            // operationReportButton
            // 
            this.operationReportButton.Location = new System.Drawing.Point(482, 264);
            this.operationReportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operationReportButton.Name = "operationReportButton";
            this.operationReportButton.Size = new System.Drawing.Size(169, 112);
            this.operationReportButton.TabIndex = 3;
            this.operationReportButton.Text = "上传手术报告";
            this.operationReportButton.UseVisualStyleBackColor = true;
            this.operationReportButton.Click += new System.EventHandler(this.operationReportButton_Click);
            // 
            // doctor_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 529);
            this.Controls.Add(this.operationReportButton);
            this.Controls.Add(this.operationScheduleButton);
            this.Controls.Add(this.patientInfoButton);
            this.Controls.Add(this.doctorInfoButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(918, 585);
            this.MinimumSize = new System.Drawing.Size(918, 585);
            this.Name = "doctor_menu";
            this.Text = "doctor_menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doctorInfoButton;
        private System.Windows.Forms.Button patientInfoButton;
        private System.Windows.Forms.Button operationScheduleButton;
        private System.Windows.Forms.Button operationReportButton;
    }
}