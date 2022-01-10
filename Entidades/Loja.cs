using System.Collections.Generic;

namespace SistemaDePedidos.Entidades
{
    public class Loja
    {
        List<Pedido> Pedidos { get; set; }

        public Loja()
        {
            this.Pedidos = new List<Pedido>();
        }

        public void InserirPedido(Pedido pedido)
        {
            this.Pedidos.Add(pedido);
        }

        public Pedido BuscarPedido(int pedidoId)
        {
            foreach (Pedido pedido in Pedidos)
            {
                if (pedido.retornarPedidoId() == pedidoId)
                {
                    return pedido;
                }
            }

            throw new System.Exception("Pedido não encontrado!!");
        }
        public void RemoverPedido(int pedidoId)
        {
            foreach(Pedido pedido in Pedidos)
            {
                if( pedido.retornarPedidoId() == pedidoId)
                {
                    this.Pedidos.Remove(pedido);
                }
            }
        }
    }
}
