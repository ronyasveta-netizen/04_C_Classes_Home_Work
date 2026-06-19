using _04_С__Classes_Home_Work;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1
        Console.WriteLine("Hello, World!");
        WebSite site1 = new WebSite("MyStat", "https://mystat.itstep.org/main", "Study", "192.168.0.6");
        site1.Print();

        Console.WriteLine();
        Console.WriteLine(site1);
        Console.WriteLine();

        /*WebSite site2 = new WebSite();
        site2.Input();
        Console.WriteLine(site2);*/
        //Console.WriteLine();

        // 2

        Journal journal1 = new Journal("Youth Technology", 1985, "+38 050 5234 567", "not yet", "Popularization of science for young people");
        journal1.Print();

        Console.WriteLine();
        Console.WriteLine(journal1);
        Console.WriteLine();

        //Journal journal2 = new Journal();
        //journal2.Input();
        //Console.WriteLine(journal2);
        //Console.WriteLine();

        // 3
        Store store1 = new Store("Seleschanskiy", "Produkt", "Novoselica, Golovna 122 ",  "+38 050 5234 567", "selesche@.gmail.com");
        store1.Print();

        Console.WriteLine();
        Console.WriteLine(store1);
        Console.WriteLine();

        /*Store store2 = new Store();
        store2.Input();
        Console.WriteLine(store2);
        Console.WriteLine();*/


        // 4 рузурвуар
        Rezervuar rezervuar1 = new Rezervuar();
        Console.WriteLine(rezervuar1);
        Console.WriteLine();
        rezervuar1.Print();
        Console.WriteLine();

        Rezervuar rezervuar2 = new Rezervuar(20, "Aluminium", false);
        rezervuar2.Fill(26.25);
        Console.WriteLine(rezervuar2);
        Console.WriteLine();

    }
}