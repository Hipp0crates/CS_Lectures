// Виды методов + цикл (for)

Console.Clear();

// 1. Ничего не принимают и ничего не возвращают

void Method1()
{
    Console.WriteLine("Метод 1.0");
}
Method1(); // Вызов метода

// 2. Что-то принимают, но ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Метод 2.0");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Метод 2.1a", 2); // порядок неименованных аргументов обязателен
Method21(count: 2, msg: "Метод 2.1b"); // порядок именованных аргументов необязателен

// 3. Ничего не принимают, но что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine("Метод 3.0 " + year);

// 4. Что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty; // начальное значение пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(4, "Метод 4.0 ");
Console.WriteLine(res);

string Method4f(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++) // цикл (for)
    {
        result = result + text;
    }
    return result;
}
string rez = Method4f(4, "Метод 4.f ");
Console.WriteLine(rez);

// Задача
// Вывести таблицу умножения.

Console.WriteLine(); // Добавил пустую строку
for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        if (i * j < 10)
        {
            Console.Write($"{j} x {i} = {i * j}   ");
        }
        else
        {
            Console.Write($"{j} x {i} = {i * j}  ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine(); // Добавил пустую строку

// Задача с заменой символов в тексте
// Дан текст.
// В тексте заменить все пробелы черточками.
// Маленькие буквы "к" заменить большими "К".
// Маленькие буквы "с" заменить большими "С".

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();

// Задача с массивом
// Алгоритм сортировки методом минимакса.
// Отсортировать от минимального до максимального значения.

int[] arr = { 6, 8, 3, 2, 1, 4, 5, 7, 1, 1 };

void PrintArray(int[] array, string msg)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(msg);
}
PrintArray(arr, " Входной массив");

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
SelectionSort(arr);
PrintArray(arr, " Отсортировано от минимума до максимума");