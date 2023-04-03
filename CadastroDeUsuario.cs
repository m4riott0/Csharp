using System;

namespace Cadastrodeusuario
{
    class cadastro
    {
        public void Main(string[])
        {

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu login: ");
            string login = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();

            Console.WriteLine("\nCadastro concluído com sucesso!");
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Seu login é: " + email);
            Console.WriteLine("Sua senha é: " + senha);

        }
    }
}