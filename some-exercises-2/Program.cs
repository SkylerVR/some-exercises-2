

int sigrdze = 10;
int sigane = 20;

static int Fartobi(int x, int y)
{
    return x * y;
}

Console.WriteLine("Fartobi: " + Fartobi(sigrdze, sigane));

static int checkSpaes(string text)
{

    int spaceCount = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == ' ')
        {
            spaceCount++;
        }
    }

    return spaceCount;
}
string checkText = "gamarjob a ";
Console.WriteLine("\"{0}\" contains {1} whitespaces" , checkText, checkSpaes(checkText));

static int SumOfNums(int number)
{
    string n = number.ToString();
    int sum = 0;

    for (int i = 0; i < n.Length; i++)
    {
        int digit = int.Parse(n[i].ToString());
        sum += digit;
    }

    return sum;
}
int sumOfDigits = 22;
Console.WriteLine($"Sum digits of number {sumOfDigits}  is: { SumOfNums(sumOfDigits)}" );

static int MaxNumberInArray(int[] array)
{

    return array.Max();
}

int[] numbers = { 2, 3, 33 };
Console.WriteLine("Max Number in array is: " + MaxNumberInArray(numbers));


static int GetRandomNumber()
{
    var random = new Random();
    return random.Next(100);
}

static void CheckStudent(int n)
{
    if (n >= 51 && n < 60)
    {
        Console.WriteLine("E");
    }
    else if (n >= 61 && n <= 70)
    {
        Console.WriteLine("C");
    }
    else if (n >= 81 && n <= 90)
    {
        Console.WriteLine("B");
    }
    else if (n >= 91 && n <= 100)
    {
        Console.WriteLine("A");
    }
    else
    {
        Console.WriteLine("F");
    }

}

CheckStudent(GetRandomNumber());

// another way to find maximum
static int FindMaximum(int[] numbers)
{
    int currentMax = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > currentMax)
            currentMax = numbers[i];
    }
    return currentMax;
}
Console.WriteLine(FindMaximum(new int[] { 21, 2, 3, 3 }));
