using System.ComponentModel.DataAnnotations; //Set of built-in validation attributes that are applied declaratively to a class or property
                                             //Formatting attributes like [DataType] that help with fomratting and don't provide any validation
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string? Title { get; set; }

        [Display(Name ="Release Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] //ApplyFormatInEditMode makes it so when user edits it'll be in this format
                                                                                           //Good to leave this false for some instances such as price
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(0, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName= "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9]")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; } = string.Empty;
    }
}
