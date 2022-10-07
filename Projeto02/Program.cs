//localização da classe dentro do projeto
using Projeto02.Controllers;
using System;

namespace Projeto02
{
    //definição da classe
    public class Program
    {
        //método para executar o conteudo da classe
        //ponto de inicialização do projeto
        public static void Main(string[] args)
        {
            //instanciando a classe de controle

            var funcionarioController = new FuncionarioController();

            //executar o metodo para cadastrar funcionario

            funcionarioController.CadastrarFuncionario();

            //pausar o prompt
            Console.ReadKey();
        }
    }
}

