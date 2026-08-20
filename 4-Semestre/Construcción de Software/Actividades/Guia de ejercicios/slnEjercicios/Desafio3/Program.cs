namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            int opcionSeleccionada = 0;
=======
            int opcionSeleccionada;
>>>>>>> de5fe6a (sadas)
            do
            {
                Console.WriteLine("COOPERATIVA DE AHORRO ESTUDIANTIL\n");

                Console.WriteLine("[1] Simular Crédito de Computador");
                Console.WriteLine("[2] Consultar Tasa de Interés Institucional 2026");
                Console.WriteLine("[3] Salir del simulador");

                Console.Write("Seleccione una opción: ");

<<<<<<< HEAD
                int.TryParse(Console.ReadLine(), out opcionSeleccionada);

                double tasa = 0.12;
=======
                bool entradaOpcion = int.TryParse(Console.ReadLine(), out opcionSeleccionada);

                double tasa = 0.1;
>>>>>>> de5fe6a (sadas)

                if (opcionSeleccionada == 1)
                {
                    Console.WriteLine("\n---------------------------------------");
                    Console.WriteLine("SIMULAR CRÉDITO DE COMPUTADOR\n");
                    bool entradaMonto;
                    double montoSolictado;
                    do
                    {
<<<<<<< HEAD
                        Console.Write("Ingrese el monto solicitado: ");
                        entradaMonto = double.TryParse(Console.ReadLine(), out montoSolictado);
=======
                        Console.Write("Ingrese el monto solicitado: $");
                        entradaMonto = double.TryParse(Console.ReadLine(), out montoSolictado);

                        Console.ForegroundColor = ConsoleColor.Red;

                        if (!entradaMonto)
                        {
                            Console.WriteLine("Error: Ingrese un número válido");
                        } else if (montoSolictado <= 0)
                        {
                            Console.WriteLine("Error: Ingrese un monto mayor a 0");
                        }

                        Console.ResetColor();
>>>>>>> de5fe6a (sadas)
                    }
                    while (!entradaMonto || montoSolictado <= 0);

                    bool entradaCuotas;
                    int numCuotas;
                    do
                    {
                        Console.Write("Ingrese el número de cuotas de amortización: ");
                        entradaCuotas = int.TryParse(Console.ReadLine(), out numCuotas);
<<<<<<< HEAD
=======

                        Console.ForegroundColor = ConsoleColor.Red;

                        if (!entradaCuotas)
                        {
                            Console.WriteLine("Error: Ingrese un número válido");
                        }
                        else if (numCuotas <= 0)
                        {
                            Console.WriteLine("Error: La cantidad de cuotas debe ser mayor a 0");
                        }

                        Console.ResetColor();
>>>>>>> de5fe6a (sadas)
                    }
                    while (!entradaCuotas || numCuotas <= 0);

                    double simulacion = (montoSolictado * (1 + tasa)) / numCuotas;

<<<<<<< HEAD
                    Console.WriteLine($"\nLa simulación del crédito es de: {simulacion:C0}");
=======
                    Console.WriteLine($"\nLa simulación del crédito es de {simulacion:C0}");
>>>>>>> de5fe6a (sadas)
                    Console.WriteLine("---------------------------------------\n");
                }
                else if (opcionSeleccionada == 2)
                {
                    Console.WriteLine("\n---------------------------------------");
                    Console.WriteLine("TASA DE INTERÉS INSTITUCIONAL 2026\n");
                    Console.WriteLine($"La tasa de interés es del {tasa * 100}% anual");
                    Console.WriteLine("---------------------------------------\n");
<<<<<<< HEAD
=======
                } else if (!entradaOpcion)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Ingrese una opción válida");
                    Console.ResetColor();
>>>>>>> de5fe6a (sadas)
                }
            }
            while (opcionSeleccionada != 3);
        }
    }
}
