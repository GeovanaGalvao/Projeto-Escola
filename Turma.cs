using System;
using System.Collections.Generic;

namespace ESCOLA_PARTE3 {
    public class Turma {

        public string CodigoDaTurma { get; set; }

        public Professor Professor { get; set; }

        public List<Aluno> AlunosDaTurma { get; set; } = new List<Aluno>();

        internal void CriarTurma() {//Método usado para criar uma turma.

            ObtemCodigoDaTurma();
            Console.WriteLine("Turma criada com sucesso!");
        }

        internal void ObtemCodigoDaTurma() {//Método de validação do codigo da turma.

            Console.Write("\n\n\n\t\tO codigo da turma deve estar entre 3 a 10 caracteres.\n\t\tPodem ser usados números," +
                    " letras minusculas e maiusculas\n\n\t\tPor gentileza insira o codigo da turma: ");
            CodigoDaTurma = Console.ReadLine();
            Validar.ValidaCodigoDaTurma(CodigoDaTurma);
        }

        internal void ImprimeListaDeAlunosDaTurma() {//Método para mostrar todos os alunos vinculados a turma.

            foreach (Aluno A in AlunosDaTurma) {
                Console.WriteLine(A);
            }
        }

        public override string ToString() {//Imprime esse texto quando for solicitado imprimir o objeto turma.
            return $"\n\n\t\t\tA turma {CodigoDaTurma} tem {AlunosDaTurma.Count} alunos.";
        }
    }
}