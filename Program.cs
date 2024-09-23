using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;
using GameManagementDemo.Entities;
using System;

namespace GameManagementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new BaseGamerManager(new UserValidationManager());
            gamerManager.Save(new Gamer { DateOfBirth = new DateTime(2001, 11, 26), FirstName="Esma", LastName="Ekim", Id=0, NationalityId=12345678910 });
            
            _ = new BaseGamerManager();
            gamerManager.Delete(new Gamer { DateOfBirth = new DateTime(2002, 02, 17), FirstName="Hans", LastName="Müller",Id=1, NationalityId=0987654321});

            _ = new BaseGamerManager();
            gamerManager.Update(new Gamer { DateOfBirth = new DateTime(1770, 12, 17), FirstName = "Ludwig", LastName = "van Beethoven", Id=3, NationalityId=85245693710 });

            Console.ReadLine();

        }
    }
}
