using static System.Console;
//Entrada de dados
try{
    int contagem = 0;
    Write("Digite a quantas pessoas: ");
    int pessoas = int.Parse(ReadLine());

    Write("Digite a altura Máxima (cm): ");
    double alturaMaxima = double.Parse(ReadLine());

    Write("Digite a altura Mínima (cm): ");
    double alturaMinima = double.Parse(ReadLine());

    //-----Processamentop de dados

    for (int i = 0; i<pessoas; i++)
    {
        Write($"Digite a altura da pessoa {i + 1} ");
        double altura = double.Parse(ReadLine());
        if (altura < alturaMaxima & altura > alturaMinima)
        {
            contagem++;
        }
    }
    WriteLine($"Quantidade de pessoas com altura entre {alturaMinima} e {alturaMaxima} cm: {contagem}");
}
catch(Exception)
{
    Write("erro digite algo válido!");
}