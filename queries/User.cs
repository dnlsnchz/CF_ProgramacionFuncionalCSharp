using System;
using System.Collections.Generic;
namespace queries
{
    public class User{
        public int Id {get;set;}
        public String Username {get;set;}
        public int Age {get;set;}
        public String Gender {get;set;}

        public User(int id, String username,int age,String gender){
            this.Id=id;
            this.Username=username;
            this.Age=age;
            this.Gender=gender;
        }
        public static List<User> Users(){
            return new List<User>{
                new User(1,"Carla",5,"female"),
                new User(2,"Roberto",40,"male"),
                new User(3,"Sonia",50,"female"),
                new User(4,"Sofia",25,"female"),
                new User(5,"Eduardo",14,"male"),
                new User(6,"Luis",29,"male"),
                new User(7,"Alex",20,"male"),
                new User(8,"Cyndi",5,"female"),
                new User(9,"Candy",15,"female"),
                new User(10,"Sandro",11,"male"),
            };
        }
    }
}