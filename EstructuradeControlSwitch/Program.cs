// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");
//Haremos un ejercicio utilizando las estrucutras de control en el lenguaje C#
//Datos de entrada. 
string iniciar = "y";
Console.WriteLine("Aplasta y para iniciar");
iniciar = (Console.ReadLine());
while (iniciar == "y")
{
    double[] num = new double[10];
    for (int i = 0; i < num.Length; i++)
    {
            Console.WriteLine("Captura tu número " + (i + 1));
            num[i] = double.Parse(Console.ReadLine());
        if (num[i] % 2 == 0)
        {
            num[i] = 0;
        }
        else
        {
            num[i] = 1;
        }
        switch (num[i])
        {
            case 0:
                Console.WriteLine("El número es PAR");
                break;
            case 1:
                Console.WriteLine("El número es IMPAR");
                break;
    }
    }
    break;
}

