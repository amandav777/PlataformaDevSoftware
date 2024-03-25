using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Se o valor de Δ for maior que zero(Δ > 0), a equação terá duas raízes reais e distintas.
            //Se o valor de Δ for igual a zero(Δ = 0), a equação apresentará uma raiz real.
            //Se o valor de Δ for menor que zero(Δ < 0), a equação não possui raízes reais.

            Console.WriteLine("Insira o valor de A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor de B: ");
            double b = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Insira o valor de C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = (b * b) - 4.0 * a * c;
            Console.WriteLine(delta);
            if (delta > 0)
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("As raízes são" + raiz1 + raiz2);
            }
            else if (delta == 0)
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("As raízes são iguais com o valor:" + raiz1);
            }
            else
            {
                Console.WriteLine("Não possui raiz");
            }
            Console.ReadKey();
        }
    }
}
