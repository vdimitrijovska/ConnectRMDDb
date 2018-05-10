using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConnectRMDDb.Entities
{
    //tabe in DB: OpisCitaci
    public class ReaderCode
    {
        public string Kod2 { get; set; }
        public string Opis_citaci { get; set; }
        public string Detalen_opis { get; set; }
    }
}