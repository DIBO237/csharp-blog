using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

using Microsoft.EntityFrameworkCore;
namespace BlogApi.Models
{
    public class Blog
    {   
        [Key]
        public int Id { get; set; }

        [Required]
        public string title { get; set; }
        [Required]
        public string shortDesc { get; set; }
        [Required]
        public string desc { get; set; }
          [Required]
         public string slug_id { get; set; }

        public DateTime Date { get;set; } = DateTime.Now;
    }
}