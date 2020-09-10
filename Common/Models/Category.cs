using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public List<Car> Cars { get; set; }
    }
}
