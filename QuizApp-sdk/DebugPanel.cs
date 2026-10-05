using QuizApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp_sdk
{
    public partial class DebugPanel : Form
    {
        QuizForm DebuggingForm;
        public DebugPanel(QuizForm form)
        {
            InitializeComponent();
            ToolTip TT = new ToolTip();
            TT.SetToolTip(HotReloadButton, "Горячая перезагрузка");

            DebuggingForm = form;
            DebuggingForm.IsDebugging = true;
            DebuggingForm.DebugForm = this;
            DebuggingForm.ReLocatorOnMaximize = ReLocator;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            if (DebuggingForm.FixedDebugPanel)
            {
                DebuggingForm.FixedDebugPanel = false;
                MinimizeButton.Image = Properties.Resources.NotFixedIcon10pix;
            }
            else
            {
                DebuggingForm.FixedDebugPanel = true;
                DebuggingForm.SetDebugPanel();
                MinimizeButton.Image = Properties.Resources.FixedIcon10pix;
            }
        }

        private void DebugPanel_Load(object sender, EventArgs e)
        {
            Height = WindowPanel.Height;
            int NewWidth = 28;
            foreach(Control control in ButtonFlowLayoutPanel.Controls)
            {
                NewWidth += 40;
            }
            Width = NewWidth;
        }

        Point LocationPoint;
        private void DragblePanel_MouseDown(object sender, MouseEventArgs e)
        {
            LocationPoint = new Point(e.X, e.Y);
        }

        private void DragblePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Left += e.X - LocationPoint.X;
                Top += e.Y - LocationPoint.Y;
                if (DebuggingForm.FixedDebugPanel)
                {
                    DebuggingForm.FixedDebugPanel = false;
                    MinimizeButton.Image = Properties.Resources.NotFixedIcon10pix;
                }
            }
        }

        private void HotReloadButton_Click(object sender, EventArgs e)
        {
            DebuggingForm.LoadQuizPage(DebuggingForm.ActualIndexPage);
        }

        private void ReLocator()
        {
            this.Location = new Point(100, 100);
            DebuggingForm.FixedDebugPanel = false;
            MinimizeButton.Image = Properties.Resources.NotFixedIcon10pix;
        }
    }
}