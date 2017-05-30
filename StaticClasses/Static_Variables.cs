using System;

class Cow
{
    static int numInstances;
    int id;
    public Cow()
    {
        id = ++numInstances;
    }
}
class MainClass
{
    static void Main()
    {
        Cow betsy = new Cow();
        Cow georgy = new Cow();
    }
}
