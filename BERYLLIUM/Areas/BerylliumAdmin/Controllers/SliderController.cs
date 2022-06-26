using BERYLLIUM.DAL;
using BERYLLIUM.Helpers;
using BERYLLIUM.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BERYLLIUM.Areas.BerylliumAdmin.Controllers
{
    [Area("BerylliumAdmin")]
    [Authorize(Roles = nameof(Role.RoleType.Admin))]
    public class SliderController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (slider.Photo.CheckFlieSize(200))
            {
                ModelState.AddModelError("Photo", "Image's max size must be less than 200kb");
                return View();
            }
            if (!slider.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of File must be image");
                return View();
            }

            slider.Url = await slider.Photo.SaveFileAsync(_env.WebRootPath, "img");
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();
            var slider = _context.Sliders.Find(id);
            if (slider == null) return NotFound();
            var path = Helper.GetPath(_env.WebRootPath, "img", slider.Url);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Slider slide = _context.Sliders.FirstOrDefault(c => c.Id == id);
            if (slide == null)
            {
                return NotFound();
            }
            return View(slide);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Slider slide)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Slider slideDb = _context.Sliders.FirstOrDefault(c => c.Id == id);

            if (slide == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (slide.Photo.CheckFlieSize(200))
            {
                ModelState.AddModelError("Photo", "Image's max size must be less than 200kb");
                return View();
            }
            if (!slide.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of File must be image");
                return View();
            }
            slide.Url = await slide.Photo.SaveFileAsync(_env.WebRootPath, "img");
            var path = Helper.GetPath(_env.WebRootPath, "img", slideDb.Url);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            slideDb.Url = slide.Url;
            slideDb.Title = slide.Title;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
