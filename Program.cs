 namespace nana
{
    class Program 
  {
        static void Main(string[] args) 
    { 
        Console.WriteLine("Please input password");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input agency");
        string name = Console.ReadLine();
        


         if (number >= 100000 && number < 1000000 ){
            int digit6 = number/100000;
            number = number - (digit6 * 100000);

            int digit5 = number/10000;
            number = number - (digit5 * 10000);

            int digit4 = number/1000;
            number = number - (digit4 * 1000);

            int digit3 = number/100;
            number = number - (digit3 * 100);

            int digit2 = number/10;
            number = number - (digit2 * 10);

            int digit1 = number/1;
            number = number - (digit5 * 1);

            switch (name) {
                case "CIA":
                    if (digit1 % 3 == 0 && digit2 != 1 && digit2 != 3 && digit2 != 5 && digit4 >= 6 && digit4 != 8) {
                    Console.WriteLine("True");
                    }     
                    else {
                        Console.WriteLine("False");
                    }              
                    break;
               case "FBI":
                    if (digit6 >=4 && digit6 <=7 && digit3 % 2 == 0 && digit3 != 6 && digit5 % 2 == 1) {
                    Console.WriteLine("True");
                    }
                    else {
                        Console.WriteLine("False");
                    }
                    break;
                case "NSA":
                    if (30 % digit1 == 0 && digit3 % 3 == 0 && digit3 % 2 != 0
                    && (digit1 == 7 || digit2 == 7 || digit3 == 7 || digit4 == 7 || digit5 == 7 || digit6 == 7)) {
                    Console.WriteLine("True");
                    
                    }
                    else {
                        Console.WriteLine("False");
                    }
                    break; 
                default:
                    Console.WriteLine("False");
                    break;
            }
         } else {
            Console.WriteLine("False");
         }
    }
  }
}




