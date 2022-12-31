//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя
//  индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [, ,] array3d = new int[2,2,2];

FillArray(array3d);
PrintIndex(array3d);

void PrintIndex (int[, ,] arr)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int z = 0; z < array3d.GetLength(2);  z++)
            {
                Console.Write($" {array3d[i,j,z] } ({i} {j}, {z})"     );
            }
        }
    }
}

void FillArray(int[, ,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[z,i,j] += count;
                count+=3;
            }
        }
    }
}