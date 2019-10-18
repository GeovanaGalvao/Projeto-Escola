using System;

namespace ESCOLA_PARTE3 {
    public class Aluno : Pessoa {

        public int Matricula { get; set; }
        public string Bolsista { get; set; }

        public void CriarAluno() {//Método que cria o objeto aluno

            Console.Clear();
            Console.Write("\n\n\n\t\tDigite as informações do aluno\n\n\t\t");
            ObterNome();
            ObterIdade();
            ObterSexo();
            DescobreSeBolsista();
            Matricula = Validar.GerarMatriculaOuRegistro();

            Console.Write($"\n\t\tO codigo de matricula de {Nome} é: {Matricula}");
            Console.Write($"\n\n\n\n\t\t{Nome} foi cadastrado com sucesso!\n\n\n\t\tAperte qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        private string DescobreSeBolsista() {//Método para obter a informação se o aluno é bolsista ou não.

            Console.Write($"\t\t{Nome} é bolsista? (S/N): ");
            Bolsista = Console.ReadLine().ToUpper();

            return Bolsista;
        }

      

        public override string ToString() => $"\t{Nome} é do sexo {Sexo} e tem {Idade} anos.\n\tSeu código de matrícula é {Matricula} e {Nome} {Bolsista}.\n";
    }
}