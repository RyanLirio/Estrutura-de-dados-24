using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Threading.Tasks;

namespace Teste
{
    public class Raiz
    {
        public static void Raix()
        {
        Console.WriteLine("Digite o valor que deseja saber a raíz:");
        float v1 = float.Parse(Console.ReadLine()); 

        Console.WriteLine($"A raíz de {v1} é {Math.Sqrt(v1)}");
        Thread.Sleep(2000);
        
        Program.Menu();
        }
        
    }
}