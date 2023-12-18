using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Employee_Management_System.AppDbContext;
using Employee_Management_System.Entities;

namespace Employee_Management_System.Pages.EmployeePages
{
    public class IndexModel : PageModel
    {
        private readonly Employee_Management_System.AppDbContext.MyDbContext _context;

        public IndexModel(Employee_Management_System.AppDbContext.MyDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.employees
                .Include(e => e.Department).ToListAsync();
        }
    }
}
