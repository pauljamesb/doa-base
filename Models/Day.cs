using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOA.Models
{
    public class Day
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public int Distance { get; set; }
        public string Description { get; set; }
        public string URLLink { get; set; }
        public string URLText { get; set; }
    }
}
