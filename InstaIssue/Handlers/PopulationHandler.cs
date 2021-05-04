using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.Handlers
{
    public class PopulationHandler
    {
        private readonly Connection connection = new Connection();

        public PopulationHandler()
        {
            connection.Connect();
        }

        public List<string> GetSla()
        {
            List<string> SLAlist = new List<string>();

            SLAlist = new Data().GetSLA();

            return SLAlist;
        }
    }
}
