using System;

namespace ESCOLA_PARTE3 {
    public class Professor : Pessoa {

        public int Registro { get; set; }

        //public Coordenador Coordenador { get; set; }

        public void CriarProfessor() {//Método para criar o "objeto" professor.

            Console.Clear();
            Console.Write("\n\n\n\t\tDigite as informações do professor\n\n\t\t");
            ObterNome();
            do { Idade = ObterIdade(); }
            while (int.Parse(Idade) < 20);//Garante que o professor tenha no mínimo 20 anos.
            Sexo = ObterSexo();
            Registro = Validar.GerarMatriculaOuRegistro();
            Console.Write($"\t\tO registro de {Nome} é: {Registro}\n");

        }

        public override string ToString() {//Imprime esse texto quando for solicitado imprimir o objeto professor.
            return $"\tProfessor {Nome}, cujo registro {Registro}, é do sexo {Sexo} e tem {Idade} anos.\n";
        }
    }
}