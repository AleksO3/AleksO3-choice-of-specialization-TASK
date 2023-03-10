// Написать программу, которая из имеющихся массивов строк формирует массив из строк, длина которых меньше или равна 3-м символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
                                                                        // Очищаем терминал.

int ReadInt(string message)                                             // Метод внесения данных и их записи.
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int n = ReadInt("Введите колличество задаваемых строк: ");              // Записываем в переменную внесенное
string[] arr = new string[n];                                           // пользователем значение вызвав метод ReadInt и заносим в массив.

for (int i = 0; i < n; i++)                                             // Запрашиваем у пользователя данные, используя цикл до числа = n,
{                                                                       // сохраняя в массив  с помощью метода, вызывая его.
    Console.WriteLine("Введите строку №-{0}:", i + 1);
    arr[i] = Console.ReadLine();
}
                                                                        // Нахождение длины <= 3 с помощью цикла.
int count = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i].Length <= 3)
    {
        count++;
    }
}
                                                                        // Создание нового массива из массивов <= 3.
string[] smallArr = new string[count];
int j = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i].Length <= 3)
    {
        smallArr[j] = arr[i];
        j++;
    }
}
Console.WriteLine();
Console.WriteLine("Массивы, длина строк которых <= 3");
Console.Write("[");
Console.Write(String.Join(", ", smallArr));                            // Вывод массивов через функцию Join.
Console.WriteLine(']');
