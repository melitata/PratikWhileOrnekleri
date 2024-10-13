internal class Program
{
    private static void Main(string[] args)
    {


        //1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            i++;

        }
        //2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
        int a = 1;
        while (a < 20)
        {
            Console.WriteLine($"{a}");
            a++;
        }
        //3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

        int b = 0;
        while (b < 20)
        {
            Console.WriteLine($"{b}");
            b += 2;
        }
        //4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
        int toplam = 0;
        int sayi_ = 50;

        while (sayi_ <= 150)
        {
            toplam += sayi_;
            sayi_++;
        }
        Console.WriteLine("Toplam: " + toplam);


        //5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
        int sayi_2 = 1;
        int tekToplam = 0;
        int ciftToplam = 0;


        while (sayi_2 <= 120)
        {
            if (sayi_2 % 2 == 0) { ciftToplam += sayi_2; }
            else { tekToplam += sayi_2; }
            sayi_2++;
        }
        Console.WriteLine("Tek Sayıların Toplamı: " + tekToplam);
        Console.WriteLine("Çift Sayıların Toplamı: " + ciftToplam);

    }
            
    
}