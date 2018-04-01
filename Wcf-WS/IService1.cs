using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Wcf_WS
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int GetBike(string apiKey, string numberToFind, string j);

        [OperationContract]
        string GetStation(string apiKey, string city);

        [OperationContract]
        string GetCity(string apiKey);

    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
