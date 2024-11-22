List<string> cities = new List<string>();
string svar;
int svarnum;

while(true){
System.Console.WriteLine("Skriv ett namn på en stad eller skriv exit för att avsluta programmet");
svar = Console.ReadLine();
cities.Add(svar);
bool siffra = int.TryParse(svar, out svarnum);

if(siffra == true ){
    System.Console.WriteLine("Skriv ett namn på en stad istället");
    cities.Remove(svar);
    Thread.Sleep(800);
}


if(svar.ToLower() == "exit"){
    cities.Remove("exit");
    break;
}
}

foreach(string city in cities)
{
    Console.WriteLine(city);
    Thread.Sleep(1000);
}
Console.ReadLine();

