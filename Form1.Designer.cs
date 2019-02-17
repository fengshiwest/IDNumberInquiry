namespace IDNumberInquiry
{
    partial class IDNumberInquiry
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.IDNumberLabel = new System.Windows.Forms.Label();
            this.IDNumberTextBox = new System.Windows.Forms.TextBox();
            this.placeLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.placeMessageLabel = new System.Windows.Forms.Label();
            this.birthdayMessageLabel = new System.Windows.Forms.Label();
            this.sexMessageLabel = new System.Windows.Forms.Label();
            this.ageMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.titleLabel.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.titleLabel.Location = new System.Drawing.Point(261, 36);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(270, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "身份证号校验";
            // 
            // IDNumberLabel
            // 
            this.IDNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDNumberLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.IDNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IDNumberLabel.Location = new System.Drawing.Point(83, 133);
            this.IDNumberLabel.Name = "IDNumberLabel";
            this.IDNumberLabel.Size = new System.Drawing.Size(139, 43);
            this.IDNumberLabel.TabIndex = 1;
            this.IDNumberLabel.Text = "身份证号";
            // 
            // IDNumberTextBox
            // 
            this.IDNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IDNumberTextBox.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.IDNumberTextBox.Location = new System.Drawing.Point(228, 132);
            this.IDNumberTextBox.Name = "IDNumberTextBox";
            this.IDNumberTextBox.Size = new System.Drawing.Size(459, 47);
            this.IDNumberTextBox.TabIndex = 2;
            this.IDNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDNumberTextBox_KeyPress);
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.placeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.placeLabel.Location = new System.Drawing.Point(89, 216);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(107, 39);
            this.placeLabel.TabIndex = 3;
            this.placeLabel.Text = "注册地";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.birthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.birthdayLabel.Location = new System.Drawing.Point(85, 269);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(137, 39);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "出生日期";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.sexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sexLabel.Location = new System.Drawing.Point(99, 320);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(77, 39);
            this.sexLabel.TabIndex = 5;
            this.sexLabel.Text = "性别";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.ageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ageLabel.Location = new System.Drawing.Point(99, 377);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(77, 39);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "年龄";
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkButton.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.checkButton.Location = new System.Drawing.Point(300, 440);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(150, 50);
            this.checkButton.TabIndex = 7;
            this.checkButton.Text = "校验";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // placeMessageLabel
            // 
            this.placeMessageLabel.AutoSize = true;
            this.placeMessageLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.placeMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.placeMessageLabel.Location = new System.Drawing.Point(239, 220);
            this.placeMessageLabel.Name = "placeMessageLabel";
            this.placeMessageLabel.Size = new System.Drawing.Size(137, 39);
            this.placeMessageLabel.TabIndex = 8;
            this.placeMessageLabel.Text = "暂无信息";
            // 
            // birthdayMessageLabel
            // 
            this.birthdayMessageLabel.AutoSize = true;
            this.birthdayMessageLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.birthdayMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.birthdayMessageLabel.Location = new System.Drawing.Point(239, 269);
            this.birthdayMessageLabel.Name = "birthdayMessageLabel";
            this.birthdayMessageLabel.Size = new System.Drawing.Size(137, 39);
            this.birthdayMessageLabel.TabIndex = 9;
            this.birthdayMessageLabel.Text = "暂无信息";
            // 
            // sexMessageLabel
            // 
            this.sexMessageLabel.AutoSize = true;
            this.sexMessageLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.sexMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sexMessageLabel.Location = new System.Drawing.Point(239, 320);
            this.sexMessageLabel.Name = "sexMessageLabel";
            this.sexMessageLabel.Size = new System.Drawing.Size(137, 39);
            this.sexMessageLabel.TabIndex = 10;
            this.sexMessageLabel.Text = "暂无信息";
            // 
            // ageMessageLabel
            // 
            this.ageMessageLabel.AutoSize = true;
            this.ageMessageLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.ageMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ageMessageLabel.Location = new System.Drawing.Point(239, 377);
            this.ageMessageLabel.Name = "ageMessageLabel";
            this.ageMessageLabel.Size = new System.Drawing.Size(137, 39);
            this.ageMessageLabel.TabIndex = 11;
            this.ageMessageLabel.Text = "暂无信息";
            // 
            // IDNumberInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.ageMessageLabel);
            this.Controls.Add(this.sexMessageLabel);
            this.Controls.Add(this.birthdayMessageLabel);
            this.Controls.Add(this.placeMessageLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.placeLabel);
            this.Controls.Add(this.IDNumberTextBox);
            this.Controls.Add(this.IDNumberLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "IDNumberInquiry";
            this.Text = "IDNumberInquiry";
            this.Load += new System.EventHandler(this.IDNumberInquiry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label IDNumberLabel;
        private System.Windows.Forms.TextBox IDNumberTextBox;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label placeMessageLabel;
        private System.Windows.Forms.Label birthdayMessageLabel;
        private System.Windows.Forms.Label sexMessageLabel;
        private System.Windows.Forms.Label ageMessageLabel;
    }
}

