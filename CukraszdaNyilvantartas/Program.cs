using CukraszdaNyilvantartas;
List<Sutemeny> sutik=new List<Sutemeny>();


for (int i=0;i<4;i++)
{
    Sutemeny aktualis = new Sutemeny();
    Console.WriteLine($"{i+1}. sütemény adatai:");
    Console.Write("\tNév:");
    aktualis.Nev = Console.ReadLine();
    Console.Write("\tEgységár (Ft): ");
    aktualis.Egysegar = int.Parse(Console.ReadLine());
    Console.Write("\tRaktáron (db): ");
    aktualis.RaktaronDb = int.Parse(Console.ReadLine());
    Console.WriteLine();
    sutik.Add(aktualis);
}
//4.1feladat
int osszes = 0;
int fullossz = 0;
Console.WriteLine("Pultban lévő sütemények:");
for (int i=0;i<sutik.Count;i++)
{
    osszes = sutik[i].Egysegar * sutik[i].RaktaronDb;
    fullossz += sutik[i].Egysegar * sutik[i].RaktaronDb;
    Console.WriteLine($"{sutik[i].Nev}: {sutik[i].Egysegar} FT / db {sutik[i].RaktaronDb} db)-> Összérték: {osszes} FT");
}
