using System;
using System.ComponentModel.DataAnnotations;

namespace Moment3.Models
{
    public class Record
    {
        public int RecordID { get; set; }
        public string? Title { get; set; }
        public string? Year { get; set; }

        [Display(Name = "Artist")]
        public int ArtistID { get; set; }
        public Artist? Artist { get; set; }
    }
}
