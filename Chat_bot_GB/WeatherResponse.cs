/// Чат-бот
/// @author Budaev G.B.
/// https://yougame.biz/threads/134263/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_bot_GB
{
    class TemperInfo
    {
        public float Temp { get; set; }
    }

    class WindInfo
    {
        public double Speed { get; set; }
    }

    class WeatherResponse
    {
        public TemperInfo Main { get; set; }

        public string Name { get; set; }

        public WindInfo Wind { get; set; }
    }
}

