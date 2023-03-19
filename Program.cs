internal class Program
{
    private static void Main(string[] args)
    {
        // atama ve işlemli atama

        int x = 3;
        int y = 3;
        y = y + 3;  // Aynı zaman da y += 3    (y = y - 3 == y -= 3),(y = y * 3 == y *= 3), 
        Console.WriteLine(y);

        y = y / 3;  // Aynı zaman da y /= 3
        Console.WriteLine(y);

        // Mantıksal Operatörler
        // ||(veya) , &&(ve) , !(değil)

        bool isSuccess = true;
        bool isCompleted = false;

        if(isSuccess && isCompleted)         // isSuccess ve isCompleted 1 ise Ekranda "Perfect" yazdır.
            Console.WriteLine("Perfect");

        if(isSuccess || isCompleted)        // İsSuccess veya isCompleted 1 ise Ekranda "Great" yazdır.
            Console.WriteLine("Great");

        if(isSuccess && !isCompleted)       // İsSucces 1 ve İsCompleted' ın değili(çünkü ! var) 1 ise "Fine" yazdır.
            Console.WriteLine("Fine");

        // İlişkisel Operatörler
        // <(küçük) , >(büyük) , <=(küçük eşit) , >=(büyük eşit) , ==(eşit eşit), !=(eşit değil)

        int sayi1 = 3;
        int sayi2 = 5;
        if(sayi1 <= sayi2)
            Console.WriteLine(+ sayi1 + " "+"sayısı" + " " + sayi2 + " "+ "sayisindan küçük eşittir.");

        int a = 4;                   // a sayısı b sayısında küçük ise True yazdır değilse false yazdır.
        int b = 5;
        bool sonuc = a < b;
        Console.WriteLine(sonuc);

        int sayi3 = 10;             // sayi3 sayi4 den büyük ise true yazdır değilse false yazdır.
        int sayi4 = 8;
        sonuc = sayi3 > sayi4;
        Console.WriteLine(sonuc);

        int sayi5 = 10;             // sayi5 sayi6 dan büyük veya eşit ise true yazdır değilse false yazdır.
        int sayi6 = 10;
        sonuc = sayi5 >= sayi6;
        Console.WriteLine(sonuc);

        int sayi7 = 10;             // sayi7 ve sayi8 birbirine eşit sadece eşitlik 
        int sayi8 = 10;
        sonuc = sayi7 == sayi8;
        Console.WriteLine(sonuc);

        int sayi9 = 5;              // sayi9 ve sayi10 birbirine eşit değil 
        int sayi10 = 2;
        sonuc = sayi9 != sayi10;
        Console.WriteLine(sonuc);

        // Aritmetik Operatörler
        // /(bölüm) , *(çarpım) , +(toplama) , -(çıkarma) , %(mod alma)

        int sayii = 10;
        int sayii1 = 5;
        int sonuc1 = sayii + sayii1;
        Console.WriteLine(+ sayii + " " + "sayısı ile" + " " + sayii1 + " " + "sayısının toplamı" + " " + sonuc1);

        int sonuc2 = sayii * sayii1;
        Console.WriteLine(+ sayii + " " + "sayısı ile" + " " + sayii1 + " " + "sayısının çarpımı" + " " + sonuc2);

        int sonuc3 = sayii / sayii1;
        Console.WriteLine(+ sayii + " " + "sayısı ile" + " " + sayii1 + " " + "sayısının bölümü" + " " + sonuc3);

        int sonuc4 = sayii - sayii1;
        Console.WriteLine(+ sayii + " " + "sayısı ile" + " " + sayii1 + " " + "sayısının cıkartma işlemi" + " " + sonuc4);

        int sonuc5 = sayii % sayii1;
        Console.WriteLine(+ sayii + " " + "sayısı ile" + " " + sayii1 + " " + "sayısının arasındaki mod" + " " + sonuc5);

    





    }
}