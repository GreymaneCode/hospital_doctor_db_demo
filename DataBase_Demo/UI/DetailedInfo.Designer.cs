
namespace DataBase_Demo
{
    partial class DetailedInfo
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
            this.detailedContent_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // detailedContent_richTextBox
            // 
            this.detailedContent_richTextBox.Location = new System.Drawing.Point(53, 40);
            this.detailedContent_richTextBox.Name = "detailedContent_richTextBox";
            this.detailedContent_richTextBox.Size = new System.Drawing.Size(699, 367);
            this.detailedContent_richTextBox.TabIndex = 1;
            this.detailedContent_richTextBox.Text = "";
            // 
            // DetailedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detailedContent_richTextBox);
            this.Name = "DetailedInfo";
            this.Text = "DetailedInfo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox detailedContent_richTextBox;
    }
}