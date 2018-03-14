using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathsApp.Api.Data.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FileName { get; set; }

        [NotMapped]
        public Dictionary<(int, int),(int, int, int)> Pixels { get; set; }

        public string PixelData { get; set; }
    }
}