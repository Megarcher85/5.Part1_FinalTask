Console.WriteLine("Введите размер текстового массива:");
int size = int.Parse(Console.ReadLine()!);
String[] arr1 = new String[size];

Console.WriteLine($"Введите через пробел {size} элементов текстового массива:");
for (int i = 0; i < size; i++)
{
    arr1[i] = Console.ReadLine();
}