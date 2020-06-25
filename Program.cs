using System;

namespace Aula24ObjetosArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto prod1 = new Produto("Fritadeira Wallit",1 ,349.99f);
            Produto prod2 = new Produto("Ferro de passar Arno",2 ,129.99f);
            Produto prod3 = new Produto("Liquidificador 3 potências Arno",3 ,89.99f);
            Produto prod4 = new Produto("Sanduicheira Mabe",4 ,29.99f);

            cart.Adicionar(prod1);
            cart.Adicionar(prod2);
            cart.Adicionar(prod3);
            cart.Adicionar(prod4);

            cart.Deletar(prod3);

            Produto prodAlterado = new Produto("Jogo de copos americanos", 3, 29.99f);
            cart.Alterar(4, prodAlterado);

            cart.Ler();
            cart.MostrarTotal();
        }
    }
}
