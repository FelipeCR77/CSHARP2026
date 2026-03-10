using static System.Console;
using static System.Linq.Enumerable;
List <string> nomes = new List<string>();
nomes.Add("Reacher");
nomes.Add("Sam winchester");
nomes.Add("Dean WInchester");
nomes.Add("Castiel");
nomes.Add("Bobby Singer");
nomes.Add("Crowley");
nomes.Add("Lucifer");
WriteLine(nomes);
foreach (var item in Range(0, nomes.Count))
{
    
    WriteLine(nomes[item]);
}
WriteLine(". ----");

nomes.Remove("Maria");

{
foreach (var item in Range (0, nomes.Count)) //Count retorna o tamanho da lista

{

WriteLine(nomes [item]);

}

WriteLine("--------------");

nomes.Clear();

foreach (var item in Range (0, nomes.Count)) //Count retorna o tamanho da lista

{

***WriteLine(nomes [item]);

}

WriteLine("--------------");

WriteLine("Indice que contém 'João': " + nomes.Contains("João"));

foreach (var item in Range (0, nomes.Count)) //Count retorna o tamanho da lista

}

...WriteLine(nomes [item]);
    