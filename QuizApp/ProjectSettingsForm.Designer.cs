namespace QuizApp
{
    partial class ProjectSettingsForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.NumberNavigationLabel = new System.Windows.Forms.Label();
            this.NumberNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(10, 10);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(122, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название теста:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(10, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(378, 29);
            this.NameTextBox.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(308, 158);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(80, 30);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "Готово";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NumberNavigationLabel
            // 
            this.NumberNavigationLabel.AutoSize = true;
            this.NumberNavigationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberNavigationLabel.Location = new System.Drawing.Point(10, 70);
            this.NumberNavigationLabel.Name = "NumberNavigationLabel";
            this.NumberNavigationLabel.Size = new System.Drawing.Size(297, 21);
            this.NumberNavigationLabel.TabIndex = 3;
            this.NumberNavigationLabel.Text = "Отображение навигации по страницам:";
            // 
            // NumberNavigationCheckBox
            // 
            this.NumberNavigationCheckBox.AutoSize = true;
            this.NumberNavigationCheckBox.Location = new System.Drawing.Point(24, 94);
            this.NumberNavigationCheckBox.Name = "NumberNavigationCheckBox";
            this.NumberNavigationCheckBox.Size = new System.Drawing.Size(93, 17);
            this.NumberNavigationCheckBox.TabIndex = 4;
            this.NumberNavigationCheckBox.Text = "Отображать";
            this.NumberNavigationCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProjectSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.NumberNavigationCheckBox);
            this.Controls.Add(this.NumberNavigationLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки проекта";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label NumberNavigationLabel;
        private System.Windows.Forms.CheckBox NumberNavigationCheckBox;
    }
}