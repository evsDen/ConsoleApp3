using ConsoleApp3;

internal class Program
{
    private static void Main(string[] args)
    {
        plants Plant = new plants("Свекла", 3, "Морковь", 6, "Горох", 8);
       
        
       

        Pole pole = new  Pole(Plant.Semena(), Plant.Name());
        pole.Zasev();
        pole.AllPole();
    
        pole.Sbor();
        pole.AllPole();

        Gryadka gryadka = new Gryadka(Plant.Semena(), Plant.Name());
        gryadka.Zasev(0);
       

        gryadka.Sbor(0);
       
        

        Console.ReadKey();
    }
}