using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REALIDCardMaker.Models {
    public class Firefighter {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MI { get; set; }
        public DateTime DOB { get; set; }
        public char Sex { get; set; }
        public int Height { get; set; }
        public string EyeColor { get; set; }
        public string BloodType { get; set; }
        public DateTime StartYear { get; set; }
        public string Rank { get; set; }
        public string Title { get; set; }
    }
}
