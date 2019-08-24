using System;

namespace REALIDCardMaker.Models {
    public class Firefighter {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string MI { get; set; }
        public DateTime DOB { get; set; }
        public char sex { get; set; }
        public int height { get; set; }
        public string eyeColor { get; set; }
        public string bloodType { get; set; }
        public DateTime startYear { get; set; }
        public string rank { get; set; }
        public string title { get; set; }
    }
}
