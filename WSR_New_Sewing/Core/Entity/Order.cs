namespace WSR_New_Sewing.Core.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderedProduct = new HashSet<OrderedProduct>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int CustomerId { get; set; }

        public int ManagerId { get; set; }

        public int StageOfExecutionId { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual StageOfExecution StageOfExecution { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderedProduct> OrderedProduct { get; set; }
    }
}
