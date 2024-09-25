public static class Theards
{
    public static bool StopLowercase { get; set; }

    public static void CountNumbers()
    {
        for (int i = 1; i <= 20; ++i)
        {
            if (i >= 10)
            {
                Console.WriteLine("# Number: " + i + "   - Thread Name: " + Thread.CurrentThread.Name +
                                  "    - Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            }
            else
            {
                Console.WriteLine("# Number: " + i + "    - Thread Name: " + Thread.CurrentThread.Name +
                                  "    - Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            }

            Thread.Sleep(300);
        }

        StopLowercase = true;
        Console.WriteLine("Lowercase thread stopped!, the number thread ends the execution");
    }

    public static void CountLowercase()
    {
        for (char lower = 'a'; lower <= 'z'; ++lower)
        {
            if (StopLowercase) break;
            Console.WriteLine("$ Lowercase: " + lower + " - Thread Name: " + Thread.CurrentThread.Name +
                              " - Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            if (lower >= 'z' && !StopLowercase)
            {
                lower = 'a';
            }
        }

        Console.WriteLine("Lowercase thread ends the execution");
    }

    public static void CountUppercase()
    {
        for (char upper = 'A'; upper <= 'Z'; ++upper)
        {
            Console.WriteLine("% Uppercase: " + upper + " - Thread Name: " + Thread.CurrentThread.Name +
                              " - Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(400);
        }

        Console.WriteLine("Uppercase thread ends the execution");
    }
}