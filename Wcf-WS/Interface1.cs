using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Wcf_WS
{
    interface Interface1
    {
        [OperationContract(IsOneWay = true)]
        void getTheVelibInStation(string city, string station, string result);

        [OperationContract(IsOneWay = true)]
        void getTheVelibFinished();
        
        
    }
}
