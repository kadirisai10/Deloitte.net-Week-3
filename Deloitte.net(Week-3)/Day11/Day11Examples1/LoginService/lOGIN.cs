using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginService
{
    public class lOGIN : ILogin
    {
        public bool Authenticate(int id, string password)
        {
            TrainingDBEntities db = new TrainingDBEntities();
            if (id <= 0)
                throw new ArgumentException("ID cannot be less than or equal to  zero");
            else if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be blank");
            else
            {
                var data = db.ResgisterShoppings.Where(x => x.Id == id && x.Password == password).SingleOrDefault();
                if (data == null)
                    throw new ArgumentException("Invalid UserName/password");
                else
                    return true;
            }
        }
    }
}
