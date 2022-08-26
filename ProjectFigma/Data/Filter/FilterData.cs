using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFigma.Data
{
    [Table("Product")]
    public class FilterData
    {
        [Key]

        public int Id { set; get; }
        [Required]
        [MaxLength(200)]
        public string Tilte { set; get; }
        [Required]
        [MaxLength(200)]
        public string Description { set; get; }

        //public int LocationId { get; set; }
        //public int PriceId { get; set; }
        //public int TypeId { get; set; }

        //[ForeignKey("LocationId")]
        //public virtual LocationData Location { get; set; }
        //[ForeignKey("PriceId")]
        //public virtual MaxPriceData MaxPrice { get; set; }
        //[ForeignKey("TypeId")]
        //public virtual PropertyTypeData PropertyType { get; set; }

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
