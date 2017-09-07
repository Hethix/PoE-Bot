using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using Discord.Commands;

namespace BotOfExile.Modules
{
    public class UniqueHandler : ModuleBase<SocketCommandContext>
    {
        [Command("Unique")]
        public async Task Testing(string item)
        {
            await Context.Channel.SendMessageAsync(item);
        }		
    }
}
