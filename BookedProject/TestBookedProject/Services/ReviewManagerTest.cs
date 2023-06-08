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

		//Non trivial
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

            manager.AddReview(review1);
            manager.AddReview(review2);
            var result = manager.GetReviewsBaseOnHotelId(hotelId);

            Assert.AreEqual(0, result.Count);
        }

		[TestMethod]
		public void SummaryReview_Of_Rating_Test()
		{
			ReviewManager manager = new ReviewManager(new FakeReviewRepo());
			User user1 = new User(1, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
			User user2 = new User(2, "Steven", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
			User user3 = new User(3, "George", "Wu", "g.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
			User user4 = new User(4, "Ben", "Wu", "g.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
			Review review1 = new Review(1, user1, 1, "Good", 5);
			Review review2 = new Review(2, user2, 1, "Nice", 3);
			Review review3 = new Review(4, user3, 1, "Nice", 1);
            Review review4 = new Review(5, user4, 1, "Nice", 1);

			manager.AddReview(review1);
			manager.AddReview(review2);
			manager.AddReview(review3);
            manager.AddReview(review4);

			int[] Summary = manager.GetSummaryRating(1);

			Assert.AreEqual(2, Summary[0]); //Count of the people that gave review rating 1 
			Assert.AreEqual(0, Summary[1]); //Count of the people that gave review rating 2 
			Assert.AreEqual(1, Summary[2]); //Count of the people that gave review rating 3 
			Assert.AreEqual(0, Summary[3]); //Count of the people that gave review rating 4 
			Assert.AreEqual(1, Summary[4]); //Count of the people that gave review rating 5 
		}

		[TestMethod]
		public void SummaryReview_Of_Rating_Hotel_With_No_Reviews_Return_Null()
		{
			ReviewManager manager = new ReviewManager(new FakeReviewRepo());
			User user1 = new User(1, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
			User user2 = new User(2, "Steven", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
			User user3 = new User(3, "George", "Wu", "g.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
			User user4 = new User(4, "Ben", "Wu", "g.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
			Review review1 = new Review(1, user1, 1, "Good", 5);
			Review review2 = new Review(2, user2, 1, "Nice", 3);
			Review review3 = new Review(3, user3, 1, "Nice", 1);
			Review review4 = new Review(4, user4, 1, "Nice", 1);

			manager.AddReview(review1);
			manager.AddReview(review2);
			manager.AddReview(review3);
            manager.AddReview(review4);

			int[] Summary = manager.GetSummaryRating(3);

			Assert.IsNull(Summary);
		}


	}

}
