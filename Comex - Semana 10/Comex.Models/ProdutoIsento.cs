using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class ProdutoIsento : Produto
    {
        public static new int Quantidade { get; set; }
        public ProdutoIsento(string nome, string descricao, decimal preco, int quantidade_estoque, string categoria, string atributos) : base(nome, descricao, preco, quantidade_estoque, categoria, atributos)
        {
        }

        public override decimal CalculaImposto()
        {
            return 0;
        }
    }
}
