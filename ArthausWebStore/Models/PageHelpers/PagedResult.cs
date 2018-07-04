using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models.PageHelpers
{
    public class PagedResult<T> : PagedResultBase
    {

        public IList<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }
    }
}

