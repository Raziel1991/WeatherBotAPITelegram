using System;
using System.IO;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;

namespace WeatherBotAPITelegram
{
    internal class Program
    {
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\BotToken.txt");
        private static readonly ReadAPIKeyFile apikey = new ReadAPIKeyFile(filePath);
        private static readonly string Token = apikey.ReadAPIKey();
        private static readonly long ChatID = 5003121219;
        private static readonly long WifeChatID = 6713370138;
        private static readonly TelegramBotClient BotMyWeather = new TelegramBotClient(Token);
        static async Task Main(string[] args) // make sure to have it async with task
        {
            
            SendMessageA sendMessageA = new SendMessageA();
            string firstMessage = "good morning";

            try
            {
                await sendMessageA.SendMessageAsync(ChatID, firstMessage, BotMyWeather);
                Console.WriteLine("Message send succesfully");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
