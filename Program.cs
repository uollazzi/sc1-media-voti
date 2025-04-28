List<double> voti = [];

Console.Write("Quanti voti vuoi inserire? ");
int numeroVoti = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numeroVoti; i++)
{
    while (true)
    {
        Console.Write("Inserisci un voto (0-10): ");
        double voto = -1;
        var strVoto = Console.ReadLine();
        if (strVoto != "")
        {
            voto = Convert.ToDouble(strVoto);
        }

        if (voto >= 0 && voto <= 10)
        {
            voti.Add(voto);
            break;
        }
        Console.WriteLine("Voto inserito non corretto.");
    }
}

double sommaVoti = 0;

foreach (var voto in voti)
{
    sommaVoti += voto;
}

double media = sommaVoti / numeroVoti;

Console.WriteLine("--- RISULTATI ---");
Console.WriteLine($"Voti inseriti: [{string.Join(" ", voti)}]");
Console.WriteLine($"Somma voti: {sommaVoti}");
Console.WriteLine($"Media voti: {media}");

string promossoBocciato = media >= 6 ? "Promosso" : "Bocciato";
Console.WriteLine($"Risultato: {promossoBocciato}");

double votoMax = 0;
double votoMin = 10;
int votiSopraMedia = 0;
int votiSottoMedia = 0;
int votiInsuff = 0;

foreach (var voto in voti)
{
    if (voto > votoMax)
    {
        votoMax = voto;
    }

    if (voto < votoMin)
    {
        votoMin = voto;
    }

    if (voto >= media)
    {
        votiSopraMedia++;
    }

    if (voto < media)
    {
        votiSottoMedia++;
    }

    if (voto < 6)
    {
        votiInsuff++;
    }
}

Console.WriteLine($"Voto Massimo: {votoMax}");
Console.WriteLine($"Voto Minimo: {votoMin}");
Console.WriteLine($"Voti sopra la media: {votiSopraMedia}");
Console.WriteLine($"Voti sotto la media: {votiSottoMedia}");
Console.WriteLine($"Voti insufficienti: {votiInsuff}");