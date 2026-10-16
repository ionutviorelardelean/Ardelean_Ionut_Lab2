using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ardelean_Ionut_Lab2.Models;

namespace Ardelean_Ionut_Lab2.Pages.Publishers;

public class DeleteModel : PageModel
{
    private readonly Ardelean_Ionut_Lab2Context _context;

    public DeleteModel(Ardelean_Ionut_Lab2Context context)
    {
        _context = context;
    }

    [BindProperty]
    public Publisher Publisher { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
        if (Publisher is null)
        {
            return NotFound();
        }
        else
        {
            Publisher = Publisher;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var Publisher = await _context.Publisher.FindAsync(id);
        if (Publisher != null)
        {
            Publisher = Publisher;
            _context.Publisher.Remove(Publisher);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
