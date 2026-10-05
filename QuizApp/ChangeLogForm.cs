using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class ChangeLogForm : Form
    {
        public ChangeLogForm(ColorTheme colorTheme)
        {
            InitializeComponent();
            if(colorTheme == ColorTheme.LightTheme)
            {
                ThemeForeColor = Color.Black;
                BackColor = Color.White;
                ForeColor = Color.Black;

                ChangeLogBox.BackColor = Color.Gainsboro;
                ChangeLogBox.ForeColor = Color.Black;
            }
            else
            {
                ThemeForeColor = Color.White;
                BackColor = Color.FromArgb(64,64,64);
                ForeColor = Color.White;

                ChangeLogBox.BackColor = Color.FromArgb(40, 40, 40);
                ChangeLogBox.ForeColor = Color.White;
            }

            SetChangeLogs();
        }

        private Color ThemeForeColor;

        private void SetChangeLogs()
        {
            ChangeLogBox.AppendText("\tРелиз Quiz Application 1.0\n", Color.Red);
            ChangeLogBox.AppendText("Quiz Application, Hello World!\n", ThemeForeColor);
        }
    }
}