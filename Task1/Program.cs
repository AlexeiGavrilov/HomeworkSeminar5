// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void FillArray(int [] arr, int len)
{
    for (int i=0; i < len; i++)
    {
        arr[i] = new Random().Next(100,999);
    }

}

int [] array = new int [8];
FillArray(array, array.Length);

for(int k = 0; k < array.Length; k++)
{
    Console.Write(array[k] + " ");
   
}
Console.WriteLine();

int j =0;
int count = 0;
while(j<array.Length)
{
    int N = array[j] % 2;
    if(N==0)
    {
        count = count + 1;
        
    }
    j++;    
       
    
}

Console.WriteLine("Количество четных чисел в масиве => " + count);
