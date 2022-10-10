using System.ComponentModel;

namespace OopKenneln;

public class UI
{
    private readonly Kennel _kennel;

    public UI(Kennel kennel)
    {
        _kennel = kennel;
    }
    public void Run()
    {
        while (true)
        {
            var sel = ShowMenu();
            if (sel == 4) break;
            else if (sel == 1) Registrera();
            else if (sel == 2) Lista();
            else if (sel == 3) Remove();
        }
    }

    private void Remove()
    {
        var allDogs = _kennel.GetDogs(0.0f);

        int index = 1;
        foreach (var dog in allDogs)
        {
            Console.WriteLine($"{index} {dog.Name}");
            index++;
        }
        Console.WriteLine("Ange vilken hund du vill ta bort:");
        index = Convert.ToInt32(Console.ReadLine()) - 1;
        if (_kennel.Remove(allDogs[index].Name) == false)
            Console.WriteLine("Finns ingen sån hund");
    }

    private void Lista()
    {
        Console.Write("Ange minsta svanslängd:");
        var taillength = Convert.ToSingle(Console.ReadLine());
        foreach (var dog in _kennel.GetDogs(taillength))
        {
            Console.WriteLine($"{dog.Name}");            
        }
    }

    private void Registrera()
    {
        Console.Write("Ange namn:");
        var namn = Console.ReadLine();
        Console.Write("Ange ras:");
        var breed = Console.ReadLine();
        Console.Write("Ange ålder:");
        var age = Convert.ToInt32(Console.ReadLine());
        if(breed.ToLower() != "tax")
            Console.Write("Ange svanslängd:");
        var taillength = Convert.ToSingle(Console.ReadLine());

        var dog = new Dog(namn, breed, age, taillength);
        _kennel.AddDog(dog);
    }

    private int ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Registrera ny hund");
            Console.WriteLine("2. Lista");
            Console.WriteLine("3. Ta bort");
            Console.WriteLine("4. avsluta");

            Console.Write("Val:");
            var sel = Convert.ToInt32(Console.ReadLine());
            if (sel >= 0 && sel <= 4) return sel;
            Console.WriteLine("Ange ett tal mellan 1 och 4 tack");
        }
    }
}