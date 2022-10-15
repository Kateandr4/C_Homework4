//В Указанном массиве вещественных чисел найдите разницу
// между максимальным и минимальным элементом 
void PrintArrey(double[] a)
{
    for (int j=0; j<a.Length; j++)
    {
    Console.Write(a[j]+ " ");
    }
}
Console.WriteLine("Введите размер массива");
int l=int.Parse(Console.ReadLine() ?? "0");
double  [] arrey = new double[l];
double min = 0;
double max = 0;
for(int i=0; i<arrey.Length; i++)
{
    arrey [i] = new Random().NextDouble() * 20 - 10
;
}
PrintArrey(arrey);
Console.WriteLine(" ");
for(int i=0; i<arrey.Length; i++)
{
    if (arrey[i]>max)
    {
       max = arrey[i] ;
    }
    else if (arrey[i]<min)
    {
         min = arrey[i] ;
    }
}
Console.WriteLine(" ");
Console.WriteLine("минимальное число " + min);
Console.WriteLine("максимальное число " + max);
Console.WriteLine("произведение " + min*max);