using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace WeatherBotAPITelegram
{
    public class SendMessageA
    {
        public async Task SendMessageAsync(long chatID, string message, TelegramBotClient MyBot)
        {
            await MyBot.SendTextMessageAsync(chatID, message);
            
        }
    }
}
