using System;
using Task8.AbstractClasses;
using Task8.Classes;
using Task8.Interfaces;
using Task8.ShapeSeries;
using Task8.Structs;

class Program
{
    static void Main()
    {
        TestVehicles();
        TestShapes();
        TestProductSorting();
        TestDeepCopy();
        TestExplicitInterface();
        TestStructEncapsulation();
        TestDefaultInterface();
        TestConstructorOverloading();
        TestShapeSeries();
        TestShapeSorting();
        TestGeometricShapes();
    }

    static void TestVehicles()
    {
        Console.WriteLine("=== Vehicle System Test ===");
        IVehicle car = new Car();
        IVehicle bike = new Bike();
        car.StartEngine();
        bike.StopEngine();
    }

    static void TestShapes()
    {
        Console.WriteLine("\n=== Shape Hierarchy Test ===");
        Shape rectangle = new Rectangle(4, 5);
        Shape circle = new Circle(3);
        rectangle.Display();
        circle.Display();
    }

    static void TestProductSorting()
    {
        Console.WriteLine("\n=== Product Sorting Test ===");
        Product[] products = {
            new Product(1, "Keyboard", 45),
            new Product(2, "Monitor", 199)
        };
        Array.Sort(products);
        foreach (var p in products)
            Console.WriteLine($"{p.Name} (${p.Price})");
    }

    static void TestDeepCopy()
    {
        Console.WriteLine("\n=== Deep Copy Test ===");
        var original = new Student(1, "Alice", "A");
        var copy = new Student(original);
        Console.WriteLine($"Original: {original.Name}, Copy: {copy.Name}");
    }

    static void TestExplicitInterface()
    {
        Console.WriteLine("\n=== Explicit Interface Test ===");
        var robot = new Robot();
        ((IWalkable)robot).Walk();
    }

    static void TestStructEncapsulation()
    {
        Console.WriteLine("\n=== Struct Test ===");
        var account = new Account(101, "John", 2500m);
        Console.WriteLine($"{account.AccountHolder}'s balance: {account.Balance}");
    }

    static void TestDefaultInterface()
    {
        Console.WriteLine("\n=== Default Interface Test ===");
        ILogger logger = new ConsoleLogger();
        logger.Log();
    }

    static void TestConstructorOverloading()
    {
        Console.WriteLine("\n=== Constructor Test ===");
        var book1 = new Book();
        var book2 = new Book("C# Programming");
        var book3 = new Book("Clean Code", "Robert Martin");
        Console.WriteLine($"Book3: {book3.Title} by {book3.Author}");
    }

    static void TestShapeSeries()
    {
        Console.WriteLine("\n=== Shape Series Test ===");
        Console.WriteLine("Squares:");
        PrintTenShapes(new SquareSeries());
        Console.WriteLine("Circles:");
        PrintTenShapes(new CircleSeries());
    }

    static void TestShapeSorting()
    {
        Console.WriteLine("\n=== Shape Sorting Test ===");
        SortableShape[] shapes = {
            new SortableShape("Square", 25),
            new SortableShape("Circle", Math.PI * 9)
        };
        Array.Sort(shapes);
        foreach (var s in shapes)
            Console.WriteLine($"{s.Name}: {s.Area:N2}");
    }

    static void TestGeometricShapes()
    {
        Console.WriteLine("\n=== Geometric Shapes Test ===");
        var triangle = new Triangle(3, 4);
        var rectangle = new RectangleShape(4, 5);
        Console.WriteLine($"Triangle area: {triangle.CalculateArea()}");
        Console.WriteLine($"Rectangle perimeter: {rectangle.Perimeter}");
    }

    static void PrintTenShapes(IShapeSeries series)
    {
        series.ResetSeries();
        for (int i = 0; i < 10; i++)
        {
            series.GetNextArea();
            Console.Write($"{series.CurrentShapeArea} ");
        }
        Console.WriteLine();
    }
}

internal class RectangleShape
{
    private int v1;
    private int v2;

    public RectangleShape(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public object Perimeter { get; internal set; }
}

internal class Triangle
{
    private int v1;
    private int v2;

    public Triangle(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    internal object CalculateArea()
    {
        throw new NotImplementedException();
    }
}