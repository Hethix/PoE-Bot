using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotOfExile.RestSharp
{
    class Query
    {
        public static string ParseToQuery(string uniqueItem)
        {
            foreach (var c in "_")
            {
                uniqueItem = uniqueItem.Replace("_", "+");
            }
            return $"/api.php?action=askargs&format=json&conditions=Has+name%3A%3A+{uniqueItem}&printouts=Has+name%7CHas+base+item%7CHas+level+requirement%7CHas+implicit+stat+text%7CHas+explicit+stat+text%7CHas+flavour+text";
        }
    }
}
