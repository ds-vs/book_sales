using System.ComponentModel.DataAnnotations;

namespace book_sales.Domain.Enum
{
    public enum TypeCover
    {
        [Display(Name = "Твердый переплет")] Hardcover = 0,
        
        [Display(Name = "Мягкий переплет")] Softcover = 1,
        
        [Display(Name = "Суперобложка")] DustJacket = 2,
    }
}