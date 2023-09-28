namespace InfinityPlatform.MvcUl.Areas.AdminPanel.Models.Dtos.Client
{
    public class UpdateClientDto
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public string? PhotoPath { get; set; }
    }
}
