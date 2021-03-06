using BERYLLIUM.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BERYLLIUM.ViewComponents
{
    public class WorkViewComponent : ViewComponent
    {
        private AppDbContext _context { get; }
        public WorkViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
