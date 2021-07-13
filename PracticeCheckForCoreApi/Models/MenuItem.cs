using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheckForCoreApi.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cousine { get; set; }

        public bool isveg { get; set; }
        public int Calories { get; set; }
        public int Price { get; set; }

    }
}
