// See https://aka.ms/new-console-template for more information

static float checkAvg(int[] ints)
{
    int sum = 0;
    foreach (var val in ints)
    {
        sum += val;
    }

    return sum / ints.Length;
}

Console.WriteLine("Hello, World!");

Console.WriteLine("Modyfikacja 1");

Console.WriteLine("Modyfikacja 2");

Console.WriteLine("Modyfikacja 3");

int[] ints = new[] { 1, 2, 3, 4, 5 };

Console.WriteLine(checkAvg(ints));