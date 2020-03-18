using System.Collections.Generic;

namespace AutomatedTellerMachine.Entities
{
    class Drawer
    {
        public decimal DrawerNote { get; set; }
        public List<Note> Notes { get; set; } = new List<Note>();

        public Drawer(decimal drawerNote)
        {
            DrawerNote = drawerNote;
        }

        public Drawer(decimal drawerNote, int amount)
        {
            DrawerNote = drawerNote;
            for (int i = 0; i < amount; i++)
            {
                Notes.Add(new Note(drawerNote));
            }
        }

        public void AddBill(Note note)
        {
            Notes.Add(note);
        }

        public void RemoveBill(Note note)
        {
            Notes.Remove(note);
        }

        public void RemoveNotes()
        {
            Notes.RemoveAt(0);
        }

        public int Amount()
        {
            return Notes.Count;
        }

        public decimal DrawerValue()
        {
            decimal sum = 0;
            foreach (Note item in Notes)
            {
                sum += item.Value;
            }
            return sum;
        }
    }
}
