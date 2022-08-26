using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFigma.Data
{
    [Table("ColumnDetail")]
    public class ColumnDetailData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "Text")]
        public string Link { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Text { get; set; }
        [Required]
        public int Order { get; set; }
        [ForeignKey("ColumnId")]
        public int ColumnId { get; set; }
        //[ForeignKey("ColumnId")]
        //public virtual ColumnData Column { get; set; }
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
