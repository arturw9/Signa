using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Signa.Data;
using Xunit;

namespace SeuProjeto.Tests
{
    public class PessoaControllerTests
    {
        private readonly ApiDbContext _context;
        private readonly PessoaController _controller;

        public PessoaControllerTests()
        {
            var options = new DbContextOptionsBuilder<ApiDbContext>()
                .UseInMemoryDatabase("TestDb") 
                .Options;

            _context = new ApiDbContext(options);

            _controller = new PessoaController(_context);
        }

        [Fact]
        public async Task Detalhes_RetornaNotFound_QuandoPessoaNaoExistir()
        {
            var pessoaId = 1;

            var result = await _controller.Detalhes(pessoaId);

            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal("Detalhes desta pessoa não encontrado.", notFoundResult.Value);
        }

        [Fact]
        public async Task Detalhes_RetornaViewComPessoa_QuandoPessoaExistir()
        {
            var pessoaId = 5;
            var pessoa = new Pessoa { PessoaId = pessoaId, NomeFantasia = "João", CnpjCpf = "6526522626" };
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();

            var result = await _controller.Detalhes(pessoaId);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<Pessoa>(viewResult.Model);
            Assert.Equal(pessoaId, model.PessoaId);
            Assert.Equal("João", model.NomeFantasia);
        }

        [Fact]
        public async Task ListarClientes_RetornaTodosOsClientes()
        {
            _context.Pessoas.RemoveRange(_context.Pessoas); 
            await _context.SaveChangesAsync();

            var pessoa1 = new Pessoa { PessoaId = 55, NomeFantasia = "Maria", CnpjCpf = "123456789" };
            var pessoa2 = new Pessoa { PessoaId = 66, NomeFantasia = "Pedro", CnpjCpf = "987654321" };
            var pessoa3 = new Pessoa { PessoaId = 77, NomeFantasia = "Ana", CnpjCpf = "1122334455" };
            var pessoa4 = new Pessoa { PessoaId = 88, NomeFantasia = "Carlos", CnpjCpf = "5566778899" };
            var pessoa5 = new Pessoa { PessoaId = 99, NomeFantasia = "Joana", CnpjCpf = "9988776655" };

            _context.Pessoas.AddRange(pessoa1, pessoa2, pessoa3, pessoa4, pessoa5); 
            await _context.SaveChangesAsync();

            var result = await _controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<List<Pessoa>>(viewResult.Model);

            foreach (var pessoa in model)
            {
                Console.WriteLine($"Pessoa ID: {pessoa.PessoaId}, Nome Fantasia: {pessoa.NomeFantasia}, CNPJ/CPF: {pessoa.CnpjCpf}");
            }
            Assert.Equal(5, model.Count);
        }
    }
}