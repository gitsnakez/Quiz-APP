using System.Drawing;

namespace QuizApp
{
    /// <summary>
    /// Тип сообщения
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// Обычное сообщение.
        /// </summary>
        Regular,
        /// <summary>
        /// Предупреждение.
        /// </summary>
        Exclamination,
        /// <summary>
        /// Ошибка.
        /// </summary>
        Error
    }

    /// <summary>
    /// Статический класс для управления терминалом(консолью) из любого места программы.
    /// </summary>
    static public class Terminal
    {
        /// <summary>
        /// Форма(окно) терминала(консоли).
        /// </summary>
        static private TerminalForm console;

        /// <summary>
        /// Свойство формы терминала(консоли), означающее её видимость.
        /// </summary>
        static public bool Opened
        {
            get
            {
                if(console.Visible) //Если форма(окно) открыта, то
                {
                    return true;    //Вернуть true и звершить метод.
                }
                else                //Если же форма(окно) закрыта, то
                {
                    return false;   //Вернуть false и звершить метод.
                }
            }
        }

        /// <summary>
        /// Открыть форму(окно) терминала(консоли).
        /// </summary>
        static public void Open()
        {
            console.Show(); //Скрыть форму
        }

        /// <summary>
        /// Закрыть форму(окно) терминала(консоли).
        /// </summary>
        static public void Close()
        {
            console.Hide(); //Показать форму.
        }

        /// <summary>
        /// Создать форму(окно) терминала(консоли).
        /// </summary>
        static public void CreateTerminal()
        {
            console = new TerminalForm(); //Присвоение переменной нового окна консоли.
        }

        /// <summary>
        /// Метод получение формы(окна) терминала(консоли).
        /// </summary>
        /// <returns>форму(окно) терминала(консоли).</returns>
        static public TerminalForm GetForm()
        {
            return console; //Вернуть форму(окно) и звершить метод.
        }

        /// <summary>
        /// Установить новую форму(окно) для этого класса.
        /// </summary>
        /// <param name="terminalForm">Новое форма(окно).</param>
        static public void SetForm(TerminalForm terminalForm)
        {
            console = terminalForm; //Присвоение новой формы(окна) переменной этого класса.
        }

        /// <summary>
        /// Отправить сообщение в терминал(консоль).
        /// </summary>
        /// <param name="MessageContent">Сообщение</param>
        static public void SendMessage(object MessageContent)
        {
            console.OutputConsole.AppendText(MessageContent.ToString() + "\n", ForeColor);  //Вставить текст в поле вывода формы(окна) терминала(консоли).
        }

        /// <summary>
        /// Цвет шрифта сообщений в терминале(консоли).
        /// </summary>
        static public Color ForeColor;

        /// <summary>
        /// Отправить сообщение в терминал(консоль) под какой-либо меткой(какого-либо типа).
        /// </summary>
        /// <param name="MessageContent">Сообщение</param>
        /// <param name="Type">Его тип(обычное сообщение, предупреждение, ошибка)</param>
        static public void SendMessage(object MessageContent, MessageType Type)
        {
            if (Type == MessageType.Error)                                                          //Если тип - ошибка, то
            {
                console.OutputConsole.AppendText(MessageContent.ToString() + "\n", Color.Red);      //Вставить текст с красным цветом шрифта в поле вывода формы(окна) терминала(консоли).
            }
            else if(Type == MessageType.Exclamination)                                              //Если тип - предупреждение, то
            {
                console.OutputConsole.AppendText(MessageContent.ToString() + "\n", Color.Orange);   //Вставить текст с ораньжевым цветом шрифта в поле вывода формы(окна) терминала(консоли).
            }
            else                                                                                    //Если тип - обычное сообщение, то
            {
                console.OutputConsole.AppendText(MessageContent.ToString() + "\n", ForeColor);      //Вставить текст с стандартным цветом шрифта в поле вывода формы(окна) терминала(консоли).
            }
        }
    }
}