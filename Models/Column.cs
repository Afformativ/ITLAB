using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace WebAPI.Models
{
    public class Column
    {


        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Guid TableId { get; set; }

        public virtual Table Table { get; set; }

    }
}
