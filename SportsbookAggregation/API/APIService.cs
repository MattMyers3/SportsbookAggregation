using SportsbookAggregation.SportsBooks.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace SportsbookAggregation.API
{
    public static class APIService
    {
        private static OktaTokenService tokenService = new OktaTokenService(Program.Configuration.GetOktaSettings());

        public static void UpdateGameLines(IEnumerable<GameOffering> gameOfferings)
        {
            Update(gameOfferings, "GameLines");
        }

        public static void UpdateOddsBoosts(IEnumerable<OddsBoostOffering> oddsBoostOfferings)
        {
            Update(oddsBoostOfferings, "OddsBoosts");
        }

        public static void UpdatePlayerProps(IEnumerable<PlayerPropOffering> playerPropOfferings)
        {
            Update(playerPropOfferings, "PlayerProp");
        }

        private static void Update<T>(IEnumerable<T> offerings, string endpoint)
        {
            var token = tokenService.GetToken();
            Program.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Result);
            var content = new StringContent(JsonSerializer.Serialize(offerings), Encoding.UTF8, "application/json");
            Program.HttpClient.PutAsync(Program.Configuration.ReadProperty("APIUrl") + endpoint, content);
        }
    }
}
