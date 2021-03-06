//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C.Core.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class shProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public shProduct()
        {
            this.shComments = new HashSet<shComment>();
            this.shOrderDetails = new HashSet<shOrderDetail>();
            this.shProductImages = new HashSet<shProductImage>();
            this.shSaleDetails = new HashSet<shSaleDetail>();
            this.shProductSets = new HashSet<shProductSet>();
        }
    
        public string ProductGuid { get; set; }
        public int ProductId { get; set; }
        public string CategoryGuid { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string MetaTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Details { get; set; }
        public string UserManual { get; set; }
        public string CompleteSetInclude { get; set; }
        public Nullable<decimal> PriceCurrent { get; set; }
        public Nullable<int> PercentCurrent { get; set; }
        public Nullable<decimal> PriceAfterPercents { get; set; }
        public Nullable<int> ViewsProduct { get; set; }
        public Nullable<int> ProductStatus { get; set; }
        public Nullable<bool> TopHot { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> Inventory { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual shCategory shCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shComment> shComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shOrderDetail> shOrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shProductImage> shProductImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shSaleDetail> shSaleDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shProductSet> shProductSets { get; set; }
    }
}
