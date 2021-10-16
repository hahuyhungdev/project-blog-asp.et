using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.Models;

namespace WebDemo.ModelsView
{
    public class HomeViewModel
    {
        public List<Post> Populars { get; set; }
        public List<Post> Inspiration { get; set; }
        public List<Post> Recents { get; set; }
        public List<Post> Trendings { get; set; }
        public List<Post> LatestPosts { get; set; }
        public Post Featured { get; set; }

    }
}