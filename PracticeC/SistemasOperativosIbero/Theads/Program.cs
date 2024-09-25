class Program
{
    static void Main()
    {
        Thread numberThread = new Thread(Theards.CountNumbers);
        numberThread.Name = "Number Thread";
        Thread lowercaseThread = new Thread(Theards.CountLowercase);
        lowercaseThread.Name = "Lowercase Thread";
        Thread uppercaseThread = new Thread(Theards.CountUppercase);
        uppercaseThread.Name = "Uppercase Thread";

        numberThread.Start();
        lowercaseThread.Start();
        uppercaseThread.Start();

        numberThread.Join();
        lowercaseThread.Join();
        uppercaseThread.Join();

        Console.WriteLine("All threads have finished their execution");

        Console.ReadKey();
    }
}