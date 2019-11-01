using System;
using System.Collections.Generic;
using System.Linq;
using SupplierManangement.Model;
namespace SupplierManagement.Services
{
    public class SupplierServiceUnitTestData
    {
        public IQueryable<Supplier> GetListOfSupplierDetails()
        {
            List<Supplier> suppliersList = new List<Supplier>();
            Supplier objSupplier1 = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                Name = "GBG",
                Category = "BankingService",
                ContactNumber = "9840473089",
                State = "LiverPool",
                Address = "Waterside Basin Road Worcester united Kingdom",
                EmailId = "aspire@gbg.com",
                ZipCode = "600059"
            };
            Supplier objSupplier2 = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                Name = "AspireSystem",
                Category = "ProffessionService",
                ContactNumber = "9840473089",
                State = "LiverPool",
                Address = "Waterside Basin Road Worcester united Kingdom",
                EmailId = "aspire@gbg.com",
                ZipCode = "600059"

            };
            suppliersList.Add(objSupplier1);
            suppliersList.Add(objSupplier2);
            return suppliersList.AsQueryable();

        }
        public IQueryable<Supplier> GetListOfSupplierDetailsByCategory()
        {
            var suppliersList = GetListOfSupplierDetails();
            foreach (var item in suppliersList)
            {
                item.Category = "BankingService";
            }
            return suppliersList;
        }

        public Supplier CreateSupplier()
        {
            Supplier objSupplier = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                Name = "GBG",
                Category = "BankingService",
                ContactNumber = "9840473089",
                State = "LiverPool",
                Address = "Waterside Basin Road Worcester united Kingdom",
                EmailId = "aspire@gbg.com",
                ZipCode = "600059"
            };

            return objSupplier;

        }
        public Supplier CreateInvalidSupplier()
        {
            Supplier objSupplier = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                Name = "GBG",
                Category = "BankingService",
                ContactNumber = "9840473089",
                State = "LiverPool",
                Address = string.Empty,
                EmailId = "aspire@gbg.com",
                ZipCode = "600059"
            };
            return objSupplier;

        }
        public Supplier CreateSupplierWithoutName()
        {
            Supplier objSupplier = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                Name = string.Empty,
                Category = "BankingService",
                ContactNumber = "9840473089",
                State = "LiverPool",
                Address = "Waterside Basin Road Worcester united Kingdom",
                EmailId = "aspire@gbg.com",
                ZipCode = "600059"
            };
            return objSupplier;

        }
        public Supplier CreateSupplierWithoutContactNumber()
        {
            Supplier objSupplier = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                Name = "GBG",
                Category = "BankingService",
                ContactNumber = "98404589473089",
                State = "LiverPool",
                Address = "Waterside Basin Road Worcester united Kingdom",
                EmailId = "aspire@gbg.com",
                ZipCode = "600059"
            };
            return objSupplier;

        }
        public Supplier CreateSupplierWithInvalidEmailId()
        {
            Supplier objSupplier = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                Name = "GBG",
                Category = "BankingService",
                ContactNumber = "9840473089",
                State = "LiverPool",
                Address = "Waterside Basin Road Worcester united Kingdom",
                EmailId = "aspire@gbg",
                ZipCode = "600059"
            };
            return objSupplier;
        }
        public Supplier CreateSupplierWithoutAddress()
        {
            Supplier objSupplier = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                Name = "GBG",
                Category = "BankingService",
                ContactNumber = "9840473089",
                State = "LiverPool",
                Address = String.Empty,
                EmailId = "aspire@gbg",
                ZipCode = "600059"
            };
            return objSupplier;
        }
        public Supplier CreateSupplierWithInvalidZipCode()
        {
            Supplier objSupplier = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                Name = "GBG",
                Category = "BankingService",
                ContactNumber = "9840473089",
                State = "LiverPool",
                Address = "Waterside Basin Road Worcester united Kingdom",
                EmailId = "aspire@ff.com",
                ZipCode = "600000000059"
            };
            return objSupplier;

        }
    }
}
