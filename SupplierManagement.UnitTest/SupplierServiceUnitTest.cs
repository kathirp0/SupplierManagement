using Moq;
using System.Collections.Generic;
using Xunit;
using SupplierManangement.BusinessService;
using SupplierManangement.Repository;
using SupplierManangement.Model;

namespace SupplierManagement.Services
{
    public class SupplierServiceUnitTest
    {
        #region Variables
        private ISupplierService SupplierService { get; set; }
        private Mock<IRepository<Supplier>> IRepositoryMock { get; set; }
        private SupplierServiceUnitTestData SupplierServiceUnitTestData { get; set; }
        #endregion

        #region TestSetup
        public SupplierServiceUnitTest()
        {
            IRepositoryMock = new Mock<IRepository<Supplier>>();
            SupplierService = new SupplierService(IRepositoryMock.Object);
            SupplierServiceUnitTestData = new SupplierServiceUnitTestData();
        }
        #endregion

        #region TestMethod
        [Fact]
        public void P_GetSupplierDetails_WhenValidSupplier_ReturnSupplierLists()
        {
            #region Arrange
            var supplierDetail = SupplierServiceUnitTestData.GetListOfSupplierDetails();
            IRepositoryMock.Setup(x => x.Get()).Returns(supplierDetail);
            #endregion

            #region Act
            var entity = SupplierService.GetSupplierDetails();
            #endregion

            #region Assert
            Assert.NotEmpty(entity);
            Assert.True(entity.GetType() == typeof(List<Supplier>));
            IRepositoryMock.Verify(x => x.Get(), Times.Once);
            #endregion
        }

        [Fact]
        public void P_GetSupplierDetailsByCategory_WhenValidSupplierCategory_ReturnSupplierList()
        {
            #region Arrange
            var supplierDetail = SupplierServiceUnitTestData.GetListOfSupplierDetails();
            IRepositoryMock.Setup(x => x.Get()).Returns(supplierDetail);
            #endregion

            #region Act
            var entity = SupplierService.GetSupplierDetails();
            #endregion

            #region Assert
            Assert.True(entity.GetType() == typeof(List<Supplier>));
            IRepositoryMock.Verify(x => x.Get(), Times.Once);
            #endregion
        }

        [Fact]
        public void P_RegisterSupplierDetails_WhenValidSupplierDetailsPassed_CreateNewSupplier()
        {
            #region Arrange
            var supplierDetail = SupplierServiceUnitTestData.CreateSupplier();
            IRepositoryMock.Setup(x => x.Create(supplierDetail)).Returns(true);
            #endregion

            #region Act
            var entity = SupplierService.RegisterSupplierDetails(supplierDetail);
            #endregion

            #region Assert
            Assert.True(entity.GetType() == typeof(string));
            Assert.NotEmpty(entity);
            Assert.Equal(entity,SupplierManangement.Constant.Success);
            #endregion
        }

        [Fact]
        public void N_RegisterSupplierDetails_WhenInvalidAddressPassed_ThrowException()
        {
            #region Arrange
            var supplierDetail = SupplierServiceUnitTestData.CreateSupplierWithoutAddress();
            #endregion

            #region Act
            var entity = SupplierService.RegisterSupplierDetails(supplierDetail);
            #endregion

            #region Assert
            Assert.True(entity.GetType() == typeof(string));
            Assert.NotEmpty(entity);
            Assert.Equal(entity, SupplierManangement.Constant.InvalidSupplierAddress);
            #endregion
        }

        [Fact]
        public void N_RegisterSupplierDetails_WhenInvalidSupplierNamePassed_ThrowException()
        {
            #region Arrange
            var supplierDetail = SupplierServiceUnitTestData.CreateSupplierWithoutName();
            #endregion

            #region Act
            var entity = SupplierService.RegisterSupplierDetails(supplierDetail);
            #endregion

            #region Assert
            Assert.True(entity.GetType() == typeof(string));
            Assert.NotEmpty(entity);
            Assert.Equal(entity, SupplierManangement.Constant.InvalidSupplierName);
            #endregion
        }

        [Fact]
        public void N_RegisterSupplierDetails_WhenInvalidPhoneNumber_ThrowException()
        {
            #region Arrange
            var supplierDetail = SupplierServiceUnitTestData.CreateSupplierWithoutContactNumber();
            #endregion

            #region Act
            var entity = SupplierService.RegisterSupplierDetails(supplierDetail);
            #endregion

            #region Assert
            Assert.True(entity.GetType() == typeof(string));
            Assert.NotEmpty(entity);
            Assert.Equal(entity, SupplierManangement.Constant.InvalidContactNumber);
            #endregion
        }

        [Fact]
        public void N_RegisterSupplierDetails_WhenInvalidEmailId_ThrowException()
        {
            #region Arrange
            var supplierDetail = SupplierServiceUnitTestData.CreateSupplierWithInvalidEmailId();
            #endregion

            #region Act
            var entity = SupplierService.RegisterSupplierDetails(supplierDetail);
            #endregion

            #region Assert
            Assert.True(entity.GetType() == typeof(string));
            Assert.NotEmpty(entity);
            Assert.Equal(entity, SupplierManangement.Constant.InvalidEmailId);
            #endregion
        }

        [Fact]
        public void N_RegisterSupplierDetails_WhenInvalidZipcode_ThrowException()
        {
            #region Arrange
            var supplierDetail = SupplierServiceUnitTestData.CreateSupplierWithInvalidZipCode();
            #endregion

            #region Act
            var entity = SupplierService.RegisterSupplierDetails(supplierDetail);
            #endregion

            #region Assert
            Assert.True(entity.GetType() == typeof(string));
            Assert.NotEmpty(entity);
            Assert.Equal(entity, SupplierManangement.Constant.InvalidZipCode);
            #endregion
        }
        #endregion

    }
}
