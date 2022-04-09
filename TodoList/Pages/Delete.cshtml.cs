using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Context _context;

        public DeleteModel(Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Todo Todo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Todo = await _context.Todo.FirstOrDefaultAsync(m => m.ID == id);

            if (Todo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Todo = await _context.Todo.FindAsync(id);

            if (Todo != null)
            {
                _context.Todo.Remove(Todo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
