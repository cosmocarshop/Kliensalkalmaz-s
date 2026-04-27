using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kliensalk
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int ModuleId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public string? Comment { get; set; }
        public int Status { get; set; }
        public List<string> ProductBvins { get; set; }
        public string SerializedProductBvins { get; set; }
    }
}
