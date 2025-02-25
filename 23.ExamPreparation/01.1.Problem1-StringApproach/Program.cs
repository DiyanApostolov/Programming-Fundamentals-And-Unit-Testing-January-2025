// четем числото от входа като string
string number = Console.ReadLine();

int sum = 0;

// обикаляме стринга по индекс от нула (0)
for (int i = 0; i < number.Length; i++)
{
    // взимаме всяка цифра от числото по индекс
    // слагаме ToString(), за да нямаме проблем с Parse метода
    int currentDigit = int.Parse(number[i].ToString()); 

    // проверяваме дали цифрата е четна
    if (currentDigit % 2 == 0)
    {
        int currentFactorial = FactorialRecursive(currentDigit);
        sum += currentFactorial;
    }
}

// печатаме изхода
Console.WriteLine(sum);

// метод за изчисление на факториел от ChatGPT
static int FactorialRecursive(int n)
{
    if (n == 0 || n == 1)
        return 1;
    return n * FactorialRecursive(n - 1);
}
