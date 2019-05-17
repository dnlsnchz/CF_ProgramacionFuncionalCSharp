using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegados
{
    class Program
    {
        public delegate float DelegateOperacion (float val1, float val2);
        //Depositos
        //Retiros
        public static float Deposito(float cantidad, float monto){
            return cantidad+monto;
        }
        public static float Retiro(float cantidad, float monto){
            if(cantidad>monto){
                Console.WriteLine("No es posible realizar el retiro");
                return 0.0f;
            }
            return monto-cantidad;
        }
        public static float EjecutarOperacion (DelegateOperacion operacion, float cantidad, float monto){
            Console.WriteLine("Esta por ejecutar la operación");
            float result = operacion(cantidad,monto);
            Console.WriteLine(result);
            Console.WriteLine("La operación se ha ejecutado");
            return result;
        }
        static void Main(string[] args)
        {
            DelegateOperacion retiro=Retiro;
            DelegateOperacion deposito = Deposito;

            //EjecutarOperacion (retiro,10,100);

            //Delegados con expresiones lamda
            DelegateOperacion depositoInteres=(cantidad,monto)=>
            {
                if(cantidad>100){
                    return cantidad + monto +(cantidad*0.02f);
                }
                return cantidad+monto;
            };

            EjecutarOperacion(depositoInteres,101,100);
        }
    }
}
