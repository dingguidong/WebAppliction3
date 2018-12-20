﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication3.Models.songjiacloudContext _context;

        public IndexModel(WebApplication3.Models.songjiacloudContext context)
        {
            _context = context;
        }

        public IList<Area> Area { get;set; }

        public async Task OnGetAsync()
        {
            Area = await _context.Area.ToListAsync();
        }
    }
}
