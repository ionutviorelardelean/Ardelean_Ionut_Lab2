using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ardelean_Ionut_Lab2.Models;
using Ardelean_Ionut_Lab2.Data;

namespace Ardelean_Ionut_Lab2.Pages.Members;

public class IndexModel : PageModel
{
    private readonly Ardelean_Ionut_Lab2Context _context;

    public IndexModel(Ardelean_Ionut_Lab2Context context)
    {
        _context = context;
    }

    public IList<Member> Member { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Member = await _context.Member.ToListAsync();
    }
}
