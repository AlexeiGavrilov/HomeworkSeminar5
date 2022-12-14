//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//1.Создали метод заполнения массива рандомными числами
void FillArrayRandom(int [] arr, int len)

{
    for(int z = 0; z < len; z++)
    {
        arr[z] = new Random().Next(-100, 100);
    }
}


//2.Создали метод сумирование элементов на нечетных позициях
int SumOddElementArray (int [] arr1)
{
int i = 1;
int result = 0;
while( i < arr1.Length)
{
    int l = arr1[i];
    result = result + l;
    i = i + 2;
}
   return result;
}


//3.Инициализзация массива
int [] array = new int [10];


//4.Заполнение массива
FillArrayRandom(array, array.Length);

//5.Вывод получившегося массива на экран
for(int f = 0; f < array.Length; f++)
{
  Console.Write(array[f] + " ");
}
Console.WriteLine();


//6.Вычисление суммы элементов на нечетных позициях в нашем массиве и вывод на экран.
Console.WriteLine("Сумма элементов на нечетных позициях = " + SumOddElementArray(array));











