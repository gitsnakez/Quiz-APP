namespace QuizApp
{
    partial class ChangeLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLogForm));
            this.ChangeLogLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChangeLogBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeLogLabel
            // 
            this.ChangeLogLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChangeLogLabel.AutoSize = true;
            this.ChangeLogLabel.Location = new System.Drawing.Point(278, 10);
            this.ChangeLogLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ChangeLogLabel.Name = "ChangeLogLabel";
            this.ChangeLogLabel.Size = new System.Drawing.Size(164, 21);
            this.ChangeLogLabel.TabIndex = 0;
            this.ChangeLogLabel.Text = "Оффлайн ченджлоги:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ChangeLogLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 70);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ChangeLogBox
            // 
            this.ChangeLogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeLogBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ChangeLogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeLogBox.Location = new System.Drawing.Point(20, 70);
            this.ChangeLogBox.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeLogBox.Name = "ChangeLogBox";
            this.ChangeLogBox.ReadOnly = true;
            this.ChangeLogBox.Size = new System.Drawing.Size(680, 1110);
            this.ChangeLogBox.TabIndex = 2;
            this.ChangeLogBox.Text = "";
            // 
            // ChangeLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 1200);
            this.Controls.Add(this.ChangeLogBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(316, 339);
            this.Name = "ChangeLogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Что нового: 25.09.2022";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ChangeLogLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox ChangeLogBox;
    }
}