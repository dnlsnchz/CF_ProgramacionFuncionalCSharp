using System;
using System.Collections.Generic;
namespace queries
{
    public class Task{
        public int Id {get;set;}
        public String Title {get;set;}
        public int UserId {get;set;}

        public Task(int id, String title,int userid){
            this.Id=id;
            this.Title=title;
            this.UserId=userid;
        }
        public static List<Task> Tasks(){
            return new List<Task>{
                new Task(1,"Terminar Examen",4),
                new Task(2,"Lavar",2),
                new Task(3,"Planchar",4),
                new Task(4,"Limpiar",4),
                new Task(5,"Ir al baño",5),
                new Task(6,"Estudiar",9),
                new Task(7,"Publicar",4),
                new Task(8,"Correr",8),
                new Task(9,"Cantar",9),
                new Task(10,"Bailar",5),
                new Task(10,"Cambiar Estilos",4),
            };
        }
    }
}