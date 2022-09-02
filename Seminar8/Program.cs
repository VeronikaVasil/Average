// Рекурсия — функция, которая вызывает саму себя
// 4!= 4 * 3 * 2 * 1 = 24
// n-> 1; n-> n -1 -> n - 2 2; n-> 3; n->
int Factorial(int value)
{
    // базовый случай - выход из рекурсии: возвращает все, кроме вызова функции

    if (value == 1) return 1;
// рекурсивный случай - вызов функции
return value * Factorial(value - 1);
}
Console.WriteLine(Factorial(3));
