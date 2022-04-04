namespace secPass.UserControls
{
    partial class RetrievePassword
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

        #region Component Designer generated code

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
            this.dgvCreds = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblMastPass = new System.Windows.Forms.Label();
            this.txtUpdateMastP = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblRetrievePass = new System.Windows.Forms.Label();
            this.siticonePanel6 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.txtUpdateName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUpdateConfPass = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtUpdatePass = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblCredTitle = new System.Windows.Forms.Label();
            this.btnSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnDisplay = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credentialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreds)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.siticonePanel6.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credentialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCreds
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCreds.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCreds.AutoGenerateColumns = false;
            this.dgvCreds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.dgvCreds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCreds.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCreds.ColumnHeadersHeight = 27;
            this.dgvCreds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvCreds.DataSource = this.credentialBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreds.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCreds.EnableHeadersVisualStyles = false;
            this.dgvCreds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCreds.Location = new System.Drawing.Point(0, 85);
            this.dgvCreds.Name = "dgvCreds";
            this.dgvCreds.RowHeadersVisible = false;
            this.dgvCreds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreds.Size = new System.Drawing.Size(274, 317);
            this.dgvCreds.TabIndex = 0;
            this.dgvCreds.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvCreds.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCreds.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCreds.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCreds.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCreds.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCreds.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.dgvCreds.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCreds.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvCreds.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvCreds.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCreds.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCreds.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCreds.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvCreds.ThemeStyle.ReadOnly = false;
            this.dgvCreds.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvCreds.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCreds.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCreds.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCreds.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCreds.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvCreds.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCreds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCreds_CellClick);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.siticonePanel2.BorderRadius = 5;
            this.siticonePanel2.BorderThickness = 2;
            this.siticonePanel2.Controls.Add(this.lblMastPass);
            this.siticonePanel2.Controls.Add(this.txtUpdateMastP);
            this.siticonePanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(196)))), ((int)(((byte)(218)))));
            this.siticonePanel2.Location = new System.Drawing.Point(627, 3);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(197, 79);
            this.siticonePanel2.TabIndex = 6;
            // 
            // lblMastPass
            // 
            this.lblMastPass.AutoSize = true;
            this.lblMastPass.BackColor = System.Drawing.Color.Transparent;
            this.lblMastPass.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMastPass.ForeColor = System.Drawing.Color.Black;
            this.lblMastPass.Location = new System.Drawing.Point(16, 9);
            this.lblMastPass.Name = "lblMastPass";
            this.lblMastPass.Size = new System.Drawing.Size(168, 18);
            this.lblMastPass.TabIndex = 7;
            this.lblMastPass.Text = "Master Password:";
            // 
            // txtUpdateMastP
            // 
            this.txtUpdateMastP.Animated = true;
            this.txtUpdateMastP.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateMastP.BorderColor = System.Drawing.Color.Black;
            this.txtUpdateMastP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateMastP.DefaultText = "";
            this.txtUpdateMastP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateMastP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateMastP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateMastP.DisabledState.Parent = this.txtUpdateMastP;
            this.txtUpdateMastP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateMastP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(196)))), ((int)(((byte)(218)))));
            this.txtUpdateMastP.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtUpdateMastP.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtUpdateMastP.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtUpdateMastP.FocusedState.Parent = this.txtUpdateMastP;
            this.txtUpdateMastP.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtUpdateMastP.ForeColor = System.Drawing.Color.White;
            this.txtUpdateMastP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateMastP.HoverState.Parent = this.txtUpdateMastP;
            this.txtUpdateMastP.Location = new System.Drawing.Point(16, 38);
            this.txtUpdateMastP.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateMastP.Name = "txtUpdateMastP";
            this.txtUpdateMastP.PasswordChar = '*';
            this.txtUpdateMastP.PlaceholderText = "";
            this.txtUpdateMastP.SelectedText = "";
            this.txtUpdateMastP.ShadowDecoration.Parent = this.txtUpdateMastP;
            this.txtUpdateMastP.Size = new System.Drawing.Size(165, 29);
            this.txtUpdateMastP.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateMastP.TabIndex = 3;
            this.txtUpdateMastP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRetrievePass
            // 
            this.lblRetrievePass.AutoSize = true;
            this.lblRetrievePass.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetrievePass.ForeColor = System.Drawing.Color.LightGray;
            this.lblRetrievePass.Location = new System.Drawing.Point(3, -5);
            this.lblRetrievePass.Name = "lblRetrievePass";
            this.lblRetrievePass.Size = new System.Drawing.Size(404, 35);
            this.lblRetrievePass.TabIndex = 7;
            this.lblRetrievePass.Text = "View and edit your credentials";
            // 
            // siticonePanel6
            // 
            this.siticonePanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.siticonePanel6.BorderRadius = 15;
            this.siticonePanel6.BorderThickness = 2;
            this.siticonePanel6.Controls.Add(this.siticoneButton1);
            this.siticonePanel6.Controls.Add(this.label2);
            this.siticonePanel6.Controls.Add(this.lblName);
            this.siticonePanel6.Controls.Add(this.lblConfPass);
            this.siticonePanel6.Controls.Add(this.txtUpdateName);
            this.siticonePanel6.Controls.Add(this.lblPass);
            this.siticonePanel6.Controls.Add(this.txtUpdateConfPass);
            this.siticonePanel6.Controls.Add(this.txtUpdatePass);
            this.siticonePanel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.siticonePanel6.Location = new System.Drawing.Point(283, 245);
            this.siticonePanel6.Name = "siticonePanel6";
            this.siticonePanel6.ShadowDecoration.Parent = this.siticonePanel6;
            this.siticonePanel6.Size = new System.Drawing.Size(338, 157);
            this.siticonePanel6.TabIndex = 14;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton1.HoverState.BorderColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.siticoneButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(21, 167);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton1.TabIndex = 13;
            this.siticoneButton1.Text = "Save";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account Credentials";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(29, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 21);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Account Name:";
            // 
            // lblConfPass
            // 
            this.lblConfPass.AutoSize = true;
            this.lblConfPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPass.ForeColor = System.Drawing.Color.Black;
            this.lblConfPass.Location = new System.Drawing.Point(4, 116);
            this.lblConfPass.Name = "lblConfPass";
            this.lblConfPass.Size = new System.Drawing.Size(153, 21);
            this.lblConfPass.TabIndex = 12;
            this.lblConfPass.Text = "Confirm Password:";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Animated = true;
            this.txtUpdateName.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateName.BorderThickness = 0;
            this.txtUpdateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateName.DefaultText = "";
            this.txtUpdateName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateName.DisabledState.Parent = this.txtUpdateName;
            this.txtUpdateName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.txtUpdateName.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtUpdateName.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtUpdateName.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtUpdateName.FocusedState.Parent = this.txtUpdateName;
            this.txtUpdateName.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtUpdateName.ForeColor = System.Drawing.Color.White;
            this.txtUpdateName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateName.HoverState.Parent = this.txtUpdateName;
            this.txtUpdateName.Location = new System.Drawing.Point(160, 39);
            this.txtUpdateName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.PasswordChar = '\0';
            this.txtUpdateName.PlaceholderText = "";
            this.txtUpdateName.SelectedText = "";
            this.txtUpdateName.ShadowDecoration.Parent = this.txtUpdateName;
            this.txtUpdateName.Size = new System.Drawing.Size(165, 29);
            this.txtUpdateName.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateName.TabIndex = 8;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Black;
            this.lblPass.Location = new System.Drawing.Point(71, 79);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(86, 21);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Password:";
            // 
            // txtUpdateConfPass
            // 
            this.txtUpdateConfPass.Animated = true;
            this.txtUpdateConfPass.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateConfPass.BorderThickness = 0;
            this.txtUpdateConfPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateConfPass.DefaultText = "";
            this.txtUpdateConfPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateConfPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateConfPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateConfPass.DisabledState.Parent = this.txtUpdateConfPass;
            this.txtUpdateConfPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateConfPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.txtUpdateConfPass.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtUpdateConfPass.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtUpdateConfPass.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtUpdateConfPass.FocusedState.Parent = this.txtUpdateConfPass;
            this.txtUpdateConfPass.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtUpdateConfPass.ForeColor = System.Drawing.Color.White;
            this.txtUpdateConfPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateConfPass.HoverState.Parent = this.txtUpdateConfPass;
            this.txtUpdateConfPass.Location = new System.Drawing.Point(160, 113);
            this.txtUpdateConfPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateConfPass.Name = "txtUpdateConfPass";
            this.txtUpdateConfPass.PasswordChar = '\0';
            this.txtUpdateConfPass.PlaceholderText = "";
            this.txtUpdateConfPass.SelectedText = "";
            this.txtUpdateConfPass.ShadowDecoration.Parent = this.txtUpdateConfPass;
            this.txtUpdateConfPass.Size = new System.Drawing.Size(165, 29);
            this.txtUpdateConfPass.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdateConfPass.TabIndex = 9;
            // 
            // txtUpdatePass
            // 
            this.txtUpdatePass.Animated = true;
            this.txtUpdatePass.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdatePass.BorderThickness = 0;
            this.txtUpdatePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdatePass.DefaultText = "";
            this.txtUpdatePass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdatePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdatePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdatePass.DisabledState.Parent = this.txtUpdatePass;
            this.txtUpdatePass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdatePass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.txtUpdatePass.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtUpdatePass.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtUpdatePass.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtUpdatePass.FocusedState.Parent = this.txtUpdatePass;
            this.txtUpdatePass.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtUpdatePass.ForeColor = System.Drawing.Color.White;
            this.txtUpdatePass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdatePass.HoverState.Parent = this.txtUpdatePass;
            this.txtUpdatePass.Location = new System.Drawing.Point(160, 76);
            this.txtUpdatePass.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdatePass.Name = "txtUpdatePass";
            this.txtUpdatePass.PasswordChar = '\0';
            this.txtUpdatePass.PlaceholderText = "";
            this.txtUpdatePass.SelectedText = "";
            this.txtUpdatePass.ShadowDecoration.Parent = this.txtUpdatePass;
            this.txtUpdatePass.Size = new System.Drawing.Size(165, 29);
            this.txtUpdatePass.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtUpdatePass.TabIndex = 10;
            // 
            // lblCredTitle
            // 
            this.lblCredTitle.AutoSize = true;
            this.lblCredTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCredTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblCredTitle.Location = new System.Drawing.Point(28, 53);
            this.lblCredTitle.Name = "lblCredTitle";
            this.lblCredTitle.Size = new System.Drawing.Size(216, 28);
            this.lblCredTitle.TabIndex = 14;
            this.lblCredTitle.Text = "Account Credentials";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderThickness = 1;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(643, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.White;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.White;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(670, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Transparent;
            this.btnDisplay.BorderColor = System.Drawing.Color.White;
            this.btnDisplay.BorderThickness = 1;
            this.btnDisplay.CheckedState.Parent = this.btnDisplay;
            this.btnDisplay.CustomImages.Parent = this.btnDisplay;
            this.btnDisplay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisplay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisplay.DisabledState.Parent = this.btnDisplay;
            this.btnDisplay.FillColor = System.Drawing.Color.Transparent;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDisplay.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.btnDisplay.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.HoverState.Parent = this.btnDisplay;
            this.btnDisplay.Location = new System.Drawing.Point(656, 88);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDisplay.ShadowDecoration.Parent = this.btnDisplay;
            this.btnDisplay.Size = new System.Drawing.Size(141, 35);
            this.btnDisplay.TabIndex = 16;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderColor = System.Drawing.Color.White;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.label5);
            this.siticonePanel1.Location = new System.Drawing.Point(280, 74);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(341, 165);
            this.siticonePanel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 153);
            this.label5.TabIndex = 17;
            this.label5.Text = "1. Enter master password\r\n2. Select the account wish to view/edit from the table\r" +
    "\n3. Click the display button to show the account credentials\r\n4. To edit, enter " +
    "the new information and click save\r\n";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(651, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 77);
            this.label1.TabIndex = 18;
            this.label1.Text = "To delete, select an account and press delete";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // credentialBindingSource
            // 
            this.credentialBindingSource.DataSource = typeof(secPass.Credential);
            // 
            // RetrievePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticonePanel6);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCredTitle);
            this.Controls.Add(this.lblRetrievePass);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.dgvCreds);
            this.Name = "RetrievePassword";
            this.Size = new System.Drawing.Size(825, 402);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreds)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.siticonePanel6.ResumeLayout(false);
            this.siticonePanel6.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.credentialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvCreds;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label lblMastPass;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUpdateMastP;
        private System.Windows.Forms.Label lblRetrievePass;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblConfPass;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUpdateName;
        private System.Windows.Forms.Label lblPass;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUpdateConfPass;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUpdatePass;
        private System.Windows.Forms.Label lblCredTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSave;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDelete;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDisplay;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.BindingSource credentialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}
