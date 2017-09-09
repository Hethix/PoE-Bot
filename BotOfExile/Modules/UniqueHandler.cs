using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using BotOfExile.RestSharp;
using System.Threading.Tasks;
using System.Net.Http;
using Discord.Commands;

namespace BotOfExile.Modules
{
    public class UniqueHandler : ModuleBase<SocketCommandContext>
    {
		private RestSharpApiCall Rest { get; set; }

        public UniqueHandler()
        {
            Rest = new RestSharpApiCall();
        }

        [Command("Unique")]
        public async Task Testing(string item)
        {
            var unique = new Unique.Printouts();

            unique.Hasname[0] = item;

            var response = Rest.GetUniqueInfo(unique);

            string message = JsonConvert.SerializeObject(response);

            await Context.Channel.SendMessageAsync(message);
        }
    }
}
