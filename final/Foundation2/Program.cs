using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("542 5th street", "Philidelphia", "PN", "USA");
        Customer Customer1 = new Customer("James Madison", address1);
        Order order1 = new Order(Customer1, address1);
        order1.AddProductToList("teacups", "TC1253", 4, 3.55);
        order1.AddProductToList("plates", "PL3477", 4, 2.35);
        order1.AddProductToList("sugar", "SG0011", 1, 1.54);
        order1.AddProductToList("pencil", "PN2341", 12, 0.20);
        string packinglabel1 = order1.CreatePackingLabel();
        string shippingLabel1 = order1.CreateShippingLabel();
        Console.Write(packinglabel1);
        Console.WriteLine();
        Console.Write(shippingLabel1);


        Address address2 = new Address("6972 Bleak street", "Harrisburg", "PN", "US");
        Customer customer2 = new Customer("Micheal P. Jackson", address2);
        Order order2 = new Order(customer2, address2);
        order2.AddProductToList("Baseball", "FB2398", 1, 10.15);
        order2.AddProductToList("Ballcap", "BC9987", 3, 6.25);
        order2.AddProductToList("Baseball Glove", "BG2525", 4, 23.45);
        order2.AddProductToList("Baseball Bat", "BB9671", 2, 15.01);
        string packinglabel2 = order2.CreatePackingLabel();
        string shippingLabel2 = order2.CreateShippingLabel();
        Console.Write(packinglabel2);
        Console.WriteLine();
        Console.Write(shippingLabel2);
    }
}