// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B.
// "Напишите ЦИКЛ" значит возводить в степень нужно 
// циклом, а не методом Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int firstNumber, int secondNumber)
{
    int result = 1;
    for (int i = 1; i <= secondNumber; i++)
    {
        result = result * firstNumber;
    }

    return result;

}

Console.Clear();
for (; ; )
{
    
    Console.WriteLine("Введите первое число:");
    Console.WriteLine("Для выхода нажмите Y");

    var inputString = Console.ReadLine();
    if (inputString.Equals("Y"))
        break;

    if (int.TryParse(inputString, out int firstNumber))
    {
        Console.WriteLine("Первое число = " + firstNumber);
    }
    else
    {
        Console.WriteLine("Введено не число или слишком большое число");
        continue;
    }

    Console.WriteLine("Введите второе натуральное число:");
    Console.WriteLine("Для выхода нажмите Y");

    var inputString2 = Console.ReadLine();

    if (inputString2.Equals("Y"))
        break;

    if (int.TryParse(inputString2, out int secondNumber))

    {
        if (secondNumber < 0)
        {
            Console.WriteLine("Введено не натуральное число");                   
        }
        else
        {
            Console.WriteLine("Второе число = " + secondNumber);
            var result = Exponentiation(firstNumber, secondNumber);
            Console.WriteLine($"{"Число"} {firstNumber} {"в"} {secondNumber} {"степени"} = {result}");                        
        }
    }
    else
    {
        Console.WriteLine("Введено не число или слишком большое число");        
    }
}







