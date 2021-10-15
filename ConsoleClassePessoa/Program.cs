using System;

namespace ConsoleClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome:");
            pessoa.nome = "Danilo Menezes"; Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            pessoa.idade = 25; Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu RG:");
            pessoa.rg = "39.564.066-6"; Console.ReadLine();

            Console.WriteLine("Digite seu CPF:");
            pessoa.cpf = "431.769.144-44"; Console.ReadLine();

            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("RG: {0}", pessoa.rg);
            Console.WriteLine("CPF: {0}", pessoa.cpf);

            Pessoa pessoaCleiton = new Pessoa();
            pessoaCleiton.nome = "Cleiton Rasta";
            pessoaCleiton.idade = 100;
            pessoaCleiton.rg = "39.560.555.20";
            pessoaCleiton.cpf = "111.120.000-80";

            Console.WriteLine("Nome: {0}", pessoaCleiton.nome);
            Console.WriteLine("Idade: {0}", pessoaCleiton.idade);
            Console.WriteLine("RG: {0}", pessoaCleiton.rg);
            Console.WriteLine("CPF: {0}", pessoaCleiton.cpf);

            pessoa.Acenar(pessoaCleiton);
            pessoa.PerguntaIdade(pessoaCleiton);
        }
    }
}