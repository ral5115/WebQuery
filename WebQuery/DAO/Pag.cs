using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuery.DAO
{
    public class Pag<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
        public int TotalR { get; set; }

        public Pag(List<T> items, int count, int pageIndex, int pageSize)
        {

            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            TotalR = count;
            this.AddRange(items);

        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex<TotalPages);
            }
        }

        public static Pag<T> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            try
            {
                var count = source.Count();
                var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return new Pag<T>(items, count, pageIndex, pageSize);
            }
            catch (Exception e)
            {

                throw;
            }

        }

    }
}
