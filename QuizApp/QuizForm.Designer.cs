namespace QuizApp
{
    partial class QuizForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.RightBar = new System.Windows.Forms.Panel();
            this.ChangeLogButton = new System.Windows.Forms.Button();
            this.AboutAppButton = new System.Windows.Forms.Button();
            this.DarkThemeButton = new System.Windows.Forms.Button();
            this.LightThemeButton = new System.Windows.Forms.Button();
            this.ColorThemeLabel = new System.Windows.Forms.Label();
            this.BarMoreButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BarTimer = new System.Windows.Forms.Timer(this.components);
            this.RightBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightBar
            // 
            this.RightBar.BackColor = System.Drawing.Color.Gainsboro;
            this.RightBar.Controls.Add(this.ChangeLogButton);
            this.RightBar.Controls.Add(this.AboutAppButton);
            this.RightBar.Controls.Add(this.DarkThemeButton);
            this.RightBar.Controls.Add(this.LightThemeButton);
            this.RightBar.Controls.Add(this.ColorThemeLabel);
            this.RightBar.Controls.Add(this.BarMoreButton);
            this.RightBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBar.ForeColor = System.Drawing.Color.Black;
            this.RightBar.Location = new System.Drawing.Point(980, 0);
            this.RightBar.Name = "RightBar";
            this.RightBar.Size = new System.Drawing.Size(300, 720);
            this.RightBar.TabIndex = 0;
            // 
            // ChangeLogButton
            // 
            this.ChangeLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeLogButton.BackColor = System.Drawing.Color.Transparent;
            this.ChangeLogButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ChangeLogButton.FlatAppearance.BorderSize = 0;
            this.ChangeLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLogButton.Location = new System.Drawing.Point(0, 640);
            this.ChangeLogButton.Name = "ChangeLogButton";
            this.ChangeLogButton.Size = new System.Drawing.Size(300, 40);
            this.ChangeLogButton.TabIndex = 5;
            this.ChangeLogButton.Text = "Оффлайн ченджлог";
            this.ChangeLogButton.UseVisualStyleBackColor = false;
            this.ChangeLogButton.Click += new System.EventHandler(this.ChangeLogButton_Click);
            // 
            // AboutAppButton
            // 
            this.AboutAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutAppButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutAppButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AboutAppButton.FlatAppearance.BorderSize = 0;
            this.AboutAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutAppButton.Location = new System.Drawing.Point(0, 680);
            this.AboutAppButton.Name = "AboutAppButton";
            this.AboutAppButton.Size = new System.Drawing.Size(300, 40);
            this.AboutAppButton.TabIndex = 4;
            this.AboutAppButton.Text = "О приложении";
            this.AboutAppButton.UseVisualStyleBackColor = false;
            this.AboutAppButton.Click += new System.EventHandler(this.AboutAppButton_Click);
            // 
            // DarkThemeButton
            // 
            this.DarkThemeButton.BackColor = System.Drawing.Color.Transparent;
            this.DarkThemeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DarkThemeButton.FlatAppearance.BorderSize = 0;
            this.DarkThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DarkThemeButton.Location = new System.Drawing.Point(0, 100);
            this.DarkThemeButton.Name = "DarkThemeButton";
            this.DarkThemeButton.Size = new System.Drawing.Size(300, 40);
            this.DarkThemeButton.TabIndex = 3;
            this.DarkThemeButton.Text = "Тёмная тема";
            this.DarkThemeButton.UseVisualStyleBackColor = false;
            this.DarkThemeButton.Click += new System.EventHandler(this.DarkThemeButton_Click);
            // 
            // LightThemeButton
            // 
            this.LightThemeButton.BackColor = System.Drawing.Color.DarkGray;
            this.LightThemeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LightThemeButton.FlatAppearance.BorderSize = 0;
            this.LightThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LightThemeButton.Location = new System.Drawing.Point(0, 60);
            this.LightThemeButton.Name = "LightThemeButton";
            this.LightThemeButton.Size = new System.Drawing.Size(300, 40);
            this.LightThemeButton.TabIndex = 2;
            this.LightThemeButton.Text = "Светлая тема";
            this.LightThemeButton.UseVisualStyleBackColor = false;
            this.LightThemeButton.Click += new System.EventHandler(this.LightThemeButton_Click);
            // 
            // ColorThemeLabel
            // 
            this.ColorThemeLabel.AutoSize = true;
            this.ColorThemeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColorThemeLabel.Location = new System.Drawing.Point(0, 40);
            this.ColorThemeLabel.Name = "ColorThemeLabel";
            this.ColorThemeLabel.Size = new System.Drawing.Size(119, 21);
            this.ColorThemeLabel.TabIndex = 1;
            this.ColorThemeLabel.Text = "Цветовая тема:";
            // 
            // BarMoreButton
            // 
            this.BarMoreButton.BackColor = System.Drawing.Color.Silver;
            this.BarMoreButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarMoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BarMoreButton.FlatAppearance.BorderSize = 0;
            this.BarMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarMoreButton.Location = new System.Drawing.Point(0, 0);
            this.BarMoreButton.Name = "BarMoreButton";
            this.BarMoreButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BarMoreButton.Size = new System.Drawing.Size(300, 40);
            this.BarMoreButton.TabIndex = 0;
            this.BarMoreButton.Text = "Скрыть";
            this.BarMoreButton.UseVisualStyleBackColor = false;
            this.BarMoreButton.Click += new System.EventHandler(this.BarMoreButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(980, 720);
            this.MainPanel.TabIndex = 1;
            // 
            // BarTimer
            // 
            this.BarTimer.Interval = 10;
            this.BarTimer.Tick += new System.EventHandler(this.BarTimer_Tick);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.RightBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.LocationChanged += new System.EventHandler(this.QuizForm_LocationChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuizForm_KeyDown);
            this.Resize += new System.EventHandler(this.QuizForm_Resize);
            this.RightBar.ResumeLayout(false);
            this.RightBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RightBar;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BarMoreButton;
        private System.Windows.Forms.Timer BarTimer;
        private System.Windows.Forms.Label ColorThemeLabel;
        private System.Windows.Forms.Button DarkThemeButton;
        private System.Windows.Forms.Button LightThemeButton;
        private System.Windows.Forms.Button AboutAppButton;
        private System.Windows.Forms.Button ChangeLogButton;
    }
}

