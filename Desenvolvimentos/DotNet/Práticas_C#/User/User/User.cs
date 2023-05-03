using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }

        public void Login(string email, int password)
        {
            if(this.Email == email && this.Password == password)
            {
                Console.WriteLine("Login efetuado com sucesso");
            }
            else
            {
                Console.WriteLine("Login inválido");
            }
        }
    }
}
