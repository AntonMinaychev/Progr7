// Для начала создадим массив и выведем его в консоль

Console.WriteLine("Set the vertical size of the array"); 
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Set the horizontal size of the array"); 
int b = int.Parse(Console.ReadLine());


Double[,] Array = new Double[a, b]; 

Random rnd = new Random(); 

for (int i = 0; i<a; i++)  // Заполнение через вложенные циклы
{
    for (int j = 0; j<b; j++)
    {
    Array[i, j] = (rnd.NextDouble()*1000)-500;  // Случайные вещественные числа от -500 до 500 
    Array[i, j] = Math.Round(Array[i, j], 2);      // Округляем до 2 знаков
    Console.Write("{0}\t", Array[i, j]);
    }
    Console.WriteLine();
}