namespace FirstTry{
    
    class Program{
        
        static bool _stopLowercase;
        
        static void Main(){
            
            Thread numberThread = new Thread(CountNumbers);
            numberThread.Name = "Number Thread";
            Thread lowercaseThread = new Thread(CountLowercase);
            lowercaseThread.Name = "Lowercase Thread";
            Thread uppercaseThread = new Thread(CountUppercase);
            uppercaseThread.Name = "Uppercase Thread";

            numberThread.Start();
            lowercaseThread.Start();
            uppercaseThread.Start();
            
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
                Thread.Sleep(500); 
            }
           
            _stopLowercase = true;
            Console.WriteLine("Lowercase thread stopped!, the number thread ends the execution");
        }

        static void CountLowercase(){
            for (char lower = 'a'; lower <= 'z'; ++lower){
                if (_stopLowercase) break;
                Console.WriteLine("$ Lowercase: " + lower + " - Thread Name: " + Thread.CurrentThread.Name + " - Thread ID: " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1200);
                if(lower >= 'z' && !_stopLowercase){
                    lower = 'a';
                }
            }
        }

        static void CountUppercase(){
            for (char upper = 'A'; upper <= 'Z'; ++upper){
                Console.WriteLine("% Uppercase: " + upper + " - Thread Name: " + Thread.CurrentThread.Name + " - Thread ID: " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(700); 
            }
        }
    }
}