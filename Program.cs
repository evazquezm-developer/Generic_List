public class Program
{
    public static void Main()
    {
        // Create a list of integers.
        MyCustomList<int> intList = new MyCustomList<int>();

        intList.Add(1);
        intList.Add(2);

        Console.WriteLine("Integer list:");

        for (int inx = 0; inx < intList.Count; inx++)
        {
            Console.WriteLine(intList.Get(inx));
        }

        // Create a list of strings.
        MyCustomList<string> stringList = new MyCustomList<string>();

        stringList.Add("C#");
        stringList.Add(".Net");

        Console.WriteLine("String list:");

        for (int inx = 0; inx < stringList.Count; inx++)
        {
            Console.WriteLine(stringList.Get(inx));
        }
    }
}