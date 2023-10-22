using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankomat;
namespace Modul6
{
    internal class Program
    {
        static void Menu()
        {
            Account userAccount = new Account { Balance = 0 }; 

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("a. Вывод баланса на экран");
                Console.WriteLine("b. Пополнение счёта");
                Console.WriteLine("c. Снять деньги со счёта");
                Console.WriteLine("d. Выход");

                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case 'a':
                        Console.WriteLine($"\nБаланс: {userAccount.Balance}");
                        break;
                    case 'b':
                        Console.WriteLine("\nВведите сумму для пополнения:");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount) && userAccount.Deposit(depositAmount))
                        {
                            Console.WriteLine($"Счёт пополнен на {depositAmount}. Текущий баланс: {userAccount.Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Неверная сумма.");
                        }
                        break;
                    case 'c':
                        Console.WriteLine("\nВведите сумму для снятия:");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount) && userAccount.Withdraw(withdrawAmount))
                        {
                            Console.WriteLine($"Снято {withdrawAmount}. Текущий баланс: {userAccount.Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Невозможно выполнить операцию. Неверная сумма или недостаточно средств.");
                        }
                        break;
                    case 'd':
                        Console.WriteLine("\nПрограмма завершена.");
                        return;
                    default:
                        Console.WriteLine("\nНеверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Constant.SomeString);
            Console.WriteLine(Constant.SomeNumber);
            Person person = new Person("Dias", "Ondiris", new DateTime(2002, 10, 14), "male", "Toregulova 70", "Dificonfig@gmail.com", "87781076714");
            string personinfo = PersonInfo.GetPersonInfo(person);
            Console.WriteLine(personinfo);
            string correctPassword = "1234"; // предположим, что это правильный пароль
            int attempts = 3;

            while (attempts > 0)
            {
                Console.WriteLine("Введите пароль кредитной карточки:");
                string inputPassword = Console.ReadLine();

                if (inputPassword == correctPassword)
                {
                    Menu();
                    break;
                }
                else
                {
                    attempts--;
                    if (attempts > 0)
                    {
                        Console.WriteLine($"Неверный пароль! У вас осталось {attempts} попыток.");
                    }
                    else
                    {
                        Console.WriteLine("Попытки исчерпаны. Программа завершена.");
                        return;
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
