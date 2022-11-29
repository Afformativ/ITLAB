using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace WebAPI.Models
{
    public class Row
    {

        public Guid Id { get; set; }
        public Guid TableId { get; set; }

        public virtual Table Table { get; set; }
    }
}
