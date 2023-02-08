using AutoMapper;
using Comex.Models;
using Microsoft.AspNetCore.Mvc;
using Comex.Web.Data.Dto;

namespace Comex.Web.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class ProdutoController : ControllerBase
    {
        private static List<Produto> _produtos = new List<Produto>();

        private IMapper _mapper;

        public ProdutoController(IMapper mapper)
        {
            _mapper = mapper;

        }

        [HttpGet]
        // GET - Used to request data from a specified resource.
        public IActionResult ObterHoraAtual()
        {
            return Ok(DateTime.Now);
        }


        [HttpPost]
        // POST - Used to send data to a server to create/update a resource.
        public IActionResult AdicionarProduto([FromBody] CriarProdutoDto produtoDto)
        {
            Produto produto = _mapper.Map<Produto>(produtoDto);
            _produtos.Add(produto);
            return CreatedAtAction(nameof(ObterProdutoPorId), new { Id = produto.Id }, produto);
        }


        [HttpGet("{id}")]
        public IActionResult ObterProdutoPorId(int id)
        {
            var produto = _produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto != null)
            {
                return Ok(produto);
            }
            return NotFound();
        }


        [HttpPut("{id}")]
        // PUT - Used to send data to a server to create/update a resource.
        // ** P.S.: The difference between POST and PUT is that PUT requests are idempotent.Which means that calling the same PUT request multiple times will always produce the same result.
        public IActionResult AtualizarProduto(int id, [FromBody] AtualizarProdutoDto produtoDto)
        {
            var produto = _produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            _mapper.Map(produtoDto, produto);
            return Ok(produto);

        }


        [HttpDelete("{id}")]
        // DELETE - Deletes the specified resource.
        public IActionResult RemoverProduto(int id)
        {
            var produto = _produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            _produtos.Remove(produto);
            return NoContent();

        }
    }


}
