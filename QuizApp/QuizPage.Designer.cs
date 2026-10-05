namespace QuizApp
{
    partial class QuizPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonNext = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PageLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PageCounterLabel = new System.Windows.Forms.Label();
            this.PageLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonNext
            // 
            this.ButtonNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonNext.AutoSize = true;
            this.ButtonNext.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonNext.Enabled = false;
            this.ButtonNext.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.ButtonNext.FlatAppearance.BorderSize = 0;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Location = new System.Drawing.Point(600, 677);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(80, 33);
            this.ButtonNext.TabIndex = 0;
            this.ButtonNext.Text = "Далее";
            this.ButtonNext.UseVisualStyleBackColor = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(576, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(127, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Оглавление";
            // 
            // PageLayout
            // 
            this.PageLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageLayout.BackColor = System.Drawing.Color.Transparent;
            this.PageLayout.ColumnCount = 1;
            this.PageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PageLayout.Controls.Add(this.TitleLabel, 0, 0);
            this.PageLayout.Location = new System.Drawing.Point(0, 0);
            this.PageLayout.Margin = new System.Windows.Forms.Padding(0);
            this.PageLayout.Name = "PageLayout";
            this.PageLayout.RowCount = 3;
            this.PageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.PageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.PageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PageLayout.Size = new System.Drawing.Size(1280, 660);
            this.PageLayout.TabIndex = 2;
            this.PageLayout.Resize += new System.EventHandler(this.PageLayout_Resize);
            // 
            // PageCounterLabel
            // 
            this.PageCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PageCounterLabel.AutoSize = true;
            this.PageCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.PageCounterLabel.Location = new System.Drawing.Point(0, 699);
            this.PageCounterLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PageCounterLabel.Name = "PageCounterLabel";
            this.PageCounterLabel.Size = new System.Drawing.Size(42, 21);
            this.PageCounterLabel.TabIndex = 3;
            this.PageCounterLabel.Text = "0 \\ 0";
            // 
            // QuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.PageCounterLabel);
            this.Controls.Add(this.PageLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "QuizPage";
            this.Size = new System.Drawing.Size(1280, 720);
            this.PageLayout.ResumeLayout(false);
            this.PageLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.TableLayoutPanel PageLayout;
        public System.Windows.Forms.Button ButtonNext;
        public System.Windows.Forms.Label PageCounterLabel;
    }
}
