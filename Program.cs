internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is the master branch");
        Console.WriteLine("This was added for develop");
        Flow flow = new Flow();
        flow.Name = "Ben";
        Console.Write("Enter if gender is m or f: ");
        char keyChar = Console.ReadKey().KeyChar;
        flow.Gender = keyChar == 'm';
    }
}

class Flow
{
    public string name;
    public bool gender;

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
    //added for feature-testforlocal
    public bool Gender
    {
        get { return gender; }
        set 
        {
            gender = value;
            Console.WriteLine(gender);
        }
    }
}