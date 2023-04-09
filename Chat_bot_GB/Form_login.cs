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

namespace Chat_bot_GB
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            /// Фокус на поле ввода логина
            textBox_login.Select(); 
        }

        /// Регистрация нажатия Enter
        private void Form_login_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button_login_Click(button_login, null);
            }
        }

        /// Авторизация
        private void button_login_Click(object sender, EventArgs e) 
        {
            /// Если логин не введён
            if (textBox_login.Text == "") 
            {
                MessageBox.Show("Вы не ввели имя");
            }
            else
            {
                /// Создание второй формы
                Form_main Form_main = new Form_main();
                /// Установка имени пользователя
                Form_main.Bot.SetUserName(textBox_login.Text);
                /// Загрузка истории
                Form_main.Bot.LoadHistory(textBox_login.Text);
                /// Вывод истории
                Form_main.RestoreChat();
                /// Показываем второе окно
                Form_main.Show();
                /// Скрываем первое
                Hide();
            }
        }
    }
}
