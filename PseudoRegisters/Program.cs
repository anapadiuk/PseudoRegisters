using System;
using System.Linq;

namespace PseudoRegisters
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello Pseudo Registers!");

            var registers = new[] {new Register("A"), new Register("B"), new Register("C"), new Register("D")};
            var processor = new RegistersProcessor();
            registers[0].Value = 7;
            processor.Dec(registers[0]);
            registers.ToList().ForEach(r => Console.WriteLine($"{r.Name}: {r.Value}"));

            Console.ReadKey();
        }
    }
}