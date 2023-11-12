//int[] months = new int[12];
//for (int i = 0; i < 12; i++)
//{
//    months[i] = i + 1;
//}
//foreach (int i in months)
//{
//    Console.WriteLine(i);
//}

string[,] name = new string[3, 2];
name[0, 0] = "A";
name[0, 1] = "B";
name[1, 0] = "C";
name[1, 1] = "D";
name[2, 0] = "E";
name[2, 1] = "F";
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(name[i, j]);
        if (j == 1)
        {
            Console.WriteLine();
        }
    }
    
}
Console.Read();
