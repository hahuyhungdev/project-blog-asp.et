﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.enums;
using WebDemo.Models;

namespace WebDemo.Controllers.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly dbBlogsContext _context;
        private IMemoryCache _memroryCache;
        public CategoriesViewComponent(dbBlogsContext context, IMemoryCache memroryCache)
        {
            _context = context;
            _memroryCache = memroryCache;
        }
        public IViewComponentResult Invoke()
        {
            var _lsDanhMuc = _memroryCache.GetOrCreate(CacheKeys.Categories, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsCategories();
            });
            return View(_lsDanhMuc);
        }
        public List<Category> GetlsCategories()
        {
            List<Category> lstins = new List<Category>();
            lstins = _context.Categories
                .Where(x => x.Published == true)
                .OrderBy(x => x.Ordering)
                .ToList();
            return lstins;
        }
    }

}