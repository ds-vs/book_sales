using System;
using book_sales.Domain.Enum;

namespace book_sales.Domain.Entity
{
    public class Book
    {
        public int Id { get; set; }
        
        public int Pages { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public decimal Price { get; set; }
        
        public DateTime Data { get; set; }

        public TypeCover TypeCover { get; set; }
    }
}