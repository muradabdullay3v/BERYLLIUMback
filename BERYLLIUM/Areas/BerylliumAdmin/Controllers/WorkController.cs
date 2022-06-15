using BERYLLIUM.DAL;
using BERYLLIUM.Helpers;
using BERYLLIUM.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BERYLLIUM.Areas.BerylliumAdmin.Controllers
{
    [Area("BerylliumAdmin")]
    public class WorkController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }

        public WorkController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Works);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Work work)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (work.Photo.CheckFlieSize(200))
            {
                ModelState.AddModelError("Photo", "Image's max size must be less than 200kb");
                return View();
            }
            if (!work.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of File must be image");
                return View();
            }

            work.Url = await work.Photo.SaveFileAsync(_env.WebRootPath, "img");
            await _context.Works.AddAsync(work);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();
            var work = _context.Works.Find(id);
            if (work == null) return NotFound();
            var path = Helper.GetPath(_env.WebRootPath, "img", work.Url);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Works.Remove(work);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Work work = _context.Works.FirstOrDefault(c => c.Id == id);
            if (work == null)
            {
                return NotFound();
            } 
            return View(work);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Work work)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Work workDb = _context.Works.FirstOrDefault(c => c.Id == id);

            if (work == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (work.Photo.CheckFlieSize(200))
            {
                ModelState.AddModelError("Photo", "Image's max size must be less than 200kb");
                return View();
            }
            if (!work.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of File must be image");
                return View();
            }
            work.Url = await work.Photo.SaveFileAsync(_env.WebRootPath, "img");
            var path = Helper.GetPath(_env.WebRootPath, "img", workDb.Url);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            workDb.Url = work.Url;
            workDb.Title = work.Title;
            workDb.Description = work.Description;
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }

}
