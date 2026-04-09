using Figuras.Classes.Entidades;
using Figuras.Classes.Enumerações;
Forma geo1 = new Forma(Cor.Vermelho);
Forma geo2 = new Retangulo(Cor.Azul,10, 10 );
Forma geo3 = new Circulo(Cor.Rosa,5);

Console.WriteLine($"Geo 1 - Tipo Forma : Area = {geo1.Area()})" +
    $"\nGeo 2 - tipo Forma -> Retangulo : Area = {geo2.Area()}" +
    $"\nGeo 3 - tipo Forma -> Circulo : Area = {geo3.Area()}");
