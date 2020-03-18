using System;
using System.Collections.Generic;
using System.Globalization;

namespace AutomatedTellerMachine.Entities
{
    class Vault
    {
        public List<Drawer> Drawers { get; set; } = new List<Drawer>();

        public Vault()
        {
        }

        public void AddDrawer(Drawer drawer)
        {
            Drawers.Add(drawer);
        }

        public void RemoveDrawer(Drawer drawer)
        {
            Drawers.Remove(drawer);
        }

        public void RemoveNotes(decimal value, int amount)
        {
            foreach (Drawer item in Drawers)
            {
                if (value == item.DrawerNote && amount <= item.Amount())
                {
                    for (int i = 0; i < amount; i++)
                    {
                        item.RemoveNotes();
                    }
                }
                else if (value == item.DrawerNote && amount > item.Amount()) {
                    Console.WriteLine();
                    Console.WriteLine("The value is higher than the drawer!");
                }
            }
        }
        public void NumberNotes()
        {
            int sum = 0;
            foreach (Drawer item in Drawers)
            {
                sum += item.Amount();
                Console.WriteLine(item.Amount() + " notes of $ " + item.DrawerNote.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            Console.WriteLine("Total of notes: " + sum);
        }
        public decimal VaultValue()
        {
            decimal sum = 0;
            foreach (Drawer item in Drawers)
            {
                sum += item.DrawerValue();
            }
            return sum;
        }
    }
}
