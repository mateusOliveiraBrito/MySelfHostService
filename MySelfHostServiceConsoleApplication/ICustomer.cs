using System.ServiceModel;

namespace MySelfHostServiceConsoleApplication
{
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        Customer CreateCustomer(int customerId, string name, string email);

        [OperationContract]
        Customer GetCustomerByName(string customerName);

        [OperationContract]
        Customer[] GetAllCustomers();
    }
}
