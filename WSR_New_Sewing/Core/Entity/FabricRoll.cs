namespace WSR_New_Sewing.Core.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FabricRoll")]
    public partial class FabricRoll
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FabricRoll()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }

        public int MaterialId { get; set; }

        public int ColorId { get; set; }

        public decimal Width { get; set; }

        public decimal Length { get; set; }

        public virtual Color Color { get; set; }

        public virtual Material Material { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
