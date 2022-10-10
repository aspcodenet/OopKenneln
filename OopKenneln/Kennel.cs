namespace OopKenneln;

public class Kennel
{
    private List<Dog> dogs = new List<Dog>();

    public void AddDog(Dog dog)
    {
        dogs.Add(dog);
    }

    public bool Remove(string name)
    {
        Dog dog = null;
        foreach(var d in dogs)
            if (d.Name == name)
            {
                dog = d;
                break;
            }

        if (dog == null) return false;
        dogs.Remove(dog);
        return true;
    }


    public List<Dog> GetDogs(float minTailLength)
    {
        var result = new List<Dog>();
        foreach(var dog in dogs)
            if (dog.GetTailLength() > minTailLength)
                result.Add(dog);
        return result;
    }


    public Kennel()
    {
        
    }
}