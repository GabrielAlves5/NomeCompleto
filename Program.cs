string nome, sobrenome;
Console.Write("Insira seu nome: ");
nome = Console.ReadLine()!;
Console.WriteLine("Insira seu sobrenome: ");
sobrenome = Console.ReadLine()!;
Console.WriteLine($"Seu nome é {nome} {sobrenome}");
Console.WriteLine($"Seu nome de catálogo {sobrenome.ToUpper()},{nome}");
