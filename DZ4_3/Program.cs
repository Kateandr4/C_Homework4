// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
void PrintArrey(int[] a)
{
    for (int j=0; j<a.Length; j++)
    {
    Console.Write(a[j]+ " ");
    }
}
Console.WriteLine("Введите размер массива");
int l=int.Parse(Console.ReadLine() ?? "0");
int [] arrey = new int[l];
int count_chet = 0;
int count_nechet = 0;
for(int i=0; i<arrey.Length; i++)
{
    arrey [i] = new Random().Next(100, 1000);
}
PrintArrey(arrey);
Console.WriteLine(" ");
for(int i=0; i<arrey.Length; i++)
{
    if (arrey[i] % 2==0)
    {
    count_chet ++;
    }
    else 
    {
        count_nechet ++;
    }
}
Console.WriteLine("Количестов четных элементов " + count_chet );
Console.WriteLine("Количестов нечетных элементов " + count_nechet );