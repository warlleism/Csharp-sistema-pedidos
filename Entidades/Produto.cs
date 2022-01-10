namespace SistemaDePedidos.Entidades
{
    public class Produto
    {
        public string nomeProduto { get; set; }//Te permite enviar o atributo para outras classes
        public double valorProduto { get; set; }

        public Produto(string nomeProduto, double valorProduto)
        {
            this.nomeProduto = nomeProduto;
            this.valorProduto = valorProduto;
        }

    }
}
