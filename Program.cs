string[] CreateArray()
{
    Console.Write("Please input size array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    while(size < 0)
    {
        Console.WriteLine("Incorrect value!");
        Console.Write("Please input size: ");
        size = Convert.ToInt32(Console.ReadLine());
    }

    string[] array = new string[size];

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Please input value: ");
        array[i] = Console.ReadLine();
    }

    return array;
}

void ShowArray(string[] array)
{
    if(array.Length == 0) Console.WriteLine("[]");
    else
    {
        Console.Write("[");
        for(int i = 0; i < array.Length; i++)
        {
            if(i != array.Length - 1) Console.Write(array[i] + ", ");
            else Console.WriteLine(array[i] + "]");
        }
    }
}

string[] ShortValueInArray(string[] array, int shortValue)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= shortValue) count++;
    
    string[] shortArray = new string[count];
    int indexShort = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= shortValue)
        {
            shortArray[indexShort] = array[i];
            indexShort++;
        }

    return shortArray;
}

Console.WriteLine("This program outputs an array of strings whose length is less than or equal to 3.");

string[] newArray = CreateArray();
Console.WriteLine();
Console.WriteLine("Your array:");
ShowArray(newArray);
int shortValue = 3;
string[] shortArray = ShortValueInArray(newArray, shortValue);
Console.WriteLine($"Values that are less {shortValue}:");
ShowArray(shortArray);