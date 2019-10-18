using System;

namespace ESCOLA_PARTE3 {
    public abstract class Pessoa {

        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }

        public string ObterNome() {//Método usado para obter o nome da pessoa.

            Console.Write("\n\t\tDigite o nome: ");
            Nome = Console.ReadLine().Trim();

            return Nome;
        }

        public string ObterIdade() {

            Console.Write($"\t\tDigite a idade de {Nome}: ");
            Idade = Console.ReadLine();

            return Idade;
        }

        public string ObterSexo() {

            Console.Write($"\t\tDigite o sexo de {Nome} (f ou m): ");
            Sexo = Console.ReadLine().ToLower();

            return Sexo;
        }
    }
}