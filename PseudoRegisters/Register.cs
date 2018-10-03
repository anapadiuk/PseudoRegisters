namespace PseudoRegisters
{
    public class Register
    {
        public Register(string name)
        {
            Name = name;
            Value = 0;
        }

        public int Value { get; set; }
        public string Name { get; set; }
    }
}