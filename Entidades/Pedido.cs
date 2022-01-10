using System;
using System.Collections.Generic;

namespace SistemaDePedidos.Entidades
{
    public class Pedido
    {
        private int PedidoId { get; set; }
        private double ValorDoPedido { get; set; }
        private string DescricaoDoPedido { get; set; }
        private DateTime DataEmissao { get; set; }
        private List<Produto> Produtos { get; set; }   
    
        public Pedido()//Caso queira instanciar um pedido vazio Compilador daria erro
        {

        }
        public Pedido(int pedidoId, string descricaoDoPedido, DateTime dataEmisao)
        {
            this.PedidoId = pedidoId;
            this.DescricaoDoPedido = descricaoDoPedido;
            this.DataEmissao = dataEmisao;
            this.Produtos = new List<Produto>();
        }


        public List<Produto> retornarListaDeProdutos()
        {
            return this.Produtos;
        }

        public void AdicionarUmProduto(Produto produto)
        {
            this.Produtos.Add(produto);
        }

        public int retornarPedidoId()
        {
            return this.PedidoId;
        }
        
        public void RemoverUmProduto(Produto produto)
        {
            this.Produtos.Remove(produto);
        }

        public double RetornaValorPedido()
        {
            return this.ValorDoPedido;
        }

        public void CalcularTotalPedido()//Apenas fazendo um calculo por isso não precisa retornar.
        {
            foreach(Produto produto in  Produtos)
            {
                this.ValorDoPedido += produto.valorProduto;
            }
        }
    }
}
