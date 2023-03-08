//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*double StepenNumber(double A, double B)
{
    double stepnumber = A;
    for(int i=2; i<=B; i++)
    {
        stepnumber*=A;
    }
    return stepnumber;
}
Console.Write($"напишите число, которое необходимо ввести в степень ");
double numA =Convert.ToDouble(Console.ReadLine());
Console.Write($"напишите чисчло, степень ");
double numB =Convert.ToDouble(Console.ReadLine());
Console.Write($"Число {numA} в степени {numB} = {StepenNumber(numA, numB)}");*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*int Summa(int numbers)
{
    int summa = 0;
    while (numbers > 0)
    {
        summa += numbers % 10;
        numbers = numbers / 10;
    }
    return summa;
}
Console.WriteLine("Введите число: ");
int checknumbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма цифр числа {checknumbers} = {Summa(checknumbers)}");
*/
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] Massiv(int mas, int massivA, int massivB)
{
    int[] massiv = new int[mas];
    Random rnd = new Random();
    for(int i=0; i<massiv.Length; i++)
    {
        massiv[i]=rnd.Next(massivA, massivB);
    }
    return massiv;
}
Console.Write("Напишите длину массива ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите число начала массива ");
int massivA = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите число конец массива ");
int massivB = Convert.ToInt32(Console.ReadLine());
int[] new_massiv = Massiv(num, massivA, massivB);
Console.Write($"[{string.Join(",", new_massiv)}]");

