namespace QuizApp
{
    partial class TerminalForm
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
            this.OutputConsole = new System.Windows.Forms.RichTextBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.InputCommandTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputConsole
            // 
            this.OutputConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OutputConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputConsole.ForeColor = System.Drawing.Color.White;
            this.OutputConsole.HideSelection = false;
            this.OutputConsole.Location = new System.Drawing.Point(0, 0);
            this.OutputConsole.Name = "OutputConsole";
            this.OutputConsole.ReadOnly = true;
            this.OutputConsole.Size = new System.Drawing.Size(800, 424);
            this.OutputConsole.TabIndex = 0;
            this.OutputConsole.Text = "";
            this.OutputConsole.WordWrap = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BottomPanel.Controls.Add(this.InputCommandTextBox);
            this.BottomPanel.Controls.Add(this.ClearButton);
            this.BottomPanel.Controls.Add(this.SendButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 424);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 26);
            this.BottomPanel.TabIndex = 1;
            // 
            // InputCommandTextBox
            // 
            this.InputCommandTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.InputCommandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputCommandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputCommandTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputCommandTextBox.ForeColor = System.Drawing.Color.White;
            this.InputCommandTextBox.Location = new System.Drawing.Point(0, 0);
            this.InputCommandTextBox.Name = "InputCommandTextBox";
            this.InputCommandTextBox.Size = new System.Drawing.Size(748, 22);
            this.InputCommandTextBox.TabIndex = 1;
            this.InputCommandTextBox.WordWrap = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Image = global::QuizApp.Properties.Resources.trashbin20pix;
            this.ClearButton.Location = new System.Drawing.Point(748, 0);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(26, 26);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Image = global::QuizApp.Properties.Resources.EnterIcon20pix;
            this.SendButton.Location = new System.Drawing.Point(774, 0);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(26, 26);
            this.SendButton.TabIndex = 0;
            this.SendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // TerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputConsole);
            this.Controls.Add(this.BottomPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TerminalForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Terminal";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsoleForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsoleForm_KeyDown);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox OutputConsole;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.TextBox InputCommandTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ClearButton;
    }
}