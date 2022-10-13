using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class BusinessPartners
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string CardCode { get; set; } = "";
        public string CardName { get; set; } = ""; 
        public string CardType { get; set; } = "";
    }
}