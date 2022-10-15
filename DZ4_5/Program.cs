// Найти сумму чисел одномерного массива стоящих на нечетной позиции
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
int summ_nechet = 0;
for(int i=0; i<arrey.Length; i++)
{
    arrey [i] = new Random().Next(-10, 10);
}
PrintArrey(arrey);
Console.WriteLine(" ");
for(int i=0; i<arrey.Length; i++)
{
    if (i % 2==0)
    {
    summ_nechet=summ_nechet+arrey[i];
    }
}
Console.WriteLine("Cумма чисел массива стоящих на нечетной позиции " + summ_nechet );
