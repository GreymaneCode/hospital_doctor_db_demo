
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
            this.components = new System.ComponentModel.Container();
            this.skinTextBox_illness = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_need_operation = new CCWin.SkinControl.SkinComboBox();
            this.skinTextBox_advice = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinButton_modify = new CCWin.SkinControl.SkinButton();
            this.skinButton_back = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinTextBox_illness
            // 
            this.skinTextBox_illness.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_illness.DownBack = null;
            this.skinTextBox_illness.Icon = null;
            this.skinTextBox_illness.IconIsButton = false;
            this.skinTextBox_illness.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_illness.IsPasswordChat = '\0';
            this.skinTextBox_illness.IsSystemPasswordChar = false;
            this.skinTextBox_illness.Lines = new string[0];
            this.skinTextBox_illness.Location = new System.Drawing.Point(453, 96);
            this.skinTextBox_illness.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_illness.MaxLength = 32767;
            this.skinTextBox_illness.MinimumSize = new System.Drawing.Size(42, 45);
            this.skinTextBox_illness.MouseBack = null;
            this.skinTextBox_illness.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_illness.Multiline = true;
            this.skinTextBox_illness.Name = "skinTextBox_illness";
            this.skinTextBox_illness.NormlBack = null;
            this.skinTextBox_illness.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.skinTextBox_illness.ReadOnly = false;
            this.skinTextBox_illness.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_illness.Size = new System.Drawing.Size(450, 80);
            // 
            // 
            // 
            this.skinTextBox_illness.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_illness.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_illness.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_illness.SkinTxt.Location = new System.Drawing.Point(8, 8);
            this.skinTextBox_illness.SkinTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skinTextBox_illness.SkinTxt.Multiline = true;
            this.skinTextBox_illness.SkinTxt.Name = "BaseText";
            this.skinTextBox_illness.SkinTxt.Size = new System.Drawing.Size(434, 64);
            this.skinTextBox_illness.SkinTxt.TabIndex = 0;
            this.skinTextBox_illness.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_illness.SkinTxt.WaterText = "";
            this.skinTextBox_illness.TabIndex = 9;
            this.skinTextBox_illness.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_illness.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_illness.WaterText = "";
            this.skinTextBox_illness.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(267, 96);
            this.skinLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(62, 31);
            this.skinLabel1.TabIndex = 10;
            this.skinLabel1.Text = "病情";
            // 
            // skinComboBox_need_operation
            // 
            this.skinComboBox_need_operation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_need_operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_need_operation.FormattingEnabled = true;
            this.skinComboBox_need_operation.Items.AddRange(new object[] {
            "是",
            "否"});
            this.skinComboBox_need_operation.Location = new System.Drawing.Point(453, 266);
            this.skinComboBox_need_operation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skinComboBox_need_operation.Name = "skinComboBox_need_operation";
            this.skinComboBox_need_operation.Size = new System.Drawing.Size(448, 36);
            this.skinComboBox_need_operation.TabIndex = 11;
            this.skinComboBox_need_operation.WaterText = "";
            // 
            // skinTextBox_advice
            // 
            this.skinTextBox_advice.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_advice.DownBack = null;
            this.skinTextBox_advice.Icon = null;
            this.skinTextBox_advice.IconIsButton = false;
            this.skinTextBox_advice.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_advice.IsPasswordChat = '\0';
            this.skinTextBox_advice.IsSystemPasswordChar = false;
            this.skinTextBox_advice.Lines = new string[0];
            this.skinTextBox_advice.Location = new System.Drawing.Point(453, 424);
            this.skinTextBox_advice.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_advice.MaxLength = 32767;
            this.skinTextBox_advice.MinimumSize = new System.Drawing.Size(42, 45);
            this.skinTextBox_advice.MouseBack = null;
            this.skinTextBox_advice.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_advice.Multiline = true;
            this.skinTextBox_advice.Name = "skinTextBox_advice";
            this.skinTextBox_advice.NormlBack = null;
            this.skinTextBox_advice.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.skinTextBox_advice.ReadOnly = false;
            this.skinTextBox_advice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_advice.Size = new System.Drawing.Size(450, 80);
            // 
            // 
            // 
            this.skinTextBox_advice.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_advice.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_advice.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_advice.SkinTxt.Location = new System.Drawing.Point(8, 8);
            this.skinTextBox_advice.SkinTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skinTextBox_advice.SkinTxt.Multiline = true;
            this.skinTextBox_advice.SkinTxt.Name = "BaseText";
            this.skinTextBox_advice.SkinTxt.Size = new System.Drawing.Size(434, 64);
            this.skinTextBox_advice.SkinTxt.TabIndex = 0;
            this.skinTextBox_advice.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_advice.SkinTxt.WaterText = "";
            this.skinTextBox_advice.TabIndex = 12;
            this.skinTextBox_advice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_advice.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_advice.WaterText = "";
            this.skinTextBox_advice.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(267, 266);
            this.skinLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(158, 31);
            this.skinLabel2.TabIndex = 13;
            this.skinLabel2.Text = "是否需要手术";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(267, 424);
            this.skinLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(62, 31);
            this.skinLabel3.TabIndex = 14;
            this.skinLabel3.Text = "医嘱";
            // 
            // skinButton_modify
            // 
            this.skinButton_modify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton_modify.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_modify.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_modify.DownBack = null;
            this.skinButton_modify.Location = new System.Drawing.Point(273, 602);
            this.skinButton_modify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skinButton_modify.MouseBack = null;
            this.skinButton_modify.Name = "skinButton_modify";
            this.skinButton_modify.NormlBack = null;
            this.skinButton_modify.Size = new System.Drawing.Size(332, 142);
            this.skinButton_modify.TabIndex = 15;
            this.skinButton_modify.Text = "提交病情";
            this.skinButton_modify.UseVisualStyleBackColor = false;
            this.skinButton_modify.Click += new System.EventHandler(this.skinButton_modify_Click);
            // 
            // skinButton_back
            // 
            this.skinButton_back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton_back.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_back.DownBack = null;
            this.skinButton_back.Location = new System.Drawing.Point(726, 602);
            this.skinButton_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skinButton_back.MouseBack = null;
            this.skinButton_back.Name = "skinButton_back";
            this.skinButton_back.NormlBack = null;
            this.skinButton_back.Size = new System.Drawing.Size(300, 142);
            this.skinButton_back.TabIndex = 16;
            this.skinButton_back.Text = "返回";
            this.skinButton_back.UseVisualStyleBackColor = false;
            this.skinButton_back.Click += new System.EventHandler(this.skinButton_back_Click);
            // 
            // patient_state_modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 880);
            this.Controls.Add(this.skinButton_back);
            this.Controls.Add(this.skinButton_modify);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinTextBox_advice);
            this.Controls.Add(this.skinComboBox_need_operation);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTextBox_illness);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 880);
            this.MinimumSize = new System.Drawing.Size(1200, 880);
            this.Name = "patient_state_modify";
            this.Padding = new System.Windows.Forms.Padding(30, 96, 30, 32);
            this.Resizable = false;
            this.Text = "新增病情记录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinTextBox skinTextBox_illness;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox skinComboBox_need_operation;
        private CCWin.SkinControl.SkinTextBox skinTextBox_advice;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton skinButton_modify;
        private CCWin.SkinControl.SkinButton skinButton_back;
    }
}