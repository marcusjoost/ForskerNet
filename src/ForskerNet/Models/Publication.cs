using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForskerNet.Models
{
    public class Publication
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public List<string> Keywords { get; set; }
    }
}
