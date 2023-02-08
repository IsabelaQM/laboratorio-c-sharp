using Comex.Comex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Pedido
    {
        public static int Quantidade { get; private set; }
        public int Id { get; private set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItensDoPedido> Itens { get; set; }
        public int QuantidadeVendida { get; set; }

        public Pedido( Cliente cliente, ItensDoPedido item, int quantidadeVendida)
        {
            Quantidade++;
            Id = Quantidade;
            Data = DateTime.Now;
            Cliente = cliente;
            Itens = new List<ItensDoPedido> { item };
            QuantidadeVendida = quantidadeVendida;
        }

        public decimal ValorTotal()
        {
            return Itens.Sum(i=>i.Total);
        }

        public decimal TotalDeImpostos()
        {
            return Itens.Sum(i=>i.Produto.CalculaImposto()); 
        }
    }
}