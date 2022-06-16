using CookHiring.Data;
using CookHiring.UI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookHiring.UI.Controllers
{
    public class JobProviderController : Controller
    {
        public UserRepository userRepository;
        public JobRepository jobRepository;
        public JobProviderController()
        {
            userRepository = new UserRepository();
            jobRepository= new JobRepository();
        }
        // GET: JobProvider
        public ActionResult Dashboard()
        {
            var jobs = jobRepository.GetJobs();
            return View(jobs);
        }
        public ActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddJob(Job job)
        {
            jobRepository.AddJob(job);
            return RedirectToAction("Dashboard");
        }
    }
    }
