namespace FirstTry{
    class Program{
        
        // Variable to stop the lowercase thread
        static bool _stopLowercase;
        
        static void Main(){
            
            // Se puede utilizar la variable 'var'
            Thread numberThread = new Thread(CountNumbers);
            numberThread.Name = "Number Thread";
            Thread lowercaseThread = new Thread(CountLowercase);
            lowercaseThread.Name = "Lowercase Thread";
            Thread uppercaseThread = new Thread(CountUppercase);
            uppercaseThread.Name = "Uppercase Thread";

            numberThread.Start();
            lowercaseThread.Start();
            uppercaseThread.Start();
            
            // Esperar a que los hilos terminen su ejecución, uno hilos esperan a otros, recordar
            numberThread.Join();
            lowercaseThread.Join();
            uppercaseThread.Join();
            
            Console.WriteLine("All threads have finished their execution");
        }

        static void CountNumbers(){
            for (int i = 1; i <= 20; ++i){
                if (i >= 10) {
                    Console.WriteLine("# Number: " + i + "   - Thread Name: " + Thread.CurrentThread.Name + "    - Thread ID: " + Thread.CurrentThread.ManagedThreadId);
                }else {
                    Console.WriteLine("# Number: " + i + "    - Thread Name: " + Thread.CurrentThread.Name + "    - Thread ID: " + Thread.CurrentThread.ManagedThreadId);
                }
                Thread.Sleep(500); // 500ms delay
            }
            // Signal to stop the lowercase thread
            _stopLowercase = true;
            Console.WriteLine("Lowercase thread stopped!, the number thread ends the execution");
        }

        static void CountLowercase(){
            for (char lower = 'a'; lower <= 'z'; ++lower){
                if (_stopLowercase) break;
                Console.WriteLine("$ Lowercase: " + lower + " - Thread Name: " + Thread.CurrentThread.Name + " - Thread ID: " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1200); // 300ms delay
            }
        }

        static void CountUppercase(){
            for (char upper = 'A'; upper <= 'Z'; ++upper){
                Console.WriteLine("% Uppercase: " + upper + " - Thread Name: " + Thread.CurrentThread.Name + " - Thread ID: " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(700); // 700ms delay
            }
        }
    }
}