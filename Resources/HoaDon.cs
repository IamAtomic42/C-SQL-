namespace baocaodoan.Resources
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay { get; set; }

        public virtual CTHD CTHD { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
