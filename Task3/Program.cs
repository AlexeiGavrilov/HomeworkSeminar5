//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//1. Создаем метод заполнения массива рандомными вещественными числами
void FillArrayRandomDoubleNum(double[] arr, int len)
{
    for(int z =0; z < len; z++)
    {
        arr[z] = new Random().NextDouble();
    }
}
//2. Создаем метод по поиску наибольшего элемента массива 
double FindMaxElement(double [] arr1, int len1)
{
    double max = arr1[0];
    int z = 1;
    while(z < len1)
    {
        if(arr1[z]>max)
        {
            max = arr1[z];
           
        }
        z++;
    }
    return max;
}

//3.Создаем метод по поиску наименьшего элемента массива 
double FindMinElement(double [] arr2, int len2)
{
    double min = arr2[0];
    int j = 1;
    while(j < len2)
    {
        if(arr2[j]<min)
        {
            min = arr2[j];
           
        }
        j++;
    }
    return min;
}

//4.Созадем массив

double [] array = new double [5];

//5.Заполняем массив через метод
FillArrayRandomDoubleNum(array, array.Length);
//6.Выводим массив на экран для визуализации выполнения задачи 
for(int k = 0; k<array.Length; k++)
{
    Console.Write(array[k] + " ");
}
Console.WriteLine();
//7.Вычислем максимальное и минимальное, узнаем разницу и выводим на экран.
Console.WriteLine("Разница между максимальными и минимальным элементом равна => " + (FindMaxElement(array, array.Length) - FindMinElement(array, array.Length)));

///Для личной проверки, что все находит и вычисляет правильно, так бы не добавлял.
Console.WriteLine();
double max = FindMaxElement(array, array.Length);
Console.WriteLine(max);
Console.WriteLine();
double min = FindMinElement(array, array.Length);
Console.WriteLine(min);


