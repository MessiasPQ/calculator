using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float value2 = float.Parse(Console.ReadLine());
        }

    }

    struct Calculator
    {
        private float Value1;
        private float Value2;

        public Calculator(float value1, float value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
}
