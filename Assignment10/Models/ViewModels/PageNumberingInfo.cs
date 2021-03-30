using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10.Models.ViewModels
{
    public class PageNumberingInfo
    {
        public int NumItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumItems { get; set; }

        //Calculate the number of pages
        //Turn that top number back into an int to make sure that we have enough pages to show all our pages
        public int NumPages => (int) Math.Ceiling(((decimal) TotalNumItems / NumItemsPerPage));
    }
}
