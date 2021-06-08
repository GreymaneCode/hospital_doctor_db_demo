
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
            this.medicineIdTextBox = new System.Windows.Forms.TextBox();
            this.medicineIdLabel = new System.Windows.Forms.Label();
            this.medicineNameLabel = new System.Windows.Forms.Label();
            this.medicineNameTextBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
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
            // medicineIdTextBox
            // 
            this.medicineIdTextBox.Location = new System.Drawing.Point(230, 56);
            this.medicineIdTextBox.Name = "medicineIdTextBox";
            this.medicineIdTextBox.Size = new System.Drawing.Size(290, 25);
            this.medicineIdTextBox.TabIndex = 2;
            // 
            // medicineIdLabel
            // 
            this.medicineIdLabel.AutoSize = true;
            this.medicineIdLabel.Location = new System.Drawing.Point(122, 66);
            this.medicineIdLabel.Name = "medicineIdLabel";
            this.medicineIdLabel.Size = new System.Drawing.Size(67, 15);
            this.medicineIdLabel.TabIndex = 3;
            this.medicineIdLabel.Text = "药品编号";
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
            // medicineNameTextBox
            // 
            this.medicineNameTextBox.Location = new System.Drawing.Point(231, 124);
            this.medicineNameTextBox.Name = "medicineNameTextBox";
            this.medicineNameTextBox.Size = new System.Drawing.Size(289, 25);
            this.medicineNameTextBox.TabIndex = 5;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(120, 184);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(67, 15);
            this.unitLabel.TabIndex = 6;
            this.unitLabel.Text = "数量单位";
            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(230, 181);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(290, 25);
            this.unitTextBox.TabIndex = 7;
            // 
            // prescribe_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.medicineNameTextBox);
            this.Controls.Add(this.medicineNameLabel);
            this.Controls.Add(this.medicineIdLabel);
            this.Controls.Add(this.medicineIdTextBox);
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
        private System.Windows.Forms.TextBox medicineIdTextBox;
        private System.Windows.Forms.Label medicineIdLabel;
        private System.Windows.Forms.Label medicineNameLabel;
        private System.Windows.Forms.TextBox medicineNameTextBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox unitTextBox;
    }
}