// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//returns closest fibonacci number before number entered
int fibonacci(int num)
{
    Console.WriteLine("Enter number: ");
    int lastNum = 1;
    int FibNum = 1;
    while (FibNum < num)
    {
        int hold = FibNum;
        FibNum += lastNum;
        lastNum = hold;
        Console.WriteLine(FibNum);
    }
    return lastNum;
}
List<int> Zeckendorf(int num)
{
    Console.WriteLine("Enter number: ");
    List<int> Numbers = [];
    while (num > 0);
        int NextNum = fibonacci(num);
        Numbers.Add(NextNum);
        num -= NextNum;
        Console.WriteLine(NextNum);
    return Numbers;
}
Console.WriteLine("Enter number: ");
Console.WriteLine(Zeckendorf(int.Parse(Console.ReadLine())));