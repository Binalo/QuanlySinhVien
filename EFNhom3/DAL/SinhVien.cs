namespace EFNhom3.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(50)]
        public string MaSinhVien { get; set; }

        [StringLength(50)]
        public string Ho { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public short? GioiTinh { get; set; }

        [StringLength(250)]
        public string QueQuan { get; set; }

        [StringLength(50)]
        public string MaLop { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}
