using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keeysight.Models
{

    //https://stackoverflow.com/questions/5550627/two-models-in-one-view-in-asp-mvc-3
    public class ParentTestTable
    {
        public TestTable TestTable { get; set; }
        public TestTableContext TestTableContext { get; set; }

    }
}
