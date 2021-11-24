﻿namespace secPass
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHomeInfo1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPassGenerator = new System.Windows.Forms.Label();
            this.btnGeneratePass = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblEnterPass = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblStoreNewPass = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSubmit);
            this.tabPage2.Controls.Add(this.lblStoreNewPass);
            this.tabPage2.Controls.Add(this.txtPass);
            this.tabPage2.Controls.Add(this.lblEnterPass);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.txtConfPass);
            this.tabPage2.Controls.Add(this.lblConfPass);
            this.tabPage2.Controls.Add(this.lblEnterName);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1184, 653);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Store Password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lblHomeInfo1);
            this.tabPage3.Controls.Add(this.lblDescription);
            this.tabPage3.Controls.Add(this.lblWelcome);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1184, 653);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Home";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(746, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(426, 376);
            this.label1.TabIndex = 3;
            this.label1.Text = "Security information and information about the application";
            // 
            // lblHomeInfo1
            // 
            this.lblHomeInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHomeInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeInfo1.Location = new System.Drawing.Point(34, 189);
            this.lblHomeInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomeInfo1.Name = "lblHomeInfo1";
            this.lblHomeInfo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHomeInfo1.Size = new System.Drawing.Size(426, 376);
            this.lblHomeInfo1.TabIndex = 2;
            this.lblHomeInfo1.Text = "Security information and information about the application";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(360, 131);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(411, 26);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Your personal secure credential manager";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(338, 68);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(460, 46);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to SecurePass";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1192, 686);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1184, 653);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Retrieve Password";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.lblPassGenerator);
            this.tabPage4.Controls.Add(this.btnGeneratePass);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(1184, 653);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Password Generator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 294);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 26);
            this.textBox1.TabIndex = 2;
            // 
            // lblPassGenerator
            // 
            this.lblPassGenerator.AutoSize = true;
            this.lblPassGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassGenerator.Location = new System.Drawing.Point(327, 35);
            this.lblPassGenerator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassGenerator.Name = "lblPassGenerator";
            this.lblPassGenerator.Size = new System.Drawing.Size(524, 46);
            this.lblPassGenerator.TabIndex = 1;
            this.lblPassGenerator.Text = "Secure Password Generator";
            // 
            // btnGeneratePass
            // 
            this.btnGeneratePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePass.Location = new System.Drawing.Point(441, 165);
            this.btnGeneratePass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeneratePass.Name = "btnGeneratePass";
            this.btnGeneratePass.Size = new System.Drawing.Size(240, 71);
            this.btnGeneratePass.TabIndex = 0;
            this.btnGeneratePass.Text = "Generate Password";
            this.btnGeneratePass.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(520, 337);
            this.txtPass.MinimumSize = new System.Drawing.Size(220, 38);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(268, 44);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // lblEnterPass
            // 
            this.lblEnterPass.AutoSize = true;
            this.lblEnterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPass.Location = new System.Drawing.Point(156, 345);
            this.lblEnterPass.Name = "lblEnterPass";
            this.lblEnterPass.Size = new System.Drawing.Size(349, 36);
            this.lblEnterPass.TabIndex = 14;
            this.lblEnterPass.Text = "Please enter a password:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(520, 235);
            this.txtName.MinimumSize = new System.Drawing.Size(220, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 44);
            this.txtName.TabIndex = 9;
            // 
            // txtConfPass
            // 
            this.txtConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPass.Location = new System.Drawing.Point(520, 414);
            this.txtConfPass.MinimumSize = new System.Drawing.Size(220, 38);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '*';
            this.txtConfPass.Size = new System.Drawing.Size(268, 44);
            this.txtConfPass.TabIndex = 12;
            this.txtConfPass.UseSystemPasswordChar = true;
            // 
            // lblConfPass
            // 
            this.lblConfPass.AutoSize = true;
            this.lblConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPass.Location = new System.Drawing.Point(83, 416);
            this.lblConfPass.Name = "lblConfPass";
            this.lblConfPass.Size = new System.Drawing.Size(422, 36);
            this.lblConfPass.TabIndex = 13;
            this.lblConfPass.Text = "Please confirm your password:";
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(212, 239);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(292, 36);
            this.lblEnterName.TabIndex = 10;
            this.lblEnterName.Text = "Please enter a name:";
            // 
            // lblStoreNewPass
            // 
            this.lblStoreNewPass.AutoSize = true;
            this.lblStoreNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreNewPass.Location = new System.Drawing.Point(375, 88);
            this.lblStoreNewPass.Name = "lblStoreNewPass";
            this.lblStoreNewPass.Size = new System.Drawing.Size(435, 46);
            this.lblStoreNewPass.TabIndex = 15;
            this.lblStoreNewPass.Text = "Store a new password";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(586, 516);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(139, 51);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 697);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPassGenerator;
        private System.Windows.Forms.Button btnGeneratePass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblStoreNewPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblEnterPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.Label lblConfPass;
        private System.Windows.Forms.Label lblEnterName;
    }
}

