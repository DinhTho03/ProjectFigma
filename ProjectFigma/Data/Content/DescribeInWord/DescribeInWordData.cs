using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFigma.Data
{
    [Table("DescribeInWord")]
    public class DescribeInWordData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        [MaxLength(200)]
        public string TitleSmall { get; set; }

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
