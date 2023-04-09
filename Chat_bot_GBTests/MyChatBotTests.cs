using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chat_bot_GB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_bot_GB.Tests
{
    [TestClass()]
    public class MyChatBotTests
    {
        [TestMethod()]
        public void GetSetUserNameTest()
        {
            MyChatBot bot = new MyChatBot();
            bot.SetUserName("Bob");
            Assert.AreEqual("Bob", bot.GetUserName());
        }

        [TestMethod()]
        public void DateAnswerTest()
        {
            MyChatBot bot = new MyChatBot();
            //bot.SetUserName("Bob");
            string question = "дата";

            Assert.AreEqual("Сегодня " + DateTime.Now.ToString("dd.MM.yy"), bot.Answer(question));
        }

        [TestMethod()]
        public void TimeAnswerTest()
        {
            MyChatBot bot = new MyChatBot();
                //bot.SetUserName("Bob");
            string question = "время";

            Assert.AreEqual("Сейчас: " + DateTime.Now.ToString("HH:mm"), bot.Answer(question));
        }

        [TestMethod()]
        public void IPAnswerTest()
        {
            MyChatBot bot = new MyChatBot();
            //bot.SetUserName("Bob");
            string question = "айпи";

            String host = System.Net.Dns.GetHostName();/// Получение ip-адреса
            System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[0];

            Assert.AreEqual("Ваш ip: " + ip.ToString(), bot.Answer(question));
        }

        [TestMethod()]
        public void MulAnswerTest()
        {
            MyChatBot bot = new MyChatBot();
            //bot.SetUserName("Bob");
            string question = "умножь 2 на   3";
            Assert.AreEqual("6", bot.Answer(question));

            question = "умножь 2 на 3.";
            Assert.AreEqual("Я вас не понимаю. Повторите, пожалуйста, ввод :(", bot.Answer(question));

            question = "умножь 2";
            Assert.AreEqual("Извините, я вас не понимаю", bot.Answer(question));
        }

        [TestMethod()]
        public void DivAnswerTest()
        {
            MyChatBot bot = new MyChatBot();
            //bot.SetUserName("Bob");
            string question = "раздели 3 на   2";
            Assert.AreEqual("1,5", bot.Answer(question));

            question = "раздели 6 на 3.";
            Assert.AreEqual("Я вас не понимаю. Повторите, пожалуйста, ввод :(", bot.Answer(question));

            question = "раздели 6";
            Assert.AreEqual("Извините, я вас не понимаю", bot.Answer(question));
        }

        [TestMethod()]
        public void SumAnswerTest()
        {
            MyChatBot bot = new MyChatBot();
            //bot.SetUserName("Bob");
            string question = "сложи 2 и 3";
            Assert.AreEqual("5", bot.Answer(question));

            question = "сложи 2 и 3.";
            Assert.AreEqual("Я вас не понимаю. Повторите, пожалуйста, ввод :(", bot.Answer(question));

            question = "сложи 2";
            Assert.AreEqual("Извините, я вас не понимаю", bot.Answer(question));
        }

        [TestMethod()]
        public void SubAnswerTest()
        {
            MyChatBot bot = new MyChatBot();
            //bot.SetUserName("Bob");
            string question = "вычти 2 из 3";
            Assert.AreEqual("1", bot.Answer(question));

            question = "вычти 2 из 3.";
            Assert.AreEqual("Я вас не понимаю. Повторите, пожалуйста, ввод :(", bot.Answer(question));

            question = "вычти 2";
            Assert.AreEqual("Извините, я вас не понимаю", bot.Answer(question));
        }

    }
}