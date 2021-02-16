using SportsbookAggregation.SportsBooks.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace SportsbookAggregation.APIService
{
    public static class APIService
    {
        private static OktaTokenService tokenService = new OktaTokenService(Program.Configuration.GetOktaSettings());

        public static void UpdateGameLines(IEnumerable<GameOffering> gameOfferings)
        {
            var token = tokenService.GetToken();
            Program.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Result);
            var content = new StringContent(JsonSerializer.Serialize(gameOfferings), Encoding.UTF8, "application/json");
            Program.HttpClient.PutAsync(Program.Configuration.ReadProperty("APIUrl") + "GameLines", content);
        }
    }
}
