using Newtonsoft.Json;
using SupplierManangement.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ApiIntegrationTest
{
    public class SupplierApiTestData
    {
        public HttpContent CreatevalidSupplier()
        {
            Supplier supplier = new Supplier
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
            var stringContent = new StringContent(JsonConvert.SerializeObject(supplier), Encoding.UTF8, "application/json");
            return stringContent;
        }

        public HttpContent CreateInvalidSupplier()
        {
            Supplier supplier = new Supplier
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
            var stringContent = new StringContent(JsonConvert.SerializeObject(supplier), Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
