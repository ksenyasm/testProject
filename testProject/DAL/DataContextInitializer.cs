using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testProject.Models;

namespace testProject.DAL
{
    public class DataContextInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (!context.Users.Any()) //select count(*) > 0 from "Users"
            {
                var user = new User();
                user.Name = "system";
                context.Users.Add(user); //insert into table "Users" values...
                context.SaveChanges();
            }
        }
    }
}
