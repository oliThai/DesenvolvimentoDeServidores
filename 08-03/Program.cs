// See https://aka.ms/new-console-template for more information
using _08_03;

Console.WriteLine("Hello, World!");

produto p1 = new produto(1, "Mouse sem fio", 59.90M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Pessoa pessoa1 = new Pessoa(1, "Thais", "(16)99623-3113");
Console.WriteLine(pessoa1.GetNome() + " " + pessoa1.GetTelefone());