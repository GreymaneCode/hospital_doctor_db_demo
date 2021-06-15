
namespace DataBase_Demo
{
    partial class patient_list
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
            this.selectButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView_patient_list = new System.Windows.Forms.DataGridView();
            this.sel_col = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pat_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pat_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient_list)).BeginInit();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(113, 297);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(165, 86);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "选择";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(447, 297);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(176, 86);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView_patient_list
            // 
            this.dataGridView_patient_list.AllowUserToAddRows = false;
            this.dataGridView_patient_list.AllowUserToDeleteRows = false;
            this.dataGridView_patient_list.AllowUserToOrderColumns = true;
            this.dataGridView_patient_list.AllowUserToResizeColumns = false;
            this.dataGridView_patient_list.AllowUserToResizeRows = false;
            this.dataGridView_patient_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_patient_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sel_col,
            this.pat_id_col,
            this.pat_name_col});
            this.dataGridView_patient_list.Location = new System.Drawing.Point(48, 40);
            this.dataGridView_patient_list.Name = "dataGridView_patient_list";
            this.dataGridView_patient_list.RowHeadersVisible = false;
            this.dataGridView_patient_list.RowHeadersWidth = 51;
            this.dataGridView_patient_list.RowTemplate.Height = 27;
            this.dataGridView_patient_list.Size = new System.Drawing.Size(575, 133);
            this.dataGridView_patient_list.TabIndex = 2;
            // 
            // sel_col
            // 
            this.sel_col.HeaderText = "选择";
            this.sel_col.MinimumWidth = 6;
            this.sel_col.Name = "sel_col";
            this.sel_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sel_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sel_col.Width = 125;
            // 
            // pat_id_col
            // 
            this.pat_id_col.DataPropertyName = "patient_id";
            this.pat_id_col.HeaderText = "病人编号";
            this.pat_id_col.MinimumWidth = 6;
            this.pat_id_col.Name = "pat_id_col";
            this.pat_id_col.Width = 125;
            // 
            // pat_name_col
            // 
            this.pat_name_col.DataPropertyName = "patient_name";
            this.pat_name_col.HeaderText = "病人姓名";
            this.pat_name_col.MinimumWidth = 6;
            this.pat_name_col.Name = "pat_name_col";
            this.pat_name_col.Width = 125;
            // 
            // patient_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_patient_list);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.selectButton);
            this.Name = "patient_list";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView_patient_list;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_name_col;
    }
}