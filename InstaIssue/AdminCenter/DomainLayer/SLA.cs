using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.DomainLayer
{
    class SLA
    {
        private String SLAID;
        private String name;
        private String description;
        private String tarif;

        public SLA()
        {
        }

        public SLA(string sLAID, string name, string description, string tarif)
        {
            SLAID = sLAID;
            this.name = name;
            this.description = description;
            this.tarif = tarif;
        }

        public string SLAID1 { get => SLAID; set => SLAID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Tarif { get => tarif; set => tarif = value; }
    }
}
