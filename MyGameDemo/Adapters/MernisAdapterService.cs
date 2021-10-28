using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceAdapter;
using MyGameDemo.Abstract;
using MyGameDemo.Entities;


namespace MyGameDemo.Adapters
{
    public class MernisAdapterService: IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamer.NationalityId, gamer.FirstName, gamer.LastName, gamer.DateOfBirth).Result;
            bool check = result.Body.TCKimlikNoDogrulaResult;
            return check;
        }
    }
}
