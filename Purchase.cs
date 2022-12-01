public class Purchase
{
    //TODO: use it for buying an animal
    public Customer customer { get; private set; }
    public string[] AnimalData { get; private set; } //Not sure if its gonna stay like this!
    public int price { get; private set; }

    public Purchase(Customer customer, string[] AnimalData, int price)
    {
        this.customer = customer;
        this.AnimalData = AnimalData;
        this.price = price;
    }
}