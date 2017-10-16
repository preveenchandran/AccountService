using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountContract
{
    public class Enterprise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Office> Offices { get; set; }
    }
}
