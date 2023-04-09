/// Чат-бот
/// @author Budaev G.B.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_bot_GB
{
    public abstract class AbstractChatBot /// Абстрактный класс чат-бота
    {
        public abstract string Answer(string question); /// Ответ на запрос
    }
}
