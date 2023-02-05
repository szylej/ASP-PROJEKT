using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace GameApp.Models
{
    public class Game
    {
        public int ID { get; set; }

        [Display(Name = "Tytuł")]
        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tytuł nie może być dluższy niż 60 znaków")]
        public string Title { get; set; }

        [Display(Name = "Gatunek")]
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nazwa gatunku nie może być dluższa niż 50 znaków oraz nie może być pusta")]
        public string Type { get; set; }

        [Display(Name = "Rok produkcji")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime YearOfProduction { get; set; }

        [Display(Name = "Opinia")]
        [Required]
        [StringLength(1000, MinimumLength = 3, ErrorMessage = "Pole nie może byc puste")]
        public string CommentText { get; set; }

        [Display(Name = "Ilość przegranych godzin")]
        [RegularExpression(@"\d+$")]
        public int Hours { get; set; }

        [Display(Name = "Ocena w skali od 1-10")]
        [RegularExpression(@"\b([1-9]|10)\b$", ErrorMessage = "Ocena musi być w skali od 1 do 10")]
        public string Grade { get; set; }
    }
}
