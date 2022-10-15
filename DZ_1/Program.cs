// Задать массив из 8 элементов, 
//заполненных нулями и единицами вывести их на экран
int [] arrey = new int[8];
Random rnd = new Random();
int i = 0;
while (i<8)
{
    arrey [i] = rnd.Next(0, 2);
    ++i;
}
i =0 ;
while (i<8)
{
Console.Write(arrey[i]+ " ");
++ i;
}

