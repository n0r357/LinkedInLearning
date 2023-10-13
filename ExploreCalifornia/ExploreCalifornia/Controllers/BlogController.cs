using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        private readonly BlogDataContext _db;

        public BlogController(BlogDataContext db)
        {
            _db = db;
        }

        [Route("")]
        public IActionResult Index(int page = 0)
        {
            var pageSize = 2;
            var totalPosts = _db.Posts.Count();
            var totalPages = totalPosts / pageSize;
            var previousPage = page - 1;
            var nextPage = page + 1;

            ViewBag.PreviousPage = previousPage;
            ViewBag.HasPreviousPage = previousPage >= 0;
            ViewBag.NextPage = nextPage;
            ViewBag.HasNextPage = nextPage < totalPages;

            var posts =
                _db.Posts
                    .OrderByDescending(x => x.Posted)
                    .Skip(pageSize * page)
                    .Take(pageSize)
                    .ToArray();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest") return PartialView(posts);

            return View(posts);
        }

        #region Old Code
        //public IActionResult Index()
        //{
        //    var posts = _db.Posts.OrderByDescending(x => x.Posted).Take(5).ToArray();


        //    var posts = new[]
        //    {
        //        new Post
        //        {
        //            Title = "My blog post",
        //            Posted = DateTime.Now,
        //            Author = "Jimmy Waern",
        //            Body = "This is a great blog post, don't you think?"
        //        },
        //        new Post
        //        {
        //            Title = "My second blog post",
        //            Posted = DateTime.Now,
        //            Author = "Jimmy Waern",
        //            Body = "This is ANOTHER great blog post, don't you think?"
        //        }
        //    };
        //    return View(posts);
        //}
        #endregion

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = _db.Posts.FirstOrDefault(x => x.Key == key);

            #region Old Code
            //var post = new Post
            //{
            //    Title = "My blog post",
            //    Posted = DateTime.Now,
            //    Author = "Jimmy Waern",
            //    Body = "This is a great blog post, don't you think?"
            //};
            //ViewBag.Title = "My blog post";
            //ViewBag.Posted = DateTime.Now;
            //ViewBag.Author = "Jimmy Waern";
            //ViewBag.Body = "This is a great blog post, don't you think?";
            #endregion

            return View(post);
        }

        [Authorize]
        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost, Route("create")]
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid) return View();

            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            _db.Posts.Add(post);
            _db.SaveChanges();

            return RedirectToAction("Post", "Blog", new
            {
                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.Key
            });
        }

        #region Old Code
        //public IActionResult Index()
        //{
        //    return new ContentResult { Content = "Blog Posts" };
        //}

        //public IActionResult Post(int year, int month, string key)
        //{
        //    return new ContentResult {
        //        Content = string.Format("Year: {0}; Month: {1}; Key: {2}", year, month, key)
        //    };
        //}

        //public IActionResult Post(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new ContentResult { Content = "null" };
        //    }
        //    else
        //    {
        //        return new ContentResult { Content = id.ToString() };
        //    }
        //}

        //public IActionResult Post(int id = -1)
        //{
        //    return new ContentResult { Content = id.ToString() };
        //}
        #endregion
    }
}