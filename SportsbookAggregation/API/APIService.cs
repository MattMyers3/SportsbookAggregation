using SportsbookAggregation.Alerts;
using SportsbookAggregation.Data;
using SportsbookAggregation.SportsBooks.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public async static Task UpdateGameLines(IEnumerable<GameOffering> gameOfferings)
        {
            await Update(gameOfferings, "GameLines");
            using (var context = new Context())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    AlertsService.Run(context);
                    dbContextTransaction.Commit();
                }
            }
        }

        public async static Task UpdateOddsBoosts(IEnumerable<OddsBoostOffering> oddsBoostOfferings)
        {
            await Update(oddsBoostOfferings, "OddsBoosts");
        }

        public async static Task UpdatePlayerProps(IEnumerable<PlayerPropOffering> playerPropOfferings)
        {
            await Update(playerPropOfferings, "PlayerProp");
        }

        private async static Task Update<T>(IEnumerable<T> offerings, string endpoint)
        {
            var token = tokenService.GetToken();
            Program.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Result);
            var content = new StringContent(JsonSerializer.Serialize(offerings), Encoding.UTF8, "application/json");
            await Program.HttpClient.PutAsync(Program.Configuration.ReadProperty("APIUrl") + endpoint, content);
        }
    }
}
