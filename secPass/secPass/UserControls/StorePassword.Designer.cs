namespace secPass.UserControls
{
    partial class StorePassword
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
            this.txtMastPass = new ns1.SiticoneTextBox();
            this.lblStore = new ns1.SiticoneLabel();
            this.lblMastP = new ns1.SiticoneLabel();
            this.siticoneShadowPanel1 = new ns1.SiticoneShadowPanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMastPass
            // 
            this.txtMastPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMastPass.DefaultText = "";
            this.txtMastPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMastPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMastPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMastPass.DisabledState.Parent = this.txtMastPass;
            this.txtMastPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMastPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMastPass.FocusedState.Parent = this.txtMastPass;
            this.txtMastPass.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMastPass.HoveredState.Parent = this.txtMastPass;
            this.txtMastPass.Location = new System.Drawing.Point(18, 55);
            this.txtMastPass.Name = "txtMastPass";
            this.txtMastPass.PasswordChar = '\0';
            this.txtMastPass.PlaceholderText = "";
            this.txtMastPass.SelectedText = "";
            this.txtMastPass.ShadowDecoration.Parent = this.txtMastPass;
            this.txtMastPass.Size = new System.Drawing.Size(165, 31);
            this.txtMastPass.TabIndex = 0;
            // 
            // lblStore
            // 
            this.lblStore.BackColor = System.Drawing.Color.Transparent;
            this.lblStore.Font = new System.Drawing.Font("Lucida Sans Typewriter", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStore.Location = new System.Drawing.Point(238, 3);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(423, 41);
            this.lblStore.TabIndex = 1;
            this.lblStore.Text = "Store a new password";
            // 
            // lblMastP
            // 
            this.lblMastP.BackColor = System.Drawing.Color.Transparent;
            this.lblMastP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMastP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMastP.Location = new System.Drawing.Point(24, 14);
            this.lblMastP.Name = "lblMastP";
            this.lblMastP.Size = new System.Drawing.Size(151, 26);
            this.lblMastP.TabIndex = 2;
            this.lblMastP.Text = "Master Password:";
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.siticoneShadowPanel1.Controls.Add(this.txtMastPass);
            this.siticoneShadowPanel1.Controls.Add(this.lblMastP);
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(18, 16);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(200, 100);
            this.siticoneShadowPanel1.TabIndex = 3;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.AutoRoundedCorners = true;
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.siticonePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.siticonePanel1.BorderRadius = 81;
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Location = new System.Drawing.Point(238, 117);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(368, 165);
            this.siticonePanel1.TabIndex = 4;
            // 
            // StorePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticoneShadowPanel1);
            this.Controls.Add(this.lblStore);
            this.Name = "StorePassword";
            this.Size = new System.Drawing.Size(825, 369);
            this.siticoneShadowPanel1.ResumeLayout(false);
            this.siticoneShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.SiticoneTextBox txtMastPass;
        private ns1.SiticoneLabel lblStore;
        private ns1.SiticoneLabel lblMastP;
        private ns1.SiticoneShadowPanel siticoneShadowPanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
    }
}
