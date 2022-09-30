Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] new_array = create_array();
print_array(new_array);
Console.WriteLine($"Разница между максимальным и минимальным элементами равна: {find_max(new_array) - find_min(new_array)}.");

int find_max(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {    
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

int find_min(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {    
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

void print_array(int[] x)
{
    int[] new_array = x;
    for (int i = 0; i < new_array.Length; i++)
        Console.Write($"{new_array[i]} ");
}

int[] create_array()
{
    int[] new_array = new int[size];
    Random randGenerator = new Random();
    for (int i = 0; i < size; i++)
    {
        new_array[i] = randGenerator.Next(0, 1000);
    }
    return(new_array);
}