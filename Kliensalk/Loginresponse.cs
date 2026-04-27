using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kliensalk
{
    public class Loginresponse
    {
        public int UserId { get; set; }
        public string DisplayName { get; set; }
        public string AccessToken { get; set; }
        public string RenewalToken { get; set; }
    }
}
