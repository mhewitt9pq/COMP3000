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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnGeneratePass = new System.Windows.Forms.Button();
            this.lblPassGenerator = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHomeInfo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(787, 420);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(787, 420);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Home";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 420);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Retrieve Password";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.lblPassGenerator);
            this.tabPage4.Controls.Add(this.btnGeneratePass);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(787, 420);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Password Generator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePass
            // 
            this.btnGeneratePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePass.Location = new System.Drawing.Point(294, 107);
            this.btnGeneratePass.Name = "btnGeneratePass";
            this.btnGeneratePass.Size = new System.Drawing.Size(160, 46);
            this.btnGeneratePass.TabIndex = 0;
            this.btnGeneratePass.Text = "Generate Password";
            this.btnGeneratePass.UseVisualStyleBackColor = true;
            // 
            // lblPassGenerator
            // 
            this.lblPassGenerator.AutoSize = true;
            this.lblPassGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassGenerator.Location = new System.Drawing.Point(218, 23);
            this.lblPassGenerator.Name = "lblPassGenerator";
            this.lblPassGenerator.Size = new System.Drawing.Size(356, 31);
            this.lblPassGenerator.TabIndex = 1;
            this.lblPassGenerator.Text = "Secure Password Generator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

