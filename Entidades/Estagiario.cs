using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePedidos.Entidades
{
    public class Estagiario : Funcionario
    {
        private double PedidoComDesconto;//representa o valor do pedido descontado
        public Estagiario(string nome, int matricula) : base(nome, matricula)
        {
            
        }

        public void CalcularValorPedidoDescontado(double valorDoPedido)
        {
            PedidoComDesconto +=  valorDoPedido * 0.95;
        }

        public double RetornarValorDesconto()
        {
            return this.PedidoComDesconto;
        }

    } 
}
