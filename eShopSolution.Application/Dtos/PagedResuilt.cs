using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Dtos
{
    public class PagedResuilt<T>
    {

        public List<T> Items { set; get; }
        public int TotalRecord { get; set; }
    }
}
