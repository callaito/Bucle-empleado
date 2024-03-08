// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Determinar la cantidad de empleados


//Declarar siempre primero

double sueldo, total, promedio;

//Inicializar siempre antes del bucle

Console.WriteLine("Cantidad de empleados: ");
int cantidad = int.Parse(Console.ReadLine());
total = 0;

for (int i = 1; i <= cantidad; i++)
{

    Console.WriteLine("Sueldo del empleado " + i);
    sueldo = Convert.ToDouble(Console.ReadLine());
    total += sueldo;
}

//Calcular el promedio
promedio = total / cantidad;

Console.WriteLine("El sueldo promedio de um empleado es: " + promedio);
