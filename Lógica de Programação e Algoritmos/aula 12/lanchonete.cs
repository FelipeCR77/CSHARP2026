using static System.Console;
//declaração de um dicionario
Dictionary<int, Double> lanchonete = new Dictionary<int, Double>()
{
    //adicionando dados ao dicionário
    {1, 5.00},
    {2, 3.50},
    {3, 60}
};
//declaração de variaveis
int codigo, quantidade;
try{
    
    //Entrada de dados
    Write("Digite o codigo do produto: ");
    codigo = int.Parse(ReadLine());
    Write("Digite a quantidade de produto (os): ");
    quantidade = int.Parse(ReadLine());

    WriteLine($"O valor total é de: {quantidade * lanchonete[codigo]}");
}
catch(Exception ex){
    WriteLine($"Digite valores válidos, erro: {ex.Message}");
}



