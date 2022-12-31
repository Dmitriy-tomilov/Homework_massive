// /Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4,4];
int count = 0;
int i = 0;
int j = 0;

// 0 строка
for (int j = 0; j < array.GetLength(1); j++)  
{
    array[i,j] = count+1;
    count++;
}
j = 3;
for (int i = 0; i < array.GetLength(0); i++)     // 3 столбец
{
    array[i,j] = count+1;
    count++;
}

i =3;
for (int j = 2; j >=0; j-=1)                   // 3 строка
{
    array[i,j] = count+1;
    count++;
}

j=0;                                            //0 column
for (int i = 2; i >=1; i -=1)
{
    array[i,j] = count+1;
    count++;
}

i=1;
for (int j = 1; j <=2; j++)       // 1 row
{
    array[i,j] = count+1;
    count++;
}
i = 2 ;                             //2 row
for (int j = 2; j >=1; j-=1)
{
    array[i,j] = count+1;
    count++;
}

for (int i= 0; i <array.GetLength(0) ; i++)   //выводим получившуюся спираль
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();

}
Console.WriteLine("____");