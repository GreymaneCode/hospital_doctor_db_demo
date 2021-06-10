
namespace DataBase_Demo
{
    partial class prescribe_add
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.medicineNameLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.medicineNameComboBox = new System.Windows.Forms.ComboBox();
            this.doseLabel = new System.Windows.Forms.Label();
            this.doseComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(194, 347);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(126, 53);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "提交";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(448, 347);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(126, 53);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // medicineNameLabel
            // 
            this.medicineNameLabel.AutoSize = true;
            this.medicineNameLabel.Location = new System.Drawing.Point(120, 124);
            this.medicineNameLabel.Name = "medicineNameLabel";
            this.medicineNameLabel.Size = new System.Drawing.Size(67, 15);
            this.medicineNameLabel.TabIndex = 4;
            this.medicineNameLabel.Text = "药品名称";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(120, 184);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(37, 15);
            this.unitLabel.TabIndex = 6;
            this.unitLabel.Text = "数量";
            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(230, 181);
            this.unitTextBox.MaxLength = 4;
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(290, 25);
            this.unitTextBox.TabIndex = 7;
            // 
            // medicineNameComboBox
            // 
            this.medicineNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicineNameComboBox.FormattingEnabled = true;
            this.medicineNameComboBox.Items.AddRange(new object[] {
            "almighty pills"});
            this.medicineNameComboBox.Location = new System.Drawing.Point(230, 124);
            this.medicineNameComboBox.Name = "medicineNameComboBox";
            this.medicineNameComboBox.Size = new System.Drawing.Size(290, 23);
            this.medicineNameComboBox.TabIndex = 8;
            // 
            // doseLabel
            // 
            this.doseLabel.AutoSize = true;
            this.doseLabel.Location = new System.Drawing.Point(128, 240);
            this.doseLabel.Name = "doseLabel";
            this.doseLabel.Size = new System.Drawing.Size(37, 15);
            this.doseLabel.TabIndex = 9;
            this.doseLabel.Text = "单位";
            // 
            // doseComboBox
            // 
            this.doseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doseComboBox.FormattingEnabled = true;
            this.doseComboBox.Items.AddRange(new object[] {
            "盒",
            "片",
            "瓶",
            "支",
            "粒",
            "颗"});
            this.doseComboBox.Location = new System.Drawing.Point(230, 242);
            this.doseComboBox.Name = "doseComboBox";
            this.doseComboBox.Size = new System.Drawing.Size(290, 23);
            this.doseComboBox.TabIndex = 10;
            // 
            // prescribe_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doseComboBox);
            this.Controls.Add(this.doseLabel);
            this.Controls.Add(this.medicineNameComboBox);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.medicineNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirmButton);
            this.Name = "prescribe_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prescribe_add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label medicineNameLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.ComboBox medicineNameComboBox;
        private System.Windows.Forms.Label doseLabel;
        private System.Windows.Forms.ComboBox doseComboBox;
    }
}