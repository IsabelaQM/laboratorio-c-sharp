using FluentAssertions;

namespace Comex.Testes
{
    public class CategoriaTestes
    {
        [Fact]
        public void TestaCriacaoDeCategoria()
        {
            Categoria categoria = new Categoria(1, "INFORM�TICA", "INATIVA");
            categoria.Nome.Should().Be("INFORM�TICA");
            categoria.Status.Should().Be("INATIVA");
        }
    }
}