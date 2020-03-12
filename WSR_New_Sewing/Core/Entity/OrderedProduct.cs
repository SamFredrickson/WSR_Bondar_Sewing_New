namespace WSR_New_Sewing.Core.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderedProduct")]
    public partial class OrderedProduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ArticulOfProduct { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumberOfOrder { get; set; }

        public int Count { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
