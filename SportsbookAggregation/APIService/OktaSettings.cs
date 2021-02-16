namespace SportsbookAggregation.APIService
{
    public class OktaSettings
    {
        public OktaSettings(string tokenUrl, string clientId, string clientSecret)
        {
            TokenUrl = tokenUrl;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }
        public string TokenUrl { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

    }
}
