using System;

namespace OuenGame
{
    class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            double divided = RollResult / DivideBy;

            int added = AddAmount + (int)divided;

            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }

        public static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [ " + lastUsedValue + " ]: ");
            string line = Console.ReadLine();
            if(int.TryParse(line,out int value))
            {
                Console.WriteLine("Используя значение " + value);
                return value;
            }
            else
            {
                Console.WriteLine("Используя значение по умолчанию " + lastUsedValue);
                return lastUsedValue;
            }
        }

        public static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [ " + lastUsedValue + " ]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine("Используя значение " + value);
                return value;
            }
            else
            {
                Console.WriteLine("Используя значение по умолчанию " + lastUsedValue);
                return lastUsedValue;
            }
        }

    }
}
