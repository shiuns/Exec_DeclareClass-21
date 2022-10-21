using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_DeclareClass___21謝孟勳
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Address
    {
        public string City { get; set; }
        public string ZipCode { get; set; }
        public String Street { get; set; }
    }

    class Telephone
    {
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }
        public string Ext { get; set; }
    }

    class Member
    {
        public Address Addr { get; set; }
        public Telephone phone { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Cellphone { get; set; }
        public string Telephone { get; set; }
        public void Register(string name, string account,string password, string confirmpassword,string email)
        {

        }

        public void ForgetPassword ( string name, string email )
        {

        }
        public void Authenticate (string Account, string Password)
        {

        }
    }   

}    






