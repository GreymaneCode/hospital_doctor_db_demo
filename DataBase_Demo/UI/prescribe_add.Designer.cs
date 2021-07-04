
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
            this.components = new System.ComponentModel.Container();
            this.medicineNameLabel = new System.Windows.Forms.Label();
            this.skinButton_confirm = new CCWin.SkinControl.SkinButton();
            this.skinButton_back = new CCWin.SkinControl.SkinButton();
            this.skinComboBox_medicine_name = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBox_dose = new CCWin.SkinControl.SkinComboBox();
            this.skinTextBox_unit = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // medicineNameLabel
            // 
            this.medicineNameLabel.AutoSize = true;
            this.medicineNameLabel.Location = new System.Drawing.Point(76, 85);
            this.medicineNameLabel.Name = "medicineNameLabel";
            this.medicineNameLabel.Size = new System.Drawing.Size(80, 18);
            this.medicineNameLabel.TabIndex = 4;
            this.medicineNameLabel.Text = "药品名称";
            // 
            // skinButton_confirm
            // 
            this.skinButton_confirm.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_confirm.DownBack = null;
            this.skinButton_confirm.Location = new System.Drawing.Point(192, 392);
            this.skinButton_confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinButton_confirm.MouseBack = null;
            this.skinButton_confirm.Name = "skinButton_confirm";
            this.skinButton_confirm.NormlBack = null;
            this.skinButton_confirm.Size = new System.Drawing.Size(142, 77);
            this.skinButton_confirm.TabIndex = 11;
            this.skinButton_confirm.Text = "提交";
            this.skinButton_confirm.UseVisualStyleBackColor = false;
            this.skinButton_confirm.Click += new System.EventHandler(this.skinButton_confirm_Click);
            // 
            // skinButton_back
            // 
            this.skinButton_back.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_back.DownBack = null;
            this.skinButton_back.Location = new System.Drawing.Point(512, 392);
            this.skinButton_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinButton_back.MouseBack = null;
            this.skinButton_back.Name = "skinButton_back";
            this.skinButton_back.NormlBack = null;
            this.skinButton_back.Size = new System.Drawing.Size(142, 77);
            this.skinButton_back.TabIndex = 12;
            this.skinButton_back.Text = "返回";
            this.skinButton_back.UseVisualStyleBackColor = false;
            this.skinButton_back.Click += new System.EventHandler(this.skinButton_back_Click);
            // 
            // skinComboBox_medicine_name
            // 
            this.skinComboBox_medicine_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_medicine_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_medicine_name.FormattingEnabled = true;
            this.skinComboBox_medicine_name.Items.AddRange(new object[] {
            "almighty pills"});
            this.skinComboBox_medicine_name.Location = new System.Drawing.Point(223, 163);
            this.skinComboBox_medicine_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinComboBox_medicine_name.Name = "skinComboBox_medicine_name";
            this.skinComboBox_medicine_name.Size = new System.Drawing.Size(445, 29);
            this.skinComboBox_medicine_name.TabIndex = 13;
            this.skinComboBox_medicine_name.WaterText = "";
            // 
            // skinComboBox_dose
            // 
            this.skinComboBox_dose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_dose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_dose.FormattingEnabled = true;
            this.skinComboBox_dose.Items.AddRange(new object[] {
            "盒",
            "片",
            "瓶",
            "支",
            "粒",
            "颗"});
            this.skinComboBox_dose.Location = new System.Drawing.Point(223, 288);
            this.skinComboBox_dose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinComboBox_dose.Name = "skinComboBox_dose";
            this.skinComboBox_dose.Size = new System.Drawing.Size(445, 29);
            this.skinComboBox_dose.TabIndex = 14;
            this.skinComboBox_dose.WaterText = "";
            // 
            // skinTextBox_unit
            // 
            this.skinTextBox_unit.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_unit.DownBack = null;
            this.skinTextBox_unit.Icon = null;
            this.skinTextBox_unit.IconIsButton = false;
            this.skinTextBox_unit.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_unit.IsPasswordChat = '\0';
            this.skinTextBox_unit.IsSystemPasswordChar = false;
            this.skinTextBox_unit.Lines = new string[0];
            this.skinTextBox_unit.Location = new System.Drawing.Point(223, 232);
            this.skinTextBox_unit.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_unit.MaxLength = 4;
            this.skinTextBox_unit.MinimumSize = new System.Drawing.Size(32, 34);
            this.skinTextBox_unit.MouseBack = null;
            this.skinTextBox_unit.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_unit.Multiline = true;
            this.skinTextBox_unit.Name = "skinTextBox_unit";
            this.skinTextBox_unit.NormlBack = null;
            this.skinTextBox_unit.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.skinTextBox_unit.ReadOnly = false;
            this.skinTextBox_unit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_unit.Size = new System.Drawing.Size(446, 35);
            // 
            // 
            // 
            this.skinTextBox_unit.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_unit.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_unit.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_unit.SkinTxt.Location = new System.Drawing.Point(6, 6);
            this.skinTextBox_unit.SkinTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinTextBox_unit.SkinTxt.MaxLength = 4;
            this.skinTextBox_unit.SkinTxt.Multiline = true;
            this.skinTextBox_unit.SkinTxt.Name = "BaseText";
            this.skinTextBox_unit.SkinTxt.Size = new System.Drawing.Size(434, 23);
            this.skinTextBox_unit.SkinTxt.TabIndex = 0;
            this.skinTextBox_unit.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_unit.SkinTxt.WaterText = "";
            this.skinTextBox_unit.TabIndex = 15;
            this.skinTextBox_unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_unit.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_unit.WaterText = "";
            this.skinTextBox_unit.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(116, 163);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(82, 24);
            this.skinLabel1.TabIndex = 16;
            this.skinLabel1.Text = "药物名称";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(116, 232);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(46, 24);
            this.skinLabel2.TabIndex = 17;
            this.skinLabel2.Text = "数量";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(116, 295);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(46, 24);
            this.skinLabel3.TabIndex = 18;
            this.skinLabel3.Text = "单位";
            // 
            // prescribe_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTextBox_unit);
            this.Controls.Add(this.skinComboBox_dose);
            this.Controls.Add(this.skinComboBox_medicine_name);
            this.Controls.Add(this.skinButton_back);
            this.Controls.Add(this.skinButton_confirm);
            this.Controls.Add(this.medicineNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "prescribe_add";
            this.Padding = new System.Windows.Forms.Padding(22, 72, 22, 24);
            this.Resizable = false;
            this.Text = "开具药方";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label medicineNameLabel;
        private CCWin.SkinControl.SkinButton skinButton_confirm;
        private CCWin.SkinControl.SkinButton skinButton_back;
        private CCWin.SkinControl.SkinComboBox skinComboBox_medicine_name;
        private CCWin.SkinControl.SkinComboBox skinComboBox_dose;
        private CCWin.SkinControl.SkinTextBox skinTextBox_unit;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
    }
}