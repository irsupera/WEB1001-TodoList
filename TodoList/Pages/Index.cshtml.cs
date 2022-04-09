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
    public class IndexModel : PageModel
    {
        private readonly Context _context;

        public IndexModel(Context context)
        {
            _context = context;
        }

        public IList<Todo> Todo { get;set; }

        public async Task OnGetAsync()
        {
            Todo = await _context.Todo.ToListAsync();
        }
    }
}
