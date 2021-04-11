using System.Runtime.Serialization;

namespace MySelfHostServiceConsoleApplication
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }

        public string CreditCardNumber { get; set; }
    }
}
