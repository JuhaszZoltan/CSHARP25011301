using BarlangokCLI;
using System.Text;

const string RESDIR = "C:\\PROJECTS\\CSHARP25011301\\RESOURCES";

List<Barlang> barlangok = [];
using StreamReader sr = new($"{RESDIR}\\barlangok.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));

Console.WriteLine($"4. feladat: barlangok szama: {barlangok.Count()}");

var f5 = barlangok
    .Where(b => b.Telepules.StartsWith("Miskolc"))
    .Average(b => b.Melyseg);
Console.WriteLine($"5. feladat: az atlagos melyseg: {f5:0.000} m");

Console.Write("6. feladat: kerem a vedettsegi szintet: ");
string f6vsz = Console.ReadLine();
var f6 = barlangok
    .Where(b => b.Vedettseg == f6vsz.ToLower())
    .MaxBy(b => b.Hossz);
Console.WriteLine(f6 is null
    ? "\tnincs ilyen vedettsegi szinttel barlang az adatok kozt"
    : f6);


var f7grp = barlangok.GroupBy(b => b.Vedettseg);
Console.WriteLine("7. feladat: statisztika:");
foreach (var g in f7grp)
    Console.WriteLine($"\t{(g.Key+':').PadRight(
        barlangok.Max(b => b.Vedettseg.Length)+4, '-')}>{g.Count(),4}");

