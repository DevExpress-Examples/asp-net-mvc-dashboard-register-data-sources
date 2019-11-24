namespace MvcDashboardDataSources
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetails
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Quantity { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smallmoney")]
        public decimal UnitPrice { get; set; }

        [Key]
        [Column(Order = 3)]
        public float Discount { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string ProductName { get; set; }

        [StringLength(217)]
        public string Supplier { get; set; }
    }
}
