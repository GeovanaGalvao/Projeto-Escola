using System;
using System.Collections.Generic;

namespace ESCOLA_PARTE3 {
    public static class Escola {

        public static List<Turma> Turmas { get; set; } = new List<Turma>();

        public static List<Professor> Professores { get; set; } = new List<Professor>();

        public static List<Aluno> Alunos { get; set; } = new List<Aluno>();

        public static void MainMenu() {

            string escolha;

            do {

                Console.WriteLine("\n\nPor favor escolha uma das opções abaixo:\n\n1) Cadastrar pessoa\n2) Deletar cadastro existente\n" +
                "3) Listar pessoas cadastradas\n4) Criar turma\n5) Deletar turma\n6) Listar turma(as)\n7) Ajuda\n\n0) Finalizar o programa");
                escolha = Console.ReadLine();
                Console.WriteLine("Qual opção deseja selecionar? ");
                Console.Clear();

                switch (escolha) {

                    case "1":

                        Console.WriteLine("\nQuem gostaria de cadastrar?\n\n1) Cadastrar coordenador\n" +
                        "2) Cadastrar professor\n3) Cadastrar aluno\n4) Voltar para menu anterior\n\n0) Finalizar o programa");
                        escolha = Console.ReadLine();

                        do {

                            switch (escolha) {

                                case "1":

                                    //Coordenador coordenador = new Coordenador();
                                    //coordenador.CriarCoordenador();
                                    //Coordenadores.Add(coordenador);
                                    //escolha = "4";

                                    break;

                                case "2":
                                    
                                    Professor professor = new Professor();
                                    professor.CriarProfessor();
                                    Professores.Add(professor);
                                    escolha = "4";

                                    break;

                                case "3":

                                    Aluno aluno = new Aluno();
                                    aluno.CriarAluno();
                                    Alunos.Add(aluno);
                                    escolha = "4";
                                    break;

                                case "4":
                                    break;

                                default:
                                    Console.WriteLine("Escolha Inválida\n");
                                    break;

                            }

                        } while (escolha != "4");

                        break;

                    case "7":

                        Console.WriteLine("\n\n\n\tPara cadastrar um coordenador, professor ou aluno, digite 1\n\tPara deletar um cadastro existente, digite 2" +
                            "");
                        break;

                    default:

                        Console.WriteLine("\nComando Inválido!");
                        break;

                }

            } while (escolha != "0");
        }
    }
}