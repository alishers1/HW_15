// Принцип инкапсуляции:
/*Инкапсуляция в языке C# означает объединение данных (полей) и методов (или других членов класса) внутри объекта, 
а также управление доступом к этим данным и методам. Главной целью инкапсуляции является скрытие внутренней реализации
объекта от внешнего кода, что обеспечивает безопасность и упрощает обслуживание кода.*/
// Здесь мы создадим класс, инкапсулирующий информацию о человеке.
class Person
{
    private string _name;
    private int _age;

    public Person(string name, int age)
    {
        this._name = name;
        this._age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {_name}, Возраст: {_age}");
    }
}

// Принцип наследования:
// Наследование позволяет создавать новые классы на основе существующих классов и переиспользовать их функциональность.
// В этом примере у нас есть базовый класс Vehicle и производный класс Car.
class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}

// Принцип полиморфизма:
// Полиморфизм позволяет объектам разных классов использовать одинаковые методы, что делает код более гибким.
// Здесь мы создадим интерфейс и два класса, реализующих этот интерфейс.
interface IShape
{
    double CalculateArea();
}

class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

// Принцип абстракции:
// Абстракция позволяет скрыть сложные детали реализации и предоставить только необходимую информацию.
// Здесь создадим абстрактный класс Animal и производные классы, представляющие конкретных животных.
abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Собака лает.");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Кот мяукает.");
    }
}
