using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUni.Models;
using ContosoUniversity.Models;

namespace ContosoUni.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUni.Models.SchoolContext _context;

        public IndexModel(ContosoUni.Models.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
