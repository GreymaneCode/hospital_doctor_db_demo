namespace DataBase_Demo
{
    partial class new_report
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
            this.skinreturnButton = new CCWin.SkinControl.SkinButton();
            this.skinsubmitButton = new CCWin.SkinControl.SkinButton();
            this.skinreportTextBox = new CCWin.SkinControl.SkinTextBox();
            this.skinidLabel = new CCWin.SkinControl.SkinLabel();
            this.skinidTextBox = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // skinreturnButton
            // 
            this.skinreturnButton.BackColor = System.Drawing.Color.Transparent;
            this.skinreturnButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinreturnButton.DownBack = null;
            this.skinreturnButton.Location = new System.Drawing.Point(159, 495);
            this.skinreturnButton.MouseBack = null;
            this.skinreturnButton.Name = "skinreturnButton";
            this.skinreturnButton.NormlBack = null;
            this.skinreturnButton.Size = new System.Drawing.Size(203, 76);
            this.skinreturnButton.TabIndex = 0;
            this.skinreturnButton.Text = "返回";
            this.skinreturnButton.UseVisualStyleBackColor = false;
            this.skinreturnButton.Click += new System.EventHandler(this.skinreturnButton_Click);
            // 
            // skinsubmitButton
            // 
            this.skinsubmitButton.BackColor = System.Drawing.Color.Transparent;
            this.skinsubmitButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinsubmitButton.DownBack = null;
            this.skinsubmitButton.Location = new System.Drawing.Point(518, 495);
            this.skinsubmitButton.MouseBack = null;
            this.skinsubmitButton.Name = "skinsubmitButton";
            this.skinsubmitButton.NormlBack = null;
            this.skinsubmitButton.Size = new System.Drawing.Size(195, 76);
            this.skinsubmitButton.TabIndex = 1;
            this.skinsubmitButton.Text = "提交";
            this.skinsubmitButton.UseVisualStyleBackColor = false;
            this.skinsubmitButton.Click += new System.EventHandler(this.skinsubmitButton_Click_1);
            // 
            // skinreportTextBox
            // 
            this.skinreportTextBox.BackColor = System.Drawing.Color.Transparent;
            this.skinreportTextBox.DownBack = null;
            this.skinreportTextBox.Icon = null;
            this.skinreportTextBox.IconIsButton = false;
            this.skinreportTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinreportTextBox.IsPasswordChat = '\0';
            this.skinreportTextBox.IsSystemPasswordChar = false;
            this.skinreportTextBox.Lines = new string[0];
            this.skinreportTextBox.Location = new System.Drawing.Point(147, 185);
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
            this.skinreportTextBox.Size = new System.Drawing.Size(575, 243);
            // 
            // 
            // 
            this.skinreportTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinreportTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinreportTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinreportTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinreportTextBox.SkinTxt.Multiline = true;
            this.skinreportTextBox.SkinTxt.Name = "BaseText";
            this.skinreportTextBox.SkinTxt.Size = new System.Drawing.Size(565, 233);
            this.skinreportTextBox.SkinTxt.TabIndex = 0;
            this.skinreportTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinreportTextBox.SkinTxt.WaterText = "";
            this.skinreportTextBox.TabIndex = 2;
            this.skinreportTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinreportTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinreportTextBox.WaterText = "";
            this.skinreportTextBox.WordWrap = true;
            // 
            // skinidLabel
            // 
            this.skinidLabel.AutoSize = true;
            this.skinidLabel.BackColor = System.Drawing.Color.Transparent;
            this.skinidLabel.BorderColor = System.Drawing.Color.White;
            this.skinidLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinidLabel.Location = new System.Drawing.Point(143, 100);
            this.skinidLabel.Name = "skinidLabel";
            this.skinidLabel.Size = new System.Drawing.Size(100, 24);
            this.skinidLabel.TabIndex = 3;
            this.skinidLabel.Text = "手术编号：";
            // 
            // skinidTextBox
            // 
            this.skinidTextBox.BackColor = System.Drawing.Color.Transparent;
            this.skinidTextBox.DownBack = null;
            this.skinidTextBox.Icon = null;
            this.skinidTextBox.IconIsButton = false;
            this.skinidTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinidTextBox.IsPasswordChat = '\0';
            this.skinidTextBox.IsSystemPasswordChar = false;
            this.skinidTextBox.Lines = new string[0];
            this.skinidTextBox.Location = new System.Drawing.Point(246, 92);
            this.skinidTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.skinidTextBox.MaxLength = 32767;
            this.skinidTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinidTextBox.MouseBack = null;
            this.skinidTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinidTextBox.Multiline = true;
            this.skinidTextBox.Name = "skinidTextBox";
            this.skinidTextBox.NormlBack = null;
            this.skinidTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.skinidTextBox.ReadOnly = false;
            this.skinidTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinidTextBox.Size = new System.Drawing.Size(129, 32);
            // 
            // 
            // 
            this.skinidTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinidTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinidTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinidTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinidTextBox.SkinTxt.Multiline = true;
            this.skinidTextBox.SkinTxt.Name = "BaseText";
            this.skinidTextBox.SkinTxt.Size = new System.Drawing.Size(119, 22);
            this.skinidTextBox.SkinTxt.TabIndex = 0;
            this.skinidTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinidTextBox.SkinTxt.WaterText = "";
            this.skinidTextBox.TabIndex = 4;
            this.skinidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinidTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinidTextBox.WaterText = "";
            this.skinidTextBox.WordWrap = true;
//            this.skinidTextBox.Paint += new System.Windows.Forms.PaintEventHandler(this.skinidTextBox_Paint);
            // 
            // new_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 655);
            this.Controls.Add(this.skinidTextBox);
            this.Controls.Add(this.skinidLabel);
            this.Controls.Add(this.skinreportTextBox);
            this.Controls.Add(this.skinsubmitButton);
            this.Controls.Add(this.skinreturnButton);
            this.Name = "new_report";
            this.Text = "新建报告";
  //          this.Load += new System.EventHandler(this.new_report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinreturnButton;
        private CCWin.SkinControl.SkinButton skinsubmitButton;
        private CCWin.SkinControl.SkinTextBox skinreportTextBox;
        private CCWin.SkinControl.SkinLabel skinidLabel;
        private CCWin.SkinControl.SkinTextBox skinidTextBox;
    }
}