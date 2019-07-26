namespace OnvixTools
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UrlTB = new System.Windows.Forms.TextBox();
            this.Poster = new System.Windows.Forms.PictureBox();
            this.FilmName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilmType = new System.Windows.Forms.Label();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.HLSrb = new System.Windows.Forms.RadioButton();
            this.MP4rb = new System.Windows.Forms.RadioButton();
            this.ParsePanel = new System.Windows.Forms.Panel();
            this.Qu1080 = new System.Windows.Forms.RadioButton();
            this.Qu720 = new System.Windows.Forms.RadioButton();
            this.Qu480 = new System.Windows.Forms.RadioButton();
            this.Qu360 = new System.Windows.Forms.RadioButton();
            this.ParseMP4b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).BeginInit();
            this.ParsePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetB
            // 
            this.GetB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GetB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.GetB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.GetB.Location = new System.Drawing.Point(225, 342);
            this.GetB.Name = "GetB";
            this.GetB.Size = new System.Drawing.Size(180, 52);
            this.GetB.TabIndex = 3;
            this.GetB.Text = "Get";
            this.GetB.UseVisualStyleBackColor = false;
            this.GetB.Click += new System.EventHandler(this.GetB_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(16, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            // 
            // UrlTB
            // 
            this.UrlTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlTB.BackColor = System.Drawing.Color.DimGray;
            this.UrlTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlTB.ForeColor = System.Drawing.Color.White;
            this.UrlTB.Location = new System.Drawing.Point(20, 402);
            this.UrlTB.Name = "UrlTB";
            this.UrlTB.Size = new System.Drawing.Size(591, 22);
            this.UrlTB.TabIndex = 5;
            this.UrlTB.Text = "https://";
            // 
            // Poster
            // 
            this.Poster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Poster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Poster.ImageLocation = "";
            this.Poster.Location = new System.Drawing.Point(12, 12);
            this.Poster.Name = "Poster";
            this.Poster.Size = new System.Drawing.Size(207, 305);
            this.Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poster.TabIndex = 6;
            this.Poster.TabStop = false;
            // 
            // FilmName
            // 
            this.FilmName.AutoSize = true;
            this.FilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.FilmName.Location = new System.Drawing.Point(234, 12);
            this.FilmName.Name = "FilmName";
            this.FilmName.Size = new System.Drawing.Size(132, 25);
            this.FilmName.TabIndex = 4;
            this.FilmName.Text = "{FilmName}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(234, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type:";
            // 
            // FilmType
            // 
            this.FilmType.AutoSize = true;
            this.FilmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.FilmType.Location = new System.Drawing.Point(276, 60);
            this.FilmType.Name = "FilmType";
            this.FilmType.Size = new System.Drawing.Size(82, 20);
            this.FilmType.TabIndex = 4;
            this.FilmType.Text = "{FilmType}";
            // 
            // ResultTB
            // 
            this.ResultTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTB.BackColor = System.Drawing.Color.DimGray;
            this.ResultTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTB.ForeColor = System.Drawing.Color.White;
            this.ResultTB.Location = new System.Drawing.Point(238, 244);
            this.ResultTB.Multiline = true;
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.ReadOnly = true;
            this.ResultTB.Size = new System.Drawing.Size(373, 73);
            this.ResultTB.TabIndex = 7;
            // 
            // HLSrb
            // 
            this.HLSrb.AutoSize = true;
            this.HLSrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HLSrb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.HLSrb.Location = new System.Drawing.Point(238, 216);
            this.HLSrb.Name = "HLSrb";
            this.HLSrb.Size = new System.Drawing.Size(55, 22);
            this.HLSrb.TabIndex = 8;
            this.HLSrb.Text = "HLS";
            this.HLSrb.UseVisualStyleBackColor = true;
            // 
            // MP4rb
            // 
            this.MP4rb.AutoSize = true;
            this.MP4rb.Checked = true;
            this.MP4rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MP4rb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.MP4rb.Location = new System.Drawing.Point(238, 188);
            this.MP4rb.Name = "MP4rb";
            this.MP4rb.Size = new System.Drawing.Size(57, 22);
            this.MP4rb.TabIndex = 8;
            this.MP4rb.TabStop = true;
            this.MP4rb.Text = "MP4";
            this.MP4rb.UseVisualStyleBackColor = true;
            // 
            // ParsePanel
            // 
            this.ParsePanel.Controls.Add(this.Qu1080);
            this.ParsePanel.Controls.Add(this.Qu720);
            this.ParsePanel.Controls.Add(this.Qu480);
            this.ParsePanel.Controls.Add(this.Qu360);
            this.ParsePanel.Controls.Add(this.ParseMP4b);
            this.ParsePanel.Location = new System.Drawing.Point(299, 124);
            this.ParsePanel.Name = "ParsePanel";
            this.ParsePanel.Size = new System.Drawing.Size(178, 114);
            this.ParsePanel.TabIndex = 9;
            this.ParsePanel.Visible = false;
            // 
            // Qu1080
            // 
            this.Qu1080.AutoSize = true;
            this.Qu1080.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qu1080.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.Qu1080.Location = new System.Drawing.Point(3, 87);
            this.Qu1080.Name = "Qu1080";
            this.Qu1080.Size = new System.Drawing.Size(58, 22);
            this.Qu1080.TabIndex = 8;
            this.Qu1080.Text = "1080";
            this.Qu1080.UseVisualStyleBackColor = true;
            this.Qu1080.Visible = false;
            // 
            // Qu720
            // 
            this.Qu720.AutoSize = true;
            this.Qu720.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qu720.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.Qu720.Location = new System.Drawing.Point(3, 59);
            this.Qu720.Name = "Qu720";
            this.Qu720.Size = new System.Drawing.Size(50, 22);
            this.Qu720.TabIndex = 8;
            this.Qu720.Text = "720";
            this.Qu720.UseVisualStyleBackColor = true;
            this.Qu720.Visible = false;
            // 
            // Qu480
            // 
            this.Qu480.AutoSize = true;
            this.Qu480.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qu480.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.Qu480.Location = new System.Drawing.Point(3, 31);
            this.Qu480.Name = "Qu480";
            this.Qu480.Size = new System.Drawing.Size(50, 22);
            this.Qu480.TabIndex = 8;
            this.Qu480.Text = "480";
            this.Qu480.UseVisualStyleBackColor = true;
            this.Qu480.Visible = false;
            // 
            // Qu360
            // 
            this.Qu360.AutoSize = true;
            this.Qu360.Checked = true;
            this.Qu360.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qu360.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.Qu360.Location = new System.Drawing.Point(3, 3);
            this.Qu360.Name = "Qu360";
            this.Qu360.Size = new System.Drawing.Size(50, 22);
            this.Qu360.TabIndex = 8;
            this.Qu360.TabStop = true;
            this.Qu360.Text = "360";
            this.Qu360.UseVisualStyleBackColor = true;
            this.Qu360.Visible = false;
            // 
            // ParseMP4b
            // 
            this.ParseMP4b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ParseMP4b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParseMP4b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParseMP4b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.ParseMP4b.Location = new System.Drawing.Point(64, 34);
            this.ParseMP4b.Name = "ParseMP4b";
            this.ParseMP4b.Size = new System.Drawing.Size(101, 52);
            this.ParseMP4b.TabIndex = 3;
            this.ParseMP4b.Text = "Parse";
            this.ParseMP4b.UseVisualStyleBackColor = false;
            this.ParseMP4b.Click += new System.EventHandler(this.ParseMP4b_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(623, 445);
            this.Controls.Add(this.ParsePanel);
            this.Controls.Add(this.MP4rb);
            this.Controls.Add(this.HLSrb);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.Poster);
            this.Controls.Add(this.UrlTB);
            this.Controls.Add(this.FilmName);
            this.Controls.Add(this.FilmType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetB);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 484);
            this.MinimumSize = new System.Drawing.Size(639, 484);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).EndInit();
            this.ParsePanel.ResumeLayout(false);
            this.ParsePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrlTB;
        private System.Windows.Forms.PictureBox Poster;
        private System.Windows.Forms.Label FilmName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FilmType;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.RadioButton HLSrb;
        private System.Windows.Forms.RadioButton MP4rb;
        private System.Windows.Forms.Panel ParsePanel;
        private System.Windows.Forms.RadioButton Qu720;
        private System.Windows.Forms.RadioButton Qu480;
        private System.Windows.Forms.RadioButton Qu360;
        private System.Windows.Forms.RadioButton Qu1080;
        private System.Windows.Forms.Button ParseMP4b;
    }
}

