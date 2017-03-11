using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class BlogLabelViewModel
    {
        public List<Blog> blogs;
        public SelectList labels;
        public string blogLabel { get; set; }
    }
}
