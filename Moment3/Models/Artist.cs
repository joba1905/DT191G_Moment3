using System;
using System.ComponentModel.DataAnnotations;

namespace Moment3.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string? ArtistName { get; set; }
        public ICollection<Record> Records { get; set; }
    }
}
