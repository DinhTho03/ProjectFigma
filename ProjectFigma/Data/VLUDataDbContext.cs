using Microsoft.EntityFrameworkCore;



namespace ProjectFigma.Data
{
    public class VLUDataDbContext : DbContext
    {
        public VLUDataDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Header> Headers { get; set; }
        public DbSet<BannerData> BannerDatas { get; set; }
        public DbSet<FilterData> FilterDatas { get; set; }
        public DbSet<ColumnDetailData> columnDetailDatas { get; set; }
        public DbSet<ColumnData> ColumnDatas { get; set; }
        public DbSet<BenefitData> BenefitDatas { get; set; }
        public DbSet<DemoData> DemoDatas { get; set; } 
        public DbSet<DescribeInWordData> DescribeInWordDatas { get; set; }
        public DbSet<ModelData> ModelDatas { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }


}
