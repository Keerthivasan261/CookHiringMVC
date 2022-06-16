using CookHiring.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookHiring.UI.Repositories
{
    public class ReviewRepository
    {
        public ApplicationDbContext dbEntities;
        public ReviewRepository()
        {
            dbEntities = new ApplicationDbContext();
        }
        public List<Review> GetJobs()
        {
            return dbEntities.Review.ToList();
        }
        public Review GetReviewById(int id)
        {
            Review review = dbEntities.Review.Find(id);
            return review;
        }

        }
    }