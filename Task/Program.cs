void CalcArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] array1 = new string[] {"hello", "2", "world", ":-)", "1234", "1567", "-2", "Computer science", "Russia", "Denmark", "Kazan", "YES"};
string[] array2 = new string[array1.Length];
CalcArray(array1, array2);
PrintArray(array2);