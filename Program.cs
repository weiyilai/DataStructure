// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] result = new[]
{
    1,4,3,6,9,11,8,36
};

List<int> list = result.ToList();
list.Insert(2, 23);

Console.WriteLine(string.Join(", ", list));
Console.ReadLine();