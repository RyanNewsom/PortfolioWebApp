using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Label { get; set; }
        public string Body { get; set; }
    }
}
