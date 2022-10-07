using Projeto02.Entities;
using Projeto02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controllers
{
    public class FuncionarioController

    {

      

        public void CadastrarFuncionario()
        {
            try
            {

                Console.WriteLine("\n *** CADASTRO DE FUNCIONÁRIO *** \n");

                #region Capturar os dados do funcionario

                var funcionario = new Funcionario();
                funcionario.Id = Guid.NewGuid();

                Console.Write("NOME DO FUNCIONARIO .........: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("DATA DE NASCIMENTO ..........: ");
                funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("MATRICULA ...................: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("CPF .........................: ");
                funcionario.CPF = Console.ReadLine();

                Console.Write("DATA DE ADMISSAO ............:");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());



                #endregion

                #region Capturar os dados do Setor do funcionario

                funcionario.Setor = new Setor();
                funcionario.Setor.Id = Guid.NewGuid();

                Console.Write("SIGLA DO SETOR ..............: ");
                funcionario.Setor.Sigla = Console.ReadLine();

                Console.Write("DESCRIÇÃO DO SETOR ..........: ");
                funcionario.Setor.Descricao = Console.ReadLine();

                #endregion

                #region Exportando os dados para arquivo

                Console.Write("\n INFORME (1)CSV ou (2)TXT: ");
                var opcao = int.Parse(Console.ReadLine());

                // criando um objeto da classe abstrata, mas sem instancia-lo
                FuncionarioRepository funcionarioRepository = null;

                switch(opcao)

                {
                    case 1: //CSV
                        //POLIMORFISMO
                        funcionarioRepository = new FuncionarioRepositoryCSV();
                        break;

                    case 2: //TXT
                        //POLIMORFISMO
                        funcionarioRepository = new FuncionarioRepositoryTXT();
                        break;

                    default: //NDA
                        Console.WriteLine("\nFORMATO INVALIDO");
                        break;

                }

                //verificando se o objeto "funcionarioRepository" não é null
                if(funcionarioRepository != null)
                {
                    //gravando os dados do funcionario em arquivo
                    funcionarioRepository.ExportarDados(funcionario);
                    Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");

                }

                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFalha ao cadastrar: {e.Message}");

            }

        }


      
    }
}
