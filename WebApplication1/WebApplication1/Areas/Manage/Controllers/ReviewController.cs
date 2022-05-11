﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ReviewController : Controller
    {
        private readonly JuanDbContext _context;


        public ReviewController(JuanDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index(int page = 1)
        {
            List<Review> reviews = await _context.Reviews
                .Include(r=>r.Blog).ToListAsync();
            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)reviews.Count() / 5);
            return View(reviews.Skip((page - 1) * 5).Take(5));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return BadRequest();
            Review dbReview = await _context.Reviews
                .Include(r => r.Blog)
                .FirstOrDefaultAsync(r => r.Id == id && !r.IsDeleted);
            if (dbReview == null) return NotFound();

            return View(dbReview);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Review review)
        {
            if (id == null) return BadRequest();
            Review dbReview = await _context.Reviews.FirstOrDefaultAsync(r => r.Id == id);
            if (dbReview == null) return NotFound();

            if (review.Id != id) return BadRequest();

            Blog blog = await _context.Blogs.FirstOrDefaultAsync(b => b.Reviews.FirstOrDefault(r => r.Id == id).Id == id);

            dbReview.Message = review.Message;
            dbReview.UpdatedAt = DateTime.UtcNow.AddHours(4);
            int bid = blog.Id;
            await _context.SaveChangesAsync();
            return RedirectToAction("index","review","manage");
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            Review review = await _context.Reviews
                .Include(r=>r.Blog)
                .FirstOrDefaultAsync(r => r.Id == id);
            if (review == null) return NotFound();

            return View(review);
        }
    }
}