using System.Linq;
using WebDemo.Models;

namespace WebDemo.Areas.Admin.Controllers
{
    internal class PagedList<T>
    {
        private IQueryable<Post> posts;
        private int pageNumber;
        private int pageSize;
        private IOrderedQueryable<Category> isCategories;
        private IOrderedQueryable<Account> lsAccounts;

        public PagedList(IQueryable<Post> posts, int pageNumber, int pageSize)
        {
            this.posts = posts;
            this.pageNumber = pageNumber;
            this.pageSize = pageSize;
        }

        public PagedList(IOrderedQueryable<Category> isCategories, int pageNumber, int pageSize)
        {
            this.isCategories = isCategories;
            this.pageNumber = pageNumber;
            this.pageSize = pageSize;
        }

        public PagedList(IOrderedQueryable<Account> lsAccounts, int pageNumber, int pageSize)
        {
            this.lsAccounts = lsAccounts;
            this.pageNumber = pageNumber;
            this.pageSize = pageSize;
        }
    }
}