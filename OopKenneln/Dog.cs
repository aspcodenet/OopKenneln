namespace OopKenneln;

public class Dog
{
    private readonly string _namn;
    private readonly string _breed;
    private readonly int _age;
    private readonly float _weight;

    public string Name
    {
        get { return _namn; }
    }

    public Dog(string namn, string breed, int age, float weight)
    {
        _namn = namn;
        _breed = breed;
        _age = age;
        _weight = weight;
    }

    public float GetTailLength()
    {
        if (_breed.ToLower() == "tax")
            return 3.7f;
        return _age * _weight / 10;
    }
}