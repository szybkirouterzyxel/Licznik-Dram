// super podstawowy program, na razie nie ma zapisu ani odzczytu
Console.WriteLine("Licznik Dram. Liczy dramy");
Console.WriteLine("Czy Drama dziś była? Y - Tak, N - Nie");


switch (Console.ReadLine()) {

        case "Y":
        Console.WriteLine("O! Drama!");
        break;

        case "N":
        Console.WriteLine("Nie Bylo Dramy");
        break;
 }

Console.WriteLine("Kliknij cos aby wylaczyc");
Console.ReadKey();
