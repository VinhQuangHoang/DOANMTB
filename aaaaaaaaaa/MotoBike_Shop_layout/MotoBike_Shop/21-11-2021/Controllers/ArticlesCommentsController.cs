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
    public class ArticlesCommentsController : Controller
    {
        private readonly DPContext _context;

        public ArticlesCommentsController(DPContext context)
        {
            _context = context;
        }

        // GET: ArticlesComments
        public async Task<IActionResult> Index()
        {
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            var dPContext = _context.articlescomments.Include(a => a.Articles);
            return View(await dPContext.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ArticleCommentViewModel vm)
        {
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            var comment = vm.Comment;
            var articleId = vm.ArticleId;
            var rating = vm.Rating;

            ArticlesComment artComment = new ArticlesComment()
            {
                ArticlesId = articleId,
                Comments = comment,
                Rating = rating,
                PublishedDate = DateTime.Now
            };

            _context.articlescomments.Add(artComment);
            _context.SaveChanges();

            return RedirectToAction("Details", "Articles", new { id = articleId });
        }

        // GET: ArticlesComments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articlesComment = await _context.articlescomments
                .Include(a => a.Articles)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (articlesComment == null)
            {
                return NotFound();
            }

            return View(articlesComment);
        }

        // GET: ArticlesComments/Create
        public IActionResult Create()
        {
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewData["ArticlesId"] = new SelectList(_context.articles, "Id", "Id");
            return View();
        }

        // POST: ArticlesComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Comments,PublishedDate,ArticlesId,Rating")] ArticlesComment articlesComment)
        {
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            if (ModelState.IsValid)
            {
                _context.Add(articlesComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArticlesId"] = new SelectList(_context.articles, "Id", "Id", articlesComment.ArticlesId);
            return View(articlesComment);
        }

        // GET: ArticlesComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articlesComment = await _context.articlescomments.FindAsync(id);
            if (articlesComment == null)
            {
                return NotFound();
            }
            ViewData["ArticlesId"] = new SelectList(_context.articles, "Id", "Id", articlesComment.ArticlesId);
            return View(articlesComment);
        }

        // POST: ArticlesComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Comments,PublishedDate,ArticlesId,Rating")] ArticlesComment articlesComment)
        {
            if (id != articlesComment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(articlesComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticlesCommentExists(articlesComment.Id))
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
            ViewData["ArticlesId"] = new SelectList(_context.articles, "Id", "Id", articlesComment.ArticlesId);
            return View(articlesComment);
        }

        // GET: ArticlesComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articlesComment = await _context.articlescomments
                .Include(a => a.Articles)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (articlesComment == null)
            {
                return NotFound();
            }

            return View(articlesComment);
        }

        // POST: ArticlesComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var articlesComment = await _context.articlescomments.FindAsync(id);
            _context.articlescomments.Remove(articlesComment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticlesCommentExists(int id)
        {
            return _context.articlescomments.Any(e => e.Id == id);
        }
    }
}
