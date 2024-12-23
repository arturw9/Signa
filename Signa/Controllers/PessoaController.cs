using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Signa.Data;

[Route("Pessoa")]
public class PessoaController : Controller
{
    private readonly ApiDbContext _context;

    public PessoaController(ApiDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var pessoas = await _context.Pessoas.ToListAsync();
        return View(pessoas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Detalhes(int id)
    {
        var pessoa = await _context.Pessoas.FindAsync(id);
        if (pessoa == null)
        {
            return NotFound("Detalhes desta pessoa não encontrado.");
        }
        return View(pessoa);
    }

    [HttpPost("{id}")]
    public async Task<IActionResult> Editar(int id, [FromForm] string nomeFantasia)
    {
        var pessoaExistente = await _context.Pessoas.FindAsync(id);
        if (pessoaExistente == null)
        {
            return NotFound("Pessoa não encontrada.");
        }

        pessoaExistente.NomeFantasia = nomeFantasia;
        await _context.SaveChangesAsync();
        return RedirectToAction("Index");
    }
}