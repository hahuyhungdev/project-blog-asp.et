using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.enums;
using WebDemo.Models;
namespace WebDemo.Controllers.Components
{
    public class PopularViewComponent : ViewComponent
    {
        private readonly dbBlogsContext _context;
        private IMemoryCache _memroryCache;
        public PopularViewComponent(dbBlogsContext context, IMemoryCache memroryCache)
        {
            _context = context;
            _memroryCache = memroryCache;
        }
        public IViewComponentResult Invoke()
        {
            var _tinseo = _memroryCache.GetOrCreate(CacheKeys.Popular, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsCategories();
            });
            return View(_tinseo);
        }
        public List<Post> GetlsCategories()
        {
            List<Post> lstins = new List<Post>();
            lstins = _context.Posts
                .Where(x => x.Published == true)
                .OrderByDescending(x => x.Xem)
                .Take(6)
                .ToList();
            return lstins;
        }
    }
}
