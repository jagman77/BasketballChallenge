using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BBallChallenge.Data;
using BBallChallenge.Models;

namespace BBallChallenge.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly BBallChallenge.Data.BBallChallengeContext _context;

        public DetailsModel(BBallChallenge.Data.BBallChallengeContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync(m => m.ID == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
