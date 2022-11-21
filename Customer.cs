 public class Customer
{
    public string Name{get;set;}
    public int Money{get;private set;}
    public List<Animal> pets;

    public Customer(string name, int money)
    {
        this.Name=name;
        this.Money=money;
        pets= new List<Animal>();
    }
}