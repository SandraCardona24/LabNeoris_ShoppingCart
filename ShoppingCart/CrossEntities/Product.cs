//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        public Product()
        {
            this.Order_Details = new HashSet<Order_Detail>();
        }

        public int ProductID { get; set; }

        [Required(ErrorMessage = "An 'Product Name' is required")]
        [StringLength(40, ErrorMessage = "Fourty is the characters limit")]
        public string ProductName { get; set; }

        public Nullable<int> SupplierID { get; set; }

        public Nullable<int> CategoryID { get; set; }

        [Required(ErrorMessage = "'Quantity Per Unit' is required")]
        [StringLength(20, ErrorMessage = "Twenty is the characters limit")]  
        public string QuantityPerUnit { get; set; }

        [Required(ErrorMessage = "'Unit Price' is required")]
        [DataType(DataType.Currency, ErrorMessage="Only decimal numbers")]
        public Nullable<decimal> UnitPrice { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Only Integers")]
        public Nullable<short> UnitsInStock { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Only Integers")]
        public Nullable<short> UnitsOnOrder { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Only Integers")]
        public Nullable<short> ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Order_Detail> Order_Details { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
