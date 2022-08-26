using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjectFigma.Data
{
    [Table("Model")]
    public class ModelData
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Title { get; set; }
        [MaxLength(200)]
        [Required]
        public string Description { get; set; }
        [Required]
        [MaxLength(200)]
        public string Url { get; set; }
        [Required]
        public double Money { get; set; }
        [Required]
        [MaxLength(50)] 
        public string Name { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }
        [Required]
        public DateTime UpdateAt { get; set; }
        [Required]
        [MaxLength(50)]
        public string CreateBy { get; set; }
        [Required]
        [MaxLength(50)]
        public string UpdateBy { get; set; }
    }
}
