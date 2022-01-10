using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePedidos.Entidades
{
    class Gerente : Funcionario
    {
        private string Senha;
        private double PedidoComDesconto;

        public Gerente(string senha, string nome, int matricula) : base(nome, matricula)//Os atributos definidos vão definir os atributos na classe base.//pegando atributos de uma outra classe
        {
            this.Senha = senha;
        }

        public void CalcularValorPedidoDescontado(double valorDoPedido)//variável começa com letra minuscula//void pois n retorna nada
        {
            this.PedidoComDesconto += valorDoPedido * 0.85;//Pegando o valor total e multiplicando por 85 porcento do valor do produto;
        }

        public double RetornarValorDescontado()
        {
            return this.PedidoComDesconto;
        }

        public string MostrarSenha()//Não precisa ser atriburido valor dentro deste método pois a senha sera definina na instanciação da classe Gerente;
        {
            return this.Senha;
        }
    }
}
