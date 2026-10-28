using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolAppCore.Models;

namespace SchoolAppCore_Ex01_Lab07.Pages.DepartmentPages;

public class IndexModel : PageModel
{
    private readonly SchoolContext _context;

    public IndexModel(SchoolContext context)
    {
        _context = context;
    }

    public IList<Department> Department { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Department = await _context.Departments.ToListAsync();
    }
}
