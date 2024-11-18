List<string> cities = new List<string>();
string svar = "";

while(true){
System.Console.WriteLine("Skriv ett namn på en stad eller skriv exit för att avsluta programmet");
svar = Console.ReadLine();
cities.Add(svar);

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

