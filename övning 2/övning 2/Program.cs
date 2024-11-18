List<string> klassnamn = ["Konstatin", "Jacob", "Anton", "David", "Richard"];
List<int> tal = [2,4,5,6,8,];
List<string> leksak = ["båt","mus","spel","råtta","kebab"];

for (int i = 0; i < 1; i++)
{
  Console.WriteLine($"{klassnamn[0]} ger {leksak[0]} betyget {tal[0]}");
  Console.WriteLine($"{klassnamn[1]} ger {leksak[1]} betyget {tal[1]}");
  Console.WriteLine($"{klassnamn[2]} ger {leksak[2]} betyget {tal[2]}");
  Console.WriteLine($"{klassnamn[3]} ger {leksak[3]} betyget {tal[3]}");
  Console.WriteLine($"{klassnamn[4]} ger {leksak[4]} betyget {tal[4]}");
}
Console.ReadLine();