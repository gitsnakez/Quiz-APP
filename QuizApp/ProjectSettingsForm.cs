using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class ProjectSettingsForm : Form
    {
        ProjectSettings Proj;
        public ProjectSettingsForm(ref ProjectSettings ProjSettings)
        {
            InitializeComponent();
            NameTextBox.Text = ProjSettings.QuizName;
            if(ProjSettings.IsNumNav)
            {
                NumberNavigationCheckBox.Checked = true;
            }
            else
            {
                NumberNavigationCheckBox.Checked = false;
            }
            Proj = ProjSettings;
        }

        private void OKButton_Click(object sender, System.EventArgs e)
        {
            Proj.QuizName = NameTextBox.Text;
            Proj.IsNumNav = NumberNavigationCheckBox.Checked;
        }
    }

    [Serializable]
    public class ProjectSettings
    {
        public string QuizName;
        public bool IsNumNav;

        public List<QuizInfo> QuizList;
    }
}