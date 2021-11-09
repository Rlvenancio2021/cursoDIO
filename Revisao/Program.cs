using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Imprimir menu para o usuário ##
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            //## Solicita uma opção ao usuário ##
            string opcaoUsuario = Console.ReadLine();
            //Opção para dar obter uma informação do usuário

            while (opcaoUsuario.ToUpper() != "X")
            // != significa Diferente de
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        break;
                    case "2":
                        //TODO: lista aluno
                        break;
                    case "3":
                        //TODO: calcular media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                        //Caso digite uma opção invalida ele irá indicar que o valo informado esta fora do range de opções
                }
            //## Após execução solicitar uma nova opção ao usuário ##
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            opcaoUsuario = Console.ReadLine();

            }            
        }
    }
}
