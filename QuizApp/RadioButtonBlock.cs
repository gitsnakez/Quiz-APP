using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class RadioButtonBlock : UserControl
    {
        /// <summary>
        /// Динамическая высота всего RadioButtonBlock. Меняется в зависимости от количества вариантов(RadioButton'ов).
        /// </summary>
        private int VarHeight = 0;

        /// <summary>
        /// Метод, вызываемый после изменения выбора вариантов(RadioButtonBlock) ответов. Вызывается при любом изменении.
        /// </summary>
        EventHandler EventHandler;

        /// <summary>
        /// RadioButtonBlock - это блок, в котором содержатся RadioButton'ы. Используется в QuizPage для того что бы была возможность выбрать несколько вариантов ответов. Имеет несколько методов взаимодействия.
        /// </summary>
        /// <param name="CheckedChanged">Метод, который будет исполняться после изменения выбора вариантов(RadioButtonBlock) ответов пользователем. Вызывается при любом изменении.</param>
        public RadioButtonBlock(EventHandler CheckedChanged)
        {
            InitializeComponent();           //Инициализация класса
            this.Height = VarHeight;         //Первоначальное присвоение нулевой высоты RadioButtonBlock'у
            EventHandler = CheckedChanged;   //Присвоение метода
        }

        /// <summary>
        /// Метод который добавляет новый вариант ответа в общий список вариантов ответов всего RadioButtonBlock.
        /// </summary>
        /// <param name="Variant">Ответ(вариант) в виде строки.</param>
        public void AddVariant(string Variant)
        {
            RadioButton Var = new RadioButton();        //Создается новый RadioButton
            Var.AutoSize = true;                        //Автоматическое изменение размера.
            Var.Text = Variant;                         //Этому RadioButton'у присваевается ответ(вариант), данный пользователем.
            Var.Font = new Font("Segoe UI", 12);        //Так-же RadioButton'у задается единый для всех контролов шрифт.
            Var.CheckedChanged += EventHandler;         //Событию RadioButton.CheckedChanged присваевается метод, данный пользователем при создании RadioButtonBlock.
            this.Controls.Add(Var);                     //Этот RadioButton добавляется в список(на поверхность RadioButtonBlock)
            Var.Location = new Point(0, VarHeight);     //Его локация (0 по X, последнее значение динамической высоты у RadioButtonBlock, тоесть VarHeight)
            VarHeight += 25;                            //Теперь к VarHeight прибавляется высчитанная высота обычного RadioButton'а(25 px.).
            this.Height = VarHeight;                    //Высота всего блока(RadioButtonBlock) увеличивается на новое значение VarHeight.
            SetWidth();                                 //И в конце выставляется ширина для весго блока(RadioButtonBlock).
        }

        /// <summary>
        /// !!! NEED FIX !!! Внутренний метод для блока, нужны для того чтобы определить его новую ширину после обновления вариантов ответа.
        /// </summary>
        private void SetWidth()
        {
            int VarWidth = 0;                           //Обьявление новой переменной VarWidth для этого метода.
            foreach (RadioButton Var in this.Controls)  //Цикл, перечисляющий
            {
                if (Var.Width > VarWidth)               //Сравнение ширины RadioButton'а с последним значением VarWidth(ширины).
                {
                    VarWidth = Var.Width;               //Присвоение нового значения VarWidth(ширины).
                }
            }
            this.Width = VarWidth;                      //Обновление ширины всего блока(RadioButtonBlock).
        }
    }
}