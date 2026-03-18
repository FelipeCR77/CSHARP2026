using static System.Console;
Title = " Calculadora de traingulo";
//Entrada de dados
Write("Digite as medidas do Triângulo X ");
double ax = double.Parse(ReadLine());
Write("Digite o valor de b: ");
double bx = double.Parse(ReadLine());
Write("Digite o valor de c: ");
double cx = double.Parse(ReadLine());

WriteLine("Digite as medidas do Triângulo Y ");
double ay = double.Parse(ReadLine());
Write("Digite o valor de b: ");
double by = double.Parse(ReadLine());
Write("Digite o valor de c: ");
double cy = double.Parse(ReadLine());
//Processamento de dados
double px = (ax + bx + cx) / 2;
double py = (ay + by + cy) / 2;
double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(py * (py - ay) * (py - by) * (py - cy));

//Saída de dados
WriteLine($"Área do Triângulo X é de {areax:F2}");
WriteLine($"Área do Triângulo Y é de {areay:F2}");


if (areax > areay)
{
    WriteLine("Maior área é do Triângulo X");
}
else if (areay areax)
{
    WriteLine("Maior área é do Triângulo Y");
}
else
{
    WriteLine("As áreas dos triângulos são iguais");
}

ReadKey();
