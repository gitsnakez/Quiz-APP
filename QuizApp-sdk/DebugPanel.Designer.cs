namespace QuizApp_sdk
{
    partial class DebugPanel
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
            this.ButtonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.WindowPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.DragblePanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HotReloadButton = new System.Windows.Forms.Button();
            this.ButtonFlowLayoutPanel.SuspendLayout();
            this.WindowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonFlowLayoutPanel
            // 
            this.ButtonFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFlowLayoutPanel.Controls.Add(this.HotReloadButton);
            this.ButtonFlowLayoutPanel.Location = new System.Drawing.Point(0, 10);
            this.ButtonFlowLayoutPanel.Name = "ButtonFlowLayoutPanel";
            this.ButtonFlowLayoutPanel.Size = new System.Drawing.Size(98, 46);
            this.ButtonFlowLayoutPanel.TabIndex = 0;
            // 
            // WindowPanel
            // 
            this.WindowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowPanel.Controls.Add(this.MinimizeButton);
            this.WindowPanel.Controls.Add(this.DragblePanel);
            this.WindowPanel.Controls.Add(this.ExitButton);
            this.WindowPanel.Controls.Add(this.ButtonFlowLayoutPanel);
            this.WindowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowPanel.Location = new System.Drawing.Point(0, 0);
            this.WindowPanel.Name = "WindowPanel";
            this.WindowPanel.Size = new System.Drawing.Size(120, 56);
            this.WindowPanel.TabIndex = 1;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.White;
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = global::QuizApp_sdk.Properties.Resources.FixedIcon10pix;
            this.MinimizeButton.Location = new System.Drawing.Point(96, 32);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(20, 20);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // DragblePanel
            // 
            this.DragblePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DragblePanel.BackgroundImage = global::QuizApp_sdk.Properties.Resources.DragblePattern;
            this.DragblePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragblePanel.Location = new System.Drawing.Point(0, 0);
            this.DragblePanel.Name = "DragblePanel";
            this.DragblePanel.Size = new System.Drawing.Size(118, 10);
            this.DragblePanel.TabIndex = 2;
            this.DragblePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragblePanel_MouseDown);
            this.DragblePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragblePanel_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = global::QuizApp_sdk.Properties.Resources.Exit10pix;
            this.ExitButton.Location = new System.Drawing.Point(96, 12);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HotReloadButton
            // 
            this.HotReloadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HotReloadButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HotReloadButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.HotReloadButton.FlatAppearance.BorderSize = 0;
            this.HotReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotReloadButton.Image = global::QuizApp_sdk.Properties.Resources.HotReload32pix;
            this.HotReloadButton.Location = new System.Drawing.Point(2, 2);
            this.HotReloadButton.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.HotReloadButton.Name = "HotReloadButton";
            this.HotReloadButton.Size = new System.Drawing.Size(40, 40);
            this.HotReloadButton.TabIndex = 2;
            this.HotReloadButton.UseVisualStyleBackColor = false;
            this.HotReloadButton.Click += new System.EventHandler(this.HotReloadButton_Click);
            // 
            // DebugPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(120, 56);
            this.Controls.Add(this.WindowPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DebugPanel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DebugPanel_Load);
            this.ButtonFlowLayoutPanel.ResumeLayout(false);
            this.WindowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ButtonFlowLayoutPanel;
        private System.Windows.Forms.Button HotReloadButton;
        private System.Windows.Forms.Panel WindowPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel DragblePanel;
    }
}