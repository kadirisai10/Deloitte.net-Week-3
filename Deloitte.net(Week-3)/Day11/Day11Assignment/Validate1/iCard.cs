using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Validate1
{
    [ServiceContract]
   public interface iCard
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        bool Authenticate(int cardno, int cvv);

        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        bool Expiry(int cardno, DateTime dt);

        [OperationContract]
        [FaultContract(typeof(ArgumentException))]

        bool trans(int cardno, int amount);


    }
}
