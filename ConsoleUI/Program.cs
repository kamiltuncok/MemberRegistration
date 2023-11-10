using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
   public class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member
            {
                Email = "deneme@gmail.com",
                FirstName = "Kullanici",
                LastName = "Soyad",
                DateOfBirth = new DateTime(1999, 5, 15),
                TcNo = "11111111111"
            });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
