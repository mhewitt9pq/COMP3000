namespace secPass
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMasterPass = new System.Windows.Forms.TextBox();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblEncryptedPass = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStoreNewPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblEnterPass = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHomeInfo1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblUpdateMastPass = new System.Windows.Forms.Label();
            this.txtUpdateMastPass = new System.Windows.Forms.TextBox();
            this.lblUpdateConfPass = new System.Windows.Forms.Label();
            this.txtUpdateConfPass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdateDisplayData = new System.Windows.Forms.Button();
            this.lblUpdatePass = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.txtUpdatePass = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.btnGetPass = new System.Windows.Forms.Button();
            this.dgCreds = new System.Windows.Forms.DataGridView();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credentialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeneratePass = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblRandPass = new System.Windows.Forms.Label();
            this.lblPassGenInfo = new System.Windows.Forms.Label();
            this.lblPassGenerator = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCreds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtMasterPass);
            this.tabPage2.Controls.Add(this.lblDecrypted);
            this.tabPage2.Controls.Add(this.btnDecrypt);
            this.tabPage2.Controls.Add(this.lblEncryptedPass);
            this.tabPage2.Controls.Add(this.btnSubmit);
            this.tabPage2.Controls.Add(this.lblStoreNewPass);
            this.tabPage2.Controls.Add(this.txtPass);
            this.tabPage2.Controls.Add(this.lblEnterPass);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.txtConfPass);
            this.tabPage2.Controls.Add(this.lblConfPass);
            this.tabPage2.Controls.Add(this.lblEnterName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(787, 420);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Store Password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(597, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "MasterPass:";
            // 
            // txtMasterPass
            // 
            this.txtMasterPass.Location = new System.Drawing.Point(562, 109);
            this.txtMasterPass.Name = "txtMasterPass";
            this.txtMasterPass.Size = new System.Drawing.Size(100, 20);
            this.txtMasterPass.TabIndex = 21;
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Location = new System.Drawing.Point(594, 224);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(150, 13);
            this.lblDecrypted.TabIndex = 20;
            this.lblDecrypted.Text = "Decrypted pass will show here";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(638, 162);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 19;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblEncryptedPass
            // 
            this.lblEncryptedPass.AutoSize = true;
            this.lblEncryptedPass.Location = new System.Drawing.Point(584, 288);
            this.lblEncryptedPass.Name = "lblEncryptedPass";
            this.lblEncryptedPass.Size = new System.Drawing.Size(129, 13);
            this.lblEncryptedPass.TabIndex = 17;
            this.lblEncryptedPass.Text = "Encryped text shows here";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(391, 335);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 33);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblStoreNewPass
            // 
            this.lblStoreNewPass.AutoSize = true;
            this.lblStoreNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreNewPass.Location = new System.Drawing.Point(250, 57);
            this.lblStoreNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreNewPass.Name = "lblStoreNewPass";
            this.lblStoreNewPass.Size = new System.Drawing.Size(302, 31);
            this.lblStoreNewPass.TabIndex = 15;
            this.lblStoreNewPass.Text = "Store a new password";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(347, 219);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.MinimumSize = new System.Drawing.Size(148, 38);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(180, 32);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // lblEnterPass
            // 
            this.lblEnterPass.AutoSize = true;
            this.lblEnterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPass.Location = new System.Drawing.Point(104, 224);
            this.lblEnterPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterPass.Name = "lblEnterPass";
            this.lblEnterPass.Size = new System.Drawing.Size(232, 25);
            this.lblEnterPass.TabIndex = 14;
            this.lblEnterPass.Text = "Please enter a password:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(347, 153);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MinimumSize = new System.Drawing.Size(148, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 32);
            this.txtName.TabIndex = 9;
            // 
            // txtConfPass
            // 
            this.txtConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPass.Location = new System.Drawing.Point(347, 269);
            this.txtConfPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfPass.MinimumSize = new System.Drawing.Size(148, 38);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '*';
            this.txtConfPass.Size = new System.Drawing.Size(180, 32);
            this.txtConfPass.TabIndex = 12;
            this.txtConfPass.UseSystemPasswordChar = true;
            // 
            // lblConfPass
            // 
            this.lblConfPass.AutoSize = true;
            this.lblConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPass.Location = new System.Drawing.Point(55, 270);
            this.lblConfPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfPass.Name = "lblConfPass";
            this.lblConfPass.Size = new System.Drawing.Size(278, 25);
            this.lblConfPass.TabIndex = 13;
            this.lblConfPass.Text = "Please confirm your password:";
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(141, 155);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(197, 25);
            this.lblEnterName.TabIndex = 10;
            this.lblEnterName.Text = "Please enter a name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lblHomeInfo1);
            this.tabPage3.Controls.Add(this.lblDescription);
            this.tabPage3.Controls.Add(this.lblWelcome);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(787, 420);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Home";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 123);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(285, 245);
            this.label1.TabIndex = 3;
            this.label1.Text = "Security information and information about the application";
            // 
            // lblHomeInfo1
            // 
            this.lblHomeInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHomeInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeInfo1.Location = new System.Drawing.Point(23, 123);
            this.lblHomeInfo1.Name = "lblHomeInfo1";
            this.lblHomeInfo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHomeInfo1.Size = new System.Drawing.Size(285, 245);
            this.lblHomeInfo1.TabIndex = 2;
            this.lblHomeInfo1.Text = "Security information and information about the application";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(240, 85);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(278, 18);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Your personal secure credential manager";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(225, 44);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(310, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to SecurePass";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblUpdateMastPass);
            this.tabPage1.Controls.Add(this.txtUpdateMastPass);
            this.tabPage1.Controls.Add(this.lblUpdateConfPass);
            this.tabPage1.Controls.Add(this.txtUpdateConfPass);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnUpdateDisplayData);
            this.tabPage1.Controls.Add(this.lblUpdatePass);
            this.tabPage1.Controls.Add(this.lblUpdateName);
            this.tabPage1.Controls.Add(this.txtUpdatePass);
            this.tabPage1.Controls.Add(this.txtUpdateName);
            this.tabPage1.Controls.Add(this.btnGetPass);
            this.tabPage1.Controls.Add(this.dgCreds);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 420);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Retrieve Password";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblUpdateMastPass
            // 
            this.lblUpdateMastPass.AutoSize = true;
            this.lblUpdateMastPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMastPass.Location = new System.Drawing.Point(75, 255);
            this.lblUpdateMastPass.Name = "lblUpdateMastPass";
            this.lblUpdateMastPass.Size = new System.Drawing.Size(167, 25);
            this.lblUpdateMastPass.TabIndex = 13;
            this.lblUpdateMastPass.Text = "Master password:";
            // 
            // txtUpdateMastPass
            // 
            this.txtUpdateMastPass.Location = new System.Drawing.Point(248, 255);
            this.txtUpdateMastPass.Multiline = true;
            this.txtUpdateMastPass.Name = "txtUpdateMastPass";
            this.txtUpdateMastPass.Size = new System.Drawing.Size(150, 30);
            this.txtUpdateMastPass.TabIndex = 12;
            // 
            // lblUpdateConfPass
            // 
            this.lblUpdateConfPass.AutoSize = true;
            this.lblUpdateConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateConfPass.Location = new System.Drawing.Point(67, 366);
            this.lblUpdateConfPass.Name = "lblUpdateConfPass";
            this.lblUpdateConfPass.Size = new System.Drawing.Size(175, 25);
            this.lblUpdateConfPass.TabIndex = 11;
            this.lblUpdateConfPass.Text = "Confirm password:";
            // 
            // txtUpdateConfPass
            // 
            this.txtUpdateConfPass.Location = new System.Drawing.Point(248, 363);
            this.txtUpdateConfPass.Multiline = true;
            this.txtUpdateConfPass.Name = "txtUpdateConfPass";
            this.txtUpdateConfPass.Size = new System.Drawing.Size(150, 30);
            this.txtUpdateConfPass.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(615, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save updates";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdateDisplayData
            // 
            this.btnUpdateDisplayData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDisplayData.Location = new System.Drawing.Point(455, 291);
            this.btnUpdateDisplayData.Name = "btnUpdateDisplayData";
            this.btnUpdateDisplayData.Size = new System.Drawing.Size(99, 47);
            this.btnUpdateDisplayData.TabIndex = 8;
            this.btnUpdateDisplayData.Text = "Display Data";
            this.btnUpdateDisplayData.UseVisualStyleBackColor = true;
            this.btnUpdateDisplayData.Click += new System.EventHandler(this.btnUpdateDisplayData_Click_1);
            // 
            // lblUpdatePass
            // 
            this.lblUpdatePass.AutoSize = true;
            this.lblUpdatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePass.Location = new System.Drawing.Point(138, 330);
            this.lblUpdatePass.Name = "lblUpdatePass";
            this.lblUpdatePass.Size = new System.Drawing.Size(104, 25);
            this.lblUpdatePass.TabIndex = 7;
            this.lblUpdatePass.Text = "Password:";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateName.Location = new System.Drawing.Point(172, 291);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(70, 25);
            this.lblUpdateName.TabIndex = 6;
            this.lblUpdateName.Text = "Name:";
            // 
            // txtUpdatePass
            // 
            this.txtUpdatePass.Location = new System.Drawing.Point(248, 327);
            this.txtUpdatePass.Multiline = true;
            this.txtUpdatePass.Name = "txtUpdatePass";
            this.txtUpdatePass.Size = new System.Drawing.Size(150, 30);
            this.txtUpdatePass.TabIndex = 5;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(248, 291);
            this.txtUpdateName.Multiline = true;
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(150, 30);
            this.txtUpdateName.TabIndex = 4;
            // 
            // btnGetPass
            // 
            this.btnGetPass.Location = new System.Drawing.Point(27, 92);
            this.btnGetPass.Name = "btnGetPass";
            this.btnGetPass.Size = new System.Drawing.Size(93, 23);
            this.btnGetPass.TabIndex = 3;
            this.btnGetPass.Text = "Retrieve data";
            this.btnGetPass.UseVisualStyleBackColor = true;
            this.btnGetPass.Click += new System.EventHandler(this.btnGetPass_Click);
            // 
            // dgCreds
            // 
            this.dgCreds.AutoGenerateColumns = false;
            this.dgCreds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCreds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCreds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgCreds.DataSource = this.credentialBindingSource;
            this.dgCreds.Location = new System.Drawing.Point(158, 6);
            this.dgCreds.Name = "dgCreds";
            this.dgCreds.RowHeadersWidth = 62;
            this.dgCreds.Size = new System.Drawing.Size(623, 221);
            this.dgCreds.TabIndex = 2;
            this.dgCreds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCreds_CellClick);
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // credentialBindingSource
            // 
            this.credentialBindingSource.DataSource = typeof(secPass.Credential);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.lblPassGenInfo);
            this.tabPage4.Controls.Add(this.lblPassGenerator);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(787, 420);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Password Generator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGeneratePass);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.lblRandPass);
            this.panel1.Location = new System.Drawing.Point(89, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 126);
            this.panel1.TabIndex = 5;
            // 
            // btnGeneratePass
            // 
            this.btnGeneratePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePass.Location = new System.Drawing.Point(152, 17);
            this.btnGeneratePass.Name = "btnGeneratePass";
            this.btnGeneratePass.Size = new System.Drawing.Size(160, 46);
            this.btnGeneratePass.TabIndex = 0;
            this.btnGeneratePass.Text = "Generate Password";
            this.btnGeneratePass.UseVisualStyleBackColor = true;
            this.btnGeneratePass.Click += new System.EventHandler(this.btnGeneratePass_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(470, 33);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(97, 61);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy to clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblRandPass
            // 
            this.lblRandPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandPass.Location = new System.Drawing.Point(30, 81);
            this.lblRandPass.Name = "lblRandPass";
            this.lblRandPass.Size = new System.Drawing.Size(407, 34);
            this.lblRandPass.TabIndex = 2;
            this.lblRandPass.Text = "Generated password will appear here";
            this.lblRandPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassGenInfo
            // 
            this.lblPassGenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassGenInfo.Location = new System.Drawing.Point(118, 106);
            this.lblPassGenInfo.Name = "lblPassGenInfo";
            this.lblPassGenInfo.Size = new System.Drawing.Size(452, 172);
            this.lblPassGenInfo.TabIndex = 4;
            this.lblPassGenInfo.Text = resources.GetString("lblPassGenInfo.Text");
            // 
            // lblPassGenerator
            // 
            this.lblPassGenerator.AutoSize = true;
            this.lblPassGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassGenerator.Location = new System.Drawing.Point(166, 26);
            this.lblPassGenerator.Name = "lblPassGenerator";
            this.lblPassGenerator.Size = new System.Drawing.Size(445, 39);
            this.lblPassGenerator.TabIndex = 1;
            this.lblPassGenerator.Text = "Secure Password Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCreds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHomeInfo1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblPassGenerator;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblStoreNewPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblEnterPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.Label lblConfPass;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblEncryptedPass;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblDecrypted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMasterPass;
        private System.Windows.Forms.DataGridView dgCreds;
        private System.Windows.Forms.Button btnGetPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource credentialBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.TextBox txtUpdatePass;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdateDisplayData;
        private System.Windows.Forms.Label lblUpdatePass;
        private System.Windows.Forms.Label lblUpdateMastPass;
        private System.Windows.Forms.TextBox txtUpdateMastPass;
        private System.Windows.Forms.Label lblUpdateConfPass;
        private System.Windows.Forms.TextBox txtUpdateConfPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGeneratePass;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblRandPass;
        private System.Windows.Forms.Label lblPassGenInfo;
    }
}

