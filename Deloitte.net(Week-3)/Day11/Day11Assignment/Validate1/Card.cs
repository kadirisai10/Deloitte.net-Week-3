using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validate1
{
    class Card:iCard
    {
        AssignmentDBEntities db = new AssignmentDBEntities();
        public bool Authenticate(int cardno,int cvv)
        {
            var data = (from t in db.CardInfoes
                        where (t.CardNo == cardno && t.CvvNo == cvv)
                        select t).SingleOrDefault();
            if (data == null)
                throw new ArgumentException("Enter correct card no and Cvvno");
            else
                return true;
        }

        public bool Expiry(int cardno,DateTime dt)
        {
            var data = (from t in db.CardInfoes
                        where (t.CardNo == cardno && (t.ExpDate > DateTime.Now ))
                        select t).SingleOrDefault();
            if (data == null)
                throw new ArgumentException("Card is Expired");
            else
                return true;
        }

        public bool trans(int cardno,int amount)
        {
            var data = (from t in db.CardInfoes
                        where (t.CardNo == cardno && t.Balance < amount)
                        select t).SingleOrDefault();
            if (data == null)
                throw new ArgumentException("Balance is low");
            else
            {
                data.Balance = data.Balance - amount;
               db.SaveChanges();
                
                    return true;

            }
        }
    }
}
