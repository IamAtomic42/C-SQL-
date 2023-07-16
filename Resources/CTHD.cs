namespace baocaodoan.Resources
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTHD()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        public int? SoLuong { get; set; }

        public virtual SanPham SanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
