//List<string> ListarNomes = new List<string>();

////  comando para criar listas

//ListarNomes.Add("leo");
//ListarNomes.Add("welbister");
//ListarNomes.Add("ana");
//ListarNomes.Add("joao");

//foreach (string nome in ListarNomes)
//{
//    Console.WriteLine(nome);
//}

using System.Reflection;
using System.Threading.Channels;
using POO;

//Livro livro1 = new Livro();

//livro1.Editora = "Arqueiro";
//livro1.NomeDoLivro = "O nome Do Vento";
//livro1.Autor = "Patric Rothfuss";

//livro1.MostrarInformacoes();

//Aluno aluno1 = new Aluno()
//{
//    idade = 1800,
//    nome = "leonardo",
//    nota_final = 2.5
//};

//Console.WriteLine("");

//aluno1.Mostrarinfos();

//Produto produto1 = new Produto()
//{
//    nome = "Feijoada Em Lata",
//    preco = 1200,
//    quantidadeEmEstoque = 78
//};

//produto1.MostrarInformacoes();
//produto1.CalcularTotal();

//Console.WriteLine("");

//produto1.preco = 150;
//produto1.quantidadeEmEstoque = 12;

//produto1.MostrarInformacoes();
//produto1.CalcularTotal();

//Carro carro1 = new Carro(); // serve para criar um objeto - voce chama a classe, da um nome para a                               variavel e inicia o objeto

//carro1.modificar("hb20");
//carro1.AnoDeFabricacao = 2020;
//carro1.Marca = "hyundai";

//Carro carro2 = new Carro()  // modo certo de instanciar um objeto
//{
//    AnoDeFabricacao = 1998,
//    Marca = "GM",

//};

//carro2.modificar("Vectra");

//Carro carro3 = new Carro()
//{
//    AnoDeFabricacao = 2024,
//    Marca = "Hyundai"
//};

//carro3.modificar("civic type R");

//List<Carro> ListarCarros = new List<Carro>();

//ListarCarros.Add(carro1);
//ListarCarros.Add(carro2);
//ListarCarros.Add(carro3);

//foreach (Carro i in ListarCarros)
//{
//    i.MostrarInfomacoes();
//    Console.WriteLine(" ");
//}

//ContaBancaria conta = new ContaBancaria();
//while (true)
//{
//    Console.WriteLine("Depositar, Sacar, visualizar ou Sair? ");
//    string resposta = Console.ReadLine().ToUpper();

//    if (resposta == "DEPOSITAR")
//    {
//        Console.WriteLine("Digite o valor do deposito");
//        double dep = double.Parse(Console.ReadLine());
//        conta.Depositar(dep);
//        Console.WriteLine($"Valor atual da conta");
//        Console.WriteLine(conta.Mostrar());
//    }

//    else if (resposta == "SACAR")
//    {
//        Console.WriteLine("Digite o valor do deposito");
//        double sac = double.Parse(Console.ReadLine());
//        conta.Sacar(sac);
//        Console.WriteLine($"Valor atual da conta");
//        Console.WriteLine(conta.Mostrar());
//    }
//    else if (resposta == "VISUALIZAR")
//    {
//        Console.WriteLine(conta.Mostrar());
//    }
//    else if (resposta == "SAIR")
//    {
//        Console.WriteLine($"Valor atual da conta");
//        Console.WriteLine(conta.Mostrar());
//        Console.WriteLine("Encerrando");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Digite um valor valido");
//    }
//}

//Funcionario funcionario1 = new Funcionario();

//funcionario1.SetSalario(2500);
//Console.WriteLine(funcionario1.GetSalario());













// W I B B