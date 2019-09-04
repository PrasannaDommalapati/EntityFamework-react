using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentValidation.TestHelper;
using static RestApiDev.Library.Models.PromotionModel;

namespace RestApiDev.Library.Models.Tests
{
    [TestClass]
    public class PromotionModelTests
    {
        [TestMethod]
        public void Ctor_Success()
        {
            var date = DateTime.UtcNow;
            var name = new Faker().Random.Word();
            var promotionModel = new PromotionModel
            {
                Name = name,
                IsComplete= false,
                StartDate = date,
                FinishDate = date.AddDays(3)
            };

            Assert.AreEqual(promotionModel.Name, name);
            Assert.IsFalse(promotionModel.IsComplete);
            Assert.AreEqual(promotionModel.StartDate, date);
            Assert.AreEqual(promotionModel.FinishDate, date.AddDays(3));
        }

        [TestMethod]
        public void Ctor_Validate_Name()
        {
            var date = DateTime.UtcNow;
            var name = new Faker().Random.String2(200);
            var promotionModel = new PromotionModel
            {
                Name = name,
                IsComplete = false,
                StartDate = date,
                FinishDate = date.AddDays(3)
            };

            var validator = new PromotionModelValidator();

            validator.ShouldHaveValidationErrorFor(p => p.Name, promotionModel)
                .WithErrorMessage("Name length can not be more than 128 char");
        }

        [TestMethod]
        public void Ctor_Validate_StartDate()
        {
            var date = DateTime.UtcNow;
            var name = new Faker().Random.String2(200);
            var promotionModel = new PromotionModel
            {
                Name = name,
                IsComplete = false,
                StartDate = date,
                FinishDate = date.AddDays(3)
            };

            var validator = new PromotionModelValidator();

            validator.ShouldHaveValidationErrorFor(p => p.StartDate, promotionModel)
                .WithErrorMessage($"'Start Date' must be greater than '{date}'.");
        }

        [TestMethod]
        public void Ctor_Validate_EndDate_GreaterThan_StartDate()
        {
            var date = DateTime.UtcNow;
            var name = new Faker().Random.String2(200);
            var promotionModel = new PromotionModel
            {
                Name = name,
                IsComplete = false,
                StartDate = date,
                FinishDate = date.AddDays(-3)
            };

            var validator = new PromotionModelValidator();

            validator.ShouldHaveValidationErrorFor(p => p.FinishDate, promotionModel)
                .WithErrorMessage($"'Finish Date' must be greater than '{date}'.");
        }
    }
}
