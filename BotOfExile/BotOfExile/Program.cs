using System.Threading.Tasks;
using Discord.WebSocket;
using Discord;

namespace BotOfExile
{
    class Program
    {
        private DiscordSocketClient _discord;
        private CommandHandler _commandHandler;

        static void Main(string[] args)
            => new Program().StartAsync().GetAwaiter().GetResult();
        
        public async Task StartAsync()
        {
            _discord = new DiscordSocketClient();
            _commandHandler = new CommandHandler();
            await _discord.LoginAsync(TokenType.Bot, "MzIwMzgyNjk0ODg0Mzc2NTg3.DJCb9g.-tCEnitVxVnEMzUDqZJSWh7E10c");
            await _discord.StartAsync();
            await _commandHandler.InitializeAsync(_discord);
            await Task.Delay(-1);
        }
    }
}
