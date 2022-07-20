using System;

namespace OuenGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = AbilityScoreCalculator.ReadInt(calculator.RollResult, "Начальный бросок 4d6");
                calculator.DivideBy = AbilityScoreCalculator.ReadDouble(calculator.DivideBy, "Разделить на");
                calculator.AddAmount = AbilityScoreCalculator.ReadInt(calculator.AddAmount, "Добавить сумму");
                calculator.Minimum = AbilityScoreCalculator.ReadInt(calculator.Minimum, "Минимум");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Расчетная оценка способности: " + calculator.Score);
                Console.WriteLine("Нажмите Q, чтобы выйти, любую другую клавишу, чтобы продолжить");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == 'Q' || keyChar == 'q') return;
            }
        }
    }
}
