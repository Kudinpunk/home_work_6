/* Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа.
 Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string [] Create_array ()
{
    Console.Write("введите количество элементов массива: ");
    int size_array = Convert.ToInt32(Console.ReadLine());
    string [] new_array = new string[size_array];
    for (int i = 0; i < size_array; i++)
    {
        Console.Write($"введите элемент массива с индексом {i}: ");
        string current_str = "";
        new_array[i] = current_str + Console.ReadLine(); 
    }
    return new_array;
}

void Show_array (string [] array)
{
    Console.Write("\n--> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine("\b\b ");
}

string [] Sort_array (string [] random_array)
{
    int size_sort_array = 0;
    for (int i = 0; i < random_array.Length; i++)
    {
        if (random_array[i].Length <= 3)
        {
            size_sort_array += 1;
        }
    }
    string [] sort_array = new string[size_sort_array];
    for (int i = 0; i < random_array.Length; i++)
    {
        if (random_array[i].Length <= 3)
        {
            sort_array[i] = random_array[i];
        }
    }
    return sort_array;
}

string [] user_array = Create_array();
Show_array(user_array);
Show_array(Sort_array(user_array));