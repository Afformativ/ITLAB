using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace WebAPI.Models
{
    public class DataBase
    {
        public DataBase()
        {
            Table = new HashSet<Table>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Table> Table { get; set; }
    }
}
