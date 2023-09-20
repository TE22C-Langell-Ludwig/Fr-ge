string text;
int Points = 0;

Console.WriteLine("Dags för frågesport");
Console.WriteLine("Första frågan. Vem är den bästa matte läraren");
Console.WriteLine("1.Joel");
Console.WriteLine("2.Calle");
Console.WriteLine("3.Hobbe");
text=Console.ReadLine();

if (text == "1")
{
 Console.WriteLine("Du fick rätt :thumbsup:") ;
 ++Points;
}
if (text == "2"){
Console.WriteLine("Du fick fel för han är ju lite cringe imo");
}
if (text == "3"){
Console.WriteLine("nämen de är ju inte ens en lärare") ;
}
Console.WriteLine();
Console.WriteLine("Andra frågan. Vem är kungen av mackerspace");
Console.WriteLine("1.Hobbe");
Console.WriteLine("2.David");
Console.WriteLine("3.Benjamin");
text=Console.ReadLine();
if (text == "1")
{
 Console.WriteLine("Han må vara cool men inte riktigt så cool är han") ;
}
if (text == "2"){
Console.WriteLine("Han må ha printat den största benchien men det är ju inte nog");
}
if (text == "3"){
Console.WriteLine("Du fick rätt :thumbsup:") ;
++Points;
}
Console.WriteLine();
Console.WriteLine("Tredje frågan. Vem är van i parkouren på hobbes server igår");
Console.WriteLine("1.Ludwig");
Console.WriteLine("2.Lowe");
Console.WriteLine("3.Oskar");
text=Console.ReadLine();
if (text == "1")
{
 Console.WriteLine("Du fick rätt :thumbsup:") ;
 ++Points;
}
if (text == "2"){
Console.WriteLine("Han typ tog sig aldrig förbi honey delen");
}
if (text == "3"){
Console.WriteLine("`Jag vet inte ens om han tog sig till honey delen nån gång") ;
}








Console.WriteLine();
Console.WriteLine($"Du fick {Points}");
if (Points== 0){
 Console.WriteLine("du fick inte ens 1 fråga rätt lite cringe imo");
}
if (Points== 1){
 Console.WriteLine("du fick bara rätt på 1 av 3 frågor better luck next time");
}
if (Points== 2){
   Console.WriteLine("du fick bara rätt på 2 av 3 frågor ganska bra gjort av dig men kan du få sista poänget");
}
if (Points== 3){
   Console.WriteLine("du fick bara rätt på 3 av 3 frågor good job du fick rätt på alla frågorna :thumbsup:");
}


Console.ReadLine();