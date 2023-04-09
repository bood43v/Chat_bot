/// Чат-бот
/// @author Budaev G.B.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace Chat_bot_GB
{
    public partial class Form_main : Form
    {
        /// Создание объекта класса MyChatBot
        public MyChatBot Bot = new MyChatBot();

        /// Создание формы  
        public Form_main()      
        {
            InitializeComponent();
            textBox_report.ReadOnly = true;
            /// Фокус на поле ввода запроса
            textBox_request.Select();
        }

        /// Восстановление истории
        public void RestoreChat()
        {
            for (int i = 0; i < Bot.History.Count; i++)
            {
                textBox_report.Text += Bot.History[i] + Environment.NewLine;
            }
        }

        /// Регистрация нажатия Enter
        private void Form_main_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button_enter_Click(button_enter, null);
            }
        }

        /// Отправка запроса
        private void button_enter_Click(object sender, EventArgs e) 
        {
            if (textBox_request.Text != "")
            {
                /// Массив с вопросами и ответами
                String[] userQuestion = textBox_request.Text.Split(new String[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
               
                /// Сообщение для отправки боту
                string message = userQuestion[0]; 

                /// Добавление времени для вывода в чат
                userQuestion[0] = userQuestion[0].Insert(0, "[" + DateTime.Now.ToString("HH:mm") + "] " + Bot.GetUserName() + ": ");

                /// Сохранение в историю
                Bot.AddToHistory(userQuestion);

                /// Вывод в textBox
                textBox_report.AppendText(userQuestion[0] + "\r\n");
                /// Очистка поля ввода
                textBox_request.Text = "";
                /// Получение ответа Бота
                string[] botAnswer = new string[] { Bot.Answer(message) };
                /// Добавление к нему времени
                botAnswer[0] = botAnswer[0].Insert(0, "[" + DateTime.Now.ToString("HH:mm") + "] Бот: ");
                /// Вывод в textBox
                textBox_report.AppendText(botAnswer[0] + Environment.NewLine);
                /// Сохранение в историю
                Bot.AddToHistory(botAnswer);
            }
        }

        /// Если вторая форма закрыта
        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// Для автоматического скроллинга
        private void TextBox_report_TextChanged(object sender, EventArgs e)
        {
            textBox_report.SelectionStart = textBox_report.Text.Length;
            textBox_report.ScrollToCaret();
            textBox_report.Refresh();
        }

        /// Очистка истории
        private void button_clear_Click(object sender, EventArgs e)
        {
            /// Вывод MessageBox для подтверждения удаления истории
            DialogResult dialogResult = MessageBox.Show("Уверены," +
    "что хотите очистить диалог?", "Подтверждение", MessageBoxButtons.YesNo);

            /// Если удаление подтверждено
            if (dialogResult == DialogResult.Yes)
            {
                ///File.WriteAllText(Bot.Path, string.Empty);

                /// Удаление истории
                Bot.History.Clear();

                /// Добавление шапки в историю
                String[] date = new String[] {"Переписка от " +
                        DateTime.Now.ToString("dd.MM.yy"+ "\n")};
                Bot.AddToHistory(date);

                /// Добавление шапки в textBox
                textBox_report.Text = date[0] + "\r\n\r\n";
            }
        }
    }
}
