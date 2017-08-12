using System;

namespace Exercicio4AreaTriangulo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double baseT, altT, areaT;
			Console.WriteLine("Digite a base do triângulo: ");
			baseT = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a altura do triângulo: ");
			altT = Convert.ToDouble(Console.ReadLine());
            areaT = 0.5 * (baseT * altT);
			Console.Write("A área do triângulo é " + areaT);
			Console.ReadLine();
        }
    }
}
