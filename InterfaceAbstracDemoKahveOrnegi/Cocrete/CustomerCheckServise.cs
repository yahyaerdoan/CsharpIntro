using InterfaceAbstracDemoKahveOrnegi.Abstrac;
using InterfaceAbstracDemoKahveOrnegi.Entities;
using MernisServiceReference;
using ServiceReference1;
using System;
using System.Threading.Tasks;

namespace InterfaceAbstracDemoKahveOrnegi.Cocrete
{
    public class CustomerCheckServise : ICustomerCheckService
    {
       
        public bool CheckedIfRealPerson(Customer customer)
        {
            return TaskAsync(customer).Result;

                     
        }

        public static async Task<bool> TaskAsync(Customer customer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            
            var durum = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.Lastname.ToUpper(), customer.DateOfBirth.Year));

            return durum.Body.TCKimlikNoDogrulaResult;
        }
    }
}
