using BlogTrackAPI.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTrackTesting
{
    [TestFixture]
    public class AdminInfoTesting
    {
        [Test]
        public void ValidAdminInfo_ShouldPassValidation()
        {
            // Arrange
            var adminInfo = new AdminInfo
            {
                EmailId = "nirmalraj@gmail.com",
                Password = "nirmalraj@1"
            };

            // Act
            var validationContext = new ValidationContext(adminInfo, null, null);
            var validationResults = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(adminInfo, validationContext, validationResults, true);

            // Assert
            Assert.IsTrue(isValid);
        }

        [Test]
        public void InvalidAdminInfo_MissingEmail_ShouldFailValidation()
        {
            // Arrange
            var adminInfo = new AdminInfo
            {
                Password = "SecurePassword1234"
            };

            // Act
            var validationContext = new ValidationContext(adminInfo, null, null);
            var validationResults = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(adminInfo, validationContext, validationResults, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(1, validationResults.Count);
            Assert.AreEqual("The EmailId field is required.", validationResults[0].ErrorMessage);
        }

        [Test]
        public void InvalidAdminInfo_InvalidEmailFormat_ShouldFailValidation()
        {
            // Arrange
            var adminInfo = new AdminInfo
            {
                EmailId = "nrj@@gm.com",  // Invalid email format
                Password = "SecurePassword1234"
            };

            // Act
            var validationContext = new ValidationContext(adminInfo, null, null);
            var validationResults = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(adminInfo, validationContext, validationResults, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(1, validationResults.Count);
            Assert.AreEqual("The EmailId field is not a valid e-mail address.", validationResults[0].ErrorMessage);
        }

        // Add more test cases as needed for other scenarios.
    }
}
    
