using SportsbookAggregation.Alerts;
using SportsbookAggregation.API.APIModels;
using SportsbookAggregation.Data;
using SportsbookAggregation.SportsBooks.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SportsbookAggregation.API
{
    public static class APIService
    {
        private static OktaTokenService tokenService = new OktaTokenService(Program.Configuration.GetOktaSettings());

        public async static Task UpdateGameLines(IEnumerable<GameOffering> gameOfferings, IEnumerable<string> sportsbooks)
        {
            var updateObject = new GameLineUpdateObject(gameOfferings, sportsbooks);
            var content = new StringContent(JsonSerializer.Serialize(updateObject), Encoding.UTF8, "application/json");
            await Update(content , "GameLines");
            if (Program.Configuration.ReadBooleanProperty("RunAlertService"))
            {
                using (var context = new Context())
                {
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        AlertsService.Run(context);
                        dbContextTransaction.Commit();
                    }
                }
            }
        }

        public async static Task UpdateOddsBoosts(IEnumerable<OddsBoostOffering> oddsBoostOfferings, IEnumerable<string> sportsbooks)
        {
            var updateObject = new OddsBoostUpdateObject(oddsBoostOfferings, sportsbooks);
            var content = new StringContent(JsonSerializer.Serialize(updateObject), Encoding.UTF8, "application/json");
            await Update(content, "OddsBoosts");
        }

        public async static Task UpdatePlayerProps(IEnumerable<PlayerPropOffering> playerPropOfferings, IEnumerable<string> sportsbooks)
        {
            var updateObject = new PlayerPropUpdateObject(playerPropOfferings, sportsbooks);
            var content = new StringContent(JsonSerializer.Serialize(updateObject), Encoding.UTF8, "application/json");
            await Update(content, "PlayerProp");
        }

        private async static Task Update(StringContent content, string endpoint)
        {
            var token = tokenService.GetToken();
            Program.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Result);
            await Program.HttpClient.PutAsync(Program.Configuration.ReadProperty("APIUrl") + endpoint, content);
        }
    }
}
