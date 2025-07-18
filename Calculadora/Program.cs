using System;

class Calculadora
{
    static void Main()
    {
        int opcion;
        double num1, num2, resultado;

        do
        {
            Console.Clear();
            Console.WriteLine("===== CALCULADORA EN CONSOLA =====");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Raíz cuadrada");
            Console.WriteLine("6. Potencia (Exponente)");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 2:
                    Console.Write("Ingresa el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 3:
                    Console.Write("Ingresa el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 4:
                    Console.Write("Ingresa el dividendo: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el divisor: ");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                    }
                    break;

                case 5:
                    Console.Write("Ingresa el número: ");
                    num1 = double.Parse(Console.ReadLine());
                    if (num1 >= 0)
                    {
                        resultado = Math.Sqrt(num1);
                        Console.WriteLine("La raíz cuadrada es: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("No se puede calcular la raíz de un número negativo.");
                    }
                    break;

                case 6:
                    Console.Write("Ingresa la base: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el exponente: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 0:
                    Console.WriteLine("¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }
}
