using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilataryElite.interfaces
{
    interface ISoldier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
