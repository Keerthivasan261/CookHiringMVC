using CookHiring.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookHiring.UI.Repositories
{
    public class JobSeekerProfileRepository
    {
        public ApplicationDbContext dbEntities;
        public JobSeekerProfileRepository()
        {
            dbEntities = new ApplicationDbContext();
        }
        public List<JobSeekerProfile> GetJobs()
        {
            return dbEntities.JobSeekersProfile.ToList();
        }
        public JobSeekerProfile GetJobSeekersProfileById(int id)
        {
            JobSeekerProfile profile = dbEntities.JobSeekersProfile.Find(id);
            return profile;
        }
        public void AddJobSeekersProfile(JobSeekerProfile data)
        {
            dbEntities.JobSeekersProfile.Add(data);
            dbEntities.SaveChanges();
        }
        public void EditJobSeekersProfile(JobSeekerProfile data)
        {
            dbEntities.Entry<JobSeekerProfile>(data).State = System.Data.Entity.EntityState.Modified;
            dbEntities.SaveChanges();

        }
        public void DeleteJobSeekersProfile(int id)
        {
            JobSeekerProfile profile =dbEntities.JobSeekersProfile.Find(id);
            dbEntities.JobSeekersProfile.Remove(profile);
            dbEntities.SaveChanges();

        }

    }
}