using CatalogoApi.Data;
using CatalogoApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogoApi.Controller;

[Route("[controller]")]
[ApiController]
public class ProdutoController: ControllerBase
{
    private readonly AppDbContext _context;

    public ProdutoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> Get()
    {
        var produtos = _context.Produtos.ToList();
        if(produtos is null){
            return NotFound("Produtos não encontrados");
        }
        return _context.Produtos.ToList();
    }

    [HttpGet("{id: int}")]
    public ActionResult<Produto> Get(int id){
        var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);
        if(produto is null){
            return NotFound();
        }
        return produto;
    }   
}