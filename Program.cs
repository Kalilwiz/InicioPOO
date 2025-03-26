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

using POO;

Carro carro1 = new Carro(); // serve para criar um objeto - voce chama a classe, da um nome para a                               variavel e inicia o objeto

carro1.modelo = "HB20";
carro1.AnoDeFabricacao = 2020;
carro1.Marca = "hyundai";

Carro carro2 = new Carro();

carro2.modelo = "vectra";
carro2.AnoDeFabricacao = 1998;
carro2.Marca = "GM";

Carro carro3 = new Carro();

carro3.modelo = "civic type R";
carro3.AnoDeFabricacao = 2024;
carro3.Marca = "Hyundai";

List<Carro> ListarCarros = new List<Carro>();

ListarCarros.Add(carro1);
ListarCarros.Add(carro2);
ListarCarros.Add(carro3);

foreach (Carro i in ListarCarros)
{
    i.MostrarInfomacoes();
    Console.WriteLine(" ");
}

Livro livro1 = new Livro();

livro1.Editora = "Arqueiro";
livro1.NomeDoLivro = "O nome Do Vento";
livro1.Autor = "Patric Rothfuss";

livro1.MostrarInformacoes();











// W I B B