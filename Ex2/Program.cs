// Для начала создадим массив и выведем его в консоль
Console.WriteLine("Set the vertical size of the array"); 
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Set the horizontal size of the array"); 
int b = int.Parse(Console.ReadLine());


Double[,] Array = new Double[a, b]; 

Random rnd = new Random(); 

for (int i = 0; i<a; i++)  
{
    for (int j = 0; j<b; j++)
    {
        Array[i, j] = (rnd.NextDouble()*1000)-500;  
        Array[i, j] = Math.Round(Array[i, j], 2);      
        Console.Write("{0}\t", Array[i, j]);
    }
    Console.WriteLine();
}
// Попросим пользователя ввести интересующие его "координаты"
Console.WriteLine("Vertical index request"); 
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Horizontal index request"); 
int d = int.Parse(Console.ReadLine());

if (c > a ^ d > b) // Для пользователя было бы удобнее если бы уже по первой невозможной координате программа прерывалась, не требуя ввести вторую, реализация возможна через вложенные условия
{
   Console.WriteLine("There is no element with that indexes in array");  
}
else
{
    Console.WriteLine($"Requested element is = {Array[c, d]}");
}