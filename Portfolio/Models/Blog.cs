using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Blog
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [StringLength(30)]
        public string Label { get; set; }
        [Required]
        public string Body { get; set; }
    }
}
