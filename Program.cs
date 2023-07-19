
using Projeto.Classes;

string opcao = "";
PessoaJuridica MetodosPJ = new PessoaJuridica();
do
{
    Console.WriteLine(@"

    1 - Cadastrar PJ
    2 - Sair

    ");

    opcao = Console.ReadLine()!;

    if (opcao == "1")
    {
        PessoaJuridica pj = new PessoaJuridica();

        Console.WriteLine("Digite o nome da Pessoa Juridica: ");
        pj.Nome = Console.ReadLine();

        Console.WriteLine("Digite o rendimento da Pessoa Juridica");
        pj.Rendimento = float.Parse(Console.ReadLine()) ; //10000

        Console.WriteLine("Digite o CNPJ da PJ");
        pj.CNPJ = Console.ReadLine();

        MetodosPJ.Inserir(pj);
    }
} while (opcao != "2");

