namespace baocaodoan.Resources
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        public long? SoLuong { get; set; }

        public long? GiaNhap { get; set; }

        public long? GiaBan { get; set; }

        [StringLength(100)]
        public string Thongtinchitiet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }
    }
}
