using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ESCOLA_PARTE3{
    public static class Validar{

        public static string ValidaCodigoDaTurma(string CodigoDaTurma){

            while (!(Regex.IsMatch(CodigoDaTurma, @"^[a-zA-Z0-9]+$") && CodigoDaTurma.Length > 2 && CodigoDaTurma.Length < 11)) {//Validação permite números, letras maiúsculas e minúsculas.
                Console.Write("\n\n\n\t\tCodigo inválido!! O codigo da turma deve estar entre 3 a 10 caracteres.\n\t\tPodem ser usados números," +
                        " letras minusculas e maiusculas\n\n\t\tPor gentileza insira o codigo da turma: ");
                CodigoDaTurma = Console.ReadLine();
            }

            foreach (Turma turma in Escola.Turmas) {

                if (turma.CodigoDaTurma == CodigoDaTurma) {

                    Console.Clear();
                    Console.Write($"\n\n\n\n\n\n\n\t\t\tO codigo da turma {CodigoDaTurma} já está em uso! Aperte enter para continuar.\n\t\t\t\t\t\t\t");
                    Console.ReadLine();
                    ValidaCodigoDaTurma(CodigoDaTurma);
                }
            }

            return CodigoDaTurma;
        }

        public static int GerarMatriculaOuRegistro(){

            int gerarMatriculaOuRegistro;

            do gerarMatriculaOuRegistro = new Random().Next(100000, 999999);
            while (Escola.Alunos.Where(x => x.Matricula == gerarMatriculaOuRegistro).Any() || Escola.Professores.Where(x => x.Registro == gerarMatriculaOuRegistro).Any());

            return gerarMatriculaOuRegistro;
        }
    }
}