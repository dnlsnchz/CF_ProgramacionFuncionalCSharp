using System;
using System.Linq;
using System.Collections.Generic;
namespace queries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LeftJoint();
        }
        public static void LeftJoint(){
            var users = User.Users();
            var tasks = Task.Tasks();
            (
                from user in users
                join task in tasks on user.Id equals task.UserId into relacion
                from a in relacion.DefaultIfEmpty()
                where a == null
                select user.Username
            ).ToList()
            .ForEach(username => Console.WriteLine(username));
        }
        public static void CrearVariables(){
            var numeros = new List<int>{10,2,3,4,5,6,7,8,9,1};

            (
                from numero in numeros
                let cuadrado = numero * numero
                where cuadrado > 50
                select cuadrado
            ).ToList()
            .ForEach(cuadrado => Console.WriteLine(cuadrado));
        }
        public static void GroupByParte2(){
            var users = User.Users();
            var tasks = Task.Tasks();
            
            //Obtener las tares de los usuarios
            //Join
            (from user in users
            join task in tasks on user.Id equals task.UserId
            group user by user.Username into groupUser
            orderby groupUser.Count() descending
            select new {
                Message = String.Format("Username: {0} Cantidad de tareas= {1}",groupUser.Key, groupUser.Count())
            }
            )
            .ToList().ForEach(
                username => 
                Console.WriteLine(username.Message)
                );

            Console.WriteLine("\n\n\n");
            
            (from user in users
            join task in tasks on user.Id equals task.UserId
            select user.Username
            )
            .ToList().ForEach(
                username => 
                Console.WriteLine(username)
                );
        }
        public static void GroupByParte1(){
            var users = User.Users();
            var tasks = Task.Tasks();
            
            //Obtener las tares de los usuarios
            //Join
            (from user in users
            join task in tasks on user.Id equals task.UserId
            group user by user.Username into groupUser
            select groupUser
            )
            .ToList().ForEach(
                username => 
                Console.WriteLine(String.Format("Username: {0}",username.Key))
                );
        }
        public static void Diferente(){
            var users = User.Users();
            var tasks = Task.Tasks();
            
            //Obtener las tares de los usuarios
            //Join
            (from user in users
            join task in tasks on user.Id equals task.UserId
            select user.Username
            )
            .Distinct()
            .ToList().ForEach(
                username => 
                Console.WriteLine(String.Format("Username: {0}",username))
                );
        }
        public static void Join(){
            var users = User.Users();
            var tasks = Task.Tasks();
            
            //Obtener las tares de los usuarios
            //Join
            (from user in users
            join task in tasks on user.Id equals task.UserId
            select new {
                Task = task.Title,
                User = user.Username
            }
            ).ToList().ForEach(
                userTask => 
                Console.WriteLine(String.Format("Username: {0} Tarea: {1}",userTask.User,userTask.Task))
                );
        }
        public static void CrearNumeroObjeto(){
            var users = User.Users();
            
            (from user in users
            where user.Age > 18
            where user.Gender == "female"
            orderby user.Username descending
            select new {
                Nombre = user.Username,
                Edad = user.Age
            }
            ).ToList().ForEach(
                user => 
                Console.WriteLine(String.Format("Username: {0} Edad: {1}",user.Nombre,user.Edad))
                );
        }
        public static void OrdenamientoParte2(){
            var users = User.Users();
            
            (from user in users
            where user.Age > 18
            where user.Gender == "female"
            orderby user.Username descending
            select user.Username
            ).ToList().ForEach(username => Console.WriteLine(username));
        }
    }
}
