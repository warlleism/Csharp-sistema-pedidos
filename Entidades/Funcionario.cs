using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePedidos.Entidades
{
    public class Funcionario
    {
        //Classe generalista, passa todos os atributos para todas as outras classes.
        private string Nome;
        private int Matricula;
        private int idade;
        /*public Funcionario()//Caso queira retornar um funcinário vázio.//Quando o classe for instanciado toda todos os parametros dentro do construtor teram que ser passados
        {                     //Não é certo ter um construtor vázio aqui,pois as heranças fazem parte do contrato

        }*/
        public Funcionario(string nome, int matricula)//definição de um contrato, tenho que passa os tributos contidos no contrado para os filhos.
        {
            this.Nome = nome;
            this.Matricula = matricula;
        }
        /*public void FactoryClass(string nome, int matricula)//Atribuindo valores a uma classe
        {
            this.Nome = nome;
            this.Matricula = matricula;
        }*/
    }
}
