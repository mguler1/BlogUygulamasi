using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogUygulaması.Web.Models
{
    public class BlogListModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime ReleaseTime { get; set; }
    }
}
