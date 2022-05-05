namespace secPass
{
    partial class frmLogin
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLoginMastP = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtLoginUserName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnCancel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblLoginHelp = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbShowPass = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.siticonePanel1.Controls.Add(this.siticonePictureBox1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(249, 72);
            this.siticonePanel1.TabIndex = 5;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = global::secPass.Properties.Resources.Logo;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(27, -6);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(194, 86);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 2;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.UseTransparentBackground = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 19F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.LightGray;
            this.lblLogin.Location = new System.Drawing.Point(74, 85);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(93, 29);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login";
            // 
            // txtLoginMastP
            // 
            this.txtLoginMastP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginMastP.DefaultText = "";
            this.txtLoginMastP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginMastP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginMastP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginMastP.DisabledState.Parent = this.txtLoginMastP;
            this.txtLoginMastP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginMastP.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtLoginMastP.FocusedState.Parent = this.txtLoginMastP;
            this.txtLoginMastP.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginMastP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginMastP.HoverState.Parent = this.txtLoginMastP;
            this.txtLoginMastP.IconLeft = global::secPass.Properties.Resources.Lock_DGrey;
            this.txtLoginMastP.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtLoginMastP.Location = new System.Drawing.Point(26, 191);
            this.txtLoginMastP.Name = "txtLoginMastP";
            this.txtLoginMastP.PasswordChar = '\0';
            this.txtLoginMastP.PlaceholderText = "Enter your master password";
            this.txtLoginMastP.SelectedText = "";
            this.txtLoginMastP.ShadowDecoration.Parent = this.txtLoginMastP;
            this.txtLoginMastP.Size = new System.Drawing.Size(200, 39);
            this.txtLoginMastP.TabIndex = 2;
            this.txtLoginMastP.TextOffset = new System.Drawing.Point(7, 0);
            this.txtLoginMastP.UseSystemPasswordChar = true;
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginUserName.DefaultText = "";
            this.txtLoginUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginUserName.DisabledState.Parent = this.txtLoginUserName;
            this.txtLoginUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginUserName.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtLoginUserName.FocusedState.Parent = this.txtLoginUserName;
            this.txtLoginUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginUserName.HoverState.Parent = this.txtLoginUserName;
            this.txtLoginUserName.IconLeft = global::secPass.Properties.Resources.User_DGrey;
            this.txtLoginUserName.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtLoginUserName.Location = new System.Drawing.Point(26, 133);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.PasswordChar = '\0';
            this.txtLoginUserName.PlaceholderText = "Enter your username";
            this.txtLoginUserName.SelectedText = "";
            this.txtLoginUserName.ShadowDecoration.Parent = this.txtLoginUserName;
            this.txtLoginUserName.Size = new System.Drawing.Size(200, 39);
            this.txtLoginUserName.TabIndex = 1;
            this.txtLoginUserName.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(152, 263);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.White;
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(90, 40);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.DisabledState.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(56, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(90, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLoginHelp
            // 
            this.lblLoginHelp.AutoSize = true;
            this.lblLoginHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginHelp.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHelp.ForeColor = System.Drawing.Color.LightGray;
            this.lblLoginHelp.Location = new System.Drawing.Point(17, 269);
            this.lblLoginHelp.Name = "lblLoginHelp";
            this.lblLoginHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoginHelp.Size = new System.Drawing.Size(22, 28);
            this.lblLoginHelp.TabIndex = 17;
            this.lblLoginHelp.Text = "?";
            this.lblLoginHelp.MouseHover += new System.EventHandler(this.lblLoginHelp_MouseMove);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShowPass.CheckedState.BorderRadius = 0;
            this.cbShowPass.CheckedState.BorderThickness = 0;
            this.cbShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPass.ForeColor = System.Drawing.Color.LightGray;
            this.cbShowPass.Location = new System.Drawing.Point(26, 237);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(102, 17);
            this.cbShowPass.TabIndex = 18;
            this.cbShowPass.Text = "Show Password";
            this.cbShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShowPass.UncheckedState.BorderRadius = 0;
            this.cbShowPass.UncheckedState.BorderThickness = 0;
            this.cbShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(249, 312);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.lblLoginHelp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginUserName);
            this.Controls.Add(this.txtLoginMastP);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtLoginUserName;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtLoginMastP;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLogin;
        private System.Windows.Forms.Label lblLoginHelp;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox cbShowPass;
    }
}