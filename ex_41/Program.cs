//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] Array(string[] array) //преобразовываем ввод в int массив
{
    int[] intArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        intArray[i] = int.Parse(array[i]);
    }
return intArray;
}

int ShowDigit(int[] array) //считаем кол-во положительных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count = count + 1;
    }
return count;
} 


Console.WriteLine("Введите числа через пробел: ");
string[] x = Console.ReadLine().Split(" ");


Console.WriteLine(ShowDigit(Array(x)));



