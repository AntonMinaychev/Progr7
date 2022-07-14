// Для начала создадим массив и выведем его в консоль
Console.WriteLine("Set the vertical size of the array"); 
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Set the horizontal size of the array"); 
int b = int.Parse(Console.ReadLine());
int[,] Array = new int[a, b]; 

Random rnd = new Random(); 

for (int i = 0; i<a; i++)  
{
    for (int j = 0; j<b; j++)
    {
        Array[i, j] = rnd.Next(-500,500); // Требуются целые числа, возьмем интервал от -500 до 500
        Console.Write("{0}\t", Array[i, j]);
    }
    Console.WriteLine();
}

int sum = 0;

for (int i = 0; i < a; i++)
    {
    for (int j = 0; j < b; j++)
        {
            sum += Array[j, i];       // Складываем в sum сумму элементов столбца 
        }   
            sum = sum/a;             // Находим среднее арифметическое       
            Console.WriteLine("Moderate of " + (i + 1) + " column is " + sum);     
            sum = 0;                 // Обнуляем для следующей итерации
        
    }