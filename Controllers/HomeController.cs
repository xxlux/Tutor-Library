﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

using LandR.Models;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace LandR.Controllers
{
    public class HomeController : BaseController
    {

        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // GET REQUESTS 
        public IActionResult Index()
        {
            List<User> users = dbContext.Users.ToList();

            int dbCount = dbContext.Users.Count();

            Random random = new Random();
            int myRandom = random.Next(dbCount);

            ViewBag.RandomSelection = myRandom;

            return View(users);
        }
        [HttpGet("Registration")]
        public IActionResult Registration()
        {
            return View("Registration");
        }
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpGet("QuickLogin")]
        public IActionResult QuickLogin()
        {
            HttpContext.Session.SetInt32("Logged", 1);
            return RedirectToAction("Index");
        }
        [HttpGet("ProfilePic")]
        public IActionResult ProfilePic()
        {
            return View("ProfilePic");
        }
        [HttpGet("Backup")]
        public IActionResult Backup()
        {
            return View("Backup");
        }
        [HttpGet("MyProfile")]
        public IActionResult MyProfile()
        {
            var LoggedInUser = HttpContext.Session.GetInt32("Logged");
            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == LoggedInUser);

            return View("MyProfile", userInDb);
        }
        [HttpGet("LeaveReview/{id}")]
        public IActionResult LeaveReview(int id)
        {
            ViewBag.Reviewee = id;
            return View("LeaveReview");
        }

        // Save New user to Database
        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            var emailCheck = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);

            if (ModelState.IsValid && emailCheck == null)
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();
                return RedirectToAction("Login");

            }
            return View("Registration");
        }
        [HttpPost("PostReview")]
        public IActionResult PostReview(Review review)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(review);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("LeaveReview");
        }
        [HttpPost("UpdateProfile")]
        [Route("UpdateProfile")]
        public IActionResult UpdateProfile(User user)
        {
            var LoggedInUser = HttpContext.Session.GetInt32("Logged");
            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == LoggedInUser);

            userInDb.FirstName = user.FirstName;
            userInDb.LastName = user.LastName;
            userInDb.Email = user.Email;
            userInDb.Subject = user.Subject;
            userInDb.Rate = user.Rate;
            userInDb.Schedule = user.Schedule;

            dbContext.Update(userInDb);
            dbContext.SaveChanges();

            return RedirectToAction("Index");

        }

        // Login User
        public IActionResult LoginAction(User user)
        {
            var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);

            if (userInDb == null)
            {
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("Login");
            }

            var hasher = new PasswordHasher<User>();
            var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.Password);

            if (result == 0)
            {
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("Login");
            }

            HttpContext.Session.SetInt32("Logged", userInDb.UserId);
            return RedirectToAction("Index");
        }

        // Profile Page per user ID

        [HttpGet("{id}")]
        public IActionResult Profile(int id)
        {
            User user = dbContext.Users.FirstOrDefault(u => u.UserId == id);

            List<Review> pageReviews = dbContext.Reviews
                .Where(review => review.TutorId == id)
                .Include(poster => poster.Poster)
                .ToList();

            List<User> userStore = dbContext.Users
                .Include(review => review.TutorReviews)
                .ToList();

            ProfileViewModel viewModel = new ProfileViewModel();
            viewModel.User = user;
            viewModel.Reviews = pageReviews;

            return View(viewModel);
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
