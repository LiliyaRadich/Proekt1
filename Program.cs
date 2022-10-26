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
string[] createMass = NewMassCreate(massiv, size); 
NewMasPrint(massiv, createMass); 
 
string[] NewMassCreate(string[] array, int a) 
{ 
    int sizenewmas = 0; 
    string[] newmas = new string[a]; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i].Length <= 3) 
        { 
            newmas[sizenewmas] = array[i]; 
            sizenewmas++; 
        } 
    } 
    return newmas; 
} 
void NewMasPrint(string[] array1, string[] array2) 
{ 
    Console.Write(" [ "); 
    for (int i = 0; i < array1.Length; i++) 
    { 
        Console.Write($"<{array1[i]}> "); 
    } 
    Console.Write("] "); 
    if (array2.Length == 0) 
    { 
        Console.Write("-> в массиве нет строк с длиной <= 3 символов"); 
        return; 
    } 
    Console.Write("-> [ "); 
    for (int i = 0; i < array2.Length; i++) 
        Console.Write($"<{array2[i]}> "); 
    Console.Write("]"); 
}