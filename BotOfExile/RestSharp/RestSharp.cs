using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace BotOfExile.RestSharpApiCalls
{
	class RestSharp
	{
		public string EndPointUrl = "https://pathofexile.gamepedia.com";
		public RestClient EndPoint { get; set; }
		public RestRequest Request { get; set; }
		public IRestResponse Response { get; set; }

		public RestSharp()
		{
			EndPoint = new RestClient(EndPointUrl);
		}

		public bool ResponseStatus(IRestResponse response)
		{
			bool responseCode = (response.StatusDescription == "OK" || response.StatusDescription == "Created" );
			return responseCode;
		}

		private string GetQuery(string query)
		{
			Request = new RestRequest(query, Method.GET);
			Response = EndPoint.Execute(Request);
			ResponseStatus(Response);
			var content = Response.Content;
			return content;
		}

		public Unique GetUniqueItem(string query)
		{
			string response = GetQuery(query);
			var json = JsonConvert.DeserializeObject<Unique>(response);
			return json;
		}
			
	}
}
