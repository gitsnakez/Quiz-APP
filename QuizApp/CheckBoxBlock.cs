using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class CheckBoxBlock : UserControl
    {
        /// <summary>
        /// Динамическая высота всего CheckBoxBlock. Меняется в зависимости от количества вариантов(CheckBox'ов).
        /// </summary>
        private int VarHeight = 0;

        /// <summary>
        /// Метод, вызываемый после изменения выбора вариантов(CheckBoxBlock) ответов. Вызывается при любом изменении.
        /// </summary>
        EventHandler EventHandler;

        /// <summary>
        /// CheckBoxBlock - это блок, в котором содержатся CheckBox'ы. Используется в QuizPage для того что бы была возможность выбрать несколько вариантов ответов. Имеет несколько методов взаимодействия.
        /// </summary>
        /// <param name="CheckedChanged">Метод, который будет исполняться после изменения выбора вариантов(CheckBoxBlock) ответов пользователем. Вызывается при любом изменении.</param>
        public CheckBoxBlock(EventHandler CheckedChanged)
        {
            InitializeComponent();          //Инициализация класса
            this.Height = VarHeight;        //Первоначальное присвоение нулевой высоты CheckBoxBlock'у
            EventHandler = CheckedChanged;  //Присвоение метода
        }

        /// <summary>
        /// Уникальный метод для одного из типов вариантов(CheckBoxBlock) ответов. Нужен для метода, который будет вызываться при изменении выбора ответа.
        /// </summary>
        /// <returns>Возвращает Лист(массив), со всеми CheckBox'ами данного Блока CheckBox'ов</returns>
        public List<CheckBox> GetAllCheckBoxes()
        {
            List<CheckBox> cbs = new List<CheckBox>();      //Новый лист(массив) в котором будут лежать CheckBox'ы.

            foreach(Control control in this.Controls)       //Перечисление всех контролов в блоке в цикле
            {
                if(control.GetType() == typeof(CheckBox))   //Сравнение типа контрола с типом CheckBox, если это CheckBox, то...
                {
                    CheckBox cb = (CheckBox)control;        //Этот контрол присваевается к CheckBox'у - "cb"
                    cbs.Add(cb);                            //CheckBox - "cb" добавляется в лист(массив) - "cbs"
                }
            }

            return cbs;                                     //Этот лист(массив) возвращается пользователю.
        }

        /// <summary>
        /// Метод который добавляет новый вариант ответа в общий список вариантов ответов всего CheckBoxBlock.
        /// </summary>
        /// <param name="Variant">Ответ(вариант) в виде строки.</param>
        public void AddVariant(string Variant)
        {
            CheckBox Var = new CheckBox();              //Создается новый CheckBox
            Var.AutoSize = true;                        //Автоматическое изменение размера.
            Var.Text = Variant;                         //Этому CheckBox'у присваевается ответ(вариант), данный пользователем.
            Var.Font = new Font("Segoe UI", 12);        //Так-же CheckBox'у задается единый для всех контролов шрифт.
            Var.CheckedChanged += EventHandler;         //Событию CheckBox.CheckedChanged присваевается метод, данный пользователем при создании CheckBoxBlock.
            this.Controls.Add(Var);                     //Этот CheckBox добавляется в список(на поверхность CheckBoxBlock)
            Var.Location = new Point(0, VarHeight);     //Его локация (0 по X, последнее значение динамической высоты у CheckBoxBlock, тоесть VarHeight)
            VarHeight += 25;                            //Теперь к VarHeight прибавляется высчитанная высота обычного CheckBox'а(25 px.).
            this.Height = VarHeight;                    //Высота всего блока(CheckBoxBlock) увеличивается на новое значение VarHeight.
            SetWidth();                                 //И в конце выставляется ширина для весго блока(CheckBoxBlock).
        }

        /// <summary>
        /// !!! NEED FIX !!! Внутренний метод для блока, нужны для того чтобы определить его новую ширину после обновления вариантов ответа.
        /// </summary>
        private void SetWidth()
        {
            int VarWidth = 0;                           //Обьявление новой переменной VarWidth для этого метода.
            foreach (CheckBox Var in this.Controls)     //Цикл, перечисляющий
            {
                if (Var.Width > VarWidth)               //Сравнение ширины CheckBox'а с последним значением VarWidth(ширины).
                {
                    VarWidth = Var.Width;               //Присвоение нового значения VarWidth(ширины).
                }
            }
            this.Width = VarWidth;                      //Обновление ширины всего блока(CheckBoxBlock).
        }
    }
}