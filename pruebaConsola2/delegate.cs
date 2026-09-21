using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaConsola2
{
    //Declaracion del delegado
    public delegate void OperacionMatematica(double a, double b);
    public class delegado
    {
        static void Sumar(double x, double y)
        {
            Console.WriteLine($"Suma: {x} + {y} = {x + y}");
        }

        static void Restar(double x, double y)
        {
            Console.WriteLine($"Resta: {x} - {y} = {x - y}");
        }

        static void Multiplicar(double x, double y)
        {
            Console.WriteLine($"Multiplicacion: {x} * {y} = {x * y}");
        }
            
        static void Main()
        {
            try
            {
                //se crean instancias del delegate
                OperacionMatematica op1 = Sumar;
                OperacionMatematica op2 = Restar;
                OperacionMatematica op3 = Multiplicar;

                //invocar los metodos a traves del delegado
                op1(2, 4);
                op2(10, 5);
                op3(6, 6);


                //Combinar varios metodos
                OperacionMatematica operaciones = Sumar;
                operaciones += Restar;
                operaciones += Multiplicar;


                Console.WriteLine("\nInvocando metodos combinados:");
                operaciones(20, 8);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        }
    }
