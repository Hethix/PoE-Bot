﻿using System.Threading.Tasks;
using Discord.Commands;

namespace BotOfExile.Modules
{
    public class UniqueHandler : ModuleBase<SocketCommandContext>
    {
        [Command("Test")]
        public async Task Testing()
        {
            await Context.Channel.SendMessageAsync("Test");
        }
    }
}
