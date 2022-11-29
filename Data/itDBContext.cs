using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class itDBContext : DbContext
    {
        public itDBContext(DbContextOptions options) : base(options)
        {
        }

        public  DbSet<Column> Column { get; set; }
        public  DbSet<DataBase> DataBase { get; set; }
        public  DbSet<Row> Row { get; set; }
        public  DbSet<Table> Table { get; set; }
    }
}
