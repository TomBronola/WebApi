using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class BusinessPartnersController : ApiController
    {

        //Dummy Data
        List<BusinessPartners> business = new List<BusinessPartners>();


        public BusinessPartnersController()
        {
           //Dummy Data
           business.Add(new BusinessPartners { Id = 12345, Name = "Banko De Oro", CardCode="12345", CardName = "BDO", CardType="Debit Card" });
           business.Add(new BusinessPartners { Id = 12346, Name = "Bank of the Philippine Islands", CardCode = "12346", CardName = "BPI", CardType = "Card Card" });
           business.Add(new BusinessPartners { Id = 12347, Name = "Blue Eyes White Dragon", CardCode = "JP-0789", CardName = "METRO BANK", CardType = "Yugioh Card" });

        }


        // GET: api/BusinessPartners
        //RETURNS EVERYTHING
        public List<BusinessPartners> Get()
        {
            return business;  
        }




        // GET: api/BusinessPartners/5
        //RETURNS ONE SPECIFIC ENTRY DEPENDING ON THEIR ID
        public BusinessPartners Get(int id)         
        {
            return business.Where(x => x.Id == id).FirstOrDefault();
        }



        //NOOOOO IDEAAAA YEEEET


        // POST: api/BusinessPartners
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BusinessPartners/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BusinessPartners/5
        public string Delete(int id)
        {
            return "hi";
        }
    }
}
