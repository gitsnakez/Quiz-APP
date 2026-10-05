using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class TerminalForm : Form
    {
        public static List<string> strings= new List<string>();
        /// <summary>
        /// Форма(окно) терминала(консоли).
        /// </summary>
        public TerminalForm()
        {
            InitializeComponent();
        }

        public bool InProgMode;

        /// <summary>
        /// Закрытие формы.
        /// </summary>
        private void ConsoleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;    //Отмена действия.
            this.Hide();        //Скрытие формы.
        }

        public void SetDarkIcons()
        {
            ClearButton.Image = Properties.Resources.trashbinDark20pix;
            SendButton.Image = Properties.Resources.EnterIconDark20pix;
        }

        /// <summary>
        /// Метод, который устанавливает цвет нижней панели терминала(консоли).
        /// </summary>
        /// <param name="ForeColor">Шрифт</param>
        /// <param name="BackColor">Задний фон</param>
        public void SetBottomPanelsColors(Color ForeColor, Color BackColor)
        {
            BottomPanel.BackColor = BackColor;
            InputCommandTextBox.BackColor = BackColor;
            ClearButton.BackColor = BackColor;
            SendButton.BackColor = BackColor;

            InputCommandTextBox.ForeColor = ForeColor;
            ClearButton.ForeColor = ForeColor;
            SendButton.ForeColor = ForeColor;
        }

        /// <summary>
        /// Фиксация нажатия клавиш пользователем.
        /// </summary>
        private void ConsoleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1 && !InProgMode)//F1
            {
                this.Hide();                            //Спрятать форму.
            }
            else if(e.KeyValue == (char)Keys.Enter)     //Enter
            {
                SendButton.PerformClick();              //Нажать кнопку "Send".
            }
        }

        /// <summary>
        /// Нажатие кнопки "Send".
        /// </summary>
        private void SendButton_Click(object sender, EventArgs e)
        {
            if(InputCommandTextBox.Text != "")                                                  //Если входящая комманда НЕ пуста.
            {
                OutputConsole.AppendText(InputCommandTextBox.Text + "\n", Terminal.ForeColor);  //Вставить текст в поле вывода формы(окна) терминала(консоли).
                FulfillCommand(InputCommandTextBox.Text);                                       //Проверить комманду.
                InputCommandTextBox.Text = "";                                                  //Очистить поле ввода комманд.
            }
        }

        /// <summary>
        /// Проверка комманд.
        /// </summary>
        /// <param name="Command">Комманда</param>
        public void FulfillCommand(string Command)
        {
            if(Command.ToLower() == "clear" || Command.ToLower() == "cls")
            {
                OutputConsole.Clear();
                return;
            }
            if (Command.ToLower() == "quiz-app#")
            {
                MessageBox.Show("Developer");
                return;
            }
        }

        /// <summary>
        /// Кнопка очистки поля вывода формы(окна) терминала(консоли).
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputConsole.Clear();  //Очистить поле вывода формы(окна) терминала(консоли).
        }
    }

    /// <summary>
    /// Дополнения для RichTextBox
    /// </summary>
    public static class RichTextBoxExtensions
    {
        /// <summary>
        /// Добавляет текст в конец текущего текста в текстовом поле.
        /// </summary>
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
    public enum CommandType
    {
        User, Creator
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class TerminalCommand : Attribute
    {

        public string Command;
        public CommandType CommandType;
        public string HelpInfo;
        public delegate void CFunc(object param);
        public CFunc CommandFunc;
        public TerminalCommand(string command, CommandType commandType = CommandType.User, string helpInfo = "")
        {
            Command = command;
            CommandType = commandType;
            HelpInfo = helpInfo;
        }
    }
}