using System;
using System.Collections.Generic;

namespace Project4.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int? JerseyNo { get; set; }
        public int? Age { get; set; }
        public string Country { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string Sport { get; set; }
    }
}
