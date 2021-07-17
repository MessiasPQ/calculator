using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var calculator = new Calculator();

            Console.WriteLine("Digite o primeiro valor:");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação desejada de acordo com sua numeração.");
            Console.WriteLine("1- Adição / 2- Subtração / 3- Multiplicação / 4-Divisão.");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Valor final: " + calculator.Addition(value1, value2));
                    break;
                case 2:
                    Console.WriteLine("Valor final: " + calculator.Subtraction(value1, value2));
                    break;
                case 3:
                    Console.WriteLine("Valor final: " + calculator.Multiplication(value1, value2));
                    break;
                case 4:
                    Console.WriteLine("Valor final: " + calculator.Division(value1, value2));
                    break;
                default:
                    Console.WriteLine("Valor inválido, tente novamente.");
                    break;
            }
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

        public float Addition(float value1, float value2)
        {
            float result;
            return result = value1 + value2;
        }

        public float Subtraction(float value1, float value2)
        {
            float result;
            return result = value1 - value2;
        }

        public float Multiplication(float value1, float value2)
        {
            float result;
            return result = value1 * value2;
        }

        public float Division(float value1, float value2)
        {
            float result;
            return result = value1 / value2;
        }

    }
}
