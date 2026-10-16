using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ardelean_Ionut_Lab2.Models;

namespace Ardelean_Ionut_Lab2.Pages.Authors;

public class IndexModel : PageModel
{
    private readonly Ardelean_Ionut_Lab2Context _context;

    public IndexModel(Ardelean_Ionut_Lab2Context context)
    {
        _context = context;
    }

    public IList<Author> Author { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Author = await _context.Author.ToListAsync();
    }
}
