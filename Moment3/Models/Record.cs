using System;
using System.ComponentModel.DataAnnotations;

namespace Moment3.Models
{
    public class Record
    {
        public int RecordID { get; set; }

        [Required(ErrorMessage = "A CD title is required!")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "The release year is required!")]
        public string? Year { get; set; }

        [Display(Name = "Artist")]
        public int ArtistID { get; set; }
        public Artist? Artist { get; set; }
    }
}
