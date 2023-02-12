/*Для нахождения среднего арифметического мы делаем следующее:
1. Задаем переменные, которые будут хранить числа;
2. Присваиваем значение всем переменным;
3. Задаем формулу и подставляем туда переменные;
4. Получаем результат.*/

double IntroNumbers()
{
    Console.WriteLine("Введите любое число");
    return Convert.ToInt32(Console.ReadLine());
}

double a = IntroNumbers();
double b = IntroNumbers();
double c = IntroNumbers();
double d = IntroNumbers();

double average = (a + b + c + d) / 4;
Console.WriteLine($"Среднее арифметическое введенных чисел равен {average}");
