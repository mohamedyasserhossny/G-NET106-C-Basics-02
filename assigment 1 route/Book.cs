using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_1_route
{
    internal class Book
    {
        public string title;
        public int pages;
        public override string ToString()
        {
            return $"book title ={title},book pages={pages}";
        }
    }
}
