using GameApp.Controllers;
using GameApp.Data;
using GameApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace GameApp.Tests
{
    [TestClass]
    public class GamesControllerTests
    {
        [TestMethod]
        public async Task Index_ReturnsCorrectViewResult()
        {
            // Arrange
            var context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>().Options);
            var controller = new GamesController(context);

            // Act
            var result = await controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public async Task SearchForm_ReturnsCorrectViewResult()
        {
            // Arrange
            var context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>().Options);
            var controller = new GamesController(context);

            // Act
            var result = await controller.SearchForm();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public async Task SearchResultsTitle_ReturnsCorrectViewResult()
        {
            // Arrange
            var context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>().Options);
            var controller = new GamesController(context);

            // Act
            var result = await controller.SearchResultsTitle("Test");

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public async Task SearchResultsType_ReturnsCorrectViewResult()
        {
            // Arrange
            var context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>().Options);
            var controller = new GamesController(context);

            // Act
            var result = await controller.SearchResultsType("Test");

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public async Task SearchResultsGrade_ReturnsCorrectViewResult()
        {
            // Arrange
            var context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>().Options);
            var controller = new GamesController(context);

            // Act
            var result = await controller.SearchResultsGrade("Test");

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}