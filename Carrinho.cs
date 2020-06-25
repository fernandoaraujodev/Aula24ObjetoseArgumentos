using System.Collections.Generic;
using System;

namespace Aula24ObjetosArgumentos
{
    public class Carrinho
    {
        public float ValorTotal {get;set;}

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _prod){
            carrinho.Add(_prod);
        }

        public void Deletar(Produto _p){
            carrinho.Remove(_p);
        }

        public void Ler(){
            foreach(Produto item in carrinho){
                Console.WriteLine($"{item.Nome} está R$ {item.Preco}");
            }
        }

        public void Alterar(int _cod, Produto _produtoAlterado){

            carrinho.Find(a => a.Codigo == _cod).Nome = _produtoAlterado.Nome;
            carrinho.Find(a => a.Codigo == _cod).Preco = _produtoAlterado.Preco;

        }

        public void MostrarTotal(){

            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Valor total da compra R$ {ValorTotal}");
            Console.ResetColor();
        
        }



    }
}