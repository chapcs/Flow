internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is the master branch");
        Console.WriteLine("This was added for develop");
        Flow flow = new Flow();
        flow.Name = "Ben";
    }
}

class Flow
{
    public string name;

    public Flow()
    {
        Console.WriteLine("This was added with the feature branch");
    }

    public string Name {
        get { return name; }
        set
        {
            name = value.ToString();
            Console.WriteLine(name);
        }
    }
}