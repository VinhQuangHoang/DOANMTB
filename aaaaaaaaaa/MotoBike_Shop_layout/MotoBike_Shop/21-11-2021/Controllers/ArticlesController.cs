using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _21_11_2021.Areas.admin.Data;
using _21_11_2021.Models;

namespace _21_11_2021.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly DPContext _context;

        public ArticlesController(DPContext context)
        {
            _context = context;
        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            return View(await _context.articles.ToListAsync());
        }

        // GET: Articles/Details/5
        public ActionResult Details(int? id)
        {
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            if (id == null)
            {
                return BadRequest();
            }

            Article article = _context.articles.Find(id);
            ArticleCommentViewModel vm = new ArticleCommentViewModel();

            if (article == null)
            {
                return NotFound();
            }
            vm.ArticleId = id.Value;
            vm.Title = article.Title;

            var Comments = _context.articlescomments.Where(d => d.ArticlesId.Equals(id.Value)).ToList();
            vm.ListOfComments = Comments;

            var ratings = _context.articlescomments.Where(d => d.ArticlesId.Equals(id.Value)).ToList();
            if (ratings.Count() > 0)
            {
                var ratingSum = ratings.Sum(d => d.Rating);
                ViewBag.RatingSum = ratingSum;
                var ratingCount = ratings.Count();
                ViewBag.RatingCount = ratingCount;
            }
            else
            {
                ViewBag.RatingSum = 0;
                ViewBag.RatingCount = 0;
            }

            return View(vm);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Active")] Article article)
        {
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            if (ModelState.IsValid)
            {
                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }

        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Active")] Article article)
        {
            if (id != article.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }

        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.articles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.articles.FindAsync(id);
            _context.articles.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.articles.Any(e => e.Id == id);
        }
    }
}
