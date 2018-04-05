using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Wcf_WS
{
    [ServiceContract(CallbackContract = typeof(Interface1))]
    public interface IService1
    {
        [OperationContract]
        void GetBike(string numberToFind, string j);

        [OperationContract]
        void SubscribedGetVelibEvent();

        [OperationContract]
        void SusbcribedGetVelibFinishedEvent();

    }
}
