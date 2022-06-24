using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            float rubBalance = 1000;
            float usdBalance = 100;
            float euroBalance = 90;
            double usdToRubles = 53;
            double euroToRubles = 56;
            double euroToUsd = 1.06, usdToEuro = 0.94;
            double moneyToChange;
            double balanceAfterChange;
            int state;
            Console.WriteLine($"Добрый день ваш баланс составляет:    \n{rubBalance} рублей \n{euroBalance} евро \n{usdBalance} долларов\n");
            Console.WriteLine($"Обменный курс: \n usd = {usdToRubles} rub \n eur = {euroToRubles} rub \n usd = {usdToEuro} eur \n eur = { euroToUsd } usd\n");
            Console.Write("Выберите вариант конвертации валют: \n 1. Обменять рубли на доллары \n 2. Обменять рубли на Евро \n 3. Обменять доллары на рубли \n 4. Обменять доллары на Евро \n 5. Обменять Евро на рубли \n 6. Обменять Евро на Доллары \n ESC Выход из программы\n");

            do
            {
                state = int.Parse(Console.ReadLine());
                switch (state)
                {
                    case 1:
                        Console.WriteLine("Сколько рублей на доллары:");
                        moneyToChange = double.Parse(Console.ReadLine());
                        if (moneyToChange <= rubBalance)
                        {
                            balanceAfterChange = rubBalance - moneyToChange;
                            moneyToChange /= usdToRubles;
                            Console.WriteLine($"У вас осталось {(balanceAfterChange)} рублей и {moneyToChange + usdBalance} долларов");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("недостаточно средств");
                            break;
                        }
                    case 2:
                        Console.WriteLine("Сколько рублей на евро:");
                        moneyToChange = double.Parse(Console.ReadLine());
                        if (moneyToChange <= rubBalance)
                        {
                            balanceAfterChange = rubBalance - moneyToChange;
                            moneyToChange /= euroToRubles;
                            Console.WriteLine($"У вас осталось {balanceAfterChange} рублей и {moneyToChange + (euroBalance)} евро");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("недостаточно средств");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Сколько долларов на рубли:");
                        moneyToChange = double.Parse(Console.ReadLine());
                        if (moneyToChange <= usdBalance)
                        {
                            balanceAfterChange = usdBalance - moneyToChange;
                            moneyToChange *= usdToRubles;
                            Console.WriteLine($"У вас осталось {balanceAfterChange} долларов и {moneyToChange + rubBalance} рублей");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("недостаточно средств");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Сколько долларов на евро:");
                        moneyToChange = double.Parse(Console.ReadLine());
                        if (moneyToChange <= usdBalance)
                        {
                            balanceAfterChange = usdBalance - moneyToChange;
                            moneyToChange *= usdToEuro;
                            Console.WriteLine($"У вас осталось {balanceAfterChange} долларов и {moneyToChange + euroBalance} евро");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("недостаточно средств");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Сколько евро на рубли:");
                        moneyToChange = double.Parse(Console.ReadLine());
                        if (moneyToChange <= euroBalance)
                        {
                            balanceAfterChange = euroBalance - moneyToChange;
                            moneyToChange *= euroToRubles;
                            Console.WriteLine($"У вас осталось {balanceAfterChange} евро и {moneyToChange + rubBalance} рублей");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("недостаточно средств");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Сколько евро на доллары:");
                        moneyToChange = double.Parse(Console.ReadLine());
                        if (moneyToChange <= euroBalance)
                        {
                            balanceAfterChange = euroBalance - moneyToChange;
                            moneyToChange /= euroToUsd;
                            Console.WriteLine($"У вас осталось {balanceAfterChange} евро и {moneyToChange + usdBalance} долларов");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("недостаточно средств");
                        }
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
