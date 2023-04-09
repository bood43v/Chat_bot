/// Чат-бот
/// @author Budaev G.B.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;

namespace Chat_bot_GB
{
    /// Класс Чат-Бот
    public class MyChatBot : AbstractChatBot 
    {
        /// Имя пользователя
        static string UserName; 

        /// Путь к файлу с историей сообщений
        string path; 

        /// Хранение истории
        List<string> history = new List<string>(); 

        List<Regex> regecies = new List<Regex>
        {
            new Regex(@"(^(пр(и|e)в)е*т|х(а|e)*й|hi|hello*)"),
            new Regex(@"(?:спасибо|благодарю)"),
            new Regex(@"(число$|дата|дату)"),
            new Regex(@"(?:который час\??|сколько времени|время\??)"),
            new Regex(@"(?:умножь(\s)?(\d+)(\s)?на(\s)?(\d+))"),
            new Regex(@"(?:раздели(\s)?(\d+)(\s)?на(\s)?(\d+))"),
            new Regex(@"(?:сложи(\s)?(\d+)(\s)?и(\s)?(\d+))"),
            new Regex(@"(?:вычти(\s)?(\d+)(\s)?из(\s)?(\d+))"),
            new Regex(@"погод(а|у)$"),
            new Regex(@"айпи"),
            new Regex(@"курс"),
        };

        /// Буфер с ответом
        Func<string, string> funcBuf; 

        /// 
        List<Func<string, string>> func = new List<Func<string, string>>
        {
             Hello,
             ThankYou,
             WhatDate,
             WhatTime,
             Mul,
             Div,
             Sum,
             Sub,
             Weather,
             GetIP,
             GetUSDRate,
        };

        /// <summary>
        /// Курс валют
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string GetUSDRate(string question)
        {
            return "USD";
        }

        /// <summary>
        /// Приветствие
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string Hello(string question) 
        {
            Random rand = new Random();
            string[] mas = { "Привет", "Здравствуй", "Рад приветствовать" };
            int k = rand.Next(mas.Length);
            return mas[k] + ", " + UserName + "!";
        }

        /// <summary>
        /// Благодарность
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string ThankYou(string question) 
        {
            Random rand = new Random();
            string[] mas = { "Рад помочь!", "Обращайтесь!" };
            int k = rand.Next(mas.Length);
            return mas[k];
        }

        /// <summary>
        /// Получение текущей даты
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string WhatDate(string question) 
        {
            return "Сегодня " + DateTime.Now.ToString("dd.MM.yy");
        }

        /// <summary>
        /// Получение текущего времени
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string WhatTime(string question) 
        {
            return "Сейчас: " + DateTime.Now.ToString("HH:mm");
        }

        /// <summary>
        /// Получение IP
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string GetIP(string question) 
        {
            String host = System.Net.Dns.GetHostName();/// Получение ip-адреса
            System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[0];
            return "Ваш ip: " + ip.ToString();
        }

        /// <summary>
        /// Расчёт суммы
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string Sum(string question) 
        {
            question = question.Replace(" ", "");
            question = question.Substring(question.LastIndexOf('ж') + 2);
            string[] words = question.Split(new char[] { 'и' },
            StringSplitOptions.RemoveEmptyEntries);
            try
            {
                int num1 = Convert.ToInt32(words[0]);
                int num2 = Convert.ToInt32(words[1]);
                return (num1 + num2).ToString();
            }
            catch
            {
                return "Я вас не понимаю. Повторите, пожалуйста, ввод :(";
            }
        }

        /// <summary>
        /// Расчёт разности
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string Sub(string question) 
        {
            question = question.Replace(" ", "");
            question = question.Substring(question.LastIndexOf('т') + 2);
            string[] words = question.Split(new char[] { 'и', 'з' },
            StringSplitOptions.RemoveEmptyEntries);
            try
            {
                int num1 = Convert.ToInt32(words[0]);
                int num2 = Convert.ToInt32(words[1]);
                return (num2 - num1).ToString();
            }
            catch
            {
                return "Я вас не понимаю. Повторите, пожалуйста, ввод :(";
            }
        }

        /// <summary>
        /// Расчёт произведения
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string Mul(string question) 
        {
            question = question.Replace(" ", "");
            question = question.Substring(question.LastIndexOf('ь') + 1);
            string[] words = question.Split(new char[] { 'н', 'а' },
            StringSplitOptions.RemoveEmptyEntries);
            try
            {
                int num1 = Convert.ToInt32(words[0]);
                int num2 = Convert.ToInt32(words[1]);
                return (num1 * num2).ToString();
            }
            catch
            {
                return "Я вас не понимаю. Повторите, пожалуйста, ввод :(";
            }
        }

        /// <summary>
        /// Расчёт частного
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string Div(string question) 
        {
            question = question.Replace(" ", "");
            question = question.Substring(question.LastIndexOf('и') + 1);
            string[] words = question.Split(new char[] { 'н', 'а' },
            StringSplitOptions.RemoveEmptyEntries);
            try
            {
                float num1 = Convert.ToInt32(words[0]);
                float num2 = Convert.ToInt32(words[1]);
                return (num1 / num2).ToString();
            }
            catch
            {
                return "Я вас не понимаю. Повторите, пожалуйста, ввод :(";
            }
        }

        /// <summary>
        /// Сеттер имени пользователя
        /// </summary>
        /// <param name="name"></param>
        public void SetUserName(string name)
        {
            UserName = name;
        }

        /// <summary>
        /// Геттер имени пользователя
        /// </summary>
        /// <returns></returns>
        public string GetUserName()
        {
            return UserName;
        }


        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public void Bot() 
        {

        }

        /// <summary>
        /// Получение адреса истории
        /// </summary>
        public string Path 
        {
            get
            {
                return path;
            }
        }

        /// <summary>
        /// Получение истории
        /// </summary>
        public List<string> History 
        {
            get
            {
                return history;
            }
        }

        /// <summary>
        /// Загрузка истории
        /// </summary>
        /// <param name="user"></param>
        public void LoadHistory(string user) 
        {
            UserName = user;
            path = UserName + ".txt"; // Запись пути

            try
            {
                /// Попытка загрузки существующей базы
                history.AddRange(File.ReadAllLines(path, Encoding.GetEncoding(1251)));

                /// Если файл был изменен не сегодня, то записываеося новая дата

                if (File.GetLastWriteTime(path).ToString("dd.MM.yy") !=
                    DateTime.Now.ToString("dd.MM.yy"))
                {
                    String[] date = new String[] {"\n" + "Переписка от " +
                        DateTime.Now.ToString("dd.MM.yy"+ "\n")};
                    AddToHistory(date);
                }
            }
            catch
            {
                /// Если файл не существует, создаем его
                File.WriteAllLines(path, history.ToArray(), Encoding.GetEncoding(1251));
                /// Отмечаем дату начала переписки
                String[] date = new String[] {"Переписка от " +
                        DateTime.Now.ToString("dd.MM.yy") + "\n"};
                AddToHistory(date);
            }
        }

        /// <summary>
        /// Добавление в историю
        /// </summary>
        /// <param name="answer"></param>
        public void AddToHistory(string[] answer) 
        {
            history.AddRange(answer);
            File.WriteAllLines(path, history.ToArray(), Encoding.GetEncoding(1251));
        }
     
        /// <summary>
        /// Получение погоды
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string Weather(string question) 
        {
            String[] infoWeather = FindOutWeather();
            return "Погода в городе " + infoWeather[0] + " " + infoWeather[1] + " °C"
                + ". Ветер " + infoWeather[2] + " м/c";
        }

        /// <summary>
        /// Поиск данных о погоде
        /// </summary>
        /// <returns></returns>
        static private String[] FindOutWeather() 
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Chita&units=metric&" +
                "APPID=128f6776e39eb304aa9cc434fe5c6682";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            WeatherResponse weather = JsonConvert.DeserializeObject <WeatherResponse> (response);

            String[] infoWeather = { weather.Name, weather.Main.Temp.ToString(), weather.Wind.Speed.ToString() };
            return infoWeather;
        }

        /// <summary>
        /// Ответ на запрос
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public override string Answer(string question) 
        {
            question = question.ToLower(); // переводим в нижний регистр

            question = System.Text.RegularExpressions.Regex.Replace(question, @"\s+", " ");

            for (int i = 0; i < regecies.Count; i++)
            {
                if (regecies[i].IsMatch(question))
                {
                    funcBuf = func[i];
                    return funcBuf(question);
                }

            }
            return "Извините, я вас не понимаю";
        }

    }
}
