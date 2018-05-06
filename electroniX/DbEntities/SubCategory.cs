using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace electroniX.DbEntities
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }

        public virtual int MainCategoryId { get; set; }
        public MainCategory MainCategory { get; set; }
    }
}