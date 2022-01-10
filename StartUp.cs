using SistemaDePedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePedidos
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o programa!!! \n");

            var loja = new Loja();
            var pedido1 = new Pedido(123, "cheio de hamburguer", DateTime.Now);

            //Produtos

            var produto1 = new Produto("X-Burguer", 20.50);
            var produto2 = new Produto("X-Bacon", 25.00);
            var produto3 = new Produto("X-Salada", 20.00);

            //Adicionando pedidos a Lista

            pedido1.AdicionarUmProduto(produto1);
            pedido1.AdicionarUmProduto(produto2);
            pedido1.AdicionarUmProduto(produto3);


            pedido1.CalcularTotalPedido();
           
            //Gerente

            var gerente = new Gerente("123","Warllei",24);
            gerente.CalcularValorPedidoDescontado(pedido1.RetornaValorPedido());//O método RetornaValorPedido() na classe pedido,
                                                                                //faz o calculo de todos os pedidos e joga para dentro da lista produtos.

            var estagiario = new Estagiario("warllei",25);
            estagiario.CalcularValorPedidoDescontado(pedido1.RetornaValorPedido());
            Console.WriteLine($"valor dado pelo estagiário Desconto: R${estagiario.RetornarValorDesconto()}");

            Console.WriteLine($"valor do pedido: R${pedido1.RetornaValorPedido()}");

            foreach (Produto produto in pedido1.retornarListaDeProdutos())
            {
                Console.WriteLine($"nome do produto: {produto.nomeProduto}");
            }

            Loja loja1 = new Loja();
            loja1.InserirPedido(pedido1);
            var PedidoBuscado = loja1.BuscarPedido(123);
            Console.WriteLine($"lista de pedidos: {PedidoBuscado.retornarPedidoId()}");
            Console.ReadKey();

        }
    }
}
