using System;
using System.IO;
namespace WeatherBotAPITelegram
{
    internal class ReadAPIKeyFile

    {
        private string _filePath;

        public ReadAPIKeyFile(string filepath) 
        {
            _filePath = filepath;
        }

        public string ReadAPIKey()
        {
            try
            {
                return File.ReadAllText(_filePath);
            }
            catch (Exception ex) { 
                return ex.Message;
            }

        }

    }
}
