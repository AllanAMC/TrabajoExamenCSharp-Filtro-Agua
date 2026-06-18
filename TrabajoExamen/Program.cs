namespace TrabajoExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== -- FILTRO DE AGUA INDUSTRIAL -- ====\n");
            Console.Write("Ingrese el valor PPM: ");
            if (double.TryParse(Console.ReadLine(), out double valorPpm)) 
            {
                Console.Clear();
                Console.Write("COMENZANDO FILTRADO");
                for (int i = 1; i <= 3; i++)
                {
                    Thread.Sleep(800);
                    Console.Write(".");
                }

                int contador = 1;
                while (true)
                {
                    Console.Clear();
                    Console.Write($"Valor PPM : {valorPpm:F2}     Ciclo actual: {contador}");
                    Thread.Sleep(450);
                    Console.Out.Flush();

                    if (contador <= 4)
                    {
                        valorPpm -= valorPpm * 0.125;
                    }
                    else if (contador <= 15)
                    {
                        valorPpm -= valorPpm * 0.06;
                    }

                    if (valorPpm <= 10)
                    {
                        Console.Clear();
                        Console.WriteLine($"Valor PPM FINAL: {valorPpm:F2}     Ciclo totales: {contador}");
                        Console.WriteLine("\nAGUA POTABLE!");
                        break;
                    }
                    if (contador == 15)
                    {
                        Console.Clear();
                        Console.WriteLine($"Valor PPM FINAL: {valorPpm:F2}     Ciclo totales: {contador}");
                        Console.WriteLine("\nEL FILTRO SE HA SATURADO!");
                        break;
                    } 
                    contador++;

                }
            } else { Console.WriteLine("VALOR INGRESADO INVALIDO."); }
        }
    }
}