using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFigma.Data
{
    [Table("Column")]
    public class ColumnData
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Title { get; set; }
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
        [ForeignKey("ColumnId")]
        public List<ColumnDetailData> columnDetailDatas { get; set; }
    }
}
