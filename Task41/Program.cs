// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int M = 5;
Console.WriteLine($"Введите {M} чисел.");

int count = 0;
int b = 0;

while(count < M)
{

    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    count++;
    if (num > 0)
    {
        b++;
    }
    
}
Console.Write($"Введено: {b} чисел больше: 0");