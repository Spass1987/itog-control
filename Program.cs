string [] array1 = new string [5] {"hello", "123", "for", "sem", "hip-hop"};
string [] array1 = new string [5] {"hello", "23", "for", "sem", "hip-hop"};
string [] array2 = new string [array1.Length];

void SecondArray (string[] array1, string[] array2)
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for(i = 0; i < array1.Length; i++)
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <=3);
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array){
    for(int i = 0; i < array.Length; i++);
    Console.Write($"{array[i]} ");
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
SecondArray(array1, array2);
PrintArray(array2);
}