namespace AutomatedTellerMachine.Entities
{
    class Note
    {
        public decimal Value { get; set; }

        public Note(decimal value)
        {
            Value = value;
        }
    }
}
