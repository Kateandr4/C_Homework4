// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]. 
void PrintArrey(int[] a)
{
    for (int j=0; j<a.Length; j++)
    {
    Console.Write(a[j]+ " ");
    }
}
int [] arrey = new int[123];
int count = 0;
for(int i=0; i<arrey.Length; i++)
{
    arrey [i] = new Random().Next(-100, 500);
}
PrintArrey(arrey);
Console.WriteLine(" ");
for(int i=0; i<arrey.Length; i++)
{
    if (arrey[i] >9 && arrey[i] <100)
    {
    count++;
    }
}
Console.WriteLine("Количество элементов из отрезка [10,99] - " + count );

