Console.Clear(); 
Console.Write("Задайте количество строк, которые вы хотите ввести: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int size = 0; 
string[] massiv = new string[n]; 
for (int i = 0; i < n; i++) 
{ 
    Console.Write("Введите строку №{0}: ", i + 1); 
    massiv[i] = Console.ReadLine(); 
    if (massiv[i].Length <= 3) size++; 
} 