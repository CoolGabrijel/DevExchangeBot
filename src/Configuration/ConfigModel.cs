
namespace DevExchangeBot.Configuration
{
    public class ConfigModel
    {
        public string Token { get; set; }
        public string Prefix { get; set; }

        public EmojiConfigModel Emoji { get; set; }
    }
}
