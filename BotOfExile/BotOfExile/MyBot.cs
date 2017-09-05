using System;
using Discord;
using Discord.Commands;


namespace BotOfExile
{
    class MyBot
    {
        private CommandService commands;
        private DiscordClient _discord;

        public MyBot()
        {
            _discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            _discord.UsingCommands(x =>
            {
                x.AllowMentionPrefix = true;
            });

            commands = _discord.GetService<CommandService>();

            RegisterTestCommand();
            RegisterUniqueCommand();
            RegisterDivCardCommand();

            _discord.ExecuteAndWait(async () =>
            {
                await _discord.Connect("MzIwMzgyNjk0ODg0Mzc2NTg3.DBPx0A.9MJjMxA6jaOsA4CklBmRWxv9Ev8", TokenType.Bot);
            });

        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private void RegisterTestCommand()
        {
            commands.CreateCommand("Test")
                .Do(async e =>
                {
                    await e.Channel.SendMessage("Working");
                });
        }

        private void RegisterUniqueCommand()
        {
            commands.CreateCommand("unique")
                .Parameter("specific")
                .Do(async e =>
                {
                    await e.Channel.SendFile("Unique/" + e.GetArg("specific") + ".PNG");
                });
        }

        private void RegisterDivCardCommand()
        {
            commands.CreateCommand("divCard")
                .Parameter("specific")
                .Do(async e =>
                {
                    await e.Channel.SendFile("DivCard/" + e.GetArg("specific") + ".PNG");
                });
        }
    }
}

