using GameSeller.Abstract;
using GameSeller.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Concrete
{
    public class CheckIdentityManager : ICheckIdentityService
    {
        public bool Check(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                gamer.IdentityNumber, gamer.Name, gamer.Surname, gamer.BirthYear
                ))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
