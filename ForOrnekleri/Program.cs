// Burada konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırdım.

for (int i=0; i<10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

// Burada 1 ile 20 arasındaki sayıları konsol ekranına yazdırdım.

for (int i=1; i<=20; ++i)
{
    Console.WriteLine(i);
}
Console.WriteLine(); // Konsolda boş bir satır oluşturur.

//Burada 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırdım.

for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine();

// Burada 50 ile 150 arasındaki sayıları topladım.

int toplam = 0; // Toplamı ilk 0 olarak tanımladım
for (int i = 50; i <= 150; i++)
{ 
    toplam += i; 
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);
Console.WriteLine();

// Son olarak 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırdım.

int tekliSayılarınToplamı = 0;// Tekli ve çiftli sayıların toplamlarını 0 olarak tanımladım
int çiftSayılarınToplamı = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        çiftSayılarınToplamı += i;
    }
    else
    {
        tekliSayılarınToplamı += i;
    }
}

Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekliSayılarınToplamı);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + çiftSayılarınToplamı);