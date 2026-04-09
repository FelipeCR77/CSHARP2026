using Master;
Console.WriteLine("Tipo.ContaNormal");
Console.WriteLine("Tipo.ContaPoupanca");
Console.WriteLine("Tipo.ContaPj");
//
Conta conta = new Conta(12345, 11500.56, new Pessoa("Clodoaldo", 4068831));
var a = conta.ToString();
Console.WriteLine(a);

Conta pj = new ContaPj(54321, 50000, new Pessoa("César", 4068831), 100000);

var b = pj.ToString();
Console.WriteLine(b);
ContaPoupanca pp = new ContaPoupanca(666666, 666.66, new Pessoa("Lu", 66666666666) , 0.5);
pp.Consulta();

Console.ReadKey();