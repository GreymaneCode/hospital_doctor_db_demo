
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinButton_state = new CCWin.SkinControl.SkinButton();
            this.skinButton_display_pre = new CCWin.SkinControl.SkinButton();
            this.skinButton_back = new CCWin.SkinControl.SkinButton();
            this.skinButton_prescribe_add = new CCWin.SkinControl.SkinButton();
            this.skinButton_patient_state_modify = new CCWin.SkinControl.SkinButton();
            this.skinDataGridView_patient_list = new CCWin.SkinControl.SkinDataGridView();
            this.sel_col = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pat_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pat_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinDataGridView_patient_info = new CCWin.SkinControl.SkinDataGridView();
            this.patient_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ill_con_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.need_operation_col = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.advice_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinDataGridView_prescribe = new CCWin.SkinControl.SkinDataGridView();
            this.pre_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_unit_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_dose_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_patient_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_patient_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_prescribe)).BeginInit();
            this.SuspendLayout();
            // 
            // skinButton_state
            // 
            this.skinButton_state.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_state.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_state.DownBack = null;
            this.skinButton_state.Location = new System.Drawing.Point(45, 282);
            this.skinButton_state.MouseBack = null;
            this.skinButton_state.Name = "skinButton_state";
            this.skinButton_state.NormlBack = null;
            this.skinButton_state.Size = new System.Drawing.Size(253, 59);
            this.skinButton_state.TabIndex = 11;
            this.skinButton_state.Text = "展示病情";
            this.skinButton_state.UseVisualStyleBackColor = false;
            this.skinButton_state.Click += new System.EventHandler(this.skinButton_state_Click);
            // 
            // skinButton_display_pre
            // 
            this.skinButton_display_pre.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_display_pre.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_display_pre.DownBack = null;
            this.skinButton_display_pre.Location = new System.Drawing.Point(45, 366);
            this.skinButton_display_pre.MouseBack = null;
            this.skinButton_display_pre.Name = "skinButton_display_pre";
            this.skinButton_display_pre.NormlBack = null;
            this.skinButton_display_pre.Size = new System.Drawing.Size(253, 59);
            this.skinButton_display_pre.TabIndex = 12;
            this.skinButton_display_pre.Text = "展示处方";
            this.skinButton_display_pre.UseVisualStyleBackColor = false;
            this.skinButton_display_pre.Click += new System.EventHandler(this.skinButton_display_pre_Click);
            // 
            // skinButton_back
            // 
            this.skinButton_back.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_back.DownBack = null;
            this.skinButton_back.Location = new System.Drawing.Point(45, 466);
            this.skinButton_back.MouseBack = null;
            this.skinButton_back.Name = "skinButton_back";
            this.skinButton_back.NormlBack = null;
            this.skinButton_back.Size = new System.Drawing.Size(253, 59);
            this.skinButton_back.TabIndex = 13;
            this.skinButton_back.Text = "返回";
            this.skinButton_back.UseVisualStyleBackColor = false;
            this.skinButton_back.Click += new System.EventHandler(this.skinButton_back_Click);
            // 
            // skinButton_prescribe_add
            // 
            this.skinButton_prescribe_add.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_prescribe_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_prescribe_add.DownBack = null;
            this.skinButton_prescribe_add.Location = new System.Drawing.Point(681, 480);
            this.skinButton_prescribe_add.MouseBack = null;
            this.skinButton_prescribe_add.Name = "skinButton_prescribe_add";
            this.skinButton_prescribe_add.NormlBack = null;
            this.skinButton_prescribe_add.Size = new System.Drawing.Size(178, 45);
            this.skinButton_prescribe_add.TabIndex = 14;
            this.skinButton_prescribe_add.Text = "开药";
            this.skinButton_prescribe_add.UseVisualStyleBackColor = false;
            this.skinButton_prescribe_add.Click += new System.EventHandler(this.skinButton_prescribe_add_Click);
            // 
            // skinButton_patient_state_modify
            // 
            this.skinButton_patient_state_modify.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_patient_state_modify.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_patient_state_modify.DownBack = null;
            this.skinButton_patient_state_modify.Location = new System.Drawing.Point(681, 244);
            this.skinButton_patient_state_modify.MouseBack = null;
            this.skinButton_patient_state_modify.Name = "skinButton_patient_state_modify";
            this.skinButton_patient_state_modify.NormlBack = null;
            this.skinButton_patient_state_modify.Size = new System.Drawing.Size(178, 45);
            this.skinButton_patient_state_modify.TabIndex = 15;
            this.skinButton_patient_state_modify.Text = "增加病情信息";
            this.skinButton_patient_state_modify.UseVisualStyleBackColor = false;
            this.skinButton_patient_state_modify.Click += new System.EventHandler(this.skinButton_patient_state_modify_Click);
            // 
            // skinDataGridView_patient_list
            // 
            this.skinDataGridView_patient_list.AllowUserToAddRows = false;
            this.skinDataGridView_patient_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView_patient_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.skinDataGridView_patient_list.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView_patient_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView_patient_list.ColumnFont = null;
            this.skinDataGridView_patient_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView_patient_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skinDataGridView_patient_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView_patient_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sel_col,
            this.pat_id_col,
            this.pat_name_col});
            this.skinDataGridView_patient_list.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView_patient_list.DefaultCellStyle = dataGridViewCellStyle3;
            this.skinDataGridView_patient_list.EnableHeadersVisualStyles = false;
            this.skinDataGridView_patient_list.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView_patient_list.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView_patient_list.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_patient_list.Location = new System.Drawing.Point(45, 63);
            this.skinDataGridView_patient_list.Name = "skinDataGridView_patient_list";
            this.skinDataGridView_patient_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView_patient_list.RowHeadersVisible = false;
            this.skinDataGridView_patient_list.RowHeadersWidth = 51;
            this.skinDataGridView_patient_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_patient_list.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridView_patient_list.RowTemplate.Height = 23;
            this.skinDataGridView_patient_list.Size = new System.Drawing.Size(253, 164);
            this.skinDataGridView_patient_list.TabIndex = 16;
            this.skinDataGridView_patient_list.TitleBack = null;
            this.skinDataGridView_patient_list.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView_patient_list.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // sel_col
            // 
            this.sel_col.HeaderText = "选择";
            this.sel_col.MinimumWidth = 6;
            this.sel_col.Name = "sel_col";
            this.sel_col.Width = 50;
            // 
            // pat_id_col
            // 
            this.pat_id_col.DataPropertyName = "patient_id";
            this.pat_id_col.HeaderText = "病人编号";
            this.pat_id_col.MinimumWidth = 6;
            this.pat_id_col.Name = "pat_id_col";
            this.pat_id_col.ReadOnly = true;
            this.pat_id_col.Width = 125;
            // 
            // pat_name_col
            // 
            this.pat_name_col.DataPropertyName = "patient_name";
            this.pat_name_col.HeaderText = "病人姓名";
            this.pat_name_col.MinimumWidth = 6;
            this.pat_name_col.Name = "pat_name_col";
            this.pat_name_col.ReadOnly = true;
            this.pat_name_col.Width = 125;
            // 
            // skinDataGridView_patient_info
            // 
            this.skinDataGridView_patient_info.AllowUserToAddRows = false;
            this.skinDataGridView_patient_info.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView_patient_info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.skinDataGridView_patient_info.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView_patient_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView_patient_info.ColumnFont = null;
            this.skinDataGridView_patient_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView_patient_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.skinDataGridView_patient_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView_patient_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patient_id_col,
            this.patient_name_col,
            this.state_time_col,
            this.ill_con_col,
            this.need_operation_col,
            this.advice_col});
            this.skinDataGridView_patient_info.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView_patient_info.DefaultCellStyle = dataGridViewCellStyle7;
            this.skinDataGridView_patient_info.EnableHeadersVisualStyles = false;
            this.skinDataGridView_patient_info.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView_patient_info.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView_patient_info.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_patient_info.Location = new System.Drawing.Point(351, 63);
            this.skinDataGridView_patient_info.Name = "skinDataGridView_patient_info";
            this.skinDataGridView_patient_info.ReadOnly = true;
            this.skinDataGridView_patient_info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView_patient_info.RowHeadersVisible = false;
            this.skinDataGridView_patient_info.RowHeadersWidth = 51;
            this.skinDataGridView_patient_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_patient_info.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.skinDataGridView_patient_info.RowTemplate.Height = 23;
            this.skinDataGridView_patient_info.Size = new System.Drawing.Size(900, 175);
            this.skinDataGridView_patient_info.TabIndex = 17;
            this.skinDataGridView_patient_info.TitleBack = null;
            this.skinDataGridView_patient_info.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView_patient_info.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // patient_id_col
            // 
            this.patient_id_col.DataPropertyName = "patient_id";
            this.patient_id_col.HeaderText = "病人编号";
            this.patient_id_col.MinimumWidth = 6;
            this.patient_id_col.Name = "patient_id_col";
            this.patient_id_col.ReadOnly = true;
            this.patient_id_col.Width = 125;
            // 
            // patient_name_col
            // 
            this.patient_name_col.DataPropertyName = "patient_name";
            this.patient_name_col.HeaderText = "病人姓名";
            this.patient_name_col.MinimumWidth = 6;
            this.patient_name_col.Name = "patient_name_col";
            this.patient_name_col.ReadOnly = true;
            this.patient_name_col.Width = 125;
            // 
            // state_time_col
            // 
            this.state_time_col.DataPropertyName = "state_time";
            this.state_time_col.HeaderText = "更新时间";
            this.state_time_col.MinimumWidth = 6;
            this.state_time_col.Name = "state_time_col";
            this.state_time_col.ReadOnly = true;
            this.state_time_col.Width = 125;
            // 
            // ill_con_col
            // 
            this.ill_con_col.DataPropertyName = "illness_condition";
            this.ill_con_col.HeaderText = "病情";
            this.ill_con_col.MinimumWidth = 6;
            this.ill_con_col.Name = "ill_con_col";
            this.ill_con_col.ReadOnly = true;
            this.ill_con_col.Width = 125;
            // 
            // need_operation_col
            // 
            this.need_operation_col.DataPropertyName = "need_operation";
            this.need_operation_col.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.need_operation_col.HeaderText = "是否需要手术";
            this.need_operation_col.Items.AddRange(new object[] {
            "是",
            "否"});
            this.need_operation_col.MinimumWidth = 6;
            this.need_operation_col.Name = "need_operation_col";
            this.need_operation_col.ReadOnly = true;
            this.need_operation_col.Width = 125;
            // 
            // advice_col
            // 
            this.advice_col.DataPropertyName = "advice";
            this.advice_col.HeaderText = "医嘱";
            this.advice_col.MinimumWidth = 6;
            this.advice_col.Name = "advice_col";
            this.advice_col.ReadOnly = true;
            this.advice_col.Width = 125;
            // 
            // skinDataGridView_prescribe
            // 
            this.skinDataGridView_prescribe.AllowUserToAddRows = false;
            this.skinDataGridView_prescribe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView_prescribe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.skinDataGridView_prescribe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView_prescribe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView_prescribe.ColumnFont = null;
            this.skinDataGridView_prescribe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView_prescribe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.skinDataGridView_prescribe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView_prescribe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pre_id_col,
            this.pid_id_col,
            this.pname_col,
            this.med_name_col,
            this.med_id_col,
            this.med_unit_col,
            this.med_dose_col,
            this.time_col});
            this.skinDataGridView_prescribe.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView_prescribe.DefaultCellStyle = dataGridViewCellStyle11;
            this.skinDataGridView_prescribe.EnableHeadersVisualStyles = false;
            this.skinDataGridView_prescribe.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView_prescribe.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView_prescribe.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_prescribe.Location = new System.Drawing.Point(351, 299);
            this.skinDataGridView_prescribe.Name = "skinDataGridView_prescribe";
            this.skinDataGridView_prescribe.ReadOnly = true;
            this.skinDataGridView_prescribe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView_prescribe.RowHeadersVisible = false;
            this.skinDataGridView_prescribe.RowHeadersWidth = 51;
            this.skinDataGridView_prescribe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_prescribe.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.skinDataGridView_prescribe.RowTemplate.Height = 23;
            this.skinDataGridView_prescribe.Size = new System.Drawing.Size(900, 175);
            this.skinDataGridView_prescribe.TabIndex = 18;
            this.skinDataGridView_prescribe.TitleBack = null;
            this.skinDataGridView_prescribe.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView_prescribe.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // pre_id_col
            // 
            this.pre_id_col.DataPropertyName = "prescribe_id";
            this.pre_id_col.HeaderText = "处方编号";
            this.pre_id_col.MinimumWidth = 6;
            this.pre_id_col.Name = "pre_id_col";
            this.pre_id_col.ReadOnly = true;
            this.pre_id_col.Width = 125;
            // 
            // pid_id_col
            // 
            this.pid_id_col.DataPropertyName = "patient_id";
            this.pid_id_col.HeaderText = "病人编号";
            this.pid_id_col.MinimumWidth = 6;
            this.pid_id_col.Name = "pid_id_col";
            this.pid_id_col.ReadOnly = true;
            this.pid_id_col.Width = 125;
            // 
            // pname_col
            // 
            this.pname_col.DataPropertyName = "patient_name";
            this.pname_col.HeaderText = "病人姓名";
            this.pname_col.MinimumWidth = 6;
            this.pname_col.Name = "pname_col";
            this.pname_col.ReadOnly = true;
            this.pname_col.Width = 125;
            // 
            // med_name_col
            // 
            this.med_name_col.DataPropertyName = "medicine_name";
            this.med_name_col.HeaderText = "药物名称";
            this.med_name_col.MinimumWidth = 6;
            this.med_name_col.Name = "med_name_col";
            this.med_name_col.ReadOnly = true;
            this.med_name_col.Width = 125;
            // 
            // med_id_col
            // 
            this.med_id_col.DataPropertyName = "medicine_id";
            this.med_id_col.HeaderText = "药物编号";
            this.med_id_col.MinimumWidth = 6;
            this.med_id_col.Name = "med_id_col";
            this.med_id_col.ReadOnly = true;
            this.med_id_col.Width = 125;
            // 
            // med_unit_col
            // 
            this.med_unit_col.DataPropertyName = "unit";
            this.med_unit_col.HeaderText = "药物数量";
            this.med_unit_col.MinimumWidth = 6;
            this.med_unit_col.Name = "med_unit_col";
            this.med_unit_col.ReadOnly = true;
            this.med_unit_col.Width = 125;
            // 
            // med_dose_col
            // 
            this.med_dose_col.DataPropertyName = "dose";
            this.med_dose_col.HeaderText = "药物单位";
            this.med_dose_col.MinimumWidth = 6;
            this.med_dose_col.Name = "med_dose_col";
            this.med_dose_col.ReadOnly = true;
            this.med_dose_col.Width = 125;
            // 
            // time_col
            // 
            this.time_col.DataPropertyName = "prescribe_time";
            this.time_col.HeaderText = "开药时间";
            this.time_col.MinimumWidth = 6;
            this.time_col.Name = "time_col";
            this.time_col.ReadOnly = true;
            this.time_col.Width = 125;
            // 
            // patient_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 548);
            this.Controls.Add(this.skinDataGridView_prescribe);
            this.Controls.Add(this.skinDataGridView_patient_info);
            this.Controls.Add(this.skinDataGridView_patient_list);
            this.Controls.Add(this.skinButton_patient_state_modify);
            this.Controls.Add(this.skinButton_prescribe_add);
            this.Controls.Add(this.skinButton_back);
            this.Controls.Add(this.skinButton_display_pre);
            this.Controls.Add(this.skinButton_state);
            this.Name = "patient_list";
            this.Resizable = false;
            this.Text = "病人列表";
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_patient_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_patient_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_prescribe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton skinButton_state;
        private CCWin.SkinControl.SkinButton skinButton_display_pre;
        private CCWin.SkinControl.SkinButton skinButton_back;
        private CCWin.SkinControl.SkinButton skinButton_prescribe_add;
        private CCWin.SkinControl.SkinButton skinButton_patient_state_modify;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView_patient_list;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_name_col;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView_patient_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_time_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ill_con_col;
        private System.Windows.Forms.DataGridViewComboBoxColumn need_operation_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn advice_col;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView_prescribe;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_unit_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_dose_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_col;
    }
}