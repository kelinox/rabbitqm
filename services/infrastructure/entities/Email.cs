namespace Microservices.Services.Infrastructure.Entities
{
    public class Email
    {
        public int Id { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
    }
}