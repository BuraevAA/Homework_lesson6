//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//0, 7, 8, -2, -2 -> 2 
//1, -7, -567, 89, 223-> 3 
 
Console.Clear(); 
Console.WriteLine("Введите количество чисел m"); 
int m = Convert.ToInt32(Console.ReadLine()); 
void FillArray(int[] array) 
{ 
    for (int j = 0; j < array.Length; j++) 
    { 
        Console.WriteLine("Введите число"); 
        array[j] = Convert.ToInt32(Console.ReadLine()); 
    } 
} 
void PrintArray(int[] array) 
{ 
    for (int j = 0; j < array.Length; j++) 
    { 
        Console.Write(array[j]); 
        Console.Write(", "); 
    } 
} 
void FindCount(int[] list) 
{ 
    int count = 0; 
    for (int i = 0; i < list.Length; i++) 
    { 
        if(list[i] > 0) count = count + 1;  
    } 
    Console.WriteLine($"Количество чисел больше нуля, введенных пользователем: {count}"); 
} 
 
int[] array = new int[m]; 
FillArray(array); 
PrintArray(array); 
Console.WriteLine(); 
FindCount(array);
