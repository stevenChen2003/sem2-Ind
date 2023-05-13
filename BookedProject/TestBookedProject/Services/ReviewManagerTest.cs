using Booked.Domain.Domain;
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
            User user = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            Review review = new Review(user, 1, "Good", 5);

            bool result = manager.AddReview(review);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfReviewExistTest()
        {
            ReviewManager manager = new ReviewManager(new FakeReviewRepo());
            User user1 = new User(1,"Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
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
            User user1 = new User(1, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            Review review1 = new Review(1, user1, 1, "Good", 5);
            Review review2 = new Review(1, user1, 1, "Nice", 5);

            manager.AddReview(review1);
            bool result = manager.UpdateReview(review2); 
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RemoveReviewTest()
        {
            ReviewManager manager = new ReviewManager(new FakeReviewRepo());
            User user1 = new User(1, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            Review review1 = new Review(1, user1, 1, "Good", 5);
            Review review2 = new Review(1, user1, 1, "Good", 5);

            manager.AddReview(review1);
            bool result = manager.DeleteReview(review2.Id);
            Assert.IsTrue(result);
        }


    }

}
