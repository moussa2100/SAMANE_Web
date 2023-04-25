
using System.Linq.Expressions;
using WebApplication1.Models;

namespace SAMANE_Web.Service
{
    public class DataService<T>  where T : class
    {
        private readonly AppDbContext context;

        public DataService(AppDbContext _context)
        {
            context = _context;
        }

        //public List<T> GetDropDownList()
        //{

        //    using (var newContext = new AppDbContext())
        //    {
        //        return newContext.Set<T>().ToList();
        //    }

        //}

        public List<TResult> GetDropDownList<TResult>(Expression<Func<T, TResult>> selector)
        {
            using (var newContext = new AppDbContext())
            {
                return newContext.Set<T>().Select(selector).ToList();
            }
            
        }

        public List<TResult> GetDropDownListFiltered<TResult>(Func<T, bool> predicate, Func<T, TResult> selector)
        {
            using (var newContext = new AppDbContext())
            {
                return newContext.Set<T>().Where(predicate).Select(selector).ToList();

            }
        }

    }
}
