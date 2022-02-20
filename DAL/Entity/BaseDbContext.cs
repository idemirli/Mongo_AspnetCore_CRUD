using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class BaseDbContext
    {
        public SampleContext _context { get; set; }

        public BaseDbContext(SampleContext context)
        {
            _context = context;
        }
    }
}
