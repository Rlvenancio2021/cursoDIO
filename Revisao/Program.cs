using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            //# criar array # - primeiro criar a struct aluno, struct por ser um exemplo simples o ideal seria uma classe
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            //## Imprimir menu para o usuário ##
            string opcaoUsuario = ObterOpcaoUsusario();
            //Opção para dar obter uma informação do usuário

            while (opcaoUsuario.ToUpper() != "X")
            // != significa Diferente de
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new Aluno(); //cria um objeto aluno
                        aluno.Nome = Console.ReadLine(); //set o nome conforme o usuário digita

                        Console.WriteLine("Informe a nota do aluno:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno; //grava aluno em alguma posição do array
                        indiceAluno++;
                                                
                        break;
                    case "2":
                        foreach(var a in alunos)//para cada a (aluno) no array
                        {
                            if (!string.IsNullOrEmpty(a.Nome))//se o nome n``ão for vazio
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}"); //imprima Aluno e Nota`
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0; //criar variável nota total com valor zero
                        var nrAlunos = 0; //criar variável nr alunos com valor zero

                        for (int i=0; i < alunos.Length; i++) //para cada aluno
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral}");
                        
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
            Console.WriteLine();
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
