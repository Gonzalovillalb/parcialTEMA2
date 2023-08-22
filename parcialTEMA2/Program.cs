namespace parcialTEMA2
{
    internal class Program
    {
        static void Main(string[] args)
        { }
             

            private class program
            
        {
            static double CalcularAreaBase(int b, int h)
            {
                double areaBase = 2 * (b * h / 2.0);
                return areaBase;
            }

            static double CalcularAreaLateral(int a, int h)
            {
                double areaLateral = 3 * (a * h);
                return areaLateral;
            }

            static double CalcularVolumen(double areaBase, int h)
            {
                double volumen = areaBase * h;
                return volumen;
            }

            static double CalcularDiagonal(int b, int h)
            {
                double diagonal = Math.Sqrt(b * b + h * h);
                return diagonal;
            }

            static void Main(string[] args)
            {
                int basePrisma, alturaPrisma, longitudPrisma;
                int cantidadPrismas = 0;

                do
                {
                    Console.WriteLine("Ingresar los datos del prisma triangular (ingrese un valor en cada dato para finalizar):");
                    Console.Write("Base: ");
                    basePrisma = int.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    alturaPrisma = int.Parse(Console.ReadLine());
                    Console.Write("Longitud: ");
                    longitudPrisma = int.Parse(Console.ReadLine());

                    if (basePrisma > 1 && alturaPrisma > 1 && longitudPrisma > 1)
                    {
                        double areaBase = CalcularAreaBase(basePrisma, alturaPrisma);
                        double areaLateral = CalcularAreaLateral(longitudPrisma, alturaPrisma);
                        double volumen = CalcularVolumen(areaBase, alturaPrisma);
                        double diagonal = CalcularDiagonal(basePrisma, alturaPrisma);

                        Console.WriteLine("Área Base: " + areaBase);
                        Console.WriteLine("Área Lateral: " + areaLateral);
                        Console.WriteLine("Volumen: " + volumen);
                        Console.WriteLine("Diagonal: " + diagonal);

                        cantidadPrismas++;
                    }

                } while (basePrisma != 1 || alturaPrisma != 1 || longitudPrisma != 1);

                Console.WriteLine("Cantidad de prismas ingresados: " + cantidadPrismas);
            }
        }
    }


}
        
    

  
