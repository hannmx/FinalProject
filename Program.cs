Console.Write("Введите количество слов: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] origArray = new string[num];
string[] newArray = new string[origArray.Length];

Console.Write("Введите слова через запятую: ");
string words = Console.ReadLine();
origArray = words.Split(",");
int count = 0;

Console.WriteLine();

    for(int i = 0; i < origArray.Length; i++)
    {
        if(origArray[i] != " ") count++;   
    }
    if(count != num)
    {
    Console.WriteLine("Вы ввели неверное количество слов!");
    }
    else
    {
        Console.WriteLine($"Ваша строка из {num} слов:");
        for(int i = 0; i < origArray.Length; i++)
        {
        if(origArray[i] != " ") count++;
        Console.Write(origArray[i] + " ");   
        }
        
        FillNewArray(origArray, newArray);
        Console.WriteLine("\nНовый массив: ");
        PrintArray(newArray);
    }
    
    void FillNewArray(string[] origArray, string[] newArray)
    {
        count = 0;
        for(int i = 0; i < origArray.Length; i++)
        {
            if(origArray[i].Length <= 3)
            {
                newArray[count] = origArray[i];
                count++;
            }
        }
    } 
    void PrintArray(string[] newArray)
    {
         for(int i = 0; i < newArray.Length; i++)
        {
             Console.Write(newArray[i] + " ");
        }
    }