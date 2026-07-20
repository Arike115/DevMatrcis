using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        LastProcess();
        Firstprocess();
        Console.ReadKey();
    }

    //synchronous method
    static void Firstprocess()
    {
        Console.WriteLine("welcome to the first process world");
        Console.WriteLine("First process starting now .........");
        Console.WriteLine("First process completed");
    }

    //asynchronous method
    static async Task LastProcess()
    {
        Console.WriteLine("welcome to the last process world");
        await Task.Delay(3000);
        Console.WriteLine("last process starting now .........");
        Console.WriteLine("last process completed");
        await DataReturnProcess();
    }

    static async Task<bool> DataReturnProcess()
    {
        return true;
    }
    static bool DataProcess()
    {
        return true;
    }
    static async Task LongDataReturnProcess()
    {

    }

}