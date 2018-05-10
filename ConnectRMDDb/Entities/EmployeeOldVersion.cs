using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConnectRMDDb.Entities
{
    //table in DB: Vraboteni
    public class EmployeeOldVersion
    {
        public string KartID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string MaticenBroj { get; set; }
        public string Grupa { get; set; }
        public string SM { get; set; }
        public string Sluzbi { get; set; }
        public int ID { get; set; }
    }
}