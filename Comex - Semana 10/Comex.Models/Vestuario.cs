using Comex.Comex.Models.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Vestuario : Produto
    {
        public string Tamanho { get; }
        public string Cor { get; }

        public Vestuario(string nome, string descricao, decimal preco, int quantidade_estoque, string categoria, string atributos) : base(nome, descricao, preco, quantidade_estoque, categoria, atributos)
        {
            Tamanho = atributos.ExtrairTamanho();
            Cor = atributos.ExtrairCor();
        }
    }
}