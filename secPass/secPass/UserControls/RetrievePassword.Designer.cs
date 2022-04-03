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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCreds = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblMastPass = new System.Windows.Forms.Label();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblRetrievePass = new System.Windows.Forms.Label();
            this.siticonePanel6 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.txtName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtConfPass = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtPass = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblCredTitle = new System.Windows.Forms.Label();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.credentialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreds)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.siticonePanel6.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credentialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCreds
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCreds.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCreds.AutoGenerateColumns = false;
            this.dgvCreds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.dgvCreds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCreds.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCreds.ColumnHeadersHeight = 27;
            this.dgvCreds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvCreds.DataSource = this.credentialBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreds.DefaultCellStyle = dataGridViewCellStyle6;
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
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.siticonePanel2.BorderRadius = 5;
            this.siticonePanel2.BorderThickness = 2;
            this.siticonePanel2.Controls.Add(this.lblMastPass);
            this.siticonePanel2.Controls.Add(this.siticoneTextBox1);
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
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Animated = true;
            this.siticoneTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTextBox1.BorderColor = System.Drawing.Color.Black;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(196)))), ((int)(((byte)(218)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.White;
            this.siticoneTextBox1.FocusedState.FillColor = System.Drawing.Color.White;
            this.siticoneTextBox1.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.siticoneTextBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.HoverState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Location = new System.Drawing.Point(16, 38);
            this.siticoneTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '*';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Size = new System.Drawing.Size(165, 29);
            this.siticoneTextBox1.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.siticoneTextBox1.TabIndex = 3;
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
            this.siticonePanel6.Controls.Add(this.txtName);
            this.siticonePanel6.Controls.Add(this.lblPass);
            this.siticonePanel6.Controls.Add(this.txtConfPass);
            this.siticonePanel6.Controls.Add(this.txtPass);
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
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtName.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtName.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(160, 39);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '*';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(165, 29);
            this.txtName.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 8;
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
            // txtConfPass
            // 
            this.txtConfPass.Animated = true;
            this.txtConfPass.BackColor = System.Drawing.Color.Transparent;
            this.txtConfPass.BorderThickness = 0;
            this.txtConfPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfPass.DefaultText = "";
            this.txtConfPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfPass.DisabledState.Parent = this.txtConfPass;
            this.txtConfPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.txtConfPass.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtConfPass.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtConfPass.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtConfPass.FocusedState.Parent = this.txtConfPass;
            this.txtConfPass.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtConfPass.ForeColor = System.Drawing.Color.White;
            this.txtConfPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfPass.HoverState.Parent = this.txtConfPass;
            this.txtConfPass.Location = new System.Drawing.Point(160, 113);
            this.txtConfPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '*';
            this.txtConfPass.PlaceholderText = "";
            this.txtConfPass.SelectedText = "";
            this.txtConfPass.ShadowDecoration.Parent = this.txtConfPass;
            this.txtConfPass.Size = new System.Drawing.Size(165, 29);
            this.txtConfPass.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtConfPass.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Animated = true;
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BorderThickness = 0;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.Parent = this.txtPass;
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtPass.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtPass.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtPass.FocusedState.Parent = this.txtPass;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.HoverState.Parent = this.txtPass;
            this.txtPass.Location = new System.Drawing.Point(160, 76);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Parent = this.txtPass;
            this.txtPass.Size = new System.Drawing.Size(165, 29);
            this.txtPass.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtPass.TabIndex = 10;
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
            // siticoneButton2
            // 
            this.siticoneButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BorderColor = System.Drawing.Color.White;
            this.siticoneButton2.BorderThickness = 1;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.BorderColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.siticoneButton2.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(643, 354);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.PressedColor = System.Drawing.Color.White;
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton2.TabIndex = 14;
            this.siticoneButton2.Text = "Save";
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.BorderColor = System.Drawing.Color.White;
            this.siticoneButton3.BorderThickness = 1;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.DisabledState.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoverState.BorderColor = System.Drawing.Color.Red;
            this.siticoneButton3.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.HoverState.ForeColor = System.Drawing.Color.Red;
            this.siticoneButton3.HoverState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(670, 296);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(125, 35);
            this.siticoneButton3.TabIndex = 15;
            this.siticoneButton3.Text = "Delete";
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.BorderColor = System.Drawing.Color.White;
            this.siticoneButton4.BorderThickness = 1;
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton4.DisabledState.Parent = this.siticoneButton4;
            this.siticoneButton4.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoverState.BorderColor = System.Drawing.Color.White;
            this.siticoneButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.siticoneButton4.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoverState.Parent = this.siticoneButton4;
            this.siticoneButton4.Location = new System.Drawing.Point(656, 88);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(141, 35);
            this.siticoneButton4.TabIndex = 16;
            this.siticoneButton4.Text = "Display";
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
            // credentialBindingSource
            // 
            this.credentialBindingSource.DataSource = typeof(secPass.Credential);
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
            // RetrievePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticonePanel6);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticoneButton4);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.lblCredTitle);
            this.Controls.Add(this.lblRetrievePass);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.dgvCreds);
            this.Name = "RetrievePassword";
            this.Size = new System.Drawing.Size(825, 402);
            this.Load += new System.EventHandler(this.RetrievePassword_Load);
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
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private System.Windows.Forms.Label lblRetrievePass;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblConfPass;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtName;
        private System.Windows.Forms.Label lblPass;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtConfPass;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPass;
        private System.Windows.Forms.Label lblCredTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.BindingSource credentialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}
