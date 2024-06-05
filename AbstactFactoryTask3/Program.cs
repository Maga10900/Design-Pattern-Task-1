FurnitureFactory furnitureFactory = new ModernFurnitureFactory();
Client client = new Client(furnitureFactory);

Console.WriteLine(client.sofa.sitOn);

interface FurnitureFactory
{
    public Chair createChair();

    public CoffeTable createCoffeTable();

    public Sofa createSofa();
}

interface Chair
{
    public void hasLegs();
    public void sitOn();
}

interface CoffeTable
{

    public void hasLegs();
    public void putOn();
}

interface Sofa
{

    public void hasLegs();
    public void sitOn();
}


class ModernFurnitureFactory : FurnitureFactory
{
    public Chair createChair() => new ModernChair();

    public CoffeTable createCoffeTable() => new ModernCoffeTable();

    public Sofa createSofa() => new ModernSofa();


}
class VicFurnitureFactory : FurnitureFactory
{
    public Chair createChair() => new VicChair();

    public CoffeTable createCoffeTable() => new VicCoffeTable();

    public Sofa createSofa() => new VicSofa();
}


class ModernChair : Chair
{
    public void hasLegs()
    {
        Console.WriteLine("modernchair");

    }

    public void sitOn()
    {
        Console.WriteLine("modernchair");

    }
}
class VicChair : Chair
{
    public void hasLegs()
    {
        Console.WriteLine("vicchair");

    }

    public void sitOn()
    {
        Console.WriteLine("vicShair");

    }
}


class ModernSofa : Sofa
{
    public void hasLegs()
    {
        Console.WriteLine("modernsofa");
    }

    public void sitOn()
    {
        Console.WriteLine("modernsofa");
    }
}

class VicSofa : Sofa
{
    public void hasLegs()
    {
        Console.WriteLine("vicsofa");
    }

    public void sitOn()
    {
        Console.WriteLine("vicsofa");
    }
}

class ModernCoffeTable : CoffeTable
{
    public void hasLegs()
    {
        Console.WriteLine("moderncofetabel");
    }

    public void putOn()
    {
        Console.WriteLine("mmoderncofetabel");
    }
}
class VicCoffeTable : CoffeTable
{
    public void hasLegs()
    {
        Console.WriteLine("vicct");
    }

    public void putOn()
    {
        Console.WriteLine("vicct");
    }
}


class Client
{
    public readonly Chair chair = null;
    public readonly Sofa sofa = null;
    public readonly CoffeTable coffeTable = null;

    public Client(FurnitureFactory furniturefac)
    {
        chair = furniturefac.createChair();
        sofa = furniturefac.createSofa();
        coffeTable = furniturefac.createCoffeTable();
    }

}