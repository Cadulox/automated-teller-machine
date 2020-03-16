using System;
using System.Globalization;
using AutomatedTellerMachine.Entities;

namespace AutomatedTellerMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Vault vault = new Vault();

            Console.WriteLine("              CADULOX BANK");
            Console.WriteLine("----------------------------------------");          
                        
            while (true)
            {
                Console.WriteLine("OPTIONS: ");
                Console.WriteLine("1 - Add Notes");
                Console.WriteLine("2 - Remove Notes");
                Console.WriteLine("3 - Consult Amount of Notes");
                Console.WriteLine("4 - Consult Total Value");
                Console.WriteLine("0 - Exit");
                Console.WriteLine();
                Console.Write("Chosse your option: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine();
                        Console.Write("Enter the value of the notes: ");
                        decimal value = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Enter the amount: ");
                        int amount = int.Parse(Console.ReadLine());
                        vault.AddDrawer(new Drawer(value, amount));
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        break;
                    case 3:
                        Console.WriteLine();
                        vault.NumberNotes();
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Total value: $ " + vault.VaultValue().ToString("F2", CultureInfo.InvariantCulture));
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid Option!");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadKey();                        
                        Console.Clear();
                        break;
                }
                if (option == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Bye Bye!!");
                    break;
                }
            }            
        }
    }
}
