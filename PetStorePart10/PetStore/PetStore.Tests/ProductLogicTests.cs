using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PetStore.Data;
using PetStore.Logic;
using System;

namespace PetStore.Tests
{
    [TestClass]
    public class ProductLogicTests
    {
        private Mock<IProductRepository> _productRepositoryMock;
        private ProductLogic _productLogic;

        [TestInitialize]
        public void Setup()
        {
            _productRepositoryMock = new Mock<IProductRepository>();
            _productLogic = new ProductLogic(_productRepositoryMock.Object);
        }

        [TestMethod]
        public void GetProductById_CallsRepo()
        {
            // Arrange
            int testProductId = 10;
            Product mockProduct = new Product { ProductId = testProductId, Name = "test product" };

            _productRepositoryMock.Setup(x => x.GetProductById(testProductId))
                                  .Returns(mockProduct);

            // Act
            var result = _productLogic.GetProductById(testProductId);

            // Assert
            _productRepositoryMock.Verify(x => x.GetProductById(testProductId), Times.Once);
        }
    }
}
