namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionSeleccionada = 0;
            do
            {
                Console.WriteLine("COOPERATIVA DE AHORRO ESTUDIANTIL\n");

                Console.WriteLine("[1] Simular Crédito de Computador");
                Console.WriteLine("[2] Consultar Tasa de Interés Institucional 2026");
                Console.WriteLine("[3] Salir del simulador");

                Console.Write("Seleccione una opción: ");

                int.TryParse(Console.ReadLine(), out opcionSeleccionada);

                double tasa = 0.12;

                if (opcionSeleccionada == 1)
                {
                    Console.WriteLine("\n---------------------------------------");
                    Console.WriteLine("SIMULAR CRÉDITO DE COMPUTADOR\n");
                    bool entradaMonto;
                    double montoSolictado;
                    do
                    {
                        Console.Write("Ingrese el monto solicitado: ");
                        entradaMonto = double.TryParse(Console.ReadLine(), out montoSolictado);
                    }
                    while (!entradaMonto || montoSolictado <= 0);

                    bool entradaCuotas;
                    int numCuotas;
                    do
                    {
                        Console.Write("Ingrese el número de cuotas de amortización: ");
                        entradaCuotas = int.TryParse(Console.ReadLine(), out numCuotas);
                    }
                    while (!entradaCuotas || numCuotas <= 0);

                    double simulacion = (montoSolictado * (1 + tasa)) / numCuotas;

                    Console.WriteLine($"\nLa simulación del crédito es de: {simulacion:C0}");
                    Console.WriteLine("---------------------------------------\n");
                }
                else if (opcionSeleccionada == 2)
                {
                    Console.WriteLine("\n---------------------------------------");
                    Console.WriteLine("TASA DE INTERÉS INSTITUCIONAL 2026\n");
                    Console.WriteLine($"La tasa de interés es del {tasa * 100}% anual");
                    Console.WriteLine("---------------------------------------\n");
                }
            }
            while (opcionSeleccionada != 3);
        }
    }
}
