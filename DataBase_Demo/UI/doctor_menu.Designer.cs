﻿
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
            this.components = new System.ComponentModel.Container();
            this.skindoctorInfoButton = new CCWin.SkinControl.SkinButton();
            this.skinpatientInfoButton = new CCWin.SkinControl.SkinButton();
            this.skinoperationScheduleButton = new CCWin.SkinControl.SkinButton();
            this.skinoperationReportButton = new CCWin.SkinControl.SkinButton();
            this.skinexitButton = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skindoctorInfoButton
            // 
            this.skindoctorInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.skindoctorInfoButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skindoctorInfoButton.DownBack = null;
            this.skindoctorInfoButton.Location = new System.Drawing.Point(169, 134);
            this.skindoctorInfoButton.MouseBack = null;
            this.skindoctorInfoButton.Name = "skindoctorInfoButton";
            this.skindoctorInfoButton.NormlBack = null;
            this.skindoctorInfoButton.Size = new System.Drawing.Size(229, 106);
            this.skindoctorInfoButton.TabIndex = 5;
            this.skindoctorInfoButton.Text = "查看个人信息";
            this.skindoctorInfoButton.UseVisualStyleBackColor = false;
            this.skindoctorInfoButton.Click += new System.EventHandler(this.skindoctorInfoButton_Click);
            // 
            // skinpatientInfoButton
            // 
            this.skinpatientInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.skinpatientInfoButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinpatientInfoButton.DownBack = null;
            this.skinpatientInfoButton.Location = new System.Drawing.Point(546, 134);
            this.skinpatientInfoButton.MouseBack = null;
            this.skinpatientInfoButton.Name = "skinpatientInfoButton";
            this.skinpatientInfoButton.NormlBack = null;
            this.skinpatientInfoButton.Size = new System.Drawing.Size(219, 106);
            this.skinpatientInfoButton.TabIndex = 6;
            this.skinpatientInfoButton.Text = "查看病人信息";
            this.skinpatientInfoButton.UseVisualStyleBackColor = false;
            this.skinpatientInfoButton.Click += new System.EventHandler(this.skinpatientInfoButton_Click);
            // 
            // skinoperationScheduleButton
            // 
            this.skinoperationScheduleButton.BackColor = System.Drawing.Color.Transparent;
            this.skinoperationScheduleButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinoperationScheduleButton.DownBack = null;
            this.skinoperationScheduleButton.Location = new System.Drawing.Point(169, 288);
            this.skinoperationScheduleButton.MouseBack = null;
            this.skinoperationScheduleButton.Name = "skinoperationScheduleButton";
            this.skinoperationScheduleButton.NormlBack = null;
            this.skinoperationScheduleButton.Size = new System.Drawing.Size(229, 98);
            this.skinoperationScheduleButton.TabIndex = 7;
            this.skinoperationScheduleButton.Text = "查看手术安排";
            this.skinoperationScheduleButton.UseVisualStyleBackColor = false;
            this.skinoperationScheduleButton.Click += new System.EventHandler(this.skinoperationScheduleButton_Click);
            // 
            // skinoperationReportButton
            // 
            this.skinoperationReportButton.BackColor = System.Drawing.Color.Transparent;
            this.skinoperationReportButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinoperationReportButton.DownBack = null;
            this.skinoperationReportButton.Location = new System.Drawing.Point(546, 288);
            this.skinoperationReportButton.MouseBack = null;
            this.skinoperationReportButton.Name = "skinoperationReportButton";
            this.skinoperationReportButton.NormlBack = null;
            this.skinoperationReportButton.Size = new System.Drawing.Size(219, 98);
            this.skinoperationReportButton.TabIndex = 8;
            this.skinoperationReportButton.Text = "上传手术报告";
            this.skinoperationReportButton.UseVisualStyleBackColor = false;
            this.skinoperationReportButton.Click += new System.EventHandler(this.skinoperationReportButton_Click);
            // 
            // skinexitButton
            // 
            this.skinexitButton.BackColor = System.Drawing.Color.Transparent;
            this.skinexitButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinexitButton.DownBack = null;
            this.skinexitButton.Location = new System.Drawing.Point(368, 451);
            this.skinexitButton.MouseBack = null;
            this.skinexitButton.Name = "skinexitButton";
            this.skinexitButton.NormlBack = null;
            this.skinexitButton.Size = new System.Drawing.Size(204, 88);
            this.skinexitButton.TabIndex = 9;
            this.skinexitButton.Text = "退出";
            this.skinexitButton.UseVisualStyleBackColor = false;
            this.skinexitButton.Click += new System.EventHandler(this.skinexitButton_Click);
            // 
            // doctor_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 596);
            this.Controls.Add(this.skinexitButton);
            this.Controls.Add(this.skinoperationReportButton);
            this.Controls.Add(this.skinoperationScheduleButton);
            this.Controls.Add(this.skinpatientInfoButton);
            this.Controls.Add(this.skindoctorInfoButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(920, 596);
            this.MinimumSize = new System.Drawing.Size(920, 596);
            this.Name = "doctor_menu";
            this.Padding = new System.Windows.Forms.Padding(22, 72, 22, 24);
            this.Text = "doctor_menu";
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton skindoctorInfoButton;
        private CCWin.SkinControl.SkinButton skinpatientInfoButton;
        private CCWin.SkinControl.SkinButton skinoperationScheduleButton;
        private CCWin.SkinControl.SkinButton skinoperationReportButton;
        private CCWin.SkinControl.SkinButton skinexitButton;
    }
}