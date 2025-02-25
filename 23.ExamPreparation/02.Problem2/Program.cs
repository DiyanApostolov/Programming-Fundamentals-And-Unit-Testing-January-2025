// прочитаме входния масив фиункцонално на един ред
int[] numbers = Console.ReadLine()
                       .Split(" ")
                       .Select(int.Parse)
                       .ToArray();


//примерен вход: 3 4 6 7 8 9 - дължина 6 елемента
// левия среден индекс = 6 / 2 - 1
int leftMiddleIndex = numbers.Length / 2 - 1;

// десния среден индекс = 6 / 2
int rigthMiddlIndex = numbers.Length / 2;

int sum = numbers[leftMiddleIndex] + numbers[rigthMiddlIndex];

double averageResult = sum / 2.0;

Console.WriteLine($"{averageResult:F2}");