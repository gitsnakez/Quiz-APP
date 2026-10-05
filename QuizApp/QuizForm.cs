using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace QuizApp
{
    public enum ColorTheme
    {
        LightTheme,DarkTheme
    }

    public partial class QuizForm : Form
    {
        public bool IsDebugging = false;
        public bool FixedDebugPanel = true;
        public delegate void VoidDelegate();
        public VoidDelegate ReLocatorOnMaximize;
        public Form DebugForm;

        /// <summary>
        /// Форма, через которую можно проходить тест(ы)
        /// </summary>
        public QuizForm()
        {
            InitializeComponent();
            Terminal.CreateTerminal();                                                          //Создание(инициализация) терминала(консоли).
            Terminal.ForeColor = Color.White;                                                   //Изменение цвета шрифта в терминале(консоли) на белый.
            Terminal.SendMessage("QuizApp started");                                            // 
            Terminal.SendMessage("Terminal initialized");                                       //  Вывод в терминал(консоль) данные сообщения.
            Terminal.SendMessage("Starting Quiz file...");                                      // 
            ImportQuizFile("quiz_executable.qf");                                               //Загрузка файла с информацией о тесте.
#if DEBUG
            Terminal.SendMessage("Debug version!", MessageType.Exclamination);             //Вывод в терминал(консоль) данное сообщение.
#endif
            TerminalKey = true;
        }

        private Color ThemeBackColor = Color.White;
        private Color ThemeBackColor2 = Color.Gainsboro;
        private Color ThemeInteractiveColor = Color.DarkGray;
        private Color ThemeForeColor = Color.Black;

        private void QuizForm_Load(object sender, EventArgs e)
        {
            BarMoreButton.Text = "";
            BarMoreButton.Image = Properties.Resources.QuizPage_32x32;
            RightBar.Width = 40;
            RightBar.BackColor = Color.Transparent;
            //Цветовая тема
            foreach (Control control in RightBar.Controls)
            {
                if (control != BarMoreButton)
                {
                    control.Visible = false;
                }
            }
        }

        public QuizForm(ref ProjectSettings projectSettings)
        {
            InitializeComponent();
            Terminal.SendMessage("Starting Quiz file...");
            ProjSettings = projectSettings;
            this.Text = ProjSettings.QuizName;
            LoadQuizPage(0);                                //Загрузка первого слайда. По стандарту - 0.
            TerminalKey = false;
        }

        private ProjectSettings ProjSettings;

        bool TerminalKey;

        /// <summary>
        /// Метод, который загружает всю информацию о всех страницах(слайдах) опроса из файла опроса.
        /// </summary>
        /// <param name="QF_Path">Путь до файла опроса.</param>
        public void ImportQuizFile(string QF_Path)
        {
            BinaryFormatter LoadBin = new BinaryFormatter();                                        //Создание BinaryFormatter.
            using (Stream Reader = new FileStream(QF_Path, FileMode.OpenOrCreate))                  //Создание потока для работы с файлом.
            {
                try
                {
                    ProjSettings = (ProjectSettings)LoadBin.Deserialize(Reader);                    //Присвоение переменной QuizList листа(массива), который был прочитан из файла теста.
                    Terminal.SendMessage("Quiz File was load successfully!");                       //Вывод в терминал(консоль) данное сообщение.
                    LoadQuizPage(0);                                                                //Загрузка первого слайда. По стандарту - 0.
                    this.Text = ProjSettings.QuizName;
                }
                catch
                {
                    Terminal.SendMessage($"Quiz File wasn't load!", MessageType.Error);             //Вывод в терминал(консоль) данное сообщение с меткой - ошибка.
                    Terminal.Open();                                                                //Открытие терминала(консоли).
                }
            }
        }

        /// <summary>
        /// Внутренняя переменная класса, служащаяя для запоминания прошлого индекса следующей страницы.
        /// </summary>
        private int LastIndexOfNextPage;

        public int ActualIndexPage;

        /// <summary>
        ///  Внутренний метод, нужный для того, что бы фиксировать нажатие на кнопку "Далее".
        /// </summary>
        private void NextPageMethod(object sender, EventArgs e)
        {
            if (LastIndexOfNextPage == 11223344 && !TerminalKey)
            {
                if (MessageBox.Show("Тест завершён!\nВы хотите его повторить?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LoadQuizPage(0);
                }
                else
                {
                    this.Close();
                }
            }
            else if (LastIndexOfNextPage == 11223344)
            {
                this.Close();
            }
            else
            {
                LoadQuizPage(LastIndexOfNextPage);
            }
        }

        /// <summary>
        /// Метод, который дает возможность загружать новую страницу(слайд) опроса.
        /// </summary>
        /// <param name="index">Индекс страницы(слайда) опроса</param>
        public void LoadQuizPage(int index)
        {
            try
            {
                MainPanel.Controls.Clear();                                                         //Очищение формы от страниц(слайдов).
                QuizPage quizPage = new QuizPage(NextPageMethod);                                   //Создание новой страницы(слайда).

                quizPage.TitleLabel.Text = ProjSettings.QuizList[index].Title;                      //Изменение её оглавления.
                quizPage.PageCounterLabel.Visible = ProjSettings.IsNumNav;

                if (ProjSettings.QuizList[index].Image != null)
                {
                    PictureBox PageImage = new PictureBox();
                    PageImage.Image = ProjSettings.QuizList[index].Image;
                    PageImage.Size = ProjSettings.QuizList[index].Image.Size;
                    PageImage.Anchor = AnchorStyles.None;
                    quizPage.PageLayout.Controls.Add(PageImage, 0, 1);
                    if (ProjSettings.QuizList[index].Type == QuizType.StartPage || ProjSettings.QuizList[index].Type == QuizType.EndPage)
                    {
                        quizPage.PageLayout.SetRowSpan(PageImage, 2);
                    }
                }

                if (ProjSettings.QuizList[index].Type == QuizType.FewVariants)                      //Если тип выбора ответа: несколько, то...
                {
                    CheckBoxBlock FewVariants = new CheckBoxBlock(quizPage.CheckedChanged);         //Создается CheckBoxBlock.
                    quizPage.Variant = FewVariants;
                    FewVariants.Anchor = AnchorStyles.None;                                         //Убирается AnchorStyle для центрирования в ячейке TableFlowLayout.
                    foreach (string var in ProjSettings.QuizList[index].Variants)                   //Запускается цикл, который перебирает все Варианты под нужным индексом страницы.
                    {
                        FewVariants.AddVariant(var);                                                //Добавляется новый вариант в CheckBoxBlock.
                    }
                    //CheckBoxBlock добавляется в страницу(слайд), в нужную ячейку.
                    if (ProjSettings.QuizList[index].Image == null)
                    {
                        quizPage.PageLayout.Controls.Add(FewVariants, 0, 1);
                        quizPage.PageLayout.SetRowSpan(FewVariants, 2);
                    }
                    else
                    {
                        quizPage.PageLayout.Controls.Add(FewVariants, 0, 2);
                    }
                    quizPage.CheckBoxes = FewVariants.GetAllCheckBoxes();                           //Все CheckBox'ы из этого блока(CheckBoxBlock) добавляются в лист(массив) CheckBox'ов этой страницы, для того что бы проверять их статус - "Checked".
                }
                else if (ProjSettings.QuizList[index].Type == QuizType.OneVariant)                  //, если же тип выбора ответа: один, то...
                {
                    RadioButtonBlock OneVariant = new RadioButtonBlock(quizPage.CheckedChanged);    //Создается RadioButtonBlock.
                    quizPage.Variant = OneVariant;
                    OneVariant.Anchor = AnchorStyles.None;                                          //Убирается AnchorStyle для центрирования в ячейке TableFlowLayout.
                    foreach (string var in ProjSettings.QuizList[index].Variants)                   //Запускается цикл, который перебирает все Варианты под нужным индексом страницы.
                    {
                        OneVariant.AddVariant(var);                                                 //Добавляется новый вариант в RadioButtonBlock.
                    }
                    //CheckBoxBlock добавляется в страницу(слайд), в нужную ячейку.
                    if (ProjSettings.QuizList[index].Image == null)
                    {
                        quizPage.PageLayout.Controls.Add(OneVariant, 0, 1);
                        quizPage.PageLayout.SetRowSpan(OneVariant, 2);
                    }
                    else
                    {
                        quizPage.PageLayout.Controls.Add(OneVariant, 0, 2);
                    }
                }
                else if (ProjSettings.QuizList[index].Type == QuizType.TextVariant)                 //, если же тип выбора ответа: один, то...
                {
                    TextBox TextVariant = new TextBox();                                            //Создается RadioButtonBlock.
                    TextVariant.TextChanged += quizPage.CheckedChanged;
                    quizPage.Variant = TextVariant;
                    TextVariant.BorderStyle = BorderStyle.None;
                    TextVariant.Anchor = AnchorStyles.None;                                         //Убирается AnchorStyle для центрирования в ячейке TableFlowLayout.
                    TextVariant.Width = Convert.ToInt32(quizPage.PageLayout.Width * 0.6);
                    //CheckBoxBlock добавляется в страницу(слайд), в нужную ячейку.
                    if (ProjSettings.QuizList[index].Image == null)
                    {
                        quizPage.PageLayout.Controls.Add(TextVariant, 0, 1);
                        quizPage.PageLayout.SetRowSpan(TextVariant, 2);
                    }
                    else
                    {
                        quizPage.PageLayout.Controls.Add(TextVariant, 0, 2);
                    }
                }
                else if (ProjSettings.QuizList[index].Type == QuizType.StartPage)
                {
                    quizPage.ButtonNext.Enabled = true;
                    quizPage.ButtonNext.Text = "Начать";
                }
                else if (ProjSettings.QuizList[index].Type == QuizType.EndPage)
                {
                    quizPage.ButtonNext.Enabled = true;
                    quizPage.ButtonNext.Text = "Завершить";
                }

                LastIndexOfNextPage = ProjSettings.QuizList[index].NextPageIndex;                   //Сохраняется новое значение последнего индекса следующей страницы.
                ActualIndexPage = index;
                SetPageColors(quizPage);

                MainPanel.Controls.Add(quizPage);                                                        //Эта страница(слайд) добавляется на форму.

                quizPage.PageCounterLabel.Text = $"{index + 1}\\{ProjSettings.QuizList.Count}";       //Обновляется счётчик на этой странице( {эта страница: index + 1} \ {общее количество страниц})
                quizPage.Dock = DockStyle.Fill;                                                     //Растягивается на всю страницу.

                Terminal.SendMessage($"Quiz Page Number: {index} was load successfully!");          //Вывод в терминал(консоль) данное сообщение.
            }
            catch
            {
                Terminal.SendMessage("Quiz Page wasn't load!", MessageType.Error);                  //Вывод в терминал(консоль) данное сообщение с меткой - ошибка.
            }
        }

        /// <summary>
        /// Фиксация нажатия пользователем по клавишам.
        /// </summary>
        private void QuizForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1 && TerminalKey)  //Клавиша - F1
            {
                if (Terminal.Opened)        //Если терминал(консоль) открыта.
                {
                    Terminal.Close();       //Закрыть терминал(консоль).
                }
                else                        //Если же терминал(консоль) закрыт.
                {
                    Terminal.Open();        //Закрыть терминал(консоль).
                }
            }
        }

        private bool BarIsOpen = false;

        private void BarMoreButton_Click(object sender, EventArgs e)
        {
            BarTimer.Start();
        }

        private void BarTimer_Tick(object sender, EventArgs e)
        {
            if (BarIsOpen)
            {
                BarMoreButton.Text = "";
                BarMoreButton.Image = Properties.Resources.QuizPage_32x32;
                if (RightBar.Width > 40)
                {
                    RightBar.Width -= 20;
                }
                else
                {
                    BarIsOpen = false;
                    RightBar.BackColor = Color.Transparent;
                    foreach(Control control in RightBar.Controls)
                    {
                        if(control != BarMoreButton)
                            control.Visible = false;
                    }
                    BarTimer.Stop();
                }
            }
            else
            {
                RightBar.BackColor = ThemeBackColor2;
                BarMoreButton.Text = "Скрыть";
                BarMoreButton.Image = null;
                foreach (Control control in RightBar.Controls)
                {
                    if (control != BarMoreButton)
                        control.Visible = true;
                }
                if (RightBar.Width < 300)
                {
                    RightBar.Width += 20;
                }
                else
                {
                    BarIsOpen = true;
                    BarTimer.Stop();
                }
            }
        }

        ColorTheme ThemeStatus = ColorTheme.LightTheme;
        
        private void LightThemeButton_Click(object sender, EventArgs e)
        {
            if(ThemeStatus == ColorTheme.DarkTheme)
            {
                ThemeStatus = ColorTheme.LightTheme;

                ThemeBackColor = Color.White;
                ThemeBackColor2 = Color.Gainsboro;
                ThemeInteractiveColor = Color.DarkGray;
                ThemeForeColor = Color.Black;

                LightThemeButton.BackColor = ThemeInteractiveColor;
                DarkThemeButton.BackColor = ThemeBackColor2;

                SetColors();
            }
        }

        private void DarkThemeButton_Click(object sender, EventArgs e)
        {
            if (ThemeStatus == ColorTheme.LightTheme)
            {
                ThemeStatus = ColorTheme.DarkTheme;

                ThemeBackColor = Color.FromArgb(64, 64, 64);
                ThemeBackColor2 = Color.FromArgb(40, 40, 40);
                ThemeInteractiveColor = Color.FromArgb(72, 72, 72);
                ThemeForeColor = Color.White;

                LightThemeButton.BackColor = ThemeBackColor2;
                DarkThemeButton.BackColor = ThemeInteractiveColor;

                SetColors();
            }
        }

        private void SetColors()
        {
            BarMoreButton.BackColor = ThemeBackColor2;

            BackColor = ThemeBackColor;
            ForeColor = ThemeForeColor;

            MainPanel.BackColor = ThemeBackColor;
            MainPanel.ForeColor = ThemeForeColor;

            foreach(Control control in MainPanel.Controls)
            {
                if(control.GetType() == typeof(QuizPage))
                {
                    QuizPage quizPage = (QuizPage)control;
                    SetPageColors(quizPage);
                    break;
                }
            }

            RightBar.BackColor = ThemeBackColor2;
            RightBar.ForeColor = ThemeForeColor;

            ChangeLogButton.BackColor = ThemeBackColor2;
            ChangeLogButton.ForeColor = ThemeForeColor;

            AboutAppButton.BackColor = ThemeBackColor2;
            AboutAppButton.ForeColor = ThemeForeColor;
        }

        private void SetPageColors(QuizPage page)
        {
            page.BackColor = ThemeBackColor;
            page.ForeColor = ThemeForeColor;

            if(page.Variant != null && page.Variant.GetType() == typeof(TextBox))
            {
                page.Variant.BackColor = ThemeBackColor2;
                page.Variant.ForeColor = ThemeForeColor;
            }

            page.ButtonNext.BackColor = ThemeBackColor2;
        }

        private void AboutAppButton_Click(object sender, EventArgs e)
        {
            AboutQuizApp aboutQuizApp = new AboutQuizApp();
            aboutQuizApp.ThemeBackColor = ThemeBackColor;
            aboutQuizApp.ThemeBackColor2 = ThemeBackColor2;
            aboutQuizApp.ThemeForeColor = ThemeForeColor;
            aboutQuizApp.ShowDialog();
        }

        private void ChangeLogButton_Click(object sender, EventArgs e)
        {
            ChangeLogForm ChangeLogs = new ChangeLogForm(ThemeStatus);
            ChangeLogs.ShowDialog();
        }

        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsDebugging)
            {
                DebugForm.Close();
            }
        }

        public void SetDebugPanel()
        {
            if (IsDebugging && FixedDebugPanel)
            {
                DebugForm.Location = new Point(this.Location.X + 8, this.Location.Y - 56);
            }
        }

        private void QuizForm_LocationChanged(object sender, EventArgs e)
        {
            SetDebugPanel();
        }

        private void QuizForm_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized && FixedDebugPanel)
            {
                ReLocatorOnMaximize();
            }
        }
    }
}