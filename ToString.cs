public class Example
{
    public static void Main()
    {
        Person person = new Person { Name = "John", Age = 12 };
        Console.WriteLine(person);
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return "Person: " + Name + " " + Age;
    }
}

// Output:
// Person: John 12

Example 2

int x = 42;
string strx = x.ToString();
Console.WriteLine(strx);
// Output:
// 42

Example 3
Convert.ToString(var) handles null exception
var.Tostring() doesnt handle null exception
