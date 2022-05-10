using System;

namespace Switch_Case
{

    class Program 
    {
        public static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is January.");
                    Console.WriteLine("************************************");
                    break;

                case 2:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is February.");
                    Console.WriteLine("************************************");
                    break;

                case 3:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is March.");
                    Console.WriteLine("************************************");
                    break;
                
                case 4:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is April.");
                    Console.WriteLine("************************************");
                    break;
                
                case 5:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is May.");
                    Console.WriteLine("************************************");
                    break;

                case 6:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is June.");
                    Console.WriteLine("************************************");
                    break;
                
                case 7:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is July");
                    Console.WriteLine("************************************");
                    break;
                
                case 8:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is August");
                    Console.WriteLine("************************************");
                    break;

                case 9:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is September");
                    Console.WriteLine("************************************");
                    break;
                case 10:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is October");
                    Console.WriteLine("************************************");
                    break;

                case 11:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is November");
                    Console.WriteLine("************************************");
                    break;

                case 12:
                    Console.WriteLine("************************************");
                    Console.WriteLine("It is December");
                    Console.WriteLine("************************************");
                    break;

                default:
                    Console.WriteLine("************************************");
                    Console.WriteLine("You're lost in timelessness boss.");
                    Console.WriteLine("************************************");
                    break;

                
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("************************************");
                    Console.WriteLine("Cold weather. Winter has arrived.");
                    Console.WriteLine("************************************");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("************************************");
                    Console.WriteLine("I see crystal raindrops fall. Must be Spring");
                    Console.WriteLine("************************************");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("************************************");
                    Console.WriteLine("Ah. look at that beach. Summer is here.");
                    Console.WriteLine("************************************");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("************************************");
                    Console.WriteLine("Honey, where is my jacket? This Fall weather is no joke.");
                    Console.WriteLine("************************************");
                    break;

                default:
                    Console.WriteLine("You got lost in time again boss.");
                    break;
            }
        }
        
    }
}