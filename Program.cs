Random rnd = new();
int[] sorozat = { 3, 2, 5, 4, 1 };

//BuborekRendezes();
//CseresRendezes();
//Veletlen();

//feladatlap f1
//Dolg01();
//Dolg02();
Dolg03();

void Dolg03()
{
    int pont = 0;
    for (int i = 0; i < 8; i++)
    {
        int x = rnd.Next(10, 100);
        int y = rnd.Next(10, 100);
        if (rnd.Next(2) == 0) x *= -1;
        if (rnd.Next(2) == 0) y *= -1;

        Console.Write($"{i+1}.) {x} + {y} = ");
        int pred = int.Parse(Console.ReadLine());

        if (pred == x + y) pont++;
    }
    Console.WriteLine($"az esetek {pont/8f*100:0.00}%-ában adtál helyes választ!");
}

void Dolg02()
{
    Console.Write("maximálisan megengedett sebesség (kmph): ");
    int limit = int.Parse(Console.ReadLine());

    if (limit <= 0 || limit > 50)
    {
        Console.WriteLine("Ez a program csak 50 kmph sebességkorlátig tudja meghatározni a bírságot :(");
    }
    else
    {
        Console.Write("tényleges sebesség (kmph): ");
        int aktSeb = int.Parse(Console.ReadLine());
        if (aktSeb <= limit)
        {
            Console.WriteLine("nem lépted túl a sebességkorlátozást, nincs büntetés");
        }
        else
        {
            int tullepes = aktSeb - limit;
            if (tullepes <= 15)
            {
                Console.WriteLine("a túlléps tűréshatáron belül van, nincs büntetés, de legyél óvatosabb!");
            }
            else
            {
                int birsag = 0;
                if      (tullepes < 25) birsag =  30000;
                else if (tullepes < 35) birsag =  45000;
                else if (tullepes < 45) birsag =  60000;
                else if (tullepes < 55) birsag =  90000;
                else if (tullepes < 65) birsag = 130000;
                else if (tullepes < 75) birsag = 200000;
                else                    birsag = 300000;

                Console.WriteLine(
                    $"a megengedett sebességet {tullepes} kmphval haladtad meg," +
                    $"a bünetés: {birsag} Ft");
            }
        }
    }
}
void Dolg01()
{
    Console.Write("karakterlánc: ");
    string karakterlanc = Console.ReadLine();
    int randomSzam = rnd.Next(10);
    Console.WriteLine($"a generált szám: {randomSzam}");
    for (int i = 0; i < randomSzam; i++)
    {
        Console.Write(karakterlanc);
        if (randomSzam % 2 == 0) Console.Write(" ");
        else Console.Write("\n");
    }
}
void Veletlen()
{
    // egész szám [0, Int.MaxValue)
    int r1 = rnd.Next();
    Console.WriteLine($"r1 = {r1}");
    // egész szám [0, maxValue)
    int r2 = rnd.Next(maxValue: 100);
    Console.WriteLine($"r2 = {r2}");
    //egész szám [minValue, maxValue)
    int r3 = rnd.Next(minValue: -30, maxValue: 60);
    Console.WriteLine($"r3 = {r3}");

    //--------------------

    //[0, 1) -> 64bites lebegőpontos szám
    double r4 = rnd.NextDouble();
    Console.WriteLine($"r4 = {r4}");

    //--------------------

    //[15, 25] szám, pontosa 1db tizedesjegy pontossággal:
    float r5 = rnd.Next(1500, 2501) / 100f;
    Console.WriteLine($"r5 = {r5}");
}

void BuborekRendezes()
{
    for (int i = sorozat.Length - 1; i >= 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (sorozat[j] > sorozat[j + 1])
            {
                int seged = sorozat[j];
                sorozat[j] = sorozat[j + 1];
                sorozat[j + 1] = seged;
            }
        }
    }
    foreach (var e in sorozat) Console.Write($"{e} ");
}

void CseresRendezes()
{
    for (int i = 0; i < sorozat.Length - 1; i++)
    {
        for (int j = i + 1; j < sorozat.Length; j++)
        {
            if (sorozat[i] > sorozat[j])
            {
                int seged = sorozat[i];
                sorozat[i] = sorozat[j];
                sorozat[j] = seged;
            }
        }
    }
    foreach (var e in sorozat) Console.Write($"{e} ");
}



