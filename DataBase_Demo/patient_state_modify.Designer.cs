
namespace DataBase_Demo
{
    partial class patient_state_modify
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
            this.modifyButton = new System.Windows.Forms.Button();
            this.illnessTextBox = new System.Windows.Forms.TextBox();
            this.illnessCondition = new System.Windows.Forms.Label();
            this.needOperation = new System.Windows.Forms.Label();
            this.needOperationTextBox = new System.Windows.Forms.TextBox();
            this.adviceTextBox = new System.Windows.Forms.TextBox();
            this.advice = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(182, 378);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(121, 44);
            this.modifyButton.TabIndex = 0;
            this.modifyButton.Text = "提交修改";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // illnessTextBox
            // 
            this.illnessTextBox.Location = new System.Drawing.Point(301, 107);
            this.illnessTextBox.Name = "illnessTextBox";
            this.illnessTextBox.Size = new System.Drawing.Size(288, 25);
            this.illnessTextBox.TabIndex = 1;
            // 
            // illnessCondition
            // 
            this.illnessCondition.AutoSize = true;
            this.illnessCondition.Location = new System.Drawing.Point(179, 110);
            this.illnessCondition.Name = "illnessCondition";
            this.illnessCondition.Size = new System.Drawing.Size(37, 15);
            this.illnessCondition.TabIndex = 2;
            this.illnessCondition.Text = "病情";
            // 
            // needOperation
            // 
            this.needOperation.AutoSize = true;
            this.needOperation.Location = new System.Drawing.Point(179, 161);
            this.needOperation.Name = "needOperation";
            this.needOperation.Size = new System.Drawing.Size(97, 15);
            this.needOperation.TabIndex = 3;
            this.needOperation.Text = "是否需要手术";
            // 
            // needOperationTextBox
            // 
            this.needOperationTextBox.Location = new System.Drawing.Point(301, 158);
            this.needOperationTextBox.Name = "needOperationTextBox";
            this.needOperationTextBox.Size = new System.Drawing.Size(288, 25);
            this.needOperationTextBox.TabIndex = 4;
            // 
            // adviceTextBox
            // 
            this.adviceTextBox.Location = new System.Drawing.Point(301, 213);
            this.adviceTextBox.Name = "adviceTextBox";
            this.adviceTextBox.Size = new System.Drawing.Size(288, 25);
            this.adviceTextBox.TabIndex = 5;
            // 
            // advice
            // 
            this.advice.AutoSize = true;
            this.advice.Location = new System.Drawing.Point(179, 216);
            this.advice.Name = "advice";
            this.advice.Size = new System.Drawing.Size(37, 15);
            this.advice.TabIndex = 6;
            this.advice.Text = "医嘱";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(468, 378);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(121, 44);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // patient_state_modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.advice);
            this.Controls.Add(this.adviceTextBox);
            this.Controls.Add(this.needOperationTextBox);
            this.Controls.Add(this.needOperation);
            this.Controls.Add(this.illnessCondition);
            this.Controls.Add(this.illnessTextBox);
            this.Controls.Add(this.modifyButton);
            this.Name = "patient_state_modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.TextBox illnessTextBox;
        private System.Windows.Forms.Label illnessCondition;
        private System.Windows.Forms.Label needOperation;
        private System.Windows.Forms.TextBox needOperationTextBox;
        private System.Windows.Forms.TextBox adviceTextBox;
        private System.Windows.Forms.Label advice;
        private System.Windows.Forms.Button backButton;
    }
}