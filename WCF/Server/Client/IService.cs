using System;

using System.ServiceModel;


namespace Client
{ [ServiceContract]
    interface IService
    {
        [OperationContract]
        void Say(string a);
    }
}
