using System.Globalization;

namespace PrimreiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
           ParametrosTriangulo  trianguloA = new ParametrosTriangulo();

           ParametrosTriangulo trianguloB = new ParametrosTriangulo();

            double resultadoCalculaP;
            double resultadoCalculaP2;
            double resultadoX;
            double resultadoY;
            Console.WriteLine("Entre com as medidas do triangulo X");
            trianguloA.lado1 = double.Parse(Console.ReadLine());
            trianguloA.lado2 = double.Parse(Console.ReadLine());
            trianguloA.lado3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com as medidas do triangulo Y");
            trianguloB.lado1 = double.Parse(Console.ReadLine());
            trianguloB.lado2 = double.Parse(Console.ReadLine());
            trianguloB.lado3 = double.Parse(Console.ReadLine());

            resultadoCalculaP = CalculaPrimeiro(trianguloA.lado1, trianguloA.lado2, trianguloA.lado3);
            resultadoCalculaP2 =CalculaPrimeiro(trianguloB.lado1, trianguloB.lado2, trianguloB.lado3);

            resultadoX = CalculaArea(resultadoCalculaP , trianguloA.lado1, trianguloA.lado2 , trianguloA.lado3);
            resultadoY =  CalculaArea(resultadoCalculaP2 ,trianguloB.lado1,trianguloB.lado2,trianguloB.lado3);

            Console.WriteLine($"Área de x = {resultadoX.ToString("F4" ,CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {resultadoY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (resultadoX > resultadoY)
            {
                Console.WriteLine("A área do X é a maior!");
            }
            else
            {
                Console.WriteLine("A área do Y é a maior!");
            }
        }

        static double CalculaPrimeiro(double a, double b, double c)
        {
            double result;

            result = (a + b + c) / 2.0;

            return result;
        }
        static double CalculaArea(double calculop , double a , double b , double c ) {
            double result;

            result = Math.Sqrt(calculop * (calculop - a) * (calculop - b)*(calculop - c));
            return result;
        }
    }

}