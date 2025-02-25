// четем числото от входа като integer
int number = int.Parse(Console.ReadLine());

int sum = 0;

while (number > 0)
{
    // вземаме последната цифра от числото
    int lastDigit = number % 10;

    // изчисляваме факториел само ако е четна цифра
    if (lastDigit % 2 == 0)
    {
        int currentFactorial = CalculateFactorial(lastDigit);
        sum += currentFactorial;
    }

    // махаме последната цифра от числото
    number /= 10;
}

// печатаме изхода
Console.WriteLine(sum);

// разписваме логика за изчисление на факториел
static int CalculateFactorial(int num)
{
    int factorial = 1;

    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }

    return factorial;
} 
