// деклариране на променлива
int number;

// инициализиране на променлива
number = 5;

// декмариране + инициализиране на променлива

double decimalNumber = 5.5;

// променяне на стойност на променливата

number = 10;

// Целочислено деление

int a = 25;
int b = 4;

int result = a / b;

Console.WriteLine(result); // 6

// Деление с реален резултат с остатък

int x = 25;
double y = 4;

double realResult = x / y;

Console.WriteLine(realResult); // 6.25

// Модулно деление

int i = 39;
int j = 6;

Console.WriteLine(i % j); // 3

// Проверка дали едно число е четно или нечетно

int oddNum = 25;
// има остатък 1 => нечетно число
Console.WriteLine(oddNum % 2); 

int evenNum = 12;
// няма остатък (равен е на 0) => четно число
Console.WriteLine(evenNum % 2);

// Закръгляне с класа Math

double realNumber = 3.14233653;

Console.WriteLine(Math.Ceiling(realNumber));  //4
Console.WriteLine(Math.Floor(realNumber));    //3
Console.WriteLine(Math.Round(realNumber));    //3

Console.WriteLine(Math.Round(realNumber, 2)); //3.14
Console.WriteLine($"{realNumber:F2}");        //3.14