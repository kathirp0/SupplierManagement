using Newtonsoft.Json;
using SupplierManangement.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiIntegrationTest
{
    public class SupplierApiTest
    {

        #region Variables 
        private SupplierApiTestData supplierApiTestData = new SupplierApiTestData();
        private ApiClient apiClient = new ApiClient();
        private readonly string Url= "/Supplier/registersupplier";
        #endregion

        [Fact]
        public async Task P_Post_WhenSupplierDetailsPassed_ThenReturnSuccessResponseAsync()
        {
            #region Arrange 
            var supplierData =  supplierApiTestData.CreatevalidSupplier();
            #endregion

            #region Act 
            var response = apiClient.httpClient.PostAsync(Url, supplierData);
            #endregion

            #region
            Assert.Equal(HttpStatusCode.OK, response.Result.StatusCode);
            #endregion
        }
        [Fact]
        public async Task N_Post_WhenInvalidSupplierDetailsPassed_ThenReturnBadResponse()
        {
            #region Arrange 
            var supplierData = supplierApiTestData.CreateInvalidSupplier();
            #endregion

            #region Act 
            var response = await apiClient.httpClient.PostAsync(Url, supplierData);
            #endregion

            #region
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            #endregion

        }
    }
}

          