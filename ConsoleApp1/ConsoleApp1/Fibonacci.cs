using System;


namespace ConsoleApp1
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            
            int  numero, primero = 0, segundo = 1, tercero;
            Console.Write("Digite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            

            for (int i = 0; i <= numero; i++)
            {
                if (i <= 0)
                {
                    tercero = i;
                }
                else
                {

                    tercero = primero + segundo;
                    primero = segundo;
                    segundo = tercero;


                    if (numero == tercero)
                    {
                        Console.WriteLine("El numero digitado en esta posicion si pertenece a la sucesion de Fibonacci");
                    }

                    else 
                    {
                        Console.WriteLine("El numero digitado en esta posicion no pertenece a la sucesion de Fibonacci");
                    }              
                   
                }
                Console.WriteLine(tercero);
                
            }
            Console.ReadKey();

        }
    
    }
}
