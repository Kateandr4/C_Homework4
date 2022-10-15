//Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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
int count=l-1;
for(int i=0; i<arrey.Length; i++)
{
    arrey [i] = new Random().Next(-10, 10);
}
PrintArrey(arrey);
Console.WriteLine(" ");
for(int i=0; i<l/2; i++)
{
    Console.WriteLine("произведение "+ arrey[i] +" и " + arrey[count] + " = "+arrey[i]*arrey[count]) ;
    count--
    ;
}

