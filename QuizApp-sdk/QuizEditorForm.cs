using QuizApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace QuizApp_sdk
{
    public partial class QuizEditorForm : Form
    {
        //ProjectSettings ProjSettings;

        public ProjectSettings ProjSettings;

        /// <summary>
        /// Форма, через которую можно проходить и редактировать тесты.
        /// </summary>
        public QuizEditorForm()
        {
            InitializeComponent();
            InitializeTerminal();                               //Инициализация терминала
            QProjectReader.SetReaderVersion(1.2f);              //Версия QProjReader
            Terminal.SendMessage("");
            Terminal.SendMessage(WelcomeMessage, MessageType.Exclamination);
            Terminal.SendMessage("");
            Terminal.SendMessage("Session start time: " + DateTime.Now.ToString());
            Terminal.SendMessage("Quiz Editor is starting..."); //Вывод в терминал(консоль) данное сообщение с меткой - ошибка.
        }

        string WelcomeMessage = "#################################\n" + "#\t\tQuiz App Editor\t\t#\n" + "#\t\t Version: 11.11\t\t#\n" + "#   snakEZ\t\t\t\t\t#\n" + "#################################";

        public void SetSettings()
        {
            this.Text = $"QuizEditor: <{ProjSettings.QuizName}>";
            foreach (TabPage QuizTab in QuizPagesWorkarea.TabPages)
            {
                foreach(Control control in QuizTab.Controls)
                {
                    if(control.GetType() == typeof(QuizPage))
                    {
                        QuizPage quizPage = (QuizPage)control;
                        if (ProjSettings.IsNumNav)
                        {
                            quizPage.PageCounterLabel.Visible = true;
                        }
                        else
                        {
                            quizPage.PageCounterLabel.Visible = false;
                        }
                        break;
                    }
                }
            }
        }

        public void NewProjectSettings()
        {
            ProjSettings = new ProjectSettings { QuizName = "New Test", IsNumNav = true, QuizList = new List<QuizInfo>() };
        }

        /// <summary>
        /// Метод, который загружает всю информацию о всех страницах(слайдах) опроса из файла опроса.
        /// </summary>
        /// <param name="filename">Путь до файла опроса.</param>
        private void LoadQFile(string filename)
        {
            BinaryFormatter LoadBin = new BinaryFormatter();                                //Создание BinaryFormatter.
            using (Stream Reader = new FileStream(filename, FileMode.OpenOrCreate))         //Создание потока для работы с файлом.
            {
                try
                {
                    ProjSettings = (ProjectSettings)LoadBin.Deserialize(Reader);                   //Присвоение переменной QuizList листа(массива), который был прочитан из файла теста.
                    if (ProjSettings.QuizList.Count >= 1)                                         //Если страниц(слайдов) 
                    {
                        AddTabPages(ProjSettings.QuizList.Count);                                 //Добавить столько-же TABстраниц сколько страниц(слайдов) есть в списке.
                    }
                    Terminal.SendMessage("Quiz File was load successfully!");               //Вывод в терминал(консоль) данное сообщение с меткой - ошибка.
                }
                catch
                {
                    Terminal.SendMessage($"Quiz File wasn't load!", MessageType.Error);     //Вывод в терминал(консоль) данное сообщение с меткой - ошибка.
                    NewProjectSettings();
                    CreateExtraTypeQuizPage(QuizType.StartPage);
                    CreateNewQuizPage();
                }
                SetSettings();
            }
        }

        #region Плавный SplitContainer
        //assign this to the SplitContainer's MouseDown event
        private void SplitContainer_MouseDown(object sender, MouseEventArgs e)
        {
            // This disables the normal move behavior
            ((SplitContainer)sender).IsSplitterFixed = true;
        }

        //assign this to the SplitContainer's MouseUp event
        private void SplitContainer_MouseUp(object sender, MouseEventArgs e)
        {
            // This allows the splitter to be moved normally again
            ((SplitContainer)sender).IsSplitterFixed = false;
        }

        //assign this to the SplitContainer's MouseMove event
        private void SplitContainer_MouseMove(object sender, MouseEventArgs e)
        {
            // Check to make sure the splitter won't be updated by the
            // normal move behavior also
            if (((SplitContainer)sender).IsSplitterFixed)
            {
                // Make sure that the button used to move the splitter
                // is the left mouse button
                if (e.Button.Equals(MouseButtons.Left))
                {
                    // Checks to see if the splitter is aligned Vertically
                    if (((SplitContainer)sender).Orientation.Equals(Orientation.Vertical))
                    {
                        // Only move the splitter if the mouse is within
                        // the appropriate bounds
                        if (e.X > 0 && e.X < ((SplitContainer)sender).Width)
                        {
                            // Move the splitter & force a visual refresh
                            ((SplitContainer)sender).SplitterDistance = e.X;
                            ((SplitContainer)sender).Refresh();
                        }
                    }
                    // If it isn't aligned vertically then it must be
                    // horizontal
                    else
                    {
                        // Only move the splitter if the mouse is within
                        // the appropriate bounds
                        if (e.Y > 0 && e.Y < ((SplitContainer)sender).Height)
                        {
                            // Move the splitter & force a visual refresh
                            ((SplitContainer)sender).SplitterDistance = e.Y;
                            ((SplitContainer)sender).Refresh();
                        }
                    }
                }
                // If a button other than left is pressed or no button
                // at all
                else
                {
                    // This allows the splitter to be moved normally again
                    ((SplitContainer)sender).IsSplitterFixed = false;
                }
            }
        }
        #endregion

        /// <summary>
        /// Метод, вызывающийся при загрузке формы.
        /// </summary>
        private void QuizEditorForm_Load(object sender, EventArgs e)
        {
#if DEBUG
            Terminal.SendMessage("Debug version!", MessageType.Exclamination);             //Вывод в терминал(консоль) данное сообщение.
#endif
            Terminal.SendMessage("Quiz Editor started");                                    //Вывод в терминал(консоль) данное сообщение с меткой - ошибка.
            MakeSettingsTable();                                                            //Вызов метода создания таблицы.

            if (File.Exists("quiz_executable.qf"))                                          //Если файл "quiz_executable.qf" существует, то...
            {
                LoadQFile("quiz_executable.qf");                                            //Загрузить этот файл через метод LoadQFile()
            }
            else
            {
                NewProjectSettings();
                CreateExtraTypeQuizPage(QuizType.StartPage);
                CreateNewQuizPage();                                                        //Вызов метода CreateNewQuizPage()
            }
            SetSettings();
        }

        public void ResetPageTypeComboBox()
        {
            PageTypeComboBox.Enabled = true;
            PageTypeComboBox.Items.Clear();

            PageTypeComboBox.Items.Add("Один вариант ответа");
            PageTypeComboBox.Items.Add("Несколько вариантов ответа");
            PageTypeComboBox.Items.Add("Поле для ввода варианта ответа");
        }

        public void SetFixedItemPageTypeComboBox(QuizType ComboItem)
        {
            SettingsTable.ForeColor = Color.DarkGray;
            SettingsTable.Enabled = false;
            PageTypeComboBox.Items.Clear();
            if(ComboItem == QuizType.StartPage)
            {
                PageTypeComboBox.Items.Add("Начальная страница");
            }
            else if(ComboItem == QuizType.EndPage)
            {
                PageTypeComboBox.Items.Add("Конечная страница");
            }
            PageTypeComboBox.SelectedIndex = 0;
            PageTypeComboBox.Enabled = false;
        }

        /// <summary>
        /// Метод, создающий таблицу настроек
        /// </summary>
        private void MakeSettingsTable()
        {
            SettingsTable.Rows.Add(10);

            for (int i = 0; i < 10; i++)
            {
                SettingsTable.Rows[i].Cells[0].Value = $"Вариант {i+1}";                                                                                //Переименование значения ячейки.
            }

            Terminal.SendMessage("Settings table was created");                                                                                         //Вывод в терминал(консоль) данное сообщение с меткой - ошибка.
        }

        /// <summary>
        /// Метод, который открывает терминал(консоль), изменяет его внешне и добавляет в панель для терминала на форме(в окне) редактора опроса.
        /// </summary>
        private void InitializeTerminal()
        {
            Terminal.CreateTerminal();
            Terminal.Open();

            TerminalForm TF = Terminal.GetForm();
            TF.InProgMode = true;
            TF.TopLevel = false;
            TF.TopMost = false;
            TF.Dock = DockStyle.Fill;
            TF.FormBorderStyle = FormBorderStyle.None;
            TF.OutputConsole.BackColor = Color.Black;
            TF.SetBottomPanelsColors(Color.Black, Color.WhiteSmoke);
            TF.SetDarkIcons();
            Terminal.ForeColor = Color.White;
            Terminal.SetForm(TF);

            TerminalTab.Controls.Add(Terminal.GetForm());
            Terminal.SendMessage("Terminal initialized");
        }

        /// <summary>
        /// Переход на следующую страницу(слайд) по индексу NextPageIndex текущей страницы(слайда).
        /// </summary>
        private void NextPageMethod(object sender, EventArgs e)
        {
            if(ProjSettings.QuizList[QuizPagesWorkarea.SelectedIndex].NextPageIndex == 11223344)
            {
                MessageBox.Show("Тест завершён!", Text);
                QuizPagesWorkarea.SelectedIndex = 0;
            }
            else
            {
                QuizPagesWorkarea.SelectedIndex = ProjSettings.QuizList[QuizPagesWorkarea.SelectedIndex].NextPageIndex;
            }
        }

        /// <summary>
        /// Создает новую TABстраницу и добавляет туда новую страницу(слайд). Для новой страницы(слайда) создается новый класс с информацией о этой странице.
        /// </summary>
        [TerminalCommand("add_new_qpage", CommandType.Creator, "Creating new quiz page for editing")]
        private void CreateNewQuizPage()
        {
            TabPage TabQuizPage = new TabPage();                                                                                    //Создание новой TABстраницы.
            QuizPage QuizPage = new QuizPage(NextPageMethod);                                                                       //Создание новой страницы(слайда) в который передается метод NextPageMethod().
            QuizInfo QuizInfo = new QuizInfo();                                                                                     //Новый класс информации о новой странице.

            //Заполнение класса информации. Здесь находятся стандартные настройки страницы(слайда).
            QuizInfo.Title = "Новый вопрос";
            QuizInfo.NextPageIndex = 0;
            QuizInfo.Type = QuizType.OneVariant;
            QuizInfo.Variants = new List<string>() { "Ответ 1", "Ответ 2" };

            ProjSettings.QuizList.Add(QuizInfo);                                                                                                 //Добавление нового класса инфориации в лист(массив).
            QuizPagesWorkarea.TabPages.Add(TabQuizPage);                                                                            //Добавление новой TABстраницы в список всех TABстраниц.
            QuizPagesWorkarea.SelectedIndex = QuizPagesWorkarea.TabPages.Count - 1;                                                 //Выбор последней TABстраницы.

            TabQuizPage.Text = "Page" + (QuizPagesWorkarea.TabPages.Count - 1).ToString();                                          //Название TABстраницы. Ни на что не влияет. Показывает реальный индекс страницы(слайда).

            QuizPagesWorkarea.SelectedTab.Controls.Add(QuizPage);                                                                   //На выбранную TABстраницу добавляется страница(слайд).
            QuizPage.Dock = DockStyle.Fill;                                                                                         //Страница(слайд) заполняет всю площадь TABсираницы.

            Terminal.SendMessage($"QuizPage: {TabQuizPage.Text} with Index: {QuizPagesWorkarea.TabPages.Count - 1} was created");   //Вывод в терминал(консоль) данное сообщение.
            GetQuizPageInfo();                                                                                                      //Вызов метода, который заполняет таблицу настроек настройками текущей выбранной TABстраницы(страницы(слайда) внутри неё).
            ReNumerateQuizPages();                                                                                                  //Вызов метода, который выставляет индексы страниц на всех страницах(слайдах).
            SetQuizPageInfo();                                                                                                      //Вызов метода, который устанавливает настройки текущей выбранной TABстраницы(страницы(слайда) внутри неё) из таблицы настроек.
        }

        /// <summary>
        /// Создает новую TABстраницу и добавляет туда стартовую страницу(слайд). Для новой страницы(слайда) создается новый класс с информацией о этой странице.
        /// </summary>
        private void CreateExtraTypeQuizPage(QuizType Type)
        {
            TabPage TabQuizPage = new TabPage();                                                                                    //Создание новой TABстраницы.
            QuizPage QuizPage = new QuizPage(NextPageMethod);                                                                       //Создание новой страницы(слайда) в который передается метод NextPageMethod().
            QuizInfo QuizInfo = new QuizInfo();                                                                                     //Новый класс информации о новой странице.

            //Заполнение класса информации. Здесь находятся стандартные настройки страницы(слайда).
            if(Type == QuizType.StartPage)
            {
                QuizInfo.Title = "Стартовая страница";
                QuizInfo.NextPageIndex = 1;
                QuizInfo.Type = QuizType.StartPage;
                QuizPage.ButtonNext.Text = "Начать";
            }
            else if (Type == QuizType.EndPage)
            {
                QuizInfo.Type = QuizType.EndPage;
                QuizInfo.Title = "Завершение теста";
                QuizInfo.NextPageIndex = 11223344;
                QuizPage.ButtonNext.Text = "Завершить";
            }

            ProjSettings.QuizList.Add(QuizInfo);                                                                                    //Добавление нового класса инфориации в лист(массив).
            QuizPagesWorkarea.TabPages.Add(TabQuizPage);                                                                            //Добавление новой TABстраницы в список всех TABстраниц.
            QuizPagesWorkarea.SelectedIndex = QuizPagesWorkarea.TabPages.Count - 1;                                                 //Выбор последней TABстраницы.

            TabQuizPage.Text = "Page" + (QuizPagesWorkarea.TabPages.Count - 1).ToString();                                          //Название TABстраницы. Ни на что не влияет. Показывает реальный индекс страницы(слайда).

            QuizPagesWorkarea.SelectedTab.Controls.Add(QuizPage);                                                                   //На выбранную TABстраницу добавляется страница(слайд).
            QuizPage.ButtonNext.Enabled = true;
            QuizPage.Dock = DockStyle.Fill;                                                                                         //Страница(слайд) заполняет всю площадь TABсираницы.

            Terminal.SendMessage($"QuizPage: {TabQuizPage.Text} with Index: {QuizPagesWorkarea.TabPages.Count - 1} was created");   //Вывод в терминал(консоль) данное сообщение.
            GetQuizPageInfo();                                                                                                      //Вызов метода, который заполняет таблицу настроек настройками текущей выбранной TABстраницы(страницы(слайда) внутри неё).
            ReNumerateQuizPages();                                                                                                  //Вызов метода, который выставляет индексы страниц на всех страницах(слайдах).
            SetQuizPageInfo();                                                                                                      //Вызов метода, который устанавливает настройки текущей выбранной TABстраницы(страницы(слайда) внутри неё) из таблицы настроек.
        }

        /// <summary>
        /// Добавить count-количество TABстраниц.
        /// </summary>
        /// <param name="count">количество TABстраниц</param>
        private void AddTabPages(int count)
        {
            for(int i = 0; i < count; i++)
            {
                TabPage TabQuizPage = new TabPage();                                                                                    //Создание новой TABстраницы.
                QuizPage QuizPage = new QuizPage(NextPageMethod);                                                                       //Создание новой страницы(слайда) в который передается метод NextPageMethod().

                QuizPagesWorkarea.TabPages.Add(TabQuizPage);                                                                            //Добавление новой TABстраницы в список всех TABстраниц.
                QuizPagesWorkarea.SelectedIndex = QuizPagesWorkarea.TabPages.Count - 1;                                                 //Выбор этой новой страницы в списке.

                TabQuizPage.Text = "Page" + (QuizPagesWorkarea.TabPages.Count - 1).ToString();                                          //Название TABстраницы. Ни на что не влияет. Показывает реальный индекс страницы(слайда).

                QuizPagesWorkarea.SelectedTab.Controls.Add(QuizPage);                                                                   //На выбранную TABстраницу добавляется страница(слайд).
                QuizPage.Dock = DockStyle.Fill;                                                                                         //Страница(слайд) заполняет всю площадь TABсираницы.

                Terminal.SendMessage($"QuizPage: {TabQuizPage.Text} with Index: {QuizPagesWorkarea.TabPages.Count - 1} was created");   //Вывод в терминал(консоль) данное сообщение.
                GetQuizPageInfo();                                                                                                      //Вызов метода, который заполняет таблицу настроек настройками текущей выбранной TABстраницы(страницы(слайда) внутри неё).
                ReNumerateQuizPages();                                                                                                  //Вызов метода, который выставляет индексы страниц на всех страницах(слайдах).
                SetQuizPageInfo();                                                                                                      //Вызов метода, который устанавливает настройки текущей выбранной TABстраницы(страницы(слайда) внутри неё) из таблицы настроек.
            }
            QuizPagesWorkarea.SelectedIndex = 0;                                                                                        //Завершение процедуры и переход на главную(первую) страницу.
        }

        /// <summary>
        /// Метод, который выставляет индексы страниц на всех страницах(слайдах).
        /// </summary>
        private void ReNumerateQuizPages()
        {
            foreach(TabPage TabPage in QuizPagesWorkarea.TabPages)                                                                                  //Цикл, который перебирает все TABстраницы в списке TABстраниц.
            {
                foreach (QuizPage QuizPage in TabPage.Controls)                                                                                     //Цикл, который перебирает все страницы(слайды) в TABстранице.
                {
                    try { QuizPage.PageCounterLabel.Text = $"{QuizPagesWorkarea.TabPages.IndexOf(TabPage) + 1}\\{ProjSettings.QuizList.Count}"; } catch { }      //Изменяет в этой странице(слайде) индексы в лейбле.
                    break;                                                                                                                          //Цикл 2 завершён.
                }
            }
        }

        /// <summary>
        /// Переход на другую TABстраницу.
        /// </summary>
        private void QuizPagesWorkarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetQuizPageInfo();      //Получение настроек данной страницы в таблицу настроек.
        }

        /// <summary>
        /// Получение информации о странице(слайде) и добавление её в таблицу настроек.
        /// </summary>
        private void GetQuizPageInfo()
        {
            ImageFileName = null;
            foreach (QuizPage QuizPage in QuizPagesWorkarea.SelectedTab.Controls)
            {
                try 
                {
                    QuizInfo shortQ = ProjSettings.QuizList[QuizPagesWorkarea.TabPages.IndexOf(QuizPagesWorkarea.SelectedTab)];

                    NextPageIndexTextBox.MaxLength = 2;
                    NextPageIndexTextBox.Enabled = true;

                    TitleTextBox.Text = shortQ.Title;
                    if(shortQ.NextPageIndex != 11223344)
                    {
                        NextPageIndexTextBox.Text = shortQ.NextPageIndex.ToString();
                    }

                    ResetPageTypeComboBox();
                    SettingsTable.Enabled = true;
                    SettingsTable.ForeColor = Color.Black;

                    for (int i = 0; i < 10; i++)
                    {
                        SettingsTable.Rows[i].Cells[1].Value = null;
                    }

                    if (shortQ.Type == QuizType.OneVariant)
                    {
                        PageTypeComboBox.SelectedIndex = 0;
                    }
                    else if(shortQ.Type == QuizType.FewVariants)
                    {
                        PageTypeComboBox.SelectedIndex = 1;
                    }
                    else if(shortQ.Type == QuizType.TextVariant)
                    {
                        SettingsTable.ForeColor = Color.DarkGray;
                        SettingsTable.Enabled = false;
                        PageTypeComboBox.SelectedIndex = 2;
                    }
                    else if (shortQ.Type == QuizType.StartPage)
                    {
                        SetFixedItemPageTypeComboBox(QuizType.StartPage);
                    }
                    else if (shortQ.Type == QuizType.EndPage)
                    {
                        SetFixedItemPageTypeComboBox(QuizType.EndPage);
                        NextPageIndexTextBox.MaxLength = 10;
                        NextPageIndexTextBox.Text = "завершение";
                        NextPageIndexTextBox.Enabled = false;
                    }

                    for (int i = 0; i < shortQ.Variants.Count; i++)
                    {
                        SettingsTable.Rows[i].Cells[1].Value = shortQ.Variants[i];
                    }

                    if (shortQ.Image == null)
                    {
                        ImageFileName = null;
                    }
                    else
                    {
                        ImageFileName = "img";
                    }
                }
                catch { }
                break;
            }
        }

        /// <summary>
        /// Получение информации из настроек и добавление её в инфоримацию о странице(слайде).
        /// </summary>
        private void SetQuizPageInfo()
        {
            foreach (QuizPage QuizPage in QuizPagesWorkarea.SelectedTab.Controls)
            {
                try
                {
                    QuizInfo shortQ = ProjSettings.QuizList[QuizPagesWorkarea.TabPages.IndexOf(QuizPagesWorkarea.SelectedTab)];

                    shortQ.Title = TitleTextBox.Text;
                    if (shortQ.NextPageIndex != 11223344)
                    {
                        shortQ.NextPageIndex = Convert.ToInt32(NextPageIndexTextBox.Text);
                    }

                    SettingsTable.Enabled = true;
                    SettingsTable.ForeColor = Color.Black;

                    if (PageTypeComboBox.Enabled)
                    {
                        if (PageTypeComboBox.SelectedIndex == 0)
                        {
                            shortQ.Type = QuizType.OneVariant;
                        }
                        else if (PageTypeComboBox.SelectedIndex == 1)
                        {
                            shortQ.Type = QuizType.FewVariants;
                        }
                        else if (PageTypeComboBox.SelectedIndex == 2)
                        {
                            SettingsTable.ForeColor = Color.DarkGray;
                            SettingsTable.Enabled = false;
                            shortQ.Type = QuizType.TextVariant;
                        }
                    }
                    else
                    {
                        SettingsTable.ForeColor = Color.DarkGray;
                        SettingsTable.Enabled = false;
                    }

                    //Проверка ячеек с вариантами и обновление этих вариантов.
                    shortQ.Variants = new List<string>();
                    for(int i = 0; i < 10; i++)
                    {
                        if(SettingsTable.Rows[i].Cells[1].Value != null)
                            shortQ.Variants.Add(SettingsTable.Rows[i].Cells[1].Value.ToString());
                    }

                    QuizPage.TitleLabel.Text = TitleTextBox.Text;

                    //Убрать старые настройки(старые объекты).
                    List<Control> list = new List<Control>();
                    foreach (Control control in QuizPage.PageLayout.Controls)
                    {
                        if(control.GetType() == typeof(RadioButtonBlock) || control.GetType() == typeof(CheckBoxBlock) || control.GetType() == typeof(TextBox) || control.GetType() == typeof(PictureBox))
                        {
                            list.Add(control);
                        }
                    }
                    for(int i = 0; i < list.Count; i++)
                    {
                        list[i].Dispose();
                    }

                    //Добавление обновленных контролов

                    SettingsTable.Enabled = true;

                    //Image
                    if (ImageFileName == null)
                    {
                        shortQ.Image = null;
                    }
                    else if (ImageFileName == "img")
                    {
                        PictureBox PageImage = new PictureBox();
                        PageImage.Image = shortQ.Image;
                        PageImage.Size = shortQ.Image.Size;
                        PageImage.Anchor = AnchorStyles.None;
                        QuizPage.PageLayout.Controls.Add(PageImage, 0, 1);
                        if (shortQ.Type == QuizType.StartPage || shortQ.Type == QuizType.EndPage)
                        {
                            Terminal.SendMessage("Image on all page");
                            QuizPage.PageLayout.SetRowSpan(PageImage, 2);
                        }
                    }
                    else if (ImageFileName != "img")
                    {
                        shortQ.Image = Image.FromFile(ImageFileName);
                        PictureBox PageImage = new PictureBox();
                        PageImage.Image = shortQ.Image;
                        PageImage.Size = shortQ.Image.Size;
                        PageImage.Anchor = AnchorStyles.None;
                        QuizPage.PageLayout.Controls.Add(PageImage, 0, 1);
                        if (shortQ.Type == QuizType.StartPage || shortQ.Type == QuizType.EndPage)
                        {
                            Terminal.SendMessage("Image on all page");
                            QuizPage.PageLayout.SetRowSpan(PageImage, 2);
                        }
                    }

                    if (shortQ.Type == QuizType.StartPage || shortQ.Type == QuizType.EndPage)
                    {
                        QuizPage.ButtonNext.Enabled = true;
                    }
                    else
                    {
                        if (PageTypeComboBox.SelectedIndex == 0)
                        {
                            RadioButtonBlock OneVariant = new RadioButtonBlock(QuizPage.CheckedChanged);
                            OneVariant.Anchor = AnchorStyles.None; foreach (string var in shortQ.Variants)
                            {
                                OneVariant.AddVariant(var);
                            }
                            if (shortQ.Image == null)
                            {
                                QuizPage.PageLayout.Controls.Add(OneVariant, 0, 1);
                                QuizPage.PageLayout.SetRowSpan(OneVariant, 2);
                            }
                            else
                            {
                                QuizPage.PageLayout.Controls.Add(OneVariant, 0, 2);
                            }
                        }
                        else if (PageTypeComboBox.SelectedIndex == 1)
                        {
                            CheckBoxBlock FewVariants = new CheckBoxBlock(QuizPage.CheckedChanged);
                            FewVariants.Anchor = AnchorStyles.None;
                            foreach (string var in shortQ.Variants)
                            {
                                FewVariants.AddVariant(var);
                            }
                            if (shortQ.Image == null)
                            {
                                QuizPage.PageLayout.Controls.Add(FewVariants, 0, 1);
                                QuizPage.PageLayout.SetRowSpan(FewVariants, 2);
                            }
                            else
                            {
                                QuizPage.PageLayout.Controls.Add(FewVariants, 0, 2);
                            }
                            QuizPage.CheckBoxes = FewVariants.GetAllCheckBoxes();
                        }
                        else if (PageTypeComboBox.SelectedIndex == 2)
                        {
                            SettingsTable.Enabled = false;
                            TextBox TextBox = new TextBox();
                            TextBox.TextChanged += QuizPage.CheckedChanged;
                            TextBox.BorderStyle = BorderStyle.None;
                            TextBox.BackColor = Color.Gainsboro;
                            TextBox.Width = Convert.ToInt32(QuizPage.PageLayout.Width * 0.6);
                            TextBox.Anchor = AnchorStyles.None;
                            if (shortQ.Image == null)
                            {
                                QuizPage.PageLayout.Controls.Add(TextBox, 0, 1);
                                QuizPage.PageLayout.SetRowSpan(TextBox, 2);
                            }
                            else
                            {
                                QuizPage.PageLayout.Controls.Add(TextBox, 0, 2);
                            }
                        }
                    }
                }
                catch { }
                break;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveQuizFile("quiz_executable.qf");
        }

        private void SaveQuizFile(string filepath)
        {
            BinaryFormatter SaveBin = new BinaryFormatter();
            using (Stream Writer = new FileStream(filepath, FileMode.Create))
            {
                SaveBin.Serialize(Writer, ProjSettings);
            }
        }

        private void SaveSettingsInfoButton_Click(object sender, EventArgs e)
        {
            SetQuizPageInfo();
        }

        private void GetSettingsInfoButton_Click(object sender, EventArgs e)
        {
            GetQuizPageInfo();
        }

        private void NextPageIndexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        string ImageFileName;

        private void OpenImageFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Все файлы изображения|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|JPEG (*.jpg, *.jpeg, *.jpe, *.jfif)|*.jpg; *.jpeg; *.jpe; *.jfif|PNG (*.png)|*.png";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image.FromFile(OFD.FileName);
                    ImageFileName = OFD.FileName;
                }
                catch
                {
                    MessageBox.Show("Error!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearImageButton_Click(object sender, EventArgs e)
        {
            ImageFileName = null;
        }

        QuizForm DebugForm;

        private void Mode1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugForm = new QuizForm(ref ProjSettings);
            DebugForm.Show();

            DebugPanel DP = new DebugPanel(DebugForm);
            DP.Show();
            DP.Location = new Point(DebugForm.Location.X + 8, DebugForm.Location.Y - 56);
        }

        private void DebugQuizAppMethod()
        {
            Terminal.SendMessage(2 + 2);
        }

        private void Mode2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveQuizFile("quiz_executable.qf");
            Process process = new Process();
            process.StartInfo.FileName = "QuizApp.exe";
            process.Start();
        }

        private void EndQuizPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateExtraTypeQuizPage(QuizType.EndPage);
        }

        private void AddNewQuizPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewQuizPage();
        }

        private void ProjectSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectSettingsForm PSF = new ProjectSettingsForm(ref ProjSettings);
            PSF.ShowDialog();
            SetSettings();
        }

        private void AboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutQuizAppEditor aboutApp = new AboutQuizAppEditor();
            aboutApp.ShowDialog();
        }

        private void TestOpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Quiz Application Project(*.qproj)|*.qproj";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                QProjectReader.ReadProject(openFileDialog.FileName);
            }
        }
    }
}