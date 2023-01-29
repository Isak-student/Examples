/* Вид 1 - метод который ничего не принимает и ничего не возвращает
 void Method1()
 {
    Console.WriteLine("Текст" );
 }

// Method1(); // вызов метода */

/*Вид 2 - ничего не возвращают но могут принимать аргументы 
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i > count)
    {
      Console.WriteLine(msg);
      i++;  
    }
}
//Method21(count: 4, msg: "текст"); */

/* Вид 3 - что-то возвращают но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year); */

/*Вид 4 - принимают и отправляют
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while ( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "ass");
Console.WriteLine(res); 

string Method4(int count, string text)
{
    
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
//Console.WriteLine(res);//

/* Цикл в цикле - выведем таблицу умножения на экран

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
} */

/* Задача на работу с текстом 
Дан текст. В тексте нудно все пробелы заменить на черточки,
маленькие буквы "к" заменить на большие "К",
большие "С" заменииь на маленькие "с". 

// string s = "qwerty"
//             012
// s[3] это r

string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю? ";



string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // новая строка  

    int Length = text.Length; // задаем длину строки
    for (int i = 0; i < Length; i++) // проходим от начала строки до конца строки 
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если текст  равен запраашевоему щначению то его заменяем на новое занчение
        else result = result + $"{text[i]}"; // если нет совпадений то добавляем текущий символ
    }
    return result;
}

string newText = Replace(text, ' ', '|'); // Replace - присвоить

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с'); // Replace - присвоить
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К'); // Replace - присвоить
Console.WriteLine(newText); */


int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for ( int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
