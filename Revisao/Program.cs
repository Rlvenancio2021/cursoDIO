using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Imprimir menu para o usuário ##
            string opcaoUsuario = ObterOpcaoUsusario();
            //Opção para dar obter uma informação do usuário

            while (opcaoUsuario.ToUpper() != "X")
            // != significa Diferente de
            {
                switch (opcaoUsuario)
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
               
                opcaoUsuario = ObterOpcaoUsusario();

            }
        }

        //# Criar um método #
        private static string ObterOpcaoUsusario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
