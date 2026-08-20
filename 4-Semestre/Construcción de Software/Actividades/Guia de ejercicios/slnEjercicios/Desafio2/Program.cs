namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTROLADOR DE CALIDAD DE SOFTWARE\n");

            int transacciones;
            do
            {
                Console.Write("Ingrese la cantidad de transacciones: ");
<<<<<<< HEAD
                transacciones = int.Parse(Console.ReadLine().Trim());
=======
                transacciones = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;

                if (transacciones <= 0)
                {
                    Console.WriteLine("Error: la cantidad de transacciones debe ser mayor a 0");
                }

                Console.ResetColor();
>>>>>>> de5fe6a (sadas)
            }
            while (transacciones <= 0);

            double tiempoAcumulado = 0;
            double umbralTransacciones = 0;
            for (int i = 1; i <= transacciones; i++)
            {
<<<<<<< HEAD
                Console.Write($"[{i}] Ingrese el tiempo de respuesta (ms): ");
=======
                Console.WriteLine($"\nTransacción {i}");
                Console.Write($"Ingrese el tiempo de respuesta (ms): ");
>>>>>>> de5fe6a (sadas)
                double tiempoRespuesta = double.Parse(Console.ReadLine());
                
                if (tiempoRespuesta > 500)
                {
                    umbralTransacciones++;
                }
               
                tiempoAcumulado += tiempoRespuesta;
            }

            double promedioRespuesta = tiempoAcumulado / transacciones;
            double porcentajeUmbral = (umbralTransacciones / transacciones) * 100;

            Console.WriteLine($"\nCantidad de transacciones: {transacciones}");
            Console.WriteLine("-----------------------------------------------");
<<<<<<< HEAD
            Console.WriteLine($"Tiempo acumulado: {tiempoAcumulado}");
            Console.WriteLine($"Tiempo promedio de respuesta: {promedioRespuesta}");
=======
            Console.WriteLine($"Tiempo acumulado: {tiempoAcumulado} ms");
            Console.WriteLine($"Tiempo promedio de respuesta: {promedioRespuesta} ms");
>>>>>>> de5fe6a (sadas)
            Console.WriteLine($"Porcentaje de transacciones que superan el umbral (500 ms): {porcentajeUmbral}%");
        }
    }
}
