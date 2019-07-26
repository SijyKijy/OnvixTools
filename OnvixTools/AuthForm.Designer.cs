namespace OnvixTools
{
    partial class AuthForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.SignInB = new System.Windows.Forms.Button();
            this.RemLP = new System.Windows.Forms.CheckBox();
            this.SiteUrlTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pass:";
            // 
            // LoginTB
            // 
            this.LoginTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTB.Location = new System.Drawing.Point(67, 13);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(217, 20);
            this.LoginTB.TabIndex = 1;
            // 
            // PassTB
            // 
            this.PassTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTB.Location = new System.Drawing.Point(67, 58);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(217, 20);
            this.PassTB.TabIndex = 1;
            // 
            // SignInB
            // 
            this.SignInB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SignInB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.SignInB.Location = new System.Drawing.Point(18, 107);
            this.SignInB.Name = "SignInB";
            this.SignInB.Size = new System.Drawing.Size(266, 57);
            this.SignInB.TabIndex = 2;
            this.SignInB.Text = "Sign In";
            this.SignInB.UseVisualStyleBackColor = false;
            this.SignInB.Click += new System.EventHandler(this.SignInB_Click);
            // 
            // RemLP
            // 
            this.RemLP.AutoSize = true;
            this.RemLP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.RemLP.Location = new System.Drawing.Point(18, 84);
            this.RemLP.Name = "RemLP";
            this.RemLP.Size = new System.Drawing.Size(77, 17);
            this.RemLP.TabIndex = 3;
            this.RemLP.Text = "Remember";
            this.RemLP.UseVisualStyleBackColor = true;
            // 
            // SiteUrlTB
            // 
            this.SiteUrlTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SiteUrlTB.Location = new System.Drawing.Point(18, 170);
            this.SiteUrlTB.Name = "SiteUrlTB";
            this.SiteUrlTB.Size = new System.Drawing.Size(162, 20);
            this.SiteUrlTB.TabIndex = 1;
            this.SiteUrlTB.Text = "https://onvix.co";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(304, 198);
            this.Controls.Add(this.RemLP);
            this.Controls.Add(this.SignInB);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.SiteUrlTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Button SignInB;
        private System.Windows.Forms.CheckBox RemLP;
        public System.Windows.Forms.TextBox SiteUrlTB;
    }
}