using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuizPage : UserControl
    {
        /// <summary>
        /// Контрол вариант.
        /// </summary>
        public Control Variant;

        /// <summary>
        /// Лист(массив) в которму могут находиться CheckBox'ы из блока(CheckBoxBlock) для того, что бы проверять их статус - "Checked".
        /// </summary>
        public List<CheckBox> CheckBoxes;

        /// <summary>
        /// Страница(слайд) опроса.
        /// </summary>
        /// <param name="NextPageMethod">Метод для кнопки "Далее"</param>
        public QuizPage(EventHandler NextPageMethod)
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer,true);
            ButtonNext.Click += NextPageMethod; //Присвоение метода, который дал пользователь к событию нажатия кнопки "Далее".
        }

        /// <summary>
        /// Метод проверки активации кнопки "Далее".
        /// </summary>
        public void CheckedChanged(object sender, EventArgs e)
        {
            if(sender.GetType() == typeof(RadioButton))     //Если тип объекта равен типу RadioButton
            {
                RadioButton RB = (RadioButton)sender;       //Создание новой переменной и присвоение ей объекта.
                if (RB.Checked)                             //Если RadioButton выбран.
                {
                    ButtonNext.Enabled = true;              //Активировать кнопку "Далее".
                }
                else                                        //Если RadioButton невыбран.
                {
                    ButtonNext.Enabled = false;             //Деактивировать кнопку "Далее".
                }
            }
            else if (sender.GetType() == typeof(CheckBox))  //Если тип объекта равен типу CheckBox.
            {
                foreach (CheckBox cb in CheckBoxes)         //Цикл, который перебирает все CheckBox'ы.
                {
                    if (cb.Checked)                         //Если хоть один CheckBox выбран...
                    {
                        ButtonNext.Enabled = true;          //...то кнопка активируется и...
                        return;                             //...метод прекращается.
                    }                                       //Если же ни один CheckBox не выбран, то...
                }
                ButtonNext.Enabled = false;                 //...кнопка деактивируется.
            }
            else if (sender.GetType() == typeof(TextBox))  //Если тип объекта равен типу CheckBox.
            {
                TextBox TB = (TextBox)sender;
                if(TB.Text != "")
                {
                    ButtonNext.Enabled = true;          //...то кнопка активируется и...
                    return;
                }
                ButtonNext.Enabled = false;                 //...кнопка деактивируется.
            }
        }

        private void PageLayout_Resize(object sender, EventArgs e)
        {
            foreach (Control control in PageLayout.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Width = Convert.ToInt32(PageLayout.Width * 0.6);
                }
            }
        }
    }

    /// <summary>
    /// Типы ответов.
    /// </summary>
    public enum QuizType
    {
        /// <summary>
        /// Один вариант.
        /// </summary>
        OneVariant,

        /// <summary>
        /// Несколько вариантов.
        /// </summary>
        FewVariants,

        /// <summary>
        /// Поле ввода.
        /// </summary>
        TextVariant,
        StartPage,
        EndPage
    }

    /// <summary>
    /// Информация для страницы(слайда).
    /// </summary>
    [Serializable]
    public class QuizInfo
    {
        /// <summary>
        /// Оглавление для страницы(слайда).
        /// </summary>
        public string Title;

        /// <summary>
        /// Индекс следующей страницы(слайда) для страницы(слайда).
        /// </summary>
        public int NextPageIndex;

        /// <summary>
        /// Изображение на странице(слайде).
        /// </summary>
        public Image Image;

        /// <summary>
        /// Тип ответа для страницы(слайда).
        /// </summary>
        public QuizType Type;

        /// <summary>
        /// Лист(массив) всех вариантов ответов для страницы(слайда).
        /// </summary>
        public List<string> Variants;
    }
}