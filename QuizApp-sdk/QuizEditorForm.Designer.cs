namespace QuizApp_sdk
{
    partial class QuizEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizEditorForm));
            this.WorkSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ImageButtonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ClearImageButton = new System.Windows.Forms.Button();
            this.OpenImageFile = new System.Windows.Forms.Button();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.VariantsLabel = new System.Windows.Forms.Label();
            this.NextPageIndexTextBox = new System.Windows.Forms.TextBox();
            this.NextPageIndexLabel = new System.Windows.Forms.Label();
            this.PageTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PageTypeLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TableLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.GetSettingsInfoButton = new System.Windows.Forms.Button();
            this.SaveSettingsInfoButton = new System.Windows.Forms.Button();
            this.SettingsTable = new System.Windows.Forms.DataGridView();
            this.SettingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuizPagesWorkarea = new System.Windows.Forms.TabControl();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestOpenProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewQuizPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EndQuizPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mode1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mode2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsoleSplitContainer = new System.Windows.Forms.SplitContainer();
            this.BottomTabPages = new System.Windows.Forms.TabControl();
            this.TerminalTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.WorkSplitContainer)).BeginInit();
            this.WorkSplitContainer.Panel1.SuspendLayout();
            this.WorkSplitContainer.Panel2.SuspendLayout();
            this.WorkSplitContainer.SuspendLayout();
            this.ImageButtonsTableLayout.SuspendLayout();
            this.TableLayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTable)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsoleSplitContainer)).BeginInit();
            this.ConsoleSplitContainer.Panel1.SuspendLayout();
            this.ConsoleSplitContainer.Panel2.SuspendLayout();
            this.ConsoleSplitContainer.SuspendLayout();
            this.BottomTabPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkSplitContainer
            // 
            this.WorkSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.WorkSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.WorkSplitContainer.Name = "WorkSplitContainer";
            // 
            // WorkSplitContainer.Panel1
            // 
            this.WorkSplitContainer.Panel1.AutoScroll = true;
            this.WorkSplitContainer.Panel1.Controls.Add(this.ImageButtonsTableLayout);
            this.WorkSplitContainer.Panel1.Controls.Add(this.ImageLabel);
            this.WorkSplitContainer.Panel1.Controls.Add(this.VariantsLabel);
            this.WorkSplitContainer.Panel1.Controls.Add(this.NextPageIndexTextBox);
            this.WorkSplitContainer.Panel1.Controls.Add(this.NextPageIndexLabel);
            this.WorkSplitContainer.Panel1.Controls.Add(this.PageTypeComboBox);
            this.WorkSplitContainer.Panel1.Controls.Add(this.PageTypeLabel);
            this.WorkSplitContainer.Panel1.Controls.Add(this.TitleTextBox);
            this.WorkSplitContainer.Panel1.Controls.Add(this.TitleLabel);
            this.WorkSplitContainer.Panel1.Controls.Add(this.TableLayoutButtons);
            this.WorkSplitContainer.Panel1.Controls.Add(this.SettingsTable);
            this.WorkSplitContainer.Panel1MinSize = 250;
            // 
            // WorkSplitContainer.Panel2
            // 
            this.WorkSplitContainer.Panel2.Controls.Add(this.QuizPagesWorkarea);
            this.WorkSplitContainer.Panel2MinSize = 400;
            this.WorkSplitContainer.Size = new System.Drawing.Size(1920, 800);
            this.WorkSplitContainer.SplitterDistance = 450;
            this.WorkSplitContainer.TabIndex = 0;
            this.WorkSplitContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplitContainer_MouseDown);
            this.WorkSplitContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplitContainer_MouseMove);
            this.WorkSplitContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SplitContainer_MouseUp);
            // 
            // ImageButtonsTableLayout
            // 
            this.ImageButtonsTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButtonsTableLayout.BackColor = System.Drawing.Color.DarkGray;
            this.ImageButtonsTableLayout.ColumnCount = 2;
            this.ImageButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImageButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImageButtonsTableLayout.Controls.Add(this.ClearImageButton, 0, 0);
            this.ImageButtonsTableLayout.Controls.Add(this.OpenImageFile, 1, 0);
            this.ImageButtonsTableLayout.Location = new System.Drawing.Point(0, 234);
            this.ImageButtonsTableLayout.Name = "ImageButtonsTableLayout";
            this.ImageButtonsTableLayout.RowCount = 1;
            this.ImageButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ImageButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ImageButtonsTableLayout.Size = new System.Drawing.Size(448, 30);
            this.ImageButtonsTableLayout.TabIndex = 15;
            // 
            // ClearImageButton
            // 
            this.ClearImageButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClearImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearImageButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ClearImageButton.FlatAppearance.BorderSize = 0;
            this.ClearImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearImageButton.Location = new System.Drawing.Point(0, 0);
            this.ClearImageButton.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.ClearImageButton.Name = "ClearImageButton";
            this.ClearImageButton.Size = new System.Drawing.Size(223, 30);
            this.ClearImageButton.TabIndex = 2;
            this.ClearImageButton.Text = "Убрать изображение";
            this.ClearImageButton.UseVisualStyleBackColor = false;
            this.ClearImageButton.Click += new System.EventHandler(this.ClearImageButton_Click);
            // 
            // OpenImageFile
            // 
            this.OpenImageFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenImageFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenImageFile.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.OpenImageFile.FlatAppearance.BorderSize = 0;
            this.OpenImageFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenImageFile.Location = new System.Drawing.Point(224, 0);
            this.OpenImageFile.Margin = new System.Windows.Forms.Padding(0);
            this.OpenImageFile.Name = "OpenImageFile";
            this.OpenImageFile.Size = new System.Drawing.Size(224, 30);
            this.OpenImageFile.TabIndex = 1;
            this.OpenImageFile.Text = "Открыть изображение";
            this.OpenImageFile.UseVisualStyleBackColor = false;
            this.OpenImageFile.Click += new System.EventHandler(this.OpenImageFile_Click);
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(10, 210);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(113, 21);
            this.ImageLabel.TabIndex = 11;
            this.ImageLabel.Text = "Изображение:";
            // 
            // VariantsLabel
            // 
            this.VariantsLabel.AutoSize = true;
            this.VariantsLabel.Location = new System.Drawing.Point(10, 270);
            this.VariantsLabel.Name = "VariantsLabel";
            this.VariantsLabel.Size = new System.Drawing.Size(134, 21);
            this.VariantsLabel.TabIndex = 10;
            this.VariantsLabel.Text = "Варианты ответа:";
            // 
            // NextPageIndexTextBox
            // 
            this.NextPageIndexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextPageIndexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NextPageIndexTextBox.Location = new System.Drawing.Point(11, 174);
            this.NextPageIndexTextBox.MaxLength = 2;
            this.NextPageIndexTextBox.Name = "NextPageIndexTextBox";
            this.NextPageIndexTextBox.Size = new System.Drawing.Size(423, 29);
            this.NextPageIndexTextBox.TabIndex = 9;
            this.NextPageIndexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NextPageIndexTextBox_KeyPress);
            // 
            // NextPageIndexLabel
            // 
            this.NextPageIndexLabel.AutoSize = true;
            this.NextPageIndexLabel.Location = new System.Drawing.Point(10, 150);
            this.NextPageIndexLabel.Name = "NextPageIndexLabel";
            this.NextPageIndexLabel.Size = new System.Drawing.Size(227, 21);
            this.NextPageIndexLabel.TabIndex = 8;
            this.NextPageIndexLabel.Text = "Индекс следующей страницы:";
            // 
            // PageTypeComboBox
            // 
            this.PageTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PageTypeComboBox.FormattingEnabled = true;
            this.PageTypeComboBox.Items.AddRange(new object[] {
            "Один вариант ответа",
            "Несколько вариантов ответа",
            "Поле для ввода варианта ответа"});
            this.PageTypeComboBox.Location = new System.Drawing.Point(11, 114);
            this.PageTypeComboBox.Name = "PageTypeComboBox";
            this.PageTypeComboBox.Size = new System.Drawing.Size(423, 29);
            this.PageTypeComboBox.TabIndex = 7;
            // 
            // PageTypeLabel
            // 
            this.PageTypeLabel.AutoSize = true;
            this.PageTypeLabel.Location = new System.Drawing.Point(10, 90);
            this.PageTypeLabel.Name = "PageTypeLabel";
            this.PageTypeLabel.Size = new System.Drawing.Size(92, 21);
            this.PageTypeLabel.TabIndex = 6;
            this.PageTypeLabel.Text = "Тип слайда:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleTextBox.Location = new System.Drawing.Point(11, 34);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(423, 50);
            this.TitleTextBox.TabIndex = 5;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(10, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(77, 21);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Заглавие:";
            // 
            // TableLayoutButtons
            // 
            this.TableLayoutButtons.BackColor = System.Drawing.Color.DarkGray;
            this.TableLayoutButtons.ColumnCount = 2;
            this.TableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutButtons.Controls.Add(this.GetSettingsInfoButton, 0, 0);
            this.TableLayoutButtons.Controls.Add(this.SaveSettingsInfoButton, 1, 0);
            this.TableLayoutButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutButtons.Location = new System.Drawing.Point(0, 768);
            this.TableLayoutButtons.Name = "TableLayoutButtons";
            this.TableLayoutButtons.RowCount = 1;
            this.TableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutButtons.Size = new System.Drawing.Size(448, 30);
            this.TableLayoutButtons.TabIndex = 3;
            // 
            // GetSettingsInfoButton
            // 
            this.GetSettingsInfoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GetSettingsInfoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetSettingsInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.GetSettingsInfoButton.FlatAppearance.BorderSize = 0;
            this.GetSettingsInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetSettingsInfoButton.Location = new System.Drawing.Point(0, 0);
            this.GetSettingsInfoButton.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.GetSettingsInfoButton.Name = "GetSettingsInfoButton";
            this.GetSettingsInfoButton.Size = new System.Drawing.Size(223, 30);
            this.GetSettingsInfoButton.TabIndex = 2;
            this.GetSettingsInfoButton.Text = "Вернуть старые настройки";
            this.GetSettingsInfoButton.UseVisualStyleBackColor = false;
            this.GetSettingsInfoButton.Click += new System.EventHandler(this.GetSettingsInfoButton_Click);
            // 
            // SaveSettingsInfoButton
            // 
            this.SaveSettingsInfoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveSettingsInfoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveSettingsInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SaveSettingsInfoButton.FlatAppearance.BorderSize = 0;
            this.SaveSettingsInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsInfoButton.Location = new System.Drawing.Point(224, 0);
            this.SaveSettingsInfoButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveSettingsInfoButton.Name = "SaveSettingsInfoButton";
            this.SaveSettingsInfoButton.Size = new System.Drawing.Size(224, 30);
            this.SaveSettingsInfoButton.TabIndex = 1;
            this.SaveSettingsInfoButton.Text = "Сохранить настройки";
            this.SaveSettingsInfoButton.UseVisualStyleBackColor = false;
            this.SaveSettingsInfoButton.Click += new System.EventHandler(this.SaveSettingsInfoButton_Click);
            // 
            // SettingsTable
            // 
            this.SettingsTable.AllowUserToAddRows = false;
            this.SettingsTable.AllowUserToDeleteRows = false;
            this.SettingsTable.AllowUserToResizeRows = false;
            this.SettingsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SettingsTable.BackgroundColor = System.Drawing.Color.White;
            this.SettingsTable.ColumnHeadersVisible = false;
            this.SettingsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SettingName,
            this.Setting});
            this.SettingsTable.Location = new System.Drawing.Point(11, 294);
            this.SettingsTable.MultiSelect = false;
            this.SettingsTable.Name = "SettingsTable";
            this.SettingsTable.RowHeadersVisible = false;
            this.SettingsTable.ShowCellErrors = false;
            this.SettingsTable.ShowEditingIcon = false;
            this.SettingsTable.ShowRowErrors = false;
            this.SettingsTable.Size = new System.Drawing.Size(423, 223);
            this.SettingsTable.TabIndex = 0;
            // 
            // SettingName
            // 
            this.SettingName.HeaderText = "Наименование";
            this.SettingName.Name = "SettingName";
            this.SettingName.ReadOnly = true;
            // 
            // Setting
            // 
            this.Setting.HeaderText = "Настройка";
            this.Setting.Name = "Setting";
            // 
            // QuizPagesWorkarea
            // 
            this.QuizPagesWorkarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuizPagesWorkarea.ItemSize = new System.Drawing.Size(20, 26);
            this.QuizPagesWorkarea.Location = new System.Drawing.Point(0, 0);
            this.QuizPagesWorkarea.Name = "QuizPagesWorkarea";
            this.QuizPagesWorkarea.SelectedIndex = 0;
            this.QuizPagesWorkarea.ShowToolTips = true;
            this.QuizPagesWorkarea.Size = new System.Drawing.Size(1464, 798);
            this.QuizPagesWorkarea.TabIndex = 1;
            this.QuizPagesWorkarea.SelectedIndexChanged += new System.EventHandler(this.QuizPagesWorkarea_SelectedIndexChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.CompileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1920, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.TestOpenProjectToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // TestOpenProjectToolStripMenuItem
            // 
            this.TestOpenProjectToolStripMenuItem.Name = "TestOpenProjectToolStripMenuItem";
            this.TestOpenProjectToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.TestOpenProjectToolStripMenuItem.Text = "Открыть проект";
            this.TestOpenProjectToolStripMenuItem.Click += new System.EventHandler(this.TestOpenProjectToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтраницуToolStripMenuItem,
            this.ProjectSettingsToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.EditToolStripMenuItem.Text = "Правка";
            // 
            // добавитьСтраницуToolStripMenuItem
            // 
            this.добавитьСтраницуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewQuizPageToolStripMenuItem,
            this.EndQuizPageToolStripMenuItem});
            this.добавитьСтраницуToolStripMenuItem.Name = "добавитьСтраницуToolStripMenuItem";
            this.добавитьСтраницуToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.добавитьСтраницуToolStripMenuItem.Text = "Добавить страницу";
            // 
            // AddNewQuizPageToolStripMenuItem
            // 
            this.AddNewQuizPageToolStripMenuItem.Name = "AddNewQuizPageToolStripMenuItem";
            this.AddNewQuizPageToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.AddNewQuizPageToolStripMenuItem.Text = "Обычную страницу";
            this.AddNewQuizPageToolStripMenuItem.Click += new System.EventHandler(this.AddNewQuizPageToolStripMenuItem_Click);
            // 
            // EndQuizPageToolStripMenuItem
            // 
            this.EndQuizPageToolStripMenuItem.Name = "EndQuizPageToolStripMenuItem";
            this.EndQuizPageToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.EndQuizPageToolStripMenuItem.Text = "Завершающую страницу";
            this.EndQuizPageToolStripMenuItem.Click += new System.EventHandler(this.EndQuizPageToolStripMenuItem_Click);
            // 
            // ProjectSettingsToolStripMenuItem
            // 
            this.ProjectSettingsToolStripMenuItem.Name = "ProjectSettingsToolStripMenuItem";
            this.ProjectSettingsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ProjectSettingsToolStripMenuItem.Text = "Настройки проекта";
            this.ProjectSettingsToolStripMenuItem.Click += new System.EventHandler(this.ProjectSettingsToolStripMenuItem_Click);
            // 
            // CompileToolStripMenuItem
            // 
            this.CompileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mode1ToolStripMenuItem,
            this.Mode2ToolStripMenuItem});
            this.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem";
            this.CompileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.CompileToolStripMenuItem.Text = "Запуск";
            // 
            // Mode1ToolStripMenuItem
            // 
            this.Mode1ToolStripMenuItem.Name = "Mode1ToolStripMenuItem";
            this.Mode1ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.Mode1ToolStripMenuItem.Text = "Запуск с отладкой";
            this.Mode1ToolStripMenuItem.Click += new System.EventHandler(this.Mode1ToolStripMenuItem_Click);
            // 
            // Mode2ToolStripMenuItem
            // 
            this.Mode2ToolStripMenuItem.Name = "Mode2ToolStripMenuItem";
            this.Mode2ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.Mode2ToolStripMenuItem.Text = "Запуск приложения";
            this.Mode2ToolStripMenuItem.Click += new System.EventHandler(this.Mode2ToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutAppToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "Справка";
            // 
            // AboutAppToolStripMenuItem
            // 
            this.AboutAppToolStripMenuItem.Name = "AboutAppToolStripMenuItem";
            this.AboutAppToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutAppToolStripMenuItem.Text = "О программе";
            this.AboutAppToolStripMenuItem.Click += new System.EventHandler(this.AboutAppToolStripMenuItem_Click);
            // 
            // ConsoleSplitContainer
            // 
            this.ConsoleSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.ConsoleSplitContainer.Name = "ConsoleSplitContainer";
            this.ConsoleSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ConsoleSplitContainer.Panel1
            // 
            this.ConsoleSplitContainer.Panel1.Controls.Add(this.WorkSplitContainer);
            this.ConsoleSplitContainer.Panel1MinSize = 100;
            // 
            // ConsoleSplitContainer.Panel2
            // 
            this.ConsoleSplitContainer.Panel2.Controls.Add(this.BottomTabPages);
            this.ConsoleSplitContainer.Panel2MinSize = 100;
            this.ConsoleSplitContainer.Size = new System.Drawing.Size(1920, 1056);
            this.ConsoleSplitContainer.SplitterDistance = 800;
            this.ConsoleSplitContainer.TabIndex = 2;
            this.ConsoleSplitContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplitContainer_MouseDown);
            this.ConsoleSplitContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplitContainer_MouseMove);
            this.ConsoleSplitContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SplitContainer_MouseUp);
            // 
            // BottomTabPages
            // 
            this.BottomTabPages.Controls.Add(this.TerminalTab);
            this.BottomTabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomTabPages.ItemSize = new System.Drawing.Size(72, 26);
            this.BottomTabPages.Location = new System.Drawing.Point(0, 0);
            this.BottomTabPages.Name = "BottomTabPages";
            this.BottomTabPages.SelectedIndex = 0;
            this.BottomTabPages.Size = new System.Drawing.Size(1918, 250);
            this.BottomTabPages.TabIndex = 0;
            // 
            // TerminalTab
            // 
            this.TerminalTab.Location = new System.Drawing.Point(4, 30);
            this.TerminalTab.Name = "TerminalTab";
            this.TerminalTab.Size = new System.Drawing.Size(1910, 216);
            this.TerminalTab.TabIndex = 2;
            this.TerminalTab.Text = "Терминал";
            this.TerminalTab.UseVisualStyleBackColor = true;
            // 
            // QuizEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.ConsoleSplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "QuizEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizEditor";
            this.Load += new System.EventHandler(this.QuizEditorForm_Load);
            this.WorkSplitContainer.Panel1.ResumeLayout(false);
            this.WorkSplitContainer.Panel1.PerformLayout();
            this.WorkSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkSplitContainer)).EndInit();
            this.WorkSplitContainer.ResumeLayout(false);
            this.ImageButtonsTableLayout.ResumeLayout(false);
            this.TableLayoutButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTable)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ConsoleSplitContainer.Panel1.ResumeLayout(false);
            this.ConsoleSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsoleSplitContainer)).EndInit();
            this.ConsoleSplitContainer.ResumeLayout(false);
            this.BottomTabPages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer WorkSplitContainer;
        private System.Windows.Forms.TabControl QuizPagesWorkarea;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer ConsoleSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.DataGridView SettingsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setting;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompileToolStripMenuItem;
        private System.Windows.Forms.Button SaveSettingsInfoButton;
        private System.Windows.Forms.Button GetSettingsInfoButton;
        private System.Windows.Forms.TableLayoutPanel TableLayoutButtons;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label PageTypeLabel;
        private System.Windows.Forms.ComboBox PageTypeComboBox;
        private System.Windows.Forms.Label NextPageIndexLabel;
        private System.Windows.Forms.TextBox NextPageIndexTextBox;
        private System.Windows.Forms.Label VariantsLabel;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.TableLayoutPanel ImageButtonsTableLayout;
        private System.Windows.Forms.Button ClearImageButton;
        private System.Windows.Forms.Button OpenImageFile;
        private System.Windows.Forms.ToolStripMenuItem Mode2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mode1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтраницуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewQuizPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EndQuizPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestOpenProjectToolStripMenuItem;
        private System.Windows.Forms.TabControl BottomTabPages;
        private System.Windows.Forms.TabPage TerminalTab;
    }
}

