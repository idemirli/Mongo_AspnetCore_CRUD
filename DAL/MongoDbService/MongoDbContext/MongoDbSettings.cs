using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MongoDbService.MongoDbContext
{
   public class MongoDbSettings
    {
        public string ConnectionString { get; set; }

        public string Database { get; set; }
    }
}
