using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Registraion_stronglytyped.Models;
namespace Registraion_stronglytyped.Models
{
    public class RegisterDeatils
    {
        //Business Logic Layer
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Hobbies { get; set; }
        public enum Courses{
            C,
            MachineLeraning ,
            Dotnet,
            Java
        }
        public enum Skills
        {
            Leadership,
            Organisation,
            Teamwork
        }
       

    }
}