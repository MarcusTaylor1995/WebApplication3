using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class IndexViewModel
    {
        // DEFINE THE DATA I NEED FOR THE INDEX
        public string Item { get; set; }
        public string Price { get; set; }
        public List<string> Unit { get; set; } = new List<string>();
        public List<string> ContactName { get; set; } = new List<string>();
        public string ContactNumber { get; set; }
        public string Description { get; set; } = "Hope you will find something here in the store!";
        public List<Database> Data { get; set; } = new List<Database>();

        // CONSTRUCTOR
        public IndexViewModel()
        {
           // Item = new List<string>();
        }

    }
}
