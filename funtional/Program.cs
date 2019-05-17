using System;
using System.Collections.Generic;
using System.Linq;

namespace funtional
{
    class Program
    {
        static void Main(string[] args)
        {
            //var calificaciones = new List<int>{10,10,5,7,7,10,8,9,9, 10, 8};
            ////obtener calificaciones mayores a 8

            ////Imperativo
            //foreach(var calificacion in calificaciones){
            //    if (calificacion>8){
            //        Console.WriteLine(calificacion);
            //    }
            //}
            //Console.WriteLine("");
            //Declarativo
            //var result = calificaciones.Where(calificacion => calificacion>8);
            //foreach(var calificacion in result)
            //    Console.WriteLine(calificacion);
            
            
            EncontrarElemento();
        }
        public static void EncontrarElemento(){
            var numeros = new List<int>{1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(":D");
            int numeroBuscar=50;
            bool existeConstaint = numeros.Contains(numeroBuscar);
            Console.WriteLine(existeConstaint);
            
            bool existeAny = numeros.Any(numero=> numero== numeroBuscar);
            Console.WriteLine(existeConstaint);
            
            int resultado = numeros.Find(numero=> numero== numeroBuscar);
            Console.WriteLine(resultado);
            
        }
        public static void ReduccionElemento(){
            var numeros = new List<int>{1,2,3,4,5,6,7,8,9,10};

            //Imperativo
            int suma=0;
            foreach(var numero in numeros)
                suma+=numero;
            Console.WriteLine(suma);
            Console.WriteLine("");

            //Declarativo
            int resultado = numeros.Aggregate( (acumulador, numero)=> acumulador+numero);
            Console.WriteLine(resultado);
        }
    }
}
