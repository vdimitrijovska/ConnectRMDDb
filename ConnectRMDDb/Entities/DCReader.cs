using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConnectRMDDb.Entities
{
    //table in DB: citac
    public class DCReader
    {
        public DateTime Data { get; set; }
        public DateTime Vreme { get; set; }
        public string KartID { get; set; }
        public string Ured { get; set; }
        public string Nastan { get; set; }
        public int DenVoNedela { get; set; }
        public string Pricina { get; set; }
        public DateTime DV { get; set; }
    }
}