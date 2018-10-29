namespace MRV.Solution.Core.WebApi.Security
{
    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string ExpirationType { get; set; }
        public int Seconds { get; set; }
        public int Minutes { get; set; }
        public int Days { get; set; }
    }
}
