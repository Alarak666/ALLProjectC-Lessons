using System;
using System.ServiceModel;


namespace Server
{ [ServiceContract]
    interface IService
    {
        [OperationContract]
        void Say(string a);
    }
}
