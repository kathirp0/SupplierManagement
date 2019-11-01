using System;
using System.ComponentModel.DataAnnotations;

namespace SupplierManangement.Model
{
    /// <summary>
    /// Represents the model for Supplier details
    /// </summary>
    public class Supplier
    {
        [Key]
        public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Category { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string ZipCode { get; set; }
    }
}
