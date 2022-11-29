namespace WebAPI.Models
{
    public class AddColumnRequest
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Guid TableId { get; set; }

    }
}
