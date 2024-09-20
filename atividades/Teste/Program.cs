using System;
using System.Reflection;
using Teste;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Qual operação deseja utilizar?");
        Console.WriteLine("Para Soma, digite 1");
        Console.WriteLine("Para Subtração, digite 2");
        Console.WriteLine("Para Divisão, digite 3");
        Console.WriteLine("Para Multiplicação, digite 4");
        Console.WriteLine("Para Potencia, digite 5");
        Console.WriteLine("Para Raíz, digite 6");
        Console.WriteLine("Para sair, digite 7");
        Console.WriteLine("");
        Console.WriteLine("Escolha uma opção:");
        short operação = short.Parse(Console.ReadLine());

        switch(operação)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: Potencia(); break;
            case 6: Raiz.Raix(); break;
            case 7: System.Environment.Exit(0); break;
            default: Menu(); break;
        
        }
        
    }

    static void Soma()
    {
        Console.Clear();
        
        //float.Parse pois o Console.ReadLine só armazena em string, com o float.Parse ele converte para float
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        //valores numéricoa o + soma. Strings ele concatena, por isso coloquei entre (v1 + v2)
        //sem os () eu teria que criar uma variavel para armazenar o resultado da soma antes. 
        //ex: float resultado = v1 + v2;
        //Console.WriteLine("O resultado da soma é: " + resultado);
    
        // Console.WriteLine("O resultado da soma é: " + (v1 + v2));
        Console.WriteLine($"O resultado da soma é: {v1 + v2}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());


        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine($"O resultado da subtração é: {v1 - v2}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());
    
        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine($"O resultado da divisão é: {v1/v2}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        
        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine($"O resultado da multiplicação é: {v1*v2}");
        Console.ReadKey();
        Menu();
    }
    static void Potencia()  
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Valor da potencia");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado de {v1} elevado a {v2} é {Math.Pow(v1, v2)}");
            Console.ReadKey();
            Menu();
        }
    }  
