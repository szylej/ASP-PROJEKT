using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameApp.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Comment
    {
        public int CommentID { get; set; }

        [Display(Name = "Treść opini")]
        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string CommentText { get; set; }

        [Display(Name = "Ocena")]
        public Grade? Grade { get; set; }

        [Display(Name = "Ilość przegranych godzin")]
        [RegularExpression(@"^[0-9*]$")]
        public int Hours { get; set; }

    }
}
