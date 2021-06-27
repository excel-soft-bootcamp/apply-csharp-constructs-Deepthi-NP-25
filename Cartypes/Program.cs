using System;

namespace Cartypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Tatacar _harrier = new Tatacar(new DicorEngine());
            _harrier.drive();
            _harrier.halt();
            Tatacar _nexon = new Tatacar(new MultiJet());
            _nexon.drive();
            _nexon.halt();
            Tatacar _hexa = new Tatacar(new RevorTron());
            _hexa.drive();
            _hexa.halt();
            Console.ReadLine();
        }
    }
}