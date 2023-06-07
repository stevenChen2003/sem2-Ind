using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBookedProject.Mocks;

namespace TestBookedProject.Services
{
    [TestClass]
    public class ReviewManagerTest
	{
        [TestMethod]
        public void AddReviewTest()
        {
            ReviewManager manager = new ReviewManager(new FakeReviewRepo());
            User user = new User(1,"Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Review review = new Review(user, 1, "Good", 5);

            manager.AddReview(review);
            Review reviewFromList = manager.GetReviewById(review.Id);

            Assert.AreEqual(review.Description, reviewFromList.Description);
        }

        [TestMethod]
        public void CheckIfReviewExistTest()
        {
            ReviewManager manager = new ReviewManager(new FakeReviewRepo());
            User user1 = new User(1,"Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Review review1 = new Review(1,user1, 1, "Good", 5);
            Review review2 = new Review(1, user1, 1, "Good", 5);

            manager.AddReview(review1);
            bool result1 = manager.CheckIfReviewExist(review2);

            Assert.IsTrue(result1);
        }

        [TestMethod]
        public void UpdateReviewTest()
        {
            ReviewManager manager = new ReviewManager(new FakeReviewRepo());
            User user1 = new User(1, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Review review1 = new Review(1, user1, 1, "Good", 5);
            Review reviewUpdate = new Review(1, user1, 1, "Nice", 5);

            manager.AddReview(review1);
            manager.UpdateReview(reviewUpdate); 
            Review reviewFound = manager.GetReviewById(1);

            Assert.AreEqual(reviewUpdate.Description, reviewFound.Description);
        }

        [TestMethod]
        public void RemoveReviewTest()
        {
            ReviewManager manager = new ReviewManager(new FakeReviewRepo());
            User user1 = new User(1, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            User user2 = new User(2, "Steven", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Review review1 = new Review(1, user1, 1, "Good", 5);
            Review review2 = new Review(2, user2, 1, "Good", 5);

            manager.AddReview(review1);
            manager.AddReview(review2);
            manager.DeleteReview(1);
            int count = manager.GetReviewsBaseOnHotelId(1).Count();

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void GetReviewsBaseOnHotelId_ReturnListOfReviews_WhenHotelExists()
        {
            // Arrange
            ReviewManager manager = new ReviewManager(new FakeReviewRepo());
            User user1 = new User(1, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            User user2 = new User(2, "Steven", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Review review1 = new Review(1, user1, 1, "Good", 5);
            Review review2 = new Review(2, user2, 1, "Nice", 5);
            var hotelId = 1;

            // Act
            manager.AddReview(review1);
            manager.AddReview(review2);
            var result = manager.GetReviewsBaseOnHotelId(hotelId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void GetReviewsBaseOnHotelId_ReturnListOfReviews_Should_Return_EmptyList()
        {
            // Arrange
            ReviewManager manager = new ReviewManager(new FakeReviewRepo());
            User user1 = new User(1, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            User user2 = new User(2, "Steven", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Review review1 = new Review(1, user1, 1, "Good", 5);
            Review review2 = new Review(2, user2, 1, "Nice", 5);
            var hotelId = 3;

            // Act
            manager.AddReview(review1);
            manager.AddReview(review2);
            var result = manager.GetReviewsBaseOnHotelId(hotelId);

            // Assert
            Assert.AreEqual(0, result.Count);
        }


    }

}
