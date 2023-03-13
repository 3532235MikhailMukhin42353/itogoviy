/*Из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив 
можно ввести с клавиатуры.*/

string [] Array = new string [6] {"hello", "231", "mi", "good", "a23", "a"};
string [] NewArray = new string [Array.Length];
FillArray(Array, NewArray);
PrintArray(NewArray);

void FillArray (string [] Array, string [] NewArray)
{
    //int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(Array[i].Length <= 3)
        NewArray[i] = Array[i];
        //NewArray[count] = Array[i];
        //count++;
    }
}

void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

