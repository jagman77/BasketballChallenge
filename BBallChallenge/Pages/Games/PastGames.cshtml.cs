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
    public class PastGamesModel : PageModel
    {
        private readonly BBallChallenge.Data.BBallChallengeContext _context;

        public PastGamesModel(BBallChallenge.Data.BBallChallengeContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
