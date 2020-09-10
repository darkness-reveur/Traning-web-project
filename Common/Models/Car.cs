using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string Img { get; set; }
        public ushort Price { get; set; }
        public bool IsFavourite { get; set; }
        public bool IsAvaible { get; set; }


        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
