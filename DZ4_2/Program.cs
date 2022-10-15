// Задать массив из 12 элементов, заполненных 
//числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
void PrintArrey(int[] a)
{
    for (int j=0; j<a.Length; j++)
    {
    Console.Write(a[j]+ " ");
    }
}
int [] arrey = new int[12];
 int sum=0;
 int summneg =0;
Random rnd = new Random();
for(int i=0; i<arrey.Length; i++)
{
    arrey [i] = rnd.Next(-9, 10);
}
PrintArrey(arrey);
for (int i=0; i<arrey.Length; i++)
    {
        if (arrey[i]>0) 
    {
        sum=sum+arrey[i];
    }
    else
    {
        summneg=summneg+arrey[i];
    } 
}
Console.WriteLine("");
Console.WriteLine("сумма положительных элементов: "+sum);
Console.WriteLine("сумма отрицательных элементов: "+summneg);

