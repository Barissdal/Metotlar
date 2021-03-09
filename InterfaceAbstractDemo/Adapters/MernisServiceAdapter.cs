using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        // dış bir kaynaktan veri alıcaksak bunu bir Adapters'ta tanımlamak gerekmektedir.
        public bool CheckIfRealPersonal(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            //return client.TCKimlikNoDogrulaAsync(TCKimlikNo: customer.NationalityId,
            //    Ad: customer.FirstName.ToUpper(),
            //    Soyad: customer.LastName.ToUpper(),
            //    DogumYili: customer.DateOfBirth.Year);

            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
                customer.FirstName.ToUpper(),
                customer.LastName.ToLower(),
                customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;

            //return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
